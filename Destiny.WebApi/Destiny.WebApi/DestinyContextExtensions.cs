using Destiny.WebApi.Entities;
using Destiny.WebApi.Entities.Context;
using System.Collections.Generic;
using System.Linq;

namespace Destiny.WebApi
{
    public static class DestinyContextExtensions
    {
        public static void EnsureSeedDataForContext(this DestinyDbContext context)
        {
            if (context.Weapons.Any())
            {
                return;
            }

            // init seed data
            var weapons = new List<Weapon>()
            {
                new Weapon()
                {
                     Name = "Hawkmoon",
                     Description = "The hawkmoon description",
                     Perks = new List<Perk>()
                     {
                         new Perk() {
                             Name = "Luck in the chamber",
                             Description = "Luck in the chamber description.",
                             IsActive = true
                         },
                         new Perk() {
                             Name = "Hammerforged",
                             Description = "The hammerforged perk description.",
                             IsActive = false
                         }
                     },
                     ImageUrl  = "https://www.bungie.net/common/destiny_content/icons/4375e2f5ddd225763ae439f7edc8e561.jpg",
                     WeaponType = "Handcannon"

                },
                new Weapon()
                {
                    Name = "Invective",
                    Description = "Invective description",
                     Perks = new List<Perk>()
                     {
                         new Perk() {
                             Name = "Invective exotic perk",
                             Description = "Regenerates ammo over time.",
                             IsActive = true
                         },
                         new Perk() {
                             Name = "Rangefinder",
                             Description = "The rangefinder perk description.",
                             IsActive = false
                         }
                     },
                     ImageUrl  = "https://www.bungie.net/common/destiny_content/icons/ae2c0ae7fb58fed10552c1b29fdbd392.jpg",
                     WeaponType = "Shotgun"
                },
                new Weapon()
                {
                    Name = "Fatebringer",
                    Description = "The one and only.",
                     Perks = new List<Perk>()
                     {
                         new Perk() {
                             Name = "Firefly",
                             Description = "Explosions!",
                             IsActive = true
                         },
                         new Perk() {
                             Name = "Explosive Rounds",
                             Description = "More explosions!",
                             IsActive = true
                         }
                     },
                     ImageUrl  = "https://www.bungie.net/common/destiny_content/icons/e09203d03e58d1e64e3d73c61450a868.jpg",
                     WeaponType = "Handcannon"
                }
            };

            context.Weapons.AddRange(weapons);
            context.SaveChanges();
        }
    }
}
