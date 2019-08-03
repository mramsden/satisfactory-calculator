using System;
using System.Reflection;
using System.Runtime.Serialization.Json;

namespace SatisfactoryCalculator.Core
{
    public class ItemsDatabaseLoader
    {
        private const string RESOURCE_NAME = "SatisfactoryCalculator.Core.Resources.items.json";

        public static ItemsDatabase Load()
        {
            var assembly = Assembly.GetAssembly(typeof(ItemsDatabaseLoader));
            using (var itemsFileStream = assembly.GetManifestResourceStream(RESOURCE_NAME))
            {
                var serializer = new DataContractJsonSerializer(typeof(ItemsDatabase));
                return (ItemsDatabase)serializer.ReadObject(itemsFileStream);
            }
        }
    }
}
