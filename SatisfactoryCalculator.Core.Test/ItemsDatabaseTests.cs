using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SatisfactoryCalculator.Core.Test
{
    [TestClass]
    public class ItemsDatabaseTests
    {
        [TestMethod]
        public void CanSearchItems()
        {
            var database = new ItemsDatabase
            {
                Items = new List<Item>
                {
                    new Item { Id = "bauxite", Name = "Bauxite" },
                    new Item { Id = "caterium_ore", Name = "Caterium Ore" },
                    new Item { Id = "copper_ore", Name = "Copper Ore" }
                }
            };
            var results = database.FindItemsForSearchTerm("ore");

            CollectionAssert.AreEqual(new List<Item>
            {
                new Item { Id = "caterium_ore", Name = "Caterium Ore" },
                new Item { Id = "copper_ore", Name = "Copper Ore" }
            }, results.ToList());
        }

        [TestMethod]
        public void CanGetRecipes()
        {
            var database = new ItemsDatabase
            {
                Items = new List<Item>
                {
                    new Item { Id = "iron_ore", Name = "Iron Ore" },
                    new Item { Id = "iron_ingot", Name = "Iron Ingot" },
                },
                Recipes = new List<Recipe>
                {
                    new Recipe { ItemId = "iron_ingot", IsAlternate = false, Quantity = 1, Ingredients = new List<Ingredient> { new Ingredient { ItemId = "iron_ore", Quantity = 1 } } }
                }
            };

            var results = database.FindRecipesForItem(new Item { Id = "iron_ingot", Name = "Iron Ingot" });

            CollectionAssert.AreEqual(new List<Recipe>
            {
                new Recipe { ItemId = "iron_ingot", IsAlternate = false, Quantity = 1, Ingredients = new List<Ingredient> { new Ingredient { ItemId = "iron_ore", Quantity = 1 } } }
            }, results.ToList());
        }
    }
}
