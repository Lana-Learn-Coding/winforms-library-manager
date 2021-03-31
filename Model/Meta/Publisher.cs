using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibraryManager.Model.Meta
{
    public class Publisher : Model, INamed
    {
        [Required, Index(IsUnique = true)] public string Name { get; set; }
    }
}