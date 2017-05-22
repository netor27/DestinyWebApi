using Destiny.WebApi.Entities;
using System.Collections.Generic;

namespace Destiny.WebApi.Services
{
    public interface IDestinyRepository
    {
        IEnumerable<Weapon> GetWeapons();
        Weapon GetWeapon(int weaponId, bool includePerks);
        IEnumerable<Perk> GetPerksForWeapon(int weaponId);
        Perk GetPerkForWeapon(int weaponId, int perkId);
        bool Save();
    }
}
