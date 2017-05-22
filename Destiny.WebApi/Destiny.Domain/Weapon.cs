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
        public Uri ImageUri { get; set; }
        public List<Perk> Perks { get; set; }
    }
}
