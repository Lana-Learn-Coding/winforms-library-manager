using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibraryManager.Model.Book
{
    public class Reader : Model
    {
        [Required] public string email { get; set; }

        public string phoneNumber { get; set; }

        [Required] public string name { get; set; }

        public string address { get; set; }

        public string avatar { get; set; }

        [Required] public string gender { get; set; } = "male";

        [Required] public int limit { get; set; } = 0;

        [Column(TypeName = "Date")] public DateTime birth { get; set; }
    }
}