using System.Web.Mvc;

namespace SecurityMVC.Controllers
{
    [Authorize(Roles = "Administrador ")]
    public class AdministrationController : Controller
    {
        public ActionResult RolesAdministration()
        {
            return View();
        }

        public ActionResult UserAdministration()
        {
            return View();
        }

        public ActionResult SystemAdministration()
        {
            return View();
        }
    }
}