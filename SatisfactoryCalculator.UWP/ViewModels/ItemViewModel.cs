using SatisfactoryCalculator.Core;

namespace SatisfactoryCalculator.UWP.ViewModels
{
    public class ItemViewModel : NotificationBase<Item>
    {
        public ItemViewModel(Item item = null) : base(item) { }

        public string Name
        {
            get { return This.Name; }
        }
    }
}
