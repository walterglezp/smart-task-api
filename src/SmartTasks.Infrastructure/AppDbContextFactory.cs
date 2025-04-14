using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SmartTasks.Infrastructure;

namespace SmartTasks.Infrastructure
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Use SQLite for dev purposes
            optionsBuilder.UseSqlite("Data Source=smarttasks.db");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

