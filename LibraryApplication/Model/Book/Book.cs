using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryApplication.Model.Meta;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Book
{
    public class BookMeta : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int? Id { get; set; }

        public override DateTime CreatedAt { get; set; }

        [Reactive] public override DateTime UpdatedAt { get; set; }

        [Reactive] [Required] public string Title { get; set; }

        [Reactive] [Required] public int? Year { get; set; }

        [Reactive] public Author Author { get; set; }

        [Reactive] public Publisher Publisher { get; set; }

        [Reactive] public Category Category { get; set; }

        [Reactive] public Series Series { get; set; }

        [Reactive] public string Image { get; set; }

        public virtual ICollection<BookItem> Items { get; set; } = new List<BookItem>();

        public override string ToString()
        {
            return $"{Title} - {Author} [{Id}]";
        }
    }

    public class BookItem : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int? Id { get; set; }

        public override DateTime CreatedAt { get; set; }

        [Reactive] public override DateTime UpdatedAt { get; set; }

        [Reactive] public string Condition { get; set; }

        [Reactive] public Position Position { get; set; }

        [Required] public Storage Storage { get; set; }

        [Required] public BookMeta BookMeta { get; set; }

        [Reactive] public string Image { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        [Reactive] public virtual Ticket BorrowingTicket { get; set; }

        [NotMapped] public bool IsBorrowed => BorrowingTicket != null;

        public override string ToString()
        {
            return $"Book [{Id}] - {BookMeta.Title}";
        }
    }
}