using System.Collections.Generic;

namespace Destiny.WebApi.Models
{
    public class WeaponDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WeaponType { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<PerkDto> Perks { get; set; } = new List<PerkDto>();
    }
}
