using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Destiny.WebApi.Entities;
using Destiny.WebApi.Entities.Context;

namespace Destiny.WebApi.Services
{
    public class DestinyRepository : IDestinyRepository
    {
        private DestinyDbContext _context;
        public DestinyRepository(DestinyDbContext context)
        {
            _context = context;
        }

        public Perk GetPerkForWeapon(int weaponId, int perkId)
        {
            return _context.Perks
              .Where(p => p.WeaponId == weaponId && p.Id == perkId).FirstOrDefault();
        }

        public IEnumerable<Perk> GetPerksForWeapon(int weaponId)
        {
            return _context.Perks
                           .Where(p => p.WeaponId == weaponId).ToList();
        }

        public Weapon GetWeapon(int weaponId, bool includePerks)
        {
            if (includePerks)
            {
                return _context.Weapons.Include(c => c.Perks)
                    .Where(c => c.Id == weaponId).FirstOrDefault();
            }

            return _context.Weapons.Where(c => c.Id == weaponId).FirstOrDefault();
        }

        public IEnumerable<Weapon> GetWeapons()
        {
            return _context.Weapons.OrderBy(c => c.Name).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
