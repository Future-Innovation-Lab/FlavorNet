using System.Diagnostics;
using System.Linq.Expressions;
using FlavorNet.Data;
using Microsoft.EntityFrameworkCore;

namespace FlavorNet.Grid;

/// <summary>
/// Creates the right expressions to filter and sort.
/// </summary>
public class GridQueryAdapter
{
    /// <summary>
    /// Holds state of the grid.
    /// </summary>
    private readonly IReviewFilters _controls;

    /// <summary>
    /// Expressions for sorting.
    /// </summary>
    private readonly Dictionary<ReviewFilterColumns, Expression<Func<Review, string>>> _expressions
        = new()
        {
            { ReviewFilterColumns.Name, c => c != null && c.Reviewer != null ? c.Reviewer : string.Empty }
        };

    private readonly Dictionary<ReviewFilterColumns, Func<IQueryable<Review>, IQueryable<Review>>> _filterQueries =
        new Dictionary<ReviewFilterColumns, Func<IQueryable<Review>, IQueryable<Review>>>();

    public GridQueryAdapter(IReviewFilters controls)
    {
        _controls = controls;

        // set up queries
        _filterQueries = new()
        {
            { ReviewFilterColumns.Name, cs => cs.Where(c => c != null && c.Reviewer != null && _controls.FilterText != null ? c.Reviewer.Contains(_controls.FilterText) : false ) }
     //       { ReviewFilterColumns.Sentiment, cs => cs.Where(c => c != null && c.Sentiment != null && _controls.FilterText != null ? c.Sentiment.Contains(_controls.FilterText) : false ) }
        };
    }

    public async Task<ICollection<Review>> FetchAsync(IQueryable<Review> query)
    {
        query = FilterAndQuery(query);
        await CountAsync(query);
        var collection = await FetchPageQuery(query)
            .ToListAsync();
        _controls.PageHelper.PageItems = collection.Count;
        return collection;
    }

    public async Task CountAsync(IQueryable<Review> query)
    {
        _controls.PageHelper.TotalItemCount = await query.CountAsync();
    }

    public IQueryable<Review> FetchPageQuery(IQueryable<Review> query)
    {
        return query
            .Skip(_controls.PageHelper.Skip)
            .Take(_controls.PageHelper.PageSize)
            .AsNoTracking();
    }

    private IQueryable<Review> FilterAndQuery(IQueryable<Review> root)
    {
        var sb = new System.Text.StringBuilder();

        // apply a filter?
        if (!string.IsNullOrWhiteSpace(_controls.FilterText))
        {
            var filter = _filterQueries[_controls.FilterColumn];
            sb.Append($"Filter: '{_controls.FilterColumn}' ");
            root = filter(root);
        }

        // apply the expression
        var expression = _expressions[_controls.SortColumn];
        sb.Append($"Sort: '{_controls.SortColumn}' ");

        // fix up name
        if (_controls.SortColumn == ReviewFilterColumns.Name && _controls.ShowFirstNameFirst)
        {
            sb.Append($"(first name first) ");
            expression = c => c.Reviewer != null ? c.Reviewer : string.Empty;
        }

        var sortDir = _controls.SortAscending ? "ASC" : "DESC";
        sb.Append(sortDir);

        Debug.WriteLine(sb.ToString());
        // return the unfiltered query for total count, and the filtered for fetching
        return _controls.SortAscending ? root.OrderBy(expression)
            : root.OrderByDescending(expression);
    }
}
