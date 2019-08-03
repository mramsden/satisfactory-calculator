using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SatisfactoryCalculator.Core
{
    [DataContract]
    public class Recipe
    {
        [DataMember(Name = "product")]
        public string ItemId;

        [DataMember(Name = "alternate")]
        public bool IsAlternate;

        [DataMember(Name = "quantity")]
        public int Quantity;

        [DataMember(Name = "ingredients")]
        public List<Ingredient> Ingredients;
    }

    [DataContract]
    public class Ingredient
    {
        [DataMember(Name = "id")]
        public string ItemId;

        [DataMember(Name = "quantity")]
        public int Quantity;
    }
}
