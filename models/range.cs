namespace CivRpgCharacterExample_20210615.models
{
    public class range : Weapon
    {
       
        public int MaxRange { get; set; }
         public int MinRange { get; set; }
        public range() : base("Bow", 20, 500, 10, 1000)
        {
            MinRange = 5;
            MaxRange = 50;
        }

        public range(string name, int weight, int value, int damage, int maxDurability, int minRange, int maxRange) : base(name, weight, value, damage, maxDurability)
        {
            MinRange = minRange;
            MaxRange = maxRange;
        }
    }
}