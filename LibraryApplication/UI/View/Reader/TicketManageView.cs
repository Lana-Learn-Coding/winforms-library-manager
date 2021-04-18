using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using DynamicData.Kernel;
using LibraryApplication.Model;
using LibraryApplication.Model.Book;
using LibraryApplication.UI.Component;
using LibraryApplication.UI.Component.Table;
using MaterialSkin.Controls;
using ReactiveUI;
using Splat;
using MessageBox = System.Windows.MessageBox;

namespace LibraryApplication.UI.View.Reader
{
    public partial class TicketManageView : UserControl, IDataFormView<Ticket, TicketManageViewModel>
    {
        public TicketManageView()
        {
            InitializeComponent();
            datePickerDueDate.Required = true;
            datePickerDueDate.MinDate = DateTime.Now;
            ((IDataFormView<Ticket, TicketManageViewModel>) this).InitializeViewModelBindings();
            this.WhenActivated(disposable =>
            {
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

                this.WhenAnyValue(v => v.ViewModel.SelectedItem)
                    .Select(value => !value.isReturned)
                    .BindTo(this, v => v.datePickerDueDate.Enabled)
                    .DisposeWith(disposable);

                this.WhenAnyValue(v => v.ViewModel.SelectedItem)
                    .Select(value => !value.isReturned)
                    .BindTo(this, v => v.btnReturn.Enabled)
                    .DisposeWith(disposable);

                this.WhenAnyValue(v => v.ViewModel.SelectedItem.BookItems)
                    .Select(value => ((ObservableCollection<BookItem>) value).ToBindingList())
                    .BindTo(this, v => v.borrowingList.DataSource)
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ReturnBookCommand, view => view.btnReturn)
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ToggleBorrowBookCommand, view => view.btnBorrow)
                    .DisposeWith(disposable);

                var context = Locator.Current.GetService<ModelContext>();
                this.WhenAnyValue(v => v.ViewModel.ShowBorrowBookDialog)
                    .Subscribe(show =>
                    {
                        if (!show || !ViewModel.IsUpdating) return;
                        ViewModel.ShowBorrowBookDialog = false;
                        var query = PromptDialog.PromptInput(this, "Enter reader phone, email, or id:");
                        if (query == null)
                        {
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(query))
                        {
                            MessageBox.Show("Please enter something", "Error");
                            return;
                        }

                        query = query.Trim();
                        var reader = context.Readers.Local.FirstOrOptional(model =>
                        {
                            try
                            {
                                var id = int.Parse(query);
                                return model.Id == id || model.PhoneNumber.Equals(query);
                            }
                            catch (Exception e)
                            {
                                return model.Email.Equals(query);
                            }
                        });

                        if (reader.HasValue)
                        {
                            var form = new BorrowingManageDialog(reader.Value);
                            form.ShowDialog(this);
                            ViewModel.RefreshSelectionCommand.Execute();
                            return;
                        }

                        MessageBox.Show("Reader not found!", "error");
                    })
                    .DisposeWith(disposable);
            });
        }

        public void Setup()
        {
            Table.Grid.AutoGenerateColumns = false;
            Table.Grid.Columns.AddRange(
                new DataGridViewTextBoxColumn {Name = "ID", DataPropertyName = "Id", Width = 80},
                new DataGridViewTextBoxColumn
                {
                    Name = "Borrower",
                    DataPropertyName = "Reader",
                    MinimumWidth = 150,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
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
                new DataGridViewDateTimeColumn
                {
                    Name = "Returned Date",
                    DataPropertyName = "ReturnedDate",
                    Width = 150,
                    Format = "yyyy-MM-dd"
                },
                new DataGridViewDateTimeColumn {Name = "Updated", DataPropertyName = "UpdatedAt", Width = 120},
                new DataGridViewTextBoxColumn {Name = "Parent", DataPropertyName = "Parent"}
            );
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TicketManageViewModel ViewModel { get; set; } = new();

        public MaterialButton BtnSave => btnSave;
        public MaterialButton BtnDelete => btnDelete;
        public SearchableDataGridViewControl Table => table;
        public MaterialButton BtnClear { get; } = new();
    }
}