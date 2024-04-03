namespace FlavorNet.Grid;

/// <summary>
/// Interface for filtering.
/// </summary>
public interface IReviewFilters
{
    /// <summary>
    /// The <see cref="ReviewFilterColumns"/> being filtered on.
    /// </summary>
    ReviewFilterColumns FilterColumn { get; set; }

    /// <summary>
    /// Loading indicator.
    /// </summary>
    bool Loading { get; set; }

    /// <summary>
    /// The text of the filter.
    /// </summary>
    string? FilterText { get; set; }

    /// <summary>
    /// Paging state in <see cref="PageHelper"/>.
    /// </summary>
    IPageHelper PageHelper { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if the name is rendered first name first.
    /// </summary>
    bool ShowFirstNameFirst { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if the sort is ascending or descending.
    /// </summary>
    bool SortAscending { get; set; }

    /// <summary>
    /// The <see cref="ReviewFilterColumns"/> being sorted.
    /// </summary>
    ReviewFilterColumns SortColumn { get; set; }
}
