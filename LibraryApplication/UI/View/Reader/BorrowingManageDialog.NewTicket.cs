using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.Model.Book;
using LibraryApplication.UI.Component.Table;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialog
    {
        private void BindingTabNewTicket()
        {
            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(view => view.ViewModel.BorrowableBooks)
                    .Select(items => items.ToBindingList())
                    .BindTo(this, view => view.availableBookTable.Grid.DataSource)
                    .DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.NewTicket.Note,
                    v => v.txtNote.Value).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.NewTicket.DueDate,
                    v => v.datePickerDueDate.Value).DisposeWith(disposable);
                this.OneWayBind(ViewModel, vm => vm.NewTicket.Id,
                    v => v.txtID.Value).DisposeWith(disposable);
                this.BindCommand(ViewModel, vm => vm.SaveNewTicketCommand, v => v.btnSaveNewTicket)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, vm => vm.ClearNewTicketCommand, v => v.btnClearNewTicket)
                    .DisposeWith(disposable);
                this.WhenAnyValue(v => v.ViewModel.NewTicket.BookItems)
                    .Select(value => ((ObservableCollection<BookItem>) value).ToBindingList())
                    .BindTo(this, v => v.addedBBookList.DataSource)
                    .DisposeWith(disposable);

                tabControl.Events().SelectedIndexChanged
                    .Where(x => tabControl.SelectedTab == tabNewTicket)
                    .Select(x => Unit.Default)
                    .InvokeCommand(ViewModel, vm => vm.ClearNewTicketCommand)
                    .DisposeWith(disposable);

                availableBookTable.Grid.Events().CellClick
                    .Select(e =>
                    {
                        if (e.RowIndex < 0 || e.ColumnIndex != availableBookTable.Grid.Columns["Action"]?.Index)
                            return 0;
                        var row = availableBookTable.Grid.SelectedRows[0];
                        return int.Parse(row.Cells[0]?.Value?.ToString() ?? "0");
                    })
                    .InvokeCommand(ViewModel, vm => vm.AddBookToListCommand)
                    .DisposeWith(disposable);
            });

            availableBookTable.Grid.AutoGenerateColumns = false;
            availableBookTable.Grid.Columns.AddRange(
                new DataGridViewTextBoxColumn {Name = "Id", DataPropertyName = "ID"},
                new DataGridViewTextBoxColumn
                {
                    Name = "Meta",
                    DataPropertyName = "BookMeta",
                    MinimumWidth = 300,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewDateTimeColumn {Name = "Updated", DataPropertyName = "UpdatedAt", Width = 120},
                new DataGridViewTextBoxColumn {Name = "Borrowed", DataPropertyName = "BorrowingTicket", Width = 100},
                new DataGridViewButtonColumn
                {
                    Name = "Action",
                    Text = "Toggle",
                    UseColumnTextForButtonValue = true, Width = 60
                }
            );
        }
    }
}