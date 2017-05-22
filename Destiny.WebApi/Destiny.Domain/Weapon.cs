using System;
using System.Collections.Generic;

namespace Destiny.Domain
{
    public class Weapon
    {
        public Weapon() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public int WeaponTypeId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<WeaponPerk> WeaponPerks { get; set; }
    }
}
