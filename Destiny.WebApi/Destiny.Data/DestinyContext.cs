using Microsoft.EntityFrameworkCore;
using Destiny.Domain;

namespace Destiny.Data
{
    public class DestinyContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Perk> Perks { get; set; }
    }
}
