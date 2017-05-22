using Destiny.Data.Entities;
using System.Collections.Generic;

namespace Destiny.Services
{
    public interface IDestinyRepository
    {
        IEnumerable<Weapon> GetWeapons();
        IEnumerable<Perk> GetPerks();        
    }
}
