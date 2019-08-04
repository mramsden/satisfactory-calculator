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

        public override bool Equals(object obj)
        {
            return obj is Recipe recipe &&
                   ItemId == recipe.ItemId &&
                   IsAlternate == recipe.IsAlternate &&
                   Quantity == recipe.Quantity &&
                   EqualityComparer<List<Ingredient>>.Default.Equals(Ingredients, recipe.Ingredients);
        }

        public override int GetHashCode()
        {
            var hashCode = -527832577;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ItemId);
            hashCode = hashCode * -1521134295 + IsAlternate.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Ingredient>>.Default.GetHashCode(Ingredients);
            return hashCode;
        }
    }

    [DataContract]
    public class Ingredient
    {
        [DataMember(Name = "id")]
        public string ItemId;

        [DataMember(Name = "quantity")]
        public int Quantity;

        public override bool Equals(object obj)
        {
            return obj is Ingredient ingredient &&
                   ItemId == ingredient.ItemId &&
                   Quantity == ingredient.Quantity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1376027413;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ItemId);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
