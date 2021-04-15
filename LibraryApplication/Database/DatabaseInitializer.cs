using System.Collections.Generic;
using System.Data.Entity;
using LibraryApplication.Model;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.Database
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
                new() {Name = "Toan Nguyen"},
                new() {Name = "Ke Huy Diet"},
                new() {Name = "Super Author"}
            };
            context.Authors.AddRange(authors);


            var publishers = new List<Publisher>
            {
                new() {Name = "Publisher Toan Nguyen"},
                new() {Name = "Kim Dong"},
                new() {Name = "Super Pulisher"}
            };
            context.Publishers.AddRange(publishers);

            var categories = new List<Category>
            {
                new() {Name = "Fantasy"},
                new() {Name = "Scifi"},
                new() {Name = "Romance"},
                new() {Name = "Horror"},
                new() {Name = "Commic"},
                new() {Name = "History"}
            };
            context.Categories.AddRange(categories);

            var series = new List<Series>
            {
                new() {Name = "Doraemon"},
                new() {Name = "Harry Potter"},
                new() {Name = "Canh sat hinh su"}
            };
            context.Series.AddRange(series);

            var storages = new List<Storage>
            {
                new() {Name = "On shelf"},
                new() {Name = "In Storage"}
            };
            context.Storages.AddRange(storages);

            var positions = new List<Position>
            {
                new() {Name = "Shelf A"},
                new() {Name = "Shelf B"},
                new() {Name = "Shelf D"}
            };
            context.Positions.AddRange(positions);

            var genders = new List<Gender>
            {
                new() {Name = "Male"},
                new() {Name = "Female"},
                new() {Name = "Gay"}
            };
            context.Genders.AddRange(genders);
        }
    }
}