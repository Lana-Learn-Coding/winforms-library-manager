using System.ComponentModel;
using System.Data.Entity;
using System.Reactive.Disposables;
using System.Windows.Forms;
using LibraryApplication.Model;
using LibraryApplication.Model.Book;
using MaterialSkin.Controls;
using ReactiveUI;
using ReactiveUI.Validation.Extensions;
using Splat;

namespace LibraryApplication.UI.View.Book
{
    public partial class BookManageView : DataFormViewUserControl<BookMeta>
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
            });
            ViewModel = new BookManageViewModel();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public sealed override DataFormViewModel<BookMeta> ViewModel { get; set; }

        protected override MaterialButton BtnSave => btnSave;
        protected override MaterialButton BtnDelete => btnDelete;
        protected override MaterialButton BtnClear => btnClear;
        protected override DataGridView Table => table;
    }
}