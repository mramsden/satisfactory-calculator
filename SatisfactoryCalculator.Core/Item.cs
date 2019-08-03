using System.Runtime.Serialization;

namespace SatisfactoryCalculator.Core
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "id")]
        public string Id { get; internal set; }

        [DataMember(Name = "name")]
        public string Name { get; internal set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return ((Item)obj).Id.Equals(Id);
        }
    }
}
