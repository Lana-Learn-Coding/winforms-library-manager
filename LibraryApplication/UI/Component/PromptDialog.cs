using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LibraryApplication.UI.Component
{
    public partial class PromptDialog : MaterialForm
    {
        public DialogResult Result { get; private set; } = DialogResult.Cancel;

        public PromptDialog(Control control)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            Width = control.Width + 86;
            Height = control.Height + 128;

            // align control to center
            mainPanel.Controls.Add(control);
            control.Left = (mainPanel.Width - control.Width) / 2;
            control.Top = (mainPanel.Height - control.Height) / 2;

            btnOk.Click += (_, _) =>
            {
                Result = DialogResult.OK;
                Close();
            };

            btnCancel.Click += (_, _) =>
            {
                Result = DialogResult.Cancel;
                Close();
            };
        }

        public static string PromptInput(Control parent, string message, string defaultValue = "")
        {
            var input = new TextboxControl {Value = defaultValue, Error = "", Label = message, Width = 280};
            var prompt = new PromptDialog(input);
            prompt.ShowDialog(parent);
            return prompt.Result != DialogResult.OK ? null : input.Value;
        }

        public static DateTime? PromptDatePicker(Control parent, string message, DateTime? defaultValue = null,
            DateTime? minDate = null)
        {
            minDate ??= DateTime.MinValue;

            var input = new DatePickerControl
            {
                Value = defaultValue,
                Required = true,
                MinDate = minDate.Value,
                Error = "",
                Label = message,
                Width = 280
            };
            var prompt = new PromptDialog(input);
            prompt.ShowDialog(parent);
            return prompt.Result != DialogResult.OK ? defaultValue : input.Value;
        }
    }
}