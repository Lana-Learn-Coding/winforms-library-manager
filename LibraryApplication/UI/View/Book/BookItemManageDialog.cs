using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows.Forms;
using LibraryApplication.Model.Book;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View.Book
{
    public partial class BookItemManageDialog : MaterialForm, IDataFormView<BookItem, BookItemManageDialogModel>
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookItemManageDialogModel ViewModel { get; set; }

        public BookItemManageDialog(BookMeta bookMeta)
        {
            InitializeComponent();
            selectPosition.InitializeDataSource();
            selectStorage.InitializeDataSource();
            txtMeta.Value = $"{bookMeta.Id.ToString()} - {bookMeta.Title}";
            ((IDataFormView<BookItem, BookItemManageDialogModel>) this).InitializeViewModelBindings();

            this.WhenActivated(disposable =>
            {
                this.OneWayBind(ViewModel,
                        vm => vm.SelectedItem.BorrowingTicket.Reader,
                        v => v.txtBorrower.Value,
                        reader => reader != null ? $"{reader.Id} - {reader.Name}" : "Not Borrowed")
                    .DisposeWith(disposable);

                this.OneWayBind(ViewModel,
                        vm => vm.SelectedItem.Id,
                        v => v.txtID.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        vm => vm.SelectedItem.Condition,
                        v => v.txtCondition.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        vm => vm.SelectedItem.Storage,
                        v => v.selectStorage.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        vm => vm.SelectedItem.Position,
                        v => v.selectPosition.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        vm => vm.SelectedItem.Image,
                        v => v.imgPicker.Value)
                    .DisposeWith(disposable);
            });
            ViewModel = new BookItemManageDialogModel(bookMeta);
        }

        public MaterialButton BtnSave => btnSave;
        public MaterialButton BtnDelete => btnDelete;
        public MaterialButton BtnClear => btnClear;
        public DataGridView Table => table;
    }
}