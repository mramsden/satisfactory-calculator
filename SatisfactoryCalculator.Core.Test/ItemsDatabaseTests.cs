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
    }
}
