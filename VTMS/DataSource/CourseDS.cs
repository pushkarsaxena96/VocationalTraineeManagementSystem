using System;
using System.Data;
using VTMS.Models;

namespace VTMS.DataSource
{
    public class CourseDS
    {
        DataContext dc = new DataContext();

        public DataSet GetListOfCourses()
        {
            CourseModel model = new CourseModel();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string str = "";

            try
            {
                str = "SELECT A.COURSE_ID , A.COURSE_CODE, A.COURSE_DESC FROM VTMS_COURSE_MSTS A"; //Select command for quering the list of institutes

                //Production
                dt = dc.getQueryViaDataTable(str);

                //Testing
                //dt.Clear();
                //dt.Columns.Add("CourseCode");
                //dt.Columns.Add("CourseName");
                //dt.Columns.Add("CourseDescription");


                //object[] a = { "1", "Ph.D.", "Doctor of Philosophy"};
                //dt.Rows.Add(a);
                //object[] a1 = { "1", "D.Sc.", "Doctor of Science" };
                //dt.Rows.Add(a1);
                //object[] a2 = { "1", "Vidya Varidhi", "Vidya Varidhi" };
                //dt.Rows.Add(a2);
                //object[] a3 = { "1", "L.L.D.", "Doctor of Laws" };
                //dt.Rows.Add(a3);
                //object[] a4 = { "1", "Vidya Vachaspati", "Vidya Vachaspati" };
                //dt.Rows.Add(a4);
                //object[] a5 = { "1", "M.A.", "Master of Arts" };
                //dt.Rows.Add(a5);
                //object[] a6 = { "1", "M.B.A.", "Master of Business Administration" };
                //dt.Rows.Add(a6);
                //object[] a7 = { "1", "M.Sc.", "Master of Science" };
                //dt.Rows.Add(a7);
                //object[] a8 = { "1", "M.C.A.", "Master of Computer Applications" };
                //dt.Rows.Add(a8);
                //object[] a9 = { "1", "M.Com.", "Master of Commerce" };
                //dt.Rows.Add(a9);
                ds.Tables.Add(dt);
            }
            catch (Exception Ex)
            {

            }
            return ds;
        }
    }
}