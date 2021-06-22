namespace CivRpgCharacterExample_20210615.models
{
    public class RpgCharacter
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Mp { get; set; }
        public int MaxMp { get; set; }
        public Inventory BackPack { get; set; }

        public RpgCharacter(string name, int maxHp, int maxMp)
        {
            this.Name = name;
            this.MaxHp = maxHp;
            // set mp to maxmp
            this.Hp = this.MaxHp;
            this.MaxMp = maxMp;
            // set mp to maxmp
            this.Mp = this.MaxMp;
            this.BackPack = new Inventory(100);
        }

        // Default constructor
        public RpgCharacter() {
            this.Name = "Dephoult";
            this.MaxHp = 100;
            this.Hp = this.MaxHp;
            this.MaxMp = 50;
            // set mp to maxmp
            this.Mp = this.MaxMp;
            this.BackPack = new Inventory(100);

            this.BackPack.Items.Add(new Item("Health Potion", 1, 10));
            this.BackPack.Items.Add(new Item("Stick", 1, 1));
            this.BackPack.Items.Add(new Weapon("Big Wacky Stick", 5, 5, 1, 5));
        }

        public int Attack(string weaponName) { return 0; }
        public void AddToBackPack(Item item) { 
            this.BackPack.AddNewItem(item);
        }
        public void RemoveFromBackPack(string itemName) { 
            this.BackPack.RemoveItem(itemName);
        }
        public string LookInBackPack() { 
            return this.BackPack.ListItems(); 
        }

    }
}