using FlavorNet.Data;
using Microsoft.EntityFrameworkCore;

public static class DatabaseUtility
{
    public static async Task EnsureDbCreatedAndSeedWithCountOfAsync(DbContextOptions<FlavorContext> options, int count)
    {
        // empty to avoid logging while inserting (otherwise will flood console)
        var factory = new LoggerFactory();
        var builder = new DbContextOptionsBuilder<FlavorContext>(options)
            .UseLoggerFactory(factory);

        using var context = new FlavorContext(builder.Options);
        // result is true if the database had to be created
        if (await context.Database.EnsureCreatedAsync())
        {
            var seed = new SeedDatabase();
            await seed.SeedDatabaseWithReviewCountOfAsync(context, count);
        }
    }
}
