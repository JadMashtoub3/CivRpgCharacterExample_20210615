namespace CivRpgCharacterExample_20210615.models
{
    public class Item
    {

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(string name, int weight, int value)
        {
            this.Name = name;
            this.Weight = weight;
            this.Value = value;

        }
    }
}