using SatisfactoryCalculator.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SatisfactoryCalculator.UWP.ViewModels
{
    public class ItemsViewModel : NotificationBase
    {
        private readonly ItemsDatabase itemsDatabase;

        public ItemsViewModel(ItemsDatabase itemsDatabase)
        {
            this.itemsDatabase = itemsDatabase;
            setCurrentItems(this.itemsDatabase.Items);
        }

        private ObservableCollection<ItemViewModel> currentItems = new ObservableCollection<ItemViewModel>();
        public ObservableCollection<ItemViewModel> CurrentItems
        {
            get { return currentItems; }
            set { SetProperty(ref currentItems, value); }
        }

        private string searchTerm = "";
        public string SearchTerm
        {
            get { return searchTerm; }
            set {
                if (SetProperty(ref searchTerm, value))
                {
                    setCurrentItems(itemsDatabase.FindItemsForSearchTerm(searchTerm));
                }
            }
        }

        private void setCurrentItems(IEnumerable<Item> currentItems)
        {
            this.currentItems.Clear();
            foreach (var item in currentItems.OrderBy(item => item.Name))
            {
                var itemViewModel = new ItemViewModel(item);
                this.currentItems.Add(itemViewModel);
            }
        }
    }
}
