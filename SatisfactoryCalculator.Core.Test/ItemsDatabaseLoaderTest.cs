using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SatisfactoryCalculator.Core
{
    [TestClass]
    public class ItemsDatabaseLoaderTest
    {
        [TestMethod]
        public void CanLoadItemsDatabase()
        {
            var database = ItemsDatabaseLoader.Load();
            Assert.AreEqual(102, database.Items.Count);
            Assert.AreEqual(117, database.Recipes.Count);
        }
    }
}
