using SatisfactoryCalculator.Core;
using SatisfactoryCalculator.UWP.Common;

namespace SatisfactoryCalculator.UWP.ViewModels
{
    public class RecipeViewModel : BindableBase<Recipe>
    {
        private ItemsDatabase itemsDatabase;

        public RecipeViewModel(ItemsDatabase itemsDatabase, Recipe recipe = null) : base(recipe)
        {
            this.itemsDatabase = itemsDatabase;
        }

        public string Name
        {
            get { return itemsDatabase.FindItemForId(This.ItemId).Name; }
        }
    }
}