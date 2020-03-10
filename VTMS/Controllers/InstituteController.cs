using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using VTMS.DataSource;
using VTMS.Models;

namespace VTMS.Controllers
{
    public class InstituteController : Controller
    {
        // GET: University
        public ActionResult Index()
        {
            if (Session["PERSONAL_NO"] != null)
            {
                InstituteModel model = new InstituteModel();
                InstituteDS source = new InstituteDS();
                DataSet ds = new DataSet();
                List<InstituteModel> dataList = new List<InstituteModel>();

                ds = source.GetListOfInstitutes();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    InstituteModel i = new InstituteModel();

                    i.InstituteCode = dr["InstituteCode"].ToString();
                    i.InstituteName = dr["InstituteName"].ToString();
                    i.InstituteType = dr["InstituteType"].ToString();
                    i.UniversityName = dr["UniversityName"].ToString();
                    i.InstituteState = dr["InstituteState"].ToString();
                    i.InstituteDistrict = dr["InstituteDistrict"].ToString();
                    dataList.Add(i);
                }



                model.ListInstitute = dataList;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "" });
            }

        }
    }
}