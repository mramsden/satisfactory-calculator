using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SatisfactoryCalculator.Core
{
    [DataContract]
    public class ItemsDatabase
    {
        [DataMember(Name = "items")]
        public List<Item> Items { get; internal set; } = new List<Item> { };

        [DataMember(Name = "recipes")]
        public List<Recipe> Recipes { get; internal set; } = new List<Recipe> { };

        public Item FindItemForId(string id)
        {
            return (from item in Items
                    where item.Id.Equals(id)
                    select item).First();
        }
        public IEnumerable<Item> FindItemsForSearchTerm(string searchTerm)
        {
            return from item in Items
                   where item.Name.IndexOf(searchTerm, System.StringComparison.OrdinalIgnoreCase) > -1
                   select item;
        }

        public IEnumerable<Recipe> FindRecipesForItem(Item item)
        {
            return from recipe in Recipes
                   where recipe.ItemId.Equals(item.Id)
                   select recipe;
        }
    }
}
