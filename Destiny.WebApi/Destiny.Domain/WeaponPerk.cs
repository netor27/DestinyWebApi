namespace Destiny.Domain
{
    public class WeaponPerk
    {
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        public int PerkId { get; set; }
        public Perk Perk { get; set; }

    }
}
