using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
        public ReactiveCommand<int, Unit> SelectCommand { get; }

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
            SelectCommand = ReactiveCommand.Create<int>(OnSelected);
            ClearCommand = ReactiveCommand.Create(ClearSelection);

            var isSelected = this.WhenAnyValue(model => model.IsUpdating);
            DeleteCommand = ReactiveCommand.Create(DeleteSelection, isSelected);
            RefreshSelectionCommand = ReactiveCommand.Create(RefreshSelection, isSelected);
        }

        private void OnSelected(int id)
        {
            if (id <= 0)
            {
                ClearSelection();
                return;
            }

            ReloadSelection();
            SelectedItem = Items.First(book => book.Id == id);
        }

        protected void ClearSelection()
        {
            ReloadSelection();
            SelectedItem = new T();
        }

        protected void RefreshSelection()
        {
            ReloadSelection();
            var item = SelectedItem;
            SelectedItem = new T();
            SelectedItem = item;
        }

        private void ReloadSelection()
        {
            var entry = Context.Entry(SelectedItem);
            if (entry.State is EntityState.Modified)
            {
                entry.ReloadAsync();
                return;
            }

            // Return if entity is non managed by context
            if (entry.State is not EntityState.Unchanged)
            {
                return;
            }

            // Check relation change
            var objectStateManager = ((IObjectContextAdapter) Context).ObjectContext.ObjectStateManager;
            var isChanged = objectStateManager.GetObjectStateEntries(EntityState.Deleted).Any(e => e.IsRelationship) ||
                            objectStateManager.GetObjectStateEntries(EntityState.Added).Any(e => e.IsRelationship);
            if (!isChanged) return;
            entry.ReloadAsync();
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
                MessageBox.Show("Data saved successfully", "success");
                return;
            }

            Context.Entry(SelectedItem).CurrentValues.SetValues(SelectedItem);
            Context.SaveChanges();
            MessageBox.Show("Data updated successfully", "success");
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