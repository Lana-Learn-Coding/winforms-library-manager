using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.Model.Book
{
    public class BookMeta : IAuditable, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [Required] public string Title { get; set; }

        [Required] public int? Year { get; set; }

        public Author Author { get; set; }

        public Publisher Publisher { get; set; }

        public Category Category { get; set; }

        public Series Series { get; set; }

        public string Image { get; set; }

        public virtual ICollection<BookItem> Items { get; set; } = new List<BookItem>();
    }

    public class BookItem : IAuditable, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Note { get; set; }

        public string Position { get; set; }

        [Required] public Storage Storage { get; set; }

        [Required] public BookMeta BookMeta { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual Ticket BorrowingTicket { get; set; }
    }
}