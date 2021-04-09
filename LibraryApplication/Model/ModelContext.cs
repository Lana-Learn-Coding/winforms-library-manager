using WinFormsLibraryManager.Database;
using WinFormsLibraryManager.Model.Book;
using WinFormsLibraryManager.Model.Meta;

namespace WinFormsLibraryManager.Model
{
    public class ModelContext : DbContext
    {
        public DbSet<BookMeta> Books { get; set; }
        public DbSet<BookItem> BookItems { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Reader> Readers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Storage> Storages { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }

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
                if (entity.Entity is IAuditable created)
                {
                    created.CreatedAt = DateTime.Now;
                }
            }

            foreach (var entity in ChangeTracker.Entries().Where(p => p.State == EntityState.Modified))
            {
                if (entity.Entity is IAuditable updated)
                {
                    updated.UpdatedAt = DateTime.Now;
                }
            }
        }
    }
}