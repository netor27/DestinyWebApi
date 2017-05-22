using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destiny.Domain
{
    public class Perk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [ForeignKey("WeaponId")]
        public Weapon Weapon { get; set; }
        public int WeaponId
        {
            get; set;
        }
    }
}
