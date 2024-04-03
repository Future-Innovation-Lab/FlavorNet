using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace FlavorNet.Data
{
    public class FlavorContext : DbContext
    {
        public static readonly string RowVersion = nameof(RowVersion);

        public static readonly string FlavorDb = nameof(FlavorDb).ToLower();

        public FlavorContext(DbContextOptions<FlavorContext> options)
            : base(options)
        {
            Debug.WriteLine($"{ContextId} context created.");
        }

        public DbSet<Review>? Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this property isn't on the C# class
            // so we set it up as a "shadow" property and use it for concurrency
            modelBuilder.Entity<Review>()
                .Property<byte[]>(RowVersion)
                .IsRowVersion();

            base.OnModelCreating(modelBuilder);
        }

        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }
    }
}
