using System.Web.Mvc;
using System.Web.Security;
using VTMS.DataSource;
using VTMS.Models;

namespace VTMS.Controllers
{
    public class LoginController : Controller
    {
        UserLoginDS source = new UserLoginDS(); // for calling check functions


        // GET: Login
        public ActionResult Index()
        {
            if (Session["PERSONAL_NO"] != null)
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                Session.RemoveAll();
                Session.Clear();
                return View();

            }
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();

            return View("SessionExpired");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormCollection fc)
        {
            UserLoginModel model = new UserLoginModel();
            // go ahead and validate username and password
            if (fc["PersonalNo"].ToString() != "" && fc["Password"].ToString() != "")
            {
                model.PERSONAL_NO = fc["PersonalNo"].ToString();
                model.PASSWORD = fc["Password"].ToString();
                var result = false;
                result = source.CheckLogin(model);
                if (result)
                {
                    UserLoginModel employee = new UserLoginModel();
                    employee = source.GetEmployeeDetails(model.PERSONAL_NO);
                    Session["PERSONAL_NO"] = employee.PERSONAL_NO;
                    Session["GRADE_CODE"] = employee.GRADE_CODE;
                    Session["EMP_NAME"] = employee.NAME;
                    Session["DESIGNATION"] = employee.DESIGNATION;
                    Session["UNIT_NAME"] = employee.UNIT_NAME;
                    Session["UNIT_CODE"] = employee.UNIT_CODE;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrMessage = "Incorrect credentials or Insufficient rights. Contact System Administrator";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.ErrMessage = "Personal Number or Password Required.";
                return View("Index");
            }
        }
    }
}