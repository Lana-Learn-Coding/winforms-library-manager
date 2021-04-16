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

        [Reactive] public bool IsUpdating { get; set; }
        public ReactiveCommand<DataGridView, Unit> SelectCommand { get; }

        public ReactiveCommand<Unit, Unit> ClearCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveCommand { get; }
        public ReactiveCommand<Unit, Unit> DeleteCommand { get; }

        public ReactiveCommand<Unit, Unit> RefreshSelectionCommand { get; }

        protected DataFormViewModel()
        {
            SelectedItem = new T();
            Context = Locator.Current.GetService<ModelContext>();

            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(model => model.SelectedItem)
                    .Subscribe(item => IsUpdating = item?.Id != null)
                    .DisposeWith(disposable);
            });

            SaveCommand = ReactiveCommand.Create(Save, ValidationContext.Valid);
            SelectCommand = ReactiveCommand.Create<DataGridView>(OnRowSelected);
            ClearCommand = ReactiveCommand.Create(ClearSelection);

            var isSelected = this.WhenAnyValue(model => model.IsUpdating);
            DeleteCommand = ReactiveCommand.Create(DeleteSelection, isSelected);
            RefreshSelectionCommand = ReactiveCommand.Create(RefreshSelection, isSelected);
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

        protected void ClearSelection()
        {
            SelectedItem = new T();
        }

        protected void RefreshSelection()
        {
            var item = SelectedItem;
            SelectedItem = new T();
            SelectedItem = item;
        }

        protected void DeleteSelection()
        {
            try
            {
                OnDeleting();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return;
            }

            var result = MessageBox.Show($"Are you sure delete {SelectedItem.Id}?", "Warning",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            DeleteItem(SelectedItem);
            ClearSelection();
        }

        protected void Save()
        {
            try
            {
                OnSaving();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return;
            }

            if (SelectedItem?.Id == null)
            {
                CreateNewItem(SelectedItem);
                RefreshSelection();
                return;
            }

            Context.Entry(SelectedItem).CurrentValues.SetValues(SelectedItem);
            Context.SaveChanges();
        }

        protected virtual void CreateNewItem(T item)
        {
            Items.Add(item);
            Context.SaveChanges();
        }

        protected virtual void DeleteItem(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }

        protected virtual void OnSaving()
        {
        }

        protected virtual void OnDeleting()
        {
        }

        public ViewModelActivator Activator { get; } = new();
    }
}