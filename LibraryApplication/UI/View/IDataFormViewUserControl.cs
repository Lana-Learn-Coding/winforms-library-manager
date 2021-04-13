using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.Model;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View
{
    public interface IDataFormViewUserControl<TE, TVm> : IViewFor<TVm>
        where TE : class, IIdentified, new() where TVm : DataFormViewModel<TE>, new()
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TVm) value;
        }

        public MaterialButton BtnSave { get; }
        public MaterialButton BtnDelete { get; }
        public MaterialButton BtnClear { get; }
        public DataGridView Table { get; }

        public void InitializeViewModelBindings()
        {
            ViewModel = new TVm();
            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(view => view.ViewModel.Items)
                    .Select(items => items.ToBindingList())
                    .BindTo(this, view => view.Table.DataSource)
                    .DisposeWith(disposable);
                this.WhenAnyValue(view => view.ViewModel.SelectedItem)
                    .Subscribe(item =>
                    {
                        if (item?.Id == null)
                        {
                            BtnDelete.Enabled = false;
                            Table.ClearSelection();
                            return;
                        }

                        var rowIndex = Table.Rows
                            .Cast<DataGridViewRow>()
                            .First(r => r.Cells[0].Value.Equals(item.Id))
                            .Index;

                        Table.InvalidateRow(rowIndex);
                        Table.Rows[rowIndex].Selected = true;
                    })
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ClearCommand, view => view.BtnClear)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, model => model.SaveCommand, view => view.BtnSave)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, model => model.DeleteCommand, view => view.BtnDelete)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel,
                        model => model.SelectCommand,
                        view => view.Table,
                        this.WhenAnyValue(view => view.Table),
                        "SelectionChanged")
                    .DisposeWith(disposable);
            });
        }
    }
}