using SatisfactoryCalculator.Core;
using SatisfactoryCalculator.UWP.ViewModels;
using Windows.UI.Xaml.Controls;

namespace SatisfactoryCalculator.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            var itemsDatabase = ItemsDatabaseLoader.Load();
            Items = new ItemsViewModel(itemsDatabase);
        }

        public ItemsViewModel Items { get; set; }
    }
}
