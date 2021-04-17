using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryApplication.Model.Meta;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Book
{
    public class Reader : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int? Id { get; set; }

        public override DateTime CreatedAt { get; set; }

        [Reactive] public override DateTime UpdatedAt { get; set; }

        [Reactive] [Required] public string Email { get; set; }

        [Reactive] [Required] public string PhoneNumber { get; set; }

        [Reactive] [Required] public string Name { get; set; }

        [Reactive] public string Address { get; set; }

        [Reactive] public string Avatar { get; set; }

        [Reactive] public Gender Gender { get; set; }

        [Reactive] [Required] public int? Limit { get; set; } = 10;

        [Reactive] [Column(TypeName = "Date")] public DateTime? Birth { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return $"{Name} [{Id}]";
        }
    }
}