using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows.Forms;
using LibraryApplication.Model.Book;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class TicketManageView : UserControl, IDataFormView<Ticket, TicketManageViewModel>
    {
        public TicketManageView()
        {
            InitializeComponent();
            datePickerDueDate.Required = true;
            ((IDataFormView<Ticket, TicketManageViewModel>) this).InitializeViewModelBindings();
            this.WhenActivated(disposable =>
            {
                this.OneWayBind(ViewModel, model => model.IsUpdating, view => view.btnBorrow.Enabled)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Note, view => view.txtNote.Value)
                    .DisposeWith(disposable);
                this.Bind(ViewModel, model => model.SelectedItem.DueDate, view => view.datePickerDueDate.Value)
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel, model => model.SelectedItem.Id, view => view.txtID.Value)
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel, model => model.SelectedItem.BorrowedDate,
                        view => view.datePickerBorrow.Value)
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel, model => model.SelectedItem.ReturnedDate,
                        view => view.datePickerReturn.Value)
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel, model => model.SelectedItem.Reader, view => view.txtReader.Value,
                        reader => $"{reader.Id} -  {reader.Name}")
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ReturnBookCommand, view => view.btnReturn)
                    .DisposeWith(disposable);
            });
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TicketManageViewModel ViewModel { get; set; } = new();

        public MaterialButton BtnSave => btnSave;
        public MaterialButton BtnDelete { get; } = new();
        public MaterialButton BtnClear { get; } = new();
        public DataGridView Table => table;
    }
}