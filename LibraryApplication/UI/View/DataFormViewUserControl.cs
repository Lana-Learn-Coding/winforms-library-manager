using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows.Forms;
using LibraryApplication.Model;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View
{
    public abstract class DataFormViewUserControl<T> : UserControl, IViewFor<DataFormViewModel<T>>
        where T : IIdentified, new()
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (DataFormViewModel<T>) value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public abstract DataFormViewModel<T> ViewModel { get; set; }

        protected abstract MaterialButton BtnSave { get; }
        protected abstract MaterialButton BtnDelete { get; }
        protected abstract MaterialButton BtnClear { get; }
        protected abstract DataGridView Table { get; }

        protected DataFormViewUserControl()
        {
            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(view => view.ViewModel.Items)
                    .BindTo(this, view => view.Table.DataSource)
                    .DisposeWith(disposable);
                this.WhenAnyValue(view => view.ViewModel.SelectedItem)
                    .Subscribe(id =>
                    {
                        if (id?.Id == null)
                        {
                            BtnDelete.Enabled = false;
                            Table.ClearSelection();
                            return;
                        }

                        var rowIndex = Table.Rows
                            .Cast<DataGridViewRow>()
                            .First(r => r.Cells[0].Value.Equals(id.Id))
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