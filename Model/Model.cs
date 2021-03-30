using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinformsLibraryManager.Model
{
    [NotMapped]
    public class Model : IIdentifiable, IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public interface IIdentifiable
    {
        int Id { get; }
    }

    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }
    }

    public interface INamed
    {
        string Name { get; set; }
    }
}