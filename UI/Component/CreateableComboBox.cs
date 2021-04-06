using MaterialSkin.Controls;
using System.ComponentModel;

namespace WinFormsLibraryManager.UI.Component
{
    public partial class CreateableComboBox : MaterialComboBox
    {
        public string CreateSelectionText { get; set; } = "--- Create new item ---";
        public string DefaultSelectionText { get; set; } = "--- (None) ---";

        public CreateableComboBox() : this(null)
        {
        }

        public CreateableComboBox(IContainer container)
        {
            container?.Add(this);

            InitializeComponent();
            Items.Insert(0, new {Text = DefaultSelectionText, Name = DefaultSelectionText});
            Items.Insert(1, new {Text = CreateSelectionText, Name = CreateSelectionText});
            DisplayMember = "Text";
            SelectedItem = null;
        }
    }
}