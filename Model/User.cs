using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinformsLibraryManager.Model
{
    public class User : Model
    {
        [Required] public string Name { get; set; }

        [Required] public string Username { get; set; }

        [Required] public string Password { get; set; }
        
        public virtual ICollection<Permission> Permissions { get; set; }
    }

    public class Permission : Model, INamed
    {
        [Index(IsUnique = true), Required] public string Name { get; set; }
    }
}