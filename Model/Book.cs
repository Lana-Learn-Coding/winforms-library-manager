using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinformsLibraryManager.Model
{
    public class BookItem : Model
    {
        private string Note { get; set; }

        private string Position { get; set; }

        private string Storage { get; set; }
    }

    public class Book
    {
        [Required] public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Image { get; set; }

        [Required] public int Year { get; set; }

        public Category Category { get; set; }
    }

    public class Category : Model, INamed
    {
        [Required, Index(IsUnique = true)] public string Name { get; set; }
    }

    public class Reader : Model
    {
        [Required] public string email { get; set; }

        public string phoneNumber { get; set; }

        [Required] public string name { get; set; }

        public string address { get; set; }

        public string avatar { get; set; }

        [Required] public string gender { get; set; } = "male";

        [Required] public int limit { get; set; } = 0;

        [Column(TypeName = "Date")] public DateTime birth { get; set; }
    }
}