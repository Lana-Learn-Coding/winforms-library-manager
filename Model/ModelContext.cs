using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinFormsLibraryManager.Database;

namespace WinFormsLibraryManager.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
        }

        public override int SaveChanges()
        {
            SetProperties();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            SetProperties();
            return base.SaveChangesAsync();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            SetProperties();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetProperties()
        {
            foreach (var entity in ChangeTracker.Entries().Where(p => p.State == EntityState.Added))
            {
                if (entity.Entity is Model created)
                {
                    created.CreatedAt = DateTime.Now;
                }
            }

            foreach (var entity in ChangeTracker.Entries().Where(p => p.State == EntityState.Modified))
            {
                if (entity.Entity is Model updated)
                {
                    updated.UpdatedAt = DateTime.Now;
                }
            }
        }
    }
}