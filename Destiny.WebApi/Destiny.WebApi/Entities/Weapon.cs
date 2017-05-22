using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Destiny.WebApi.Entities
{
    public class Weapon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string WeaponType { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }


        public List<Perk> Perks { get; set; } = new List<Perk>();
    }
}
