using System.Collections.Generic;
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
    }
}
