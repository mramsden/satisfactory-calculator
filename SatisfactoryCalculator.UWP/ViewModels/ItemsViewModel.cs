using SatisfactoryCalculator.Core;
using SatisfactoryCalculator.UWP.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SatisfactoryCalculator.UWP.ViewModels
{
    public class ItemsViewModel : BindableBase
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

        private int selectedIndex = -1;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                if (SetProperty(ref selectedIndex, value))
                {
                    RaisePropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public SelectedItemViewModel SelectedItem
        {
            get {
                if (selectedIndex > -1)
                {
                    var item = currentItems[selectedIndex];
                    return new SelectedItemViewModel(itemsDatabase, item);
                }
                return null;
            }
        }

        private void setCurrentItems(IEnumerable<Item> currentItems)
        {
            SelectedIndex = -1;
            this.currentItems.Clear();
            foreach (var item in currentItems.OrderBy(item => item.Name))
            {
                var itemViewModel = new ItemViewModel(item);
                this.currentItems.Add(itemViewModel);
            }
        }
    }
}
