using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Book
{
    public class Ticket : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int? Id { get; set; }

        [Reactive] public override DateTime CreatedAt { get; set; }

        [Reactive] public override DateTime UpdatedAt { get; set; }

        [Reactive] public string Note { get; set; }

        [Reactive]
        [Column(TypeName = "Date"), Required]
        public DateTime BorrowedDate { get; set; }

        [Reactive]
        [Column(TypeName = "Date"), Required]
        public DateTime? DueDate { get; set; } = DateTime.Now.AddDays(10);

        [Reactive] [Column(TypeName = "Date")] public DateTime? ReturnedDate { get; set; }
        [NotMapped] public bool isReturned => ReturnedDate != null;

        [InverseProperty("Tickets")]
        public virtual ICollection<BookItem> BookItems { get; set; } = new ObservableCollection<BookItem>();

        public virtual Reader Reader { get; set; }

        public virtual Ticket Parent { get; set; }

        public override string ToString()
        {
            if (Id == null)
            {
                return "New Ticket";
            }

            return ReturnedDate.HasValue
                ? $"Ticket {Id} from {BorrowedDate:yyyy-MM-dd} to {ReturnedDate:yyyy-MM-dd}"
                : $"Ticket {Id} from {BorrowedDate:yyyy-MM-dd} due at {DueDate:yyyy-MM-dd}";
        }
    }
}