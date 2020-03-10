using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using VTMS.DataSource;
using VTMS.Models;


namespace VTMS.Controllers
{
    public class ListOfVTController : Controller
    {
        // GET: ListOfVT
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["PERSONAL_NO"] != null)
            {
                VTDetails model = new VTDetails();
                VTListDS source = new VTListDS();
                DataSet ds = new DataSet();
                List<VTDetails> dataListActive = new List<VTDetails>();
                List<VTDetails> dataListEnrolled = new List<VTDetails>();

                ds = source.GetActiveEnrolledVTList();
                 if (ds.Tables.Count > 0)
                 {
                     int max = 0;
                     if (ds.Tables[0].Rows.Count > ds.Tables[1].Rows.Count)
                     {
                         max = ds.Tables[0].Rows.Count;
                     }
                     else if ( ds.Tables[1].Rows.Count > ds.Tables[0].Rows.Count)
                     {
                         max = ds.Tables[1].Rows.Count;
                     }
                     else if (ds.Tables[1].Rows.Count == ds.Tables[0].Rows.Count)
                     {
                         max = ds.Tables[1].Rows.Count;
                     }
                 }

                 foreach (DataRow dr in ds.Tables[0].Rows)
                 {
                     VTDetails vt1 = new VTDetails();

                     vt1.VTCode = dr["VTCode"].ToString();
                     vt1.VTName = dr["VTName"].ToString();
                     vt1.InstituteName = dr["InstituteName"].ToString();
                     vt1.CourseName = dr["CourseName"].ToString();
                     vt1.BranchName = dr["BranchName"].ToString();
                     vt1.VTStartDate = dr["VTStartDate"].ToString();
                     vt1.VTEndDate = dr["VTEndDate"].ToString();
                     dataListActive.Add(vt1);
                 }

                 foreach (DataRow dr in ds.Tables[1].Rows)
                 {
                     VTDetails vt1 = new VTDetails();

                    vt1.VTCode = dr["VTCode"].ToString();
                    vt1.VTName = dr["VTName"].ToString();
                    vt1.InstituteName = dr["InstituteName"].ToString();
                    vt1.CourseName = dr["CourseName"].ToString();
                    vt1.BranchName = dr["BranchName"].ToString();
                    vt1.VTStartDate = dr["VTStartDate"].ToString();
                    vt1.VTEndDate = dr["VTEndDate"].ToString();
                    dataListEnrolled.Add(vt1);
                 }


                            


                model.ListActive = dataListActive;
                model.ListEnrolled = dataListEnrolled;
                 

                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "" });
            }
        }


        public ActionResult EnrollNewVT()
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

        public ActionResult GenerateVTPdf()
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

        public JsonResult GetVTTables()
        {
            VTListDS m = new VTListDS();
            DataSet ds = m.GetActiveEnrolledVTList();
            var data = JsonConvert.SerializeObject(ds);
            return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult DocumentGen()
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


        [HttpPost]
        public ActionResult GetVTListForDoc(FormCollection fc)
        {
            VTDetails model = new VTDetails();
            VTListDS source = new VTListDS();
            DataSet ds = new DataSet();
            List<VTDetails> dataList = new List<VTDetails>();

            ds = source.GetEnrolledVTList();

            //dataList = (from  dr in ds.Tables[0].AsEnumerable()
            //           where dr.Field<string>("VTCode") == fc["VTCode"]
            //           select dr);

            model.ListEnrolled = dataList;
            return View(model);

        }
    }
}