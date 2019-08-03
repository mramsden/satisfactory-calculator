using SatisfactoryCalculator.Core;
using System.Collections.ObjectModel;
using System.Linq;

namespace SatisfactoryCalculator.UWP.ViewModels
{
    public class ItemsViewModel : NotificationBase
    {
        private ItemsDatabase itemsDatabase;

        public ItemsViewModel(ItemsDatabase itemsDatabase)
        {
            this.itemsDatabase = itemsDatabase;
            foreach (var item in this.itemsDatabase.Items.OrderBy(item => item.Name))
            {
                var itemViewModel = new ItemViewModel(item);
                currentItems.Add(itemViewModel);
            }
        }

        private ObservableCollection<ItemViewModel> currentItems = new ObservableCollection<ItemViewModel>();
        public ObservableCollection<ItemViewModel> CurrentItems
        {
            get { return currentItems; }
            set { SetProperty(ref currentItems, value); }
        }
    }
}
