using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component
{
    public partial class ImagePickerControl : UserControl, INotifyPropertyChanged
    {
        public string Value
        {
            get => imgBox.ImageLocation;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    imgBox.LoadAsync("none");
                    return;
                }

                imgBox.LoadAsync(value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ImagePickerControl()
        {
            InitializeComponent();
            imgBox.WaitOnLoad = false;
            imgBox.LoadCompleted +=
                (_, _) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));

            fileDialog.Filter = "Image files|*.jpg; *.jpeg; *.png";
            fileDialog.Multiselect = false;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgBox.LoadAsync(fileDialog.FileName);
            }
        }
    }
}