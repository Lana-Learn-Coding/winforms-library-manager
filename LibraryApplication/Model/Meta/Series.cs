using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Meta
{
    public class Series : ReactiveObject, IAuditable, INamed, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [Reactive] public DateTime UpdatedAt { get; set; }

        [Reactive]
        [Required, Index(IsUnique = true), Column(TypeName = "VARCHAR"), MaxLength(256)]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}