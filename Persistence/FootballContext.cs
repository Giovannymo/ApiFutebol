using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class FootballContext : DbContext
    {
        public FootballContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
}