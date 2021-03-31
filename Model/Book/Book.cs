using System.ComponentModel.DataAnnotations;
using WinFormsLibraryManager.Model.Meta;

namespace WinFormsLibraryManager.Model.Book
{
    public class Book
    {
        [Required] public string Title { get; set; }

        [Required] public int Year { get; set; }

        public Author Author { get; set; }

        public Publisher Publisher { get; set; }

        public Category Category { get; set; }

        public string Image { get; set; }
    }

    public class BookItem : Model
    {
        private string Note { get; set; }

        private string Position { get; set; }

        private Storage Storage { get; set; }
    }
}