using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Windows.Forms;
using LibraryApplication.Model;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Contexts;
using Splat;

namespace LibraryApplication.UI.View
{
    public class DataFormViewModel<T> : ReactiveObject, IValidatableViewModel, IActivatableViewModel
        where T : IIdentified, new()
    {
        protected readonly ModelContext Context;
        public ValidationContext ValidationContext { get; } = new();

        [Reactive] public T SelectedItem { get; set; }
        [Reactive] public ObservableCollection<T> Items { get; set; }

        [Reactive] public bool IsDeletable { get; set; }

        [Reactive] public bool IsUpdating { get; set; }

        public ReactiveCommand<DataGridView, Unit> SelectCommand { get; }

        public ReactiveCommand<Unit, Unit> ClearCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveCommand { get; }
        public ReactiveCommand<Unit, Unit> DeleteCommand { get; }

        protected DataFormViewModel()
        {
            Context = Locator.Current.GetService<ModelContext>();
            ClearCommand = ReactiveCommand.Create(ClearSelection);
            DeleteCommand = ReactiveCommand.Create(DeleteSelection);
            SaveCommand = ReactiveCommand.Create(Save, ValidationContext.Valid);
            SelectCommand = ReactiveCommand.Create<DataGridView>(OnRowSelected);

            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(model => model.SelectedItem)
                    .Subscribe(item => IsDeletable = item?.Id != null)
                    .DisposeWith(disposable);

                this.WhenAnyValue(model => model.SelectedItem)
                    .Subscribe(item => IsUpdating = item?.Id != null)
                    .DisposeWith(disposable);
            });
        }

        private void OnRowSelected(DataGridView table)
        {
            var selectedRows = table.SelectedRows;
            var rowsCount = selectedRows.Count;
            if (rowsCount is 0 or > 1) return;
            var row = selectedRows[0];
            if (row == null) return;
            var id = int.Parse(row.Cells[0]?.Value?.ToString() ?? "0");
            if (id <= 0)
            {
                ClearSelection();
                return;
            }

            SelectedItem = Items.First(book => book.Id == id);
        }

        private void ClearSelection()
        {
            SelectedItem = new T();
        }

        private void DeleteSelection()
        {
            if (!ValidateBeforeDelete())
            {
                return;
            }

            var result = MessageBox.Show($"Are you sure delete ${SelectedItem.Id}?", "Warning",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            Items.Remove(SelectedItem);
            Context.SaveChanges();
            ClearSelection();
        }

        private void Save()
        {
            if (!ValidateBeforeSave())
            {
                return;
            }

            if (SelectedItem.Id == null)
            {
                Items.Add(SelectedItem);
            }
            else
            {
                Context.Entry(SelectedItem).CurrentValues.SetValues(SelectedItem);
            }

            var item = SelectedItem;
            Context.SaveChanges();
            ClearSelection();
            SelectedItem = item;
        }

        protected virtual bool ValidateBeforeSave()
        {
            return true;
        }

        protected virtual bool ValidateBeforeDelete()
        {
            return true;
        }

        public ViewModelActivator Activator { get; } = new();
    }
}