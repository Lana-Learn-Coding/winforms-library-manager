using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibraryManager.Model.Book
{
    public class Reader : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        
        [Required] public string email { get; set; }

        public string phoneNumber { get; set; }

        [Required] public string name { get; set; }

        public string address { get; set; }

        public string avatar { get; set; }

        [Required] public string gender { get; set; } = "male";

        [Required] public int limit { get; set; } = 0;

        [Column(TypeName = "Date")] public DateTime birth { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}