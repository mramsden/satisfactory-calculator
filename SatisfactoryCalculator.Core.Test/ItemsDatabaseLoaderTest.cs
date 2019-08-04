using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SatisfactoryCalculator.Core
{
    [TestClass]
    public class ItemsDatabaseLoaderTest
    {
        [TestMethod]
        public void CanLoadItemsDatabase()
        {
            var database = ItemsDatabaseLoader.Load();
            Assert.AreEqual(99, database.Items.Count);
            Assert.AreEqual(117, database.Recipes.Count);
        }
    }
}
