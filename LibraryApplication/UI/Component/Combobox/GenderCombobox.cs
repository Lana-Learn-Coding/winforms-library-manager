using System.Collections.ObjectModel;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.UI.Component.Combobox
{
    public class GenderCombobox : BaseComboboxControl<Gender>
    {
        protected sealed override ObservableCollection<Gender> LocalContext => Context.Genders.Local;

        public GenderCombobox()
        {
            Hint = "Select Gender";
            Label = "Gender";
        }
    }
}