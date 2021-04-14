using System.Collections.ObjectModel;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.UI.Component.Combobox
{
    public class PositionComboboxControl : BaseComboboxControl<Position>
    {
        protected override ObservableCollection<Position> LocalContext => Context.Positions.Local;

        public PositionComboboxControl()
        {
            Hint = "Select Position";
            Label = "Position";
        }
    }
}