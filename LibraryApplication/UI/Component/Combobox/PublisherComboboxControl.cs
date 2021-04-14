using System.Collections.ObjectModel;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.UI.Component.Combobox
{
    public class PublisherComboboxControl : BaseComboboxControl<Publisher>
    {
        protected sealed override ObservableCollection<Publisher> LocalContext => Context.Publishers.Local;

        public PublisherComboboxControl()
        {
            Hint = "Select Publisher";
            Label = "Publisher";
        }
    }
}