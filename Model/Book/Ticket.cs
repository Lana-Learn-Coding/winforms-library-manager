using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibraryManager.Model.Book
{
    public class Ticket : Model
    {
        public string Note { get; set; }

        [Column(TypeName = "Date"), Required] public DateTime BorrowedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "Date"), Required] public DateTime DueDate { get; set; }

        [Column(TypeName = "Date")] public DateTime ReturnedDate { get; set; }

        public ICollection<BookItem> BookItems { get; set; }

        public Reader Reader { get; set; }

        public Ticket Parent { get; set; }
    }
}