using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
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
        private void BindingTabHistory()
        {
            this.WhenActivated(disposable =>
            {
                bookHistoryTable.Grid.Events().SelectionChanged.Select(_ =>
                    {
                        var selectedRows = bookHistoryTable.Grid.SelectedRows;
                        var rowsCount = selectedRows.Count;
                        if (rowsCount is 0 or > 1) return 0;
                        var row = selectedRows[0];
                        return int.Parse(row.Cells[0]?.Value?.ToString() ?? "0");
                    })
                    .DistinctUntilChanged()
                    .Select(id =>
                    {
                        if (id == 0) return new BookItem();
                        return ViewModel.Reader.Tickets
                            .SelectMany(ticket => ticket.BookItems)
                            .First(item => item.Id == id);
                    })
                    .BindTo(this, v => v.ViewModel.SelectedHistoryBook)
                    .DisposeWith(disposable);

                this.WhenAnyValue(view => view.ViewModel.SelectedHistoryBook.Tickets)
                    .Select(items => ((ObservableCollection<Ticket>) items).ToBindingList())
                    .BindTo(this, view => view.bookTicketList.DataSource)
                    .DisposeWith(disposable);

                this.OneWayBind(ViewModel, vm => vm.SelectedHistoryBook.Id,
                        v => v.txtIdHistory.Value)
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel, vm => vm.SelectedHistoryBook.BookMeta,
                        v => v.txtBookHistory.Value,
                        value => value?.ToString())
                    .DisposeWith(disposable);

                this.WhenAnyValue(v => v.ViewModel.HistoryBooks)
                    .Select(value => value.ToBindingList())
                    .BindTo(this, v => v.bookHistoryTable.Grid.DataSource)
                    .DisposeWith(disposable);

                this.OneWayBind(ViewModel, vm => vm.SelectedHistoryBook.Tickets,
                        v => v.txtCountHistory.Value,
                        value => value.Count.ToString())
                    .DisposeWith(disposable);

                this.WhenAnyValue(v => v.ViewModel.SelectedHistoryBook)
                    .Where(item => item.Tickets.Count > 0)
                    .Subscribe(bookItem =>
                    {
                        if (bookItem.IsBorrowed)
                        {
                            txtLastBorrowHistory.Value = bookItem.BorrowedDate.Value.ToString("yyyy-MM-dd");
                            txtLastReturnHistory.Value = "Borrowed";
                            return;
                        }

                        txtLastBorrowHistory.Value = bookItem.Tickets.OrderByDescending(t => t.BorrowedDate)
                            .First().BorrowedDate.ToString("yyyy-MM-dd");
                        txtLastReturnHistory.Value = bookItem.Tickets.OrderByDescending(ticket => ticket.ReturnedDate)
                            .First().ReturnedDate.Value.ToString("yyyy-MM-dd");
                    });

                tabControl.Events().SelectedIndexChanged
                    .Where(x => tabControl.SelectedTab == tabHistory)
                    .Select(x => Unit.Default)
                    .InvokeCommand(ViewModel, vm => vm.RefreshHistoryCommand)
                    .DisposeWith(disposable);
            });
            bookHistoryTable.Grid.AutoGenerateColumns = false;
            bookHistoryTable.Grid.Columns.AddRange(
                new DataGridViewTextBoxColumn {Name = "Id", DataPropertyName = "ID"},
                new DataGridViewTextBoxColumn
                {
                    Name = "Meta",
                    DataPropertyName = "BookMeta",
                    MinimumWidth = 200,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewTextBoxColumn {Name = "Count", DataPropertyName = "BorrowedTimes"},
                new DataGridViewDateTimeColumn {Name = "Ticket", DataPropertyName = "BorrowingTicket", Width = 200},
                new DataGridViewDateTimeColumn {Name = "Updated", DataPropertyName = "UpdatedAt", Width = 120}
            );
        }
    }
}