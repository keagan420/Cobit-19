using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Cobit_19.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<FocusAreaModel> FocusAreas { get; set; }
    }
}
