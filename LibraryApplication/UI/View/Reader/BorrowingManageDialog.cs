using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialog : MaterialForm, IViewFor<BorrowingManageDialogModel>
    {
        public BorrowingManageDialog(Model.Book.Reader reader)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            Text = $"Borrow Manage - {reader.Name}";
            txtReader.Value = $"{reader.Id} - {reader.Name}";
            txtReaderEmail.Value = $"{reader.Email}";
            datePickerDueDate.Required = true;
            datePickerDueDate.MinDate = DateTime.Today.AddDays(1);

            ViewModel = new BorrowingManageDialogModel(reader);
            BindingTabNewTicket();
            BindingTabBorrowManage();
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BorrowingManageDialogModel) value;
        }

        public BorrowingManageDialogModel ViewModel { get; set; }
    }
}