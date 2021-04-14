using System.Collections.ObjectModel;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.UI.Component.Combobox
{
    public class StorageComboboxControl : BaseComboboxControl<Storage>
    {
        protected override ObservableCollection<Storage> LocalContext => Context.Storages.Local;

        public StorageComboboxControl()
        {
            Hint = "Select Storage";
            Label = "Storage";
        }
    }
}