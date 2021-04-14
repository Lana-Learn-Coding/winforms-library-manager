using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DynamicData.Kernel;
using LibraryApplication.Model;
using Splat;

namespace LibraryApplication.UI.Component.Combobox
{
    public partial class BaseComboboxControl<T> : UserControl, INotifyPropertyChanged where T : class, INamed, new()
    {
        protected object DataSource
        {
            get => comboBox.DataSource;
            set => comboBox.DataSource = value;
        }

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

        public string Label
        {
            get => lbl.Text;
            set => lbl.Text = value;
        }

        public string Hint
        {
            get => comboBox.Hint;
            set => comboBox.Hint = value;
        }

        [Category("Material Skin"), DefaultValue(true)]
        public bool Required { get; set; }

        protected ModelContext Context { get; }

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

        protected BaseComboboxControl()
        {
            InitializeComponent();
            Context = Locator.Current.GetService<ModelContext>();
            comboBox.SelectedIndexChanged += (_, _) =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                menuItemEdit.Enabled = comboBox.SelectedItem != null;
                if (Required && comboBox.SelectedItem == null)
                {
                    Error = "Please select an item";
                }
            };
        }

        protected virtual ObservableCollection<T> LocalContext =>
            throw new NotSupportedException("LocalContext prop MUST be overriden by ALL derived classes.");

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            var input = Microsoft.VisualBasic.Interaction.InputBox("Enter name", "Add new item").Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Empty name. Aborted!");
                return;
            }

            var existedItem = LocalContext.FirstOrOptional(named => named.Name.Equals(input));
            if (existedItem.HasValue)
            {
                comboBox.SelectedItem = existedItem.Value;
                return;
            }

            var item = new T {Name = input};
            LocalContext.Add(item);
            Context.SaveChanges();
            comboBox.SelectedItem = item;
        }

        private void menuItemEdit_Click(object sender, EventArgs e)
        {
            var currentItem = (INamed) comboBox.SelectedItem;
            var input = Microsoft.VisualBasic.Interaction.InputBox("Enter name",
                $"Edit item {currentItem.Name}", currentItem.Name).Trim();
            if (input == currentItem.Name)
            {
                return;
            }

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Empty name. Aborted!");
                return;
            }

            if (LocalContext.Any(named => named.Name.Equals(input)))
            {
                MessageBox.Show("Item exist. Aborted!");
                return;
            }

            Context.Entry(currentItem).CurrentValues.SetValues(currentItem);
            Context.SaveChanges();
            comboBox.SelectedItem = currentItem;
        }
    }
}