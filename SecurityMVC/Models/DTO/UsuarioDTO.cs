using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityMVC.Models.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public int IdRol { get; set; }
        public string NomRol { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}