using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using VTMS.DataSource;
using VTMS.Models;

namespace VTMS.Controllers
{
    public class BranchController : Controller
    {
        // GET: Branch
        public ActionResult Index()
        {
            if (Session["PERSONAL_NO"] != null)
            {
                BranchModel model = new BranchModel();
                BranchDS source = new BranchDS();
                DataSet ds = new DataSet();
                List<BranchModel> dataList = new List<BranchModel>();

                ds = source.GetListOfBranches();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    BranchModel b = new BranchModel();

                    b.BranchCode = dr["BRANCH_ID"].ToString();
                    b.BranchName = dr["BRANCH_DESC"].ToString();
                    b.BranchShortDesc = dr["BRANCH_CODE"].ToString();
                    b.CourseName = dr["COURSE_DESC"].ToString();
                    dataList.Add(b);
                }



                model.ListBranch = dataList;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "" });
            }

        }

        // PUT : Branch
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertBranch(FormCollection fc)
        {
            int result;
            BranchModel branch = new BranchModel();
            BranchDS source = new BranchDS();

            branch.BranchCode = fc["BranchCode"].ToString();
            branch.BranchShortDesc = fc["BranchCode"].ToString();
            branch.BranchName = fc["BranchName"].ToString();
            //branch.co
            branch.Created_By = Session["PERSONAL_NO"].ToString();

            result = source.AddBranch(branch);

            if (result==0)
            {
                ViewBag.Message = "Error in saving record. Try again!";
            }
            else
            {
                ViewBag.Message = "Record Entered Successfully!";
            }

            return RedirectToAction("Index", "Branch", new { area = "" });

        }
    }
}