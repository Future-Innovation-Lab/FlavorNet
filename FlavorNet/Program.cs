using FlavorNet.Data;
using FlavorNet.Grid;
using FlavorNet.Services;
using Microsoft.EntityFrameworkCore;

namespace FlavorNet
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            builder.Services.AddDbContextFactory<FlavorContext>(opt =>
                opt.UseSqlite($"Data Source={nameof(FlavorContext.FlavorDb)}.db"));

            // pager
            builder.Services.AddScoped<IPageHelper, PageHelper>();

            // filters
            builder.Services.AddScoped<IReviewFilters, GridControls>();

            // query adapter (applies filter to contact request).
            builder.Services.AddScoped<GridQueryAdapter>();

            builder.Services.AddScoped<IFavorDb, FavorDb>();
            builder.Services.AddScoped<ISentimentProcessor, OpenAiSentimentProcessor>();
            builder.Services.AddScoped<ISummaryProcessor, OpenAiSummaryProcessor>();


            var app = builder.Build();

            await using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateAsyncScope();
            var options = scope.ServiceProvider.GetRequiredService<DbContextOptions<FlavorContext>>();
            await DatabaseUtility.EnsureDbCreatedAndSeedWithCountOfAsync(options, 500);


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}