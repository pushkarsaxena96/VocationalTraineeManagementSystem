using System;
using System.Data;
using System.Web.Mvc;
using VTMS.Models;

namespace VTMS.DataSource
{
    public class BranchDS
    {
        DataContext dc = new DataContext();

        public DataSet GetListOfBranches()
        {
            BranchModel model = new BranchModel();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string str = "";

            try
            {
                str = "SELECT A.BRANCH_ID, A.BRANCH_CODE, A.BRANCH_DESC, B.COURSE_DESC   FROM VTMS_BRANCH_MSTS A, VTMS_COURSE_MSTS B WHERE A.COURSE_ID = B.COURSE_ID"; //Select command for quering the list of institutes

                //Production
                dt = dc.getQueryViaDataTable(str);

                //Testing
                //dt.Clear();
                //dt.Columns.Add("BranchCode");
                //dt.Columns.Add("BranchName");
                //dt.Columns.Add("BranchShortDesc");
                //dt.Columns.Add("CourseName");


                //object[] a = { "53", "Master of Business Administration (MBA)", "M1", "Master of Business Administration" };
                //dt.Rows.Add(a);
                //object[] a1 = { "54", "Master of Business Administration: Business Economics", "M2", "Master of Business Administration" };
                //dt.Rows.Add(a1);
                //object[] a2 = { "55", "Master of Business Administration: Finance & Control", "M3", "Master of Business Administration" };
                //dt.Rows.Add(a2);
                //object[] a3 = { "56", "Master of Business Administration: Tourism Management", "M4", "Master of Business Administration" };
                //dt.Rows.Add(a3);
                //object[] a4 = { "57", "Master of Business Administration_International Business (IB)", "M5", "Master of Business Administration" };
                //dt.Rows.Add(a4);
                //object[] a5 = { "58", "Master of Business Administration_Financial Management (FM)", "M6", "Master of Business Administration" };
                //dt.Rows.Add(a5);
                //object[] a6 = { "59", "Master of Business Administration_Agri. Business", "M17", "Master of Business Administration" };
                //dt.Rows.Add(a6);
                //object[] a7 = { "60", "Master of Business Administration_Marketing", "M20", "Master of Business Administration" };
                //dt.Rows.Add(a7);
                //object[] a8 = { "61", "Master of Business Administration_E-Commerce", "M21", "Master of Business Administration" };
                //dt.Rows.Add(a8);
                //object[] a9 = { "62", "Master of Business Administration_Human Research & Development", "M22", "Master of Business Administration" };
                //dt.Rows.Add(a9);
                ds.Tables.Add(dt);
            }
            catch (Exception Ex)
            {

            }
            return ds;
        }

        [HttpPost]
        public int AddBranch(BranchModel branch )
        {
            DateTime now = DateTime.Now;
            var result = 0;
            try
            {
                string str = "INSERT INTO VTMS_BRANCH_MSTS(BRANCH_ID, BRANCH_CODE, BRANCH_DESC, COURSE_ID, CREATED_BY, CREATION_DATETIME) VALUES('"+ branch.BranchCode+"','"+branch.BranchShortDesc+"','"+branch.BranchName+"','"+branch.Created_By+"','"+now+"'";
                result = Convert.ToInt16(dc.insertToDB(str));

            }
            catch
            {

            }
            return result;
        }
    }
}