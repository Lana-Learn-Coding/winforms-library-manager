﻿using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component
{
    public partial class ComboboxControl : UserControl
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

        public ComboboxControl()
        {
            InitializeComponent();
            comboBox.Items.Insert(0, ComboboxSelection.None);
            comboBox.Items.Insert(1, ComboboxSelection.Create);
        }
    }

    internal class ComboboxSelection
    {
        private const string CreateSelectionText = "--- Create new item ---";
        private const string NoneSelectionText = "--- (None) ---";

        public static readonly ComboboxSelection None = new()
        {
            Text = NoneSelectionText
        };

        public static readonly ComboboxSelection Create = new()
        {
            Text = CreateSelectionText
        };

        public string Id { get; }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}