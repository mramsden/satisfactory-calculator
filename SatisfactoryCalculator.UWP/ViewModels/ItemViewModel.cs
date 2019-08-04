using SatisfactoryCalculator.Core;
using SatisfactoryCalculator.UWP.Common;

namespace SatisfactoryCalculator.UWP.ViewModels
{
    public class ItemViewModel : BindableBase<Item>
    {
        public ItemViewModel(Item item = null) : base(item) { }

        public string Id
        {
            get { return This.Id; }
        }

        public string Name
        {
            get { return This.Name; }
        }
    }
}
