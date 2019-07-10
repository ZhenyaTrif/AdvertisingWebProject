using Common.Entity;
using Microsoft.EntityFrameworkCore;

namespace Advertising.Dal.Contexts
{
    public class AdvertisingServiceContext : DbContext
    {
        public AdvertisingServiceContext(DbContextOptions<AdvertisingServiceContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<AdvertisingModel> Advertisings { get; set; }

        public DbSet<AdvertisingCategory> AdvertisingCategories { get; set; }
    }
}
