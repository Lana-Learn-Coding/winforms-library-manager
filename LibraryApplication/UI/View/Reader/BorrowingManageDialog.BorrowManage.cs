using System;
using System.Data.Entity;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.UI.Component.Table;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialog
    {
        private void BindingTabBorrowManage()
        {
            this.WhenActivated(disposable =>
            {
                borrowedBookTable.Grid.Events().SelectionChanged.Select(_ =>
                    {
                        var selectedRows = borrowedBookTable.Grid.SelectedRows;
                        var rowsCount = selectedRows.Count;
                        if (rowsCount is 0 or > 1) return 0;
                        var row = selectedRows[0];
                        return int.Parse(row.Cells[0]?.Value?.ToString() ?? "0");
                    })
                    .Where(id => id > 0)
                    .DistinctUntilChanged()
                    .Select(id => ViewModel.Reader.Tickets.Where(ticket => !ticket.isReturned)
                        .SelectMany(ticket => ticket.BookItems)
                        .First(item => item.Id == id))
                    .BindTo(this, v => v.ViewModel.SelectedBorrowedBook)
                    .DisposeWith(disposable);

                borrowedBookTable.Grid.Events().DataBindingComplete
                    .Subscribe(_ => { borrowedBookTable.Grid.ClearSelection(); })
                    .DisposeWith(disposable);

                this.WhenAnyValue(v => v.ViewModel.BorrowedBooks)
                    .Select(value => value.ToBindingList())
                    .BindTo(this, v => v.borrowedBookTable.Grid.DataSource)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, vm => vm.IsSafeModeEnabled,
                    v => v.checkSafe.Checked).DisposeWith(disposable);

                this.BindCommand(ViewModel, vm => vm.ReturnBookCommand,
                        v => v.btnReturnBook)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, vm => vm.ReturnTicketCommand,
                        v => v.btnReturnTicket)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, vm => vm.RemoveBookCommand,
                        v => v.btnRemoveBook)
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, vm => vm.ExtendDueDateCommand,
                        v => v.btnExtendDueDate)
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, vm => vm.ExtendTicketDueDateCommand,
                        v => v.btnExtendTicketDueDate)
                    .DisposeWith(disposable);

                tabControl.Events().SelectedIndexChanged
                    .Where(x => tabControl.SelectedTab == tabBorrowManage)
                    .Select(x => Unit.Default)
                    .InvokeCommand(ViewModel, vm => vm.RefreshBorrowedBooksCommand)
                    .DisposeWith(disposable);
            });

            borrowedBookTable.Grid.AutoGenerateColumns = false;
            borrowedBookTable.Grid.Columns.AddRange(
                new DataGridViewTextBoxColumn {Name = "Id", DataPropertyName = "ID"},
                new DataGridViewTextBoxColumn
                {
                    Name = "Meta",
                    DataPropertyName = "BookMeta",
                    MinimumWidth = 200,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewDateTimeColumn {Name = "Ticket", DataPropertyName = "BorrowingTicket", Width = 200},
                new DataGridViewDateTimeColumn
                {
                    Name = "Borrowed Date",
                    DataPropertyName = "BorrowedDate",
                    Width = 150,
                    Format = "yyyy-MM-dd"
                },
                new DataGridViewDateTimeColumn
                {
                    Name = "Due Date",
                    DataPropertyName = "DueDate",
                    Width = 150,
                    Format = "yyyy-MM-dd"
                },
                new DataGridViewDateTimeColumn {Name = "Updated", DataPropertyName = "UpdatedAt", Width = 120}
            );
        }
    }
}