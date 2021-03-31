using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsLibraryManager.Model;
using WinFormsLibraryManager.Model.Meta;

namespace WinFormsLibraryManager.Database
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<ModelContext>
    {
        protected override void Seed(ModelContext context)
        {
            base.Seed(context);
            SeedUsers(context);
            SaveCommonMeta(context);
            context.SaveChanges();
        }

        private static void SeedUsers(ModelContext context)
        {
            context.Users.Add(new User {Username = "Admin", Password = "raw", Name = "The Fucking Admin"});
        }

        private static void SaveCommonMeta(ModelContext context)
        {
            var authors = new List<Author>
            {
                new Author {Name = "Toan Nguyen"},
                new Author {Name = "Ke Huy Diet"},
                new Author {Name = "Super Author"},
            };
            context.Authors.AddRange(authors);


            var publishers = new List<Publisher>
            {
                new Publisher {Name = "Publisher Toan Nguyen"},
                new Publisher {Name = "Kim Dong"},
                new Publisher {Name = "Super Pulisher"},
            };
            context.Publishers.AddRange(publishers);

            var categories = new List<Category>
            {
                new Category {Name = "Fantasy"},
                new Category {Name = "Scifi"},
                new Category {Name = "Romance"},
                new Category {Name = "Horror"},
                new Category {Name = "Commic"},
                new Category {Name = "History"},
            };
            context.Categories.AddRange(categories);

            var series = new List<Series>
            {
                new Series {Name = "Doraemon"},
                new Series {Name = "Harry Potter"},
                new Series {Name = "Canh sat hinh su"},
            };
            context.Series.AddRange(series);

            var storages = new List<Storage>
            {
                new Storage {Name = "On shelf"},
                new Storage {Name = "In Storage"},
            };
            context.Storages.AddRange(storages);
        }
    }
}