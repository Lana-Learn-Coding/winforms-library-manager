using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model
{
    public class User : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Reactive]
        public override int? Id { get; set; }

        public override DateTime CreatedAt { get; set; }

        [Reactive] public override DateTime UpdatedAt { get; set; }

        [Reactive] [Required] public string Name { get; set; }

        [Reactive] [Required] public string Username { get; set; }

        [Reactive] [Required] public string Password { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }

    public class Permission : Entity, INamed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Reactive]
        public override int? Id { get; set; }

        public override DateTime CreatedAt { get; set; }

        [Reactive] public override DateTime UpdatedAt { get; set; }

        [Required, Index(IsUnique = true), Column(TypeName = "VARCHAR"), MaxLength(256)]
        [Reactive]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}