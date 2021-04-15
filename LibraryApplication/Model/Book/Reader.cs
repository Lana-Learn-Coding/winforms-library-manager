using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryApplication.Model.Meta;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Book
{
    public class Reader : ReactiveObject, IAuditable, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [Reactive] public DateTime UpdatedAt { get; set; }

        [Reactive] [Required] public string Email { get; set; }

        [Reactive] public string PhoneNumber { get; set; }

        [Reactive] [Required] public string Name { get; set; }

        [Reactive] public string Address { get; set; }

        [Reactive] public string Avatar { get; set; }

        [Reactive] public Gender Gender { get; set; }

        [Reactive] [Required] public int Limit { get; set; } = 0;

        [Reactive] [Column(TypeName = "Date")] public DateTime Birth { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}