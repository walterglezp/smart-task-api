using Microsoft.EntityFrameworkCore;
using SmartTasks.Domain.Entities;

namespace SmartTasks.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<ResourceRecord> Records { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResourceRecord>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Cts).IsRequired();
                entity.Property(x => x.Ts).IsRequired();
                entity.Property(x => x.ResourceType).HasMaxLength(100);
                entity.Property(x => x.Resource).HasColumnType("TEXT");
            });
        }
    }
}
