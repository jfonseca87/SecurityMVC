using System.Web.Mvc;

namespace SecurityMVC.Controllers
{
    [Authorize]
    public class InvoicingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateInvoice()
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        public ActionResult DeleteInvoice()
        {
            return View();
        }
    }
}