using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibraryManager.Model.Meta
{
    public class Author : IAuditable, INamed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [Required, Index(IsUnique = true), Column(TypeName = "VARCHAR"), MaxLength(256)]
        public string Name { get; set; }
    }
}