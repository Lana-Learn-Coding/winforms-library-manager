using System.Collections.Generic;
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

        public virtual ICollection<BookItem> Items { get; set; }
    }

    public class BookItem : Model
    {
        public string Note { get; set; }

        public string Position { get; set; }

        [Required] public Storage Storage { get; set; }

        [Required] public Book book { get; set; }

        public Ticket BorrowingTicket { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}