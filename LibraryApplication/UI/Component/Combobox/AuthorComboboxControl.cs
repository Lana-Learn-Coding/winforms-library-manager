using System.Collections.ObjectModel;
using System.Data.Entity;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.UI.Component.Combobox
{
    public class AuthorComboboxControl : BaseComboboxControl<Author>
    {
        protected sealed override ObservableCollection<Author> LocalContext => Context.Authors.Local;

        public AuthorComboboxControl()
        {
            Hint = "Select Author";
            Label = "Author";
            DataSource = LocalContext.ToBindingList();
        }
    }
}