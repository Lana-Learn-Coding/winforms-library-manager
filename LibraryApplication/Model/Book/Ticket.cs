using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Book
{
    public class Ticket : ReactiveObject, IAuditable, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Reactive] public DateTime CreatedAt { get; set; }

        [Reactive] public DateTime UpdatedAt { get; set; }

        [Reactive] public string Note { get; set; }

        [Reactive]
        [Column(TypeName = "Date"), Required]
        public DateTime BorrowedDate { get; set; } = DateTime.Now;

        [Reactive]
        [Column(TypeName = "Date"), Required]
        public DateTime? DueDate { get; set; }

        [Reactive] [Column(TypeName = "Date")] public DateTime? ReturnedDate { get; set; }

        [InverseProperty("Tickets")] public virtual ICollection<BookItem> BookItems { get; set; }

        public virtual Reader Reader { get; set; }

        public virtual Ticket Parent { get; set; }
    }
}