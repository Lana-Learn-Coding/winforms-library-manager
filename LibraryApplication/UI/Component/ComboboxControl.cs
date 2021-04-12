using System.ComponentModel;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LibraryApplication.UI.Component
{
    public partial class ComboboxControl : UserControl, INotifyPropertyChanged
    {
        [Description("Hint of the combobox"), Category("Material Skin")]
        public string Hint
        {
            get => comboBox.Hint;
            set => comboBox.Hint = value;
        }

        [Description("Error of the textbox"), Category("Material Skin")]
        public string Error
        {
            get => lblError.Text;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    comboBox.UseAccent = false;
                    lblError.Text = "";
                    return;
                }

                lblError.Text = value;
                comboBox.UseAccent = true;
            }
        }

        [Description("Label of the textbox"), Category("Material Skin")]
        public string Label
        {
            get => lbl.Text;
            set => lbl.Text = value;
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => comboBox.Text;
            set => comboBox.Text = value;
        }

        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint),
         AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get => comboBox.DataSource;
            set => comboBox.DataSource = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object? Value
        {
            get => comboBox.SelectedItem;
            set
            {
                comboBox.SelectedItem = value;
                comboBox.Refresh();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ComboboxControl()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += (_, _) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
        }
    }

    internal class ComboboxSelection
    {
        private const string CreateSelectionText = "--- Create new item ---";
        private const string NoneSelectionText = "--- (None) ---";

        public static readonly ComboboxSelection None = new()
        {
            Name = NoneSelectionText
        };

        public static readonly ComboboxSelection Create = new()
        {
            Name = CreateSelectionText
        };

        public int Id { get; init; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}