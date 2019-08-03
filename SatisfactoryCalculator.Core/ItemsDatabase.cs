using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SatisfactoryCalculator.Core
{
    [DataContract]
    public class ItemsDatabase
    {
        [DataMember(Name = "items")]
        internal List<Item> Items;

        [DataMember(Name = "recipes")]
        internal List<Recipe> Recipes;

        public IEnumerable<Item> FindItemsForSearchTerm(string searchTerm)
        {
            return from item in Items
                   where item.Name.IndexOf(searchTerm, System.StringComparison.OrdinalIgnoreCase) > -1
                   select item;
        }
    }
}
