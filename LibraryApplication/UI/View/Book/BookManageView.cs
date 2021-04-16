using System;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows.Forms;
using LibraryApplication.Model.Book;
using LibraryApplication.UI.Component.Table;
using MaterialSkin.Controls;
using ReactiveUI;
using ReactiveUI.Validation.Extensions;

namespace LibraryApplication.UI.View.Book
{
    public partial class BookManageView : UserControl, IDataFormView<BookMeta, BookManageViewModel>
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookManageViewModel ViewModel { get; set; } = new();

        public BookManageView()
        {
            InitializeComponent();
            selectAuthor.InitializeDataSource();
            selectCategory.InitializeDataSource();
            selectPublisher.InitializeDataSource();
            selectSeries.InitializeDataSource();
            ((IDataFormView<BookMeta, BookManageViewModel>) this).InitializeViewModelBindings();
            this.WhenActivated(disposable =>
            {
                this.BindCommand(ViewModel, model => model.ToggleViewBooksDialogCommand, view => view.btnViewBooks)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Id, view => view.txtID.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Image, view => view.imgPicker.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Title, view => view.txtTitle.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Title, view => view.txtTitle.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Year,
                        view => view.txtYear.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Year, view => view.txtYear.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Author,
                        view => view.selectAuthor.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Category,
                        view => view.selectCategory.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Series,
                        view => view.selectSeries.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel,
                        model => model.SelectedItem.Publisher,
                        view => view.selectPublisher.Value)
                    .DisposeWith(disposable);

                this.WhenAnyValue(v => v.ViewModel.ShowViewBooksDialog)
                    .Subscribe(show =>
                    {
                        if (!show || !ViewModel.IsUpdating) return;
                        var form = new BookItemManageDialog(ViewModel.SelectedItem);
                        form.ShowDialog(this);
                        ViewModel.ShowViewBooksDialog = false;
                        ViewModel.RefreshSelectionCommand.Execute();
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
                    Name = "Title",
                    DataPropertyName = "Title",
                    MinimumWidth = 200,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewTextBoxColumn {Name = "Year", DataPropertyName = "Year", Width = 80},
                new DataGridViewTextBoxColumn {Name = "Category", DataPropertyName = "Category"},
                new DataGridViewTextBoxColumn {Name = "Author", DataPropertyName = "Author"},
                new DataGridViewTextBoxColumn {Name = "Publisher", DataPropertyName = "Publisher"},
                new DataGridViewTextBoxColumn {Name = "Series", DataPropertyName = "Series", Width = 150},
                new DataGridViewDateTimeColumn {Name = "Updated", DataPropertyName = "UpdatedAt", Width = 120}
            );
        }

        public MaterialButton BtnSave => btnSave;
        public MaterialButton BtnDelete => btnDelete;
        public MaterialButton BtnClear => btnClear;
        public SearchableDataGridViewControl Table => table;
    }
}