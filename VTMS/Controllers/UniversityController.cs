using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using VTMS.DataSource;
using VTMS.Models;

namespace VTMS.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index()
        {
            if (Session["PERSONAL_NO"] != null)
            {
                UniversityModel model = new UniversityModel();
                UniversityDS source = new UniversityDS();
                DataSet ds = new DataSet();
                List<UniversityModel> dataList = new List<UniversityModel>();

                ds = source.GetListOfUniversities();
                
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    UniversityModel u = new UniversityModel
                    {
                        UniversityCode = dr["UNIVERSITY_ID"].ToString(),
                        UniversityName = dr["UNIVERSITY_NAME"].ToString(),
                        UniversityArea = dr["CITY"].ToString()
                    };
                    dataList.Add(u);
                }

                

                model.ListUniversity = dataList;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "" });
            }

        }
    }
}