using System;
using System.Reflection;
using System.Runtime.Serialization.Json;

namespace SatisfactoryCalculator.Core
{
    internal class ItemsDatabaseLoader
    {
        private const string RESOURCE_NAME = "SatisfactoryCalculator.Core.Resources.items.json";

        internal static ItemsDatabase Load()
        {
            var assembly = Assembly.GetAssembly(typeof(ItemsDatabaseLoader));
            using (var itemsFileStream = assembly.GetManifestResourceStream(RESOURCE_NAME)) {
                var serializer = new DataContractJsonSerializer(typeof(ItemsDatabase));
                return (ItemsDatabase) serializer.ReadObject(itemsFileStream);
            }
        }
    }
}
