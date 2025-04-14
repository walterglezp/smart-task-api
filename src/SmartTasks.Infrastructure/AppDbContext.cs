using Microsoft.EntityFrameworkCore;
using SmartTasks.Domain.Entities;

namespace SmartTasks.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskRecord> Tasks { get; set; }
        public DbSet<TaskHistoryRecord> TaskHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskRecord>(entity =>
            {
                entity.ToTable("Tasks");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Version).IsRequired();
                entity.Property(x => x.Cts).IsRequired();
                entity.Property(x => x.Ts).IsRequired();
                entity.Property(x => x.ResourceType).HasMaxLength(100);
                entity.Property(x => x.Resource).HasColumnType("TEXT");
            });

            modelBuilder.Entity<TaskHistoryRecord>(entity =>
            {
                entity.ToTable("TaskHistory");
                entity.HasKey(x => new { x.Id, x.Version }); // Composite key for immutability
                entity.Property(x => x.Cts).IsRequired();
                entity.Property(x => x.Ts).IsRequired();
                entity.Property(x => x.ResourceType).HasMaxLength(100);
                entity.Property(x => x.Resource).HasColumnType("TEXT");
            });
        }
    }
}
