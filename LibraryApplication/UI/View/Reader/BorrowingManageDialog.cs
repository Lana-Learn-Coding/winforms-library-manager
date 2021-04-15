using System;
using System.Reactive.Disposables;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialog : MaterialForm, IViewFor<BorrowingManageDialogModel>
    {
        public BorrowingManageDialog(Model.Book.Reader reader)
        {
            InitializeComponent();
            CustomizeComponents(reader);
            ViewModel = new BorrowingManageDialogModel(reader);
            this.WhenActivated(disposable =>
            {
                BindingTabNewTicket(disposable);
                BindingTabBorrowManage(disposable);
            });
        }

        private void CustomizeComponents(Model.Book.Reader reader)
        {
            Text = $"Borrow Manage - {reader.Name}";
            txtReader.Value = $"{reader.Id} - {reader.Name}";
            txtReaderEmail.Value = $"{reader.Email}";
            datePickerDueDate.Required = true;
            datePickerDueDate.MinDate = DateTime.Today.AddDays(1);
            tabControl.SelectedIndexChanged += (_, _) =>
            {
                if (tabControl.SelectedTab == tabNewTicket)
                {
                    ViewModel.ClearNewTicketCommand.Execute();
                }
            };
        }

        private void BindingTabNewTicket(CompositeDisposable disposable)
        {
            this.Bind(ViewModel, vm => vm.NewTicket.Note,
                v => v.txtNote.Value).DisposeWith(disposable);
            this.Bind(ViewModel, vm => vm.NewTicket.DueDate,
                v => v.datePickerDueDate.Value).DisposeWith(disposable);
            this.Bind(ViewModel, vm => vm.NewTicket.DueDate,
                v => v.datePickerDueDate.Value).DisposeWith(disposable);
            this.OneWayBind(ViewModel, vm => vm.NewTicket.Id,
                v => v.txtID.Value).DisposeWith(disposable);
            this.BindCommand(ViewModel, vm => vm.SaveNewTicketCommand, v => v.btnSaveNewTicket)
                .DisposeWith(disposable);
            this.BindCommand(ViewModel, vm => vm.ClearNewTicketCommand, v => v.btnClearNewTicket)
                .DisposeWith(disposable);
        }

        private void BindingTabBorrowManage(CompositeDisposable disposable)
        {
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BorrowingManageDialogModel) value;
        }

        public BorrowingManageDialogModel ViewModel { get; set; }
    }
}