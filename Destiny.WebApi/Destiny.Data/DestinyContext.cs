using Microsoft.EntityFrameworkCore;
using Destiny.Domain;

namespace Destiny.Data
{
    public class DestinyContext : DbContext
    {
        public DestinyContext(DbContextOptions<DestinyContext> context) : base(context) { }

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Perk> Perks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeaponPerk>().HasKey(s => new { s.WeaponId, s.PerkId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
