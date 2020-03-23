using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurityMVC.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }
    }
}