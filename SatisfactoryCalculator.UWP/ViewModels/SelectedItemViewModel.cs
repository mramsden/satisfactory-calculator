using SatisfactoryCalculator.Core;
using SatisfactoryCalculator.UWP.Common;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SatisfactoryCalculator.UWP.ViewModels
{
    public class SelectedItemViewModel : BindableBase<Item>
    {
        public SelectedItemViewModel(ItemsDatabase itemsDatabase, Item item) : base(item)
        {
            foreach (var recipe in itemsDatabase.FindRecipesForItem(item))
            {
                recipes.Add(new RecipeViewModel(itemsDatabase, recipe));
            }
        }

        public string Name
        {
            get { return This.Name; }
        }

        private ObservableCollection<RecipeViewModel> recipes = new ObservableCollection<RecipeViewModel> { };
        public ObservableCollection<RecipeViewModel> Recipes
        {
            get { return recipes; }
            set { SetProperty(ref recipes, value); }
        }

        public bool HasRecipes
        {
            get { return recipes.Count > 0; }
        }
    }
}
