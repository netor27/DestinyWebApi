namespace Destiny.Domain
{
    public class Perk
    {
        public Perk() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WeaponId { get; set; }
    }
}
