using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using SecurityMVC.Models;
using SecurityMVC.Models.DTO;

namespace SecurityMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario user)
        {
            UsuarioDTO userDB = null;

            using (SecurityContext db = new SecurityContext())
            {
                userDB = (from u in db.Usuario
                          join r in db.Rol
                          on u.IdRol equals r.IdRol
                          where u.NickName.Equals(user.NickName, StringComparison.OrdinalIgnoreCase) &&
                                u.Password.Equals(user.Password, StringComparison.Ordinal)
                          select new UsuarioDTO
                          {
                              IdUsuario = u.IdUsuario,
                              NomUsuario = u.NomUsuario,
                              IdRol = r.IdRol,
                              NomRol = r.NomRol
                          }).FirstOrDefault();
            }

            if (userDB != null)
            {
                var identity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim("IdUsuario", userDB.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Name, userDB.NomUsuario),
                    new Claim(ClaimTypes.Role, userDB.NomRol)
                },
                "SecurityAppCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return RedirectToAction("PrincipalPage");
            }

            ViewBag.Error = "User does not exist";
            return View("Index");
        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("SecurityAppCookie");

            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult PrincipalPage()
        {
            var asd = HttpContext.User;
            return View();
        }

    }
}