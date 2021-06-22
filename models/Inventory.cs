using System.Collections.Generic;
using System.Linq;

namespace CivRpgCharacterExample_20210615.models
{
    public class Inventory
    {

        public int WeightCapacity { get; set; }
        public List<Item> Items { get; set; }

        public Inventory(int weightCapacity)
        {
            this.WeightCapacity = weightCapacity;

            // initialise an empty list of items
            this.Items = new List<Item>();
        }

        public void SortByName() { 
            this.Items = this.Items.OrderBy(thing => thing.Name).ToList();
        }

        public void SortByWeight() {
            this.Items = this.Items.OrderBy(i => i.Weight).ToList();
        }

        public int GetCurrentCapacity() { 
            int i=0;
            foreach (Item item in this.Items)
            {
                i+=item.Weight;
            }
            return i; 
            
        }

        public void AddNewItem(Item item) { 
            this.Items.Add(item);
        }

        public void RemoveItem(string itemName) { 
            // Go through the list - foreach --
            // Check each item's name to see if matches the search term (itemName) - if
            // if match - remove item, stop the loop
            // if no match - keep going through the loop

            foreach(Item i in this.Items) {
                if (i.Name == itemName) {
                    this.Items.Remove(i);
                    break;
                } 
            }

        }

        public int GetQuantity(string itemName) { 
            int quantity=0;
            foreach(Item i in this.Items){
                if(i.Name==itemName){
                    quantity++;
                }
            }
            return quantity; 
        }
             
        

        public string ListItems() { 
            string result = "Name\t\t\t\t\tWeight\t\tValue\n";
            result += "---------------------------------------------------------------\n";
            foreach(Item thing in this.Items) {
                result += $"{thing.Name}\t\t\t\t{thing.Weight}\t\t{thing.Value}\n";
            }

            return result;
         }
    }
}