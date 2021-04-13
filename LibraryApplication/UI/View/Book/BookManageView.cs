using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.Model;
using ReactiveUI;
using ReactiveUI.Validation.Extensions;
using Splat;

namespace LibraryApplication.UI.View.Book
{
    public partial class BookManageView : UserControl, IViewFor<BookManageViewModel>
    {
        public BookManageView()
        {
            InitializeComponent();
            var context = Locator.Current.GetService<ModelContext>();
            selectAuthor.DataSource = context.Authors.Local.ToBindingList();
            selectPublisher.DataSource = context.Publishers.Local.ToBindingList();
            selectCategory.DataSource = context.Categories.Local.ToBindingList();
            selectSeries.DataSource = context.Series.Local.ToBindingList();

            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(view => view.ViewModel.SelectedItem)
                    .Subscribe(book =>
                    {
                        if (book?.Id == null)
                        {
                            btnDelete.Enabled = false;
                            table.ClearSelection();
                            return;
                        }

                        btnDelete.Enabled = book.Id != null || book.Items.All(item => item.BorrowingTicket == null);
                        var rowIndex = table.Rows
                            .Cast<DataGridViewRow>()
                            .First(r => r.Cells[0].Value.Equals(book.Id))
                            .Index;

                        table.InvalidateRow(rowIndex);
                        table.Rows[rowIndex].Selected = true;
                    })
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Id, view => view.txtID.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Title, view => view.txtTitle.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Title, view => view.txtTitle.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Year,
                        view => view.txtYear.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel,
                        model => model.SelectedItem.Year,
                        view => view.txtYear.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Author,
                        view => view.selectAuthor.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel,
                        model => model.SelectedItem.Author,
                        view => view.selectAuthor.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Category,
                        view => view.selectCategory.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel,
                        model => model.SelectedItem.Category,
                        view => view.selectCategory.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Series,
                        view => view.selectSeries.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel,
                        model => model.SelectedItem.Series,
                        view => view.selectSeries.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Publisher,
                        view => view.selectPublisher.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel,
                        model => model.SelectedItem.Publisher,
                        view => view.selectPublisher.Error)
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ClearSelectionCommand, view => view.btnClear);
                this.BindCommand(ViewModel, model => model.SaveCommand, view => view.btnSave);
                this.BindCommand(ViewModel, model => model.DeleteCommand, view => view.btnDelete);


                table.DataSource = ViewModel.Items.ToBindingList();
                table.Events().SelectionChanged
                    .Select(arg => table.SelectedRows.Count)
                    .Subscribe(rowsCount =>
                    {
                        if (rowsCount == 0 || rowsCount > 1) return;
                        var row = table.SelectedRows[0];
                        if (row == null) return;
                        var id = row.Cells[0].Value.ToString() ?? "0";
                        ViewModel.OnRowSelected(int.Parse(id));
                    })
                    .DisposeWith(disposable);
            });
            ViewModel = new BookManageViewModel();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BookManageViewModel) value;
        }
    }
}