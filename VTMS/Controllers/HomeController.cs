using System.Web.Mvc;

namespace VTMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["PERSONAL_NO"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "" });
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}