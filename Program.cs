using System;
using CivRpgCharacterExample_20210615.models;

namespace CivRpgCharacterExample_20210615
{
    class Program
    {
        static void Main(string[] args)
        {
            Item healthPotion = new Item("Health Potion", 2, 10);
            Item stone = new Item("Stone", 1, 0);
            Item herb = new Item("Herb", 1, 2);
            Item hat = new Item("Magic Cap", 2, 100);

            Weapon sword = new Weapon("Sword", 20, 200, 10, 100);
            range bow = new range("Bow", 10, 200, 5, 50, 1, 5);
            magic wand = new magic("Wand of Pestilence", 10, 200, 5, 50, 1, 5, 2);

            RpgCharacter fred = new RpgCharacter("Fred", 100, 50);
            RpgCharacter defaultCharacter = new RpgCharacter();
            fred.BackPack.AddNewItem(healthPotion);
            fred.BackPack.AddNewItem(healthPotion);
            fred.BackPack.AddNewItem(stone);
            fred.BackPack.AddNewItem(hat);
            fred.BackPack.AddNewItem(herb);
            
            

            fred.BackPack.SortByWeight();
            System.Console.WriteLine($"Fred's backpack\n {fred.BackPack.ListItems()}");
            Console.WriteLine($"Fred's backpack is at {fred.BackPack.GetCurrentCapacity()}");
            Console.WriteLine($"{fred.BackPack.GetQuantity("Health Potion")} Health Potions in Fred's Backpack");


            defaultCharacter.BackPack.SortByName();
            System.Console.WriteLine($"Dephoult's backpack\n {defaultCharacter.BackPack.ListItems()}");

            // To cast (convert) an object into a subtype use the example below.  Turns an item into a weapon in this case
            // ((Weapon)defaultCharacter.BackPack.Items[0])
            System.Console.WriteLine($"{defaultCharacter.BackPack.Items[0].Name} damage: {((Weapon)defaultCharacter.BackPack.Items[0]).Damage}");            

            // go through default's backpack and see what's an item and what's a weapon
            foreach(Item i in defaultCharacter.BackPack.Items) {
                if (i is Item) {
                    System.Console.WriteLine($"{i.Name} is an Item");
                }

                if (i is Weapon) {
                    System.Console.WriteLine($"{i.Name} is a Weapon");
                }
            }
        }
    }
}
