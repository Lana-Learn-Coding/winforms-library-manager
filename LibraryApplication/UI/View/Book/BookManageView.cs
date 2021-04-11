using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.Model;
using ReactiveUI;
using Splat;

namespace LibraryApplication.UI.View.Book
{
    public partial class BookManageView : UserControl, IViewFor<BookManageViewModel>
    {
        public BookManageView()
        {
            InitializeComponent();
            ViewModel = new BookManageViewModel();

            var context = Locator.Current.GetService<ModelContext>();
            selectAuthor.DataSource = context.Authors.Local.ToBindingList();
            selectPublisher.DataSource = context.Publishers.Local.ToBindingList();
            selectCategory.DataSource = context.Categories.Local.ToBindingList();
            selectSeries.DataSource = context.Series.Local.ToBindingList();

            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, model => model.SelectedBook.Id, view => view.txtID.Text)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedBook.Title, view => view.txtTitle.Text)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedBook.Year, view => view.txtYear.Text,
                    model => model.ToString(), int.Parse).DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedBook.Author, view => view.selectAuthor.SelectedItem)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedBook.Category, view => view.selectCategory.SelectedItem)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedBook.Series, view => view.selectSeries.SelectedItem)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedBook.Publisher, view => view.selectPublisher.SelectedItem)
                    .DisposeWith(disposable);

                this.OneWayBind(ViewModel, model => model.Books, view => view.table.DataSource,
                        model => model.ToBindingList())
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ClearSelectionCommand, view => view.btnClear);

                table.Events().SelectionChanged
                    .Select(arg => table.SelectedRows.Count)
                    .Subscribe(rowsCount =>
                    {
                        if (rowsCount == 0 || rowsCount > 1) return;
                        var row = table.SelectedRows[0];
                        if (row == null) return;
                        var id = row.Cells["ID"].Value.ToString() ?? "0";
                        ViewModel.OnRowSelected(int.Parse(id));
                    });
            });
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