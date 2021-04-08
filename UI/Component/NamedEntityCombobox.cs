using System.ComponentModel;

namespace WinFormsLibraryManager.UI.Component
{
    public partial class NamedEntityCombobox : CreateableComboBox
    {
        public NamedEntityCombobox() : this(null)
        {
        }

        public NamedEntityCombobox(IContainer container) : base(container)
        {
        }
    }
}