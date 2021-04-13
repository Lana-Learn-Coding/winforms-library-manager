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
    public partial class BookManageView : UserControl, IDataFormViewUserControl<BookMeta, BookManageViewModel>
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookManageViewModel ViewModel { get; set; }

        public BookManageView()
        {
            InitializeComponent();
            ((IDataFormViewUserControl<BookMeta, BookManageViewModel>) this).InitializeViewModelBindings();
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
        }

        public MaterialButton BtnSave => btnSave;
        public MaterialButton BtnDelete => btnDelete;
        public MaterialButton BtnClear => btnClear;
        public DataGridView Table => table;
    }
}