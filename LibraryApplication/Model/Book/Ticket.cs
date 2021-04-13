using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApplication.Model.Book
{
    public class Ticket : IAuditable, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Note { get; set; }

        [Column(TypeName = "Date"), Required] public DateTime BorrowedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "Date"), Required] public DateTime DueDate { get; set; }

        [Column(TypeName = "Date")] public DateTime ReturnedDate { get; set; }

        [InverseProperty("Tickets")] public virtual ICollection<BookItem> BookItems { get; set; }

        public virtual Reader Reader { get; set; }

        public virtual Ticket Parent { get; set; }
    }
}