using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using VTMS.DataSource;
using VTMS.Models;

namespace VTMS.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            if (Session["PERSONAL_NO"] != null)
            {
                CourseModel model = new CourseModel();
                CourseDS source = new CourseDS();
                DataSet ds = new DataSet();
                List<CourseModel> dataList = new List<CourseModel>();

                ds = source.GetListOfCourses();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    CourseModel i = new CourseModel();

                    i.CourseId = dr["COURSE_ID"].ToString();
                    i.CourseName = dr["COURSE_CODE"].ToString();
                    i.CourseDesc = dr["COURSE_DESC"].ToString();
                    dataList.Add(i);
                }

                model.ListCourse = dataList;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "" });
            }

        }
    }
    
}