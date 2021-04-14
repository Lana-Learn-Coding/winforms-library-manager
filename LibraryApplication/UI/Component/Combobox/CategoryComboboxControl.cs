using System.Collections.ObjectModel;
using System.Data.Entity;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.UI.Component.Combobox
{
    public class CategoryComboboxControl : BaseComboboxControl<Category>
    {
        protected sealed override ObservableCollection<Category> LocalContext => Context.Categories.Local;

        public CategoryComboboxControl()
        {
            Hint = "Select Category";
            Label = "Category";
            DataSource = LocalContext.ToBindingList();
        }
    }
}