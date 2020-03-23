using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurityMVC.Models
{
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        public string NomRol { get; set; }
    }
}