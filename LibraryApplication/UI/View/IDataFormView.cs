using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.Model;
using LibraryApplication.UI.Component.Table;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View
{
    public interface IDataFormView : IActivatableView
    {
        public MaterialButton BtnSave { get; }
        public MaterialButton BtnDelete { get; }
        public MaterialButton BtnClear { get; }
        public SearchableDataGridViewControl Table { get; }
    }

    public interface IDataFormView<TE, TVm> : IDataFormView, IViewFor<TVm>
        where TE : class, IIdentified, new() where TVm : DataFormViewModel<TE>
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TVm) value;
        }

        public void InitializeViewModelBindings()
        {
            Setup();
            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(view => view.ViewModel.Items)
                    .Where(items => items != null)
                    .DistinctUntilChanged()
                    .Select(items => items.ToBindingList())
                    .BindTo(this, view => view.Table.Grid.DataSource)
                    .DisposeWith(disposable);

                this.WhenAnyValue(view => view.ViewModel.SelectedItem.Id)
                    .DistinctUntilChanged()
                    .Subscribe(item =>
                    {
                        var grid = Table.Grid;
                        if (item == null)
                        {
                            grid.ClearSelection();
                            return;
                        }

                        var rowIndex = grid.Rows
                            .Cast<DataGridViewRow>()
                            .First(r => r.Cells[0].Value.Equals(item))
                            .Index;
                        grid.Rows[rowIndex].Selected = true;
                    })
                    .DisposeWith(disposable);

                this.BindCommand(ViewModel, model => model.ClearCommand, view => view.BtnClear)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, model => model.SaveCommand, view => view.BtnSave)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, model => model.DeleteCommand, view => view.BtnDelete)
                    .DisposeWith(disposable);

                Table.Grid.Events().SelectionChanged
                    .Select(_ =>
                    {
                        var selectedRows = Table.Grid.SelectedRows;
                        var rowsCount = selectedRows.Count;
                        if (rowsCount is 0 or > 1) return 0;
                        var row = selectedRows[0];
                        return row == null ? 0 : int.Parse(row.Cells[0]?.Value?.ToString() ?? "0");
                    })
                    .Where(id => id != 0)
                    .DistinctUntilChanged()
                    .InvokeCommand(ViewModel, m => m.SelectCommand)
                    .DisposeWith(disposable);
            });
        }

        public void Setup()
        {
        }
    }
}