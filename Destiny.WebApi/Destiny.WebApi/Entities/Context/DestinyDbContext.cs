using Microsoft.EntityFrameworkCore;

namespace Destiny.WebApi.Entities.Context
{
    public class DestinyDbContext : DbContext
    {
        public DestinyDbContext(DbContextOptions<DestinyDbContext> context) : base(context) {
            Database.Migrate();
        }

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Perk> Perks { get; set; }
        
    }
}
