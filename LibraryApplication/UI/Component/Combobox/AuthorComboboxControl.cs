using System.Collections.ObjectModel;
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
        }
    }
}