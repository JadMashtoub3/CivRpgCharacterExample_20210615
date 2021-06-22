namespace CivRpgCharacterExample_20210615.models
{
    public class magic : range
    {
        public int MpCost { get; set; }
        public int maxMPCost { get; set; }
        public magic() : base("Staff", 30, 100, 25, 1000, 50, 200)
        {
            MpCost = 10;
        }

        public magic(string name, int weight, int value, int damage, int maxDurability, int minRange, int maxRange, int mpCost) : base(name, weight, value, damage, maxDurability, minRange, maxRange)
        {
            MpCost = mpCost;
        }
    }
}