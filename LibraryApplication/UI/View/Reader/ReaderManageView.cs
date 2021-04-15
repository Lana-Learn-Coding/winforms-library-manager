using System;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ReactiveUI;
using ReactiveUI.Validation.Extensions;

namespace LibraryApplication.UI.View.Reader
{
    public partial class ReaderManageView : UserControl, IDataFormView<Model.Book.Reader, ReaderManageViewModel>
    {
        public ReaderManageView()
        {
            InitializeComponent();
            selectGender.InitializeDataSource();
            ((IDataFormView<Model.Book.Reader, ReaderManageViewModel>) this).InitializeViewModelBindings();
            this.WhenActivated(disposable =>
            {
                this.OneWayBind(ViewModel, model => model.SelectedItem.Id, view => view.txtID.Value)
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ToggleBorrowBookCommand, view => view.btnBorrow)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Avatar, view => view.imgPicker.Value)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Name, view => view.txtName.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Name, view => view.txtName.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Birth, view => view.dateBirthdate.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Birth, view => view.dateBirthdate.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Gender, view => view.selectGender.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Gender, view => view.selectGender.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Email, view => view.txtEmail.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Email, view => view.txtEmail.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.PhoneNumber, view => view.txtPhone.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.PhoneNumber, view => view.txtPhone.Error)
                    .DisposeWith(disposable);

                this.Bind(ViewModel, model => model.SelectedItem.Limit, view => view.txtLimit.Value)
                    .DisposeWith(disposable);
                this.BindValidation(ViewModel, model => model.SelectedItem.Limit, view => view.txtLimit.Error)
                    .DisposeWith(disposable);

                this.WhenAnyValue(v => v.ViewModel.ShowBorrowBookDialog)
                    .Subscribe(show =>
                    {
                        //TODO: implement actual borrow dialog
                        if (!show) return;
                        var form = new Form();
                        form.ShowDialog(this);
                        ViewModel.ShowBorrowBookDialog = false;
                    })
                    .DisposeWith(disposable);
            });
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ReaderManageViewModel ViewModel { get; set; } = new();

        public MaterialButton BtnSave => btnSave;
        public MaterialButton BtnDelete => btnDelete;
        public MaterialButton BtnClear => btnClear;
        public DataGridView Table => table;
    }
}