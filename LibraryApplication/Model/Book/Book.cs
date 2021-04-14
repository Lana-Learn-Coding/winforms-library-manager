using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryApplication.Model.Meta;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Book
{
    public class BookMeta : ReactiveObject, IAuditable, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [Reactive] public DateTime UpdatedAt { get; set; }

        [Reactive] [Required] public string Title { get; set; }

        [Reactive] [Required] public int? Year { get; set; }

        [Reactive] public Author Author { get; set; }

        [Reactive] public Publisher Publisher { get; set; }

        [Reactive] public Category Category { get; set; }

        [Reactive] public Series Series { get; set; }

        [Reactive] public string Image { get; set; }

        public virtual ICollection<BookItem> Items { get; set; } = new List<BookItem>();
    }

    public class BookItem : ReactiveObject, IAuditable, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [Reactive] public DateTime UpdatedAt { get; set; }

        [Reactive] public string Condition { get; set; }

        [Reactive] public Position Position { get; set; }

        [Required] public Storage Storage { get; set; }

        [Required] public BookMeta BookMeta { get; set; }

        [Reactive] public string Image { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual Ticket BorrowingTicket { get; set; }
    }
}