using System;
using System.Data;
using VTMS.Models;

namespace VTMS.DataSource
{
    public class VTListDS
    {
        DataContext dc = new DataContext();

        public DataSet GetActiveEnrolledVTList()
        {
            
            VTDetails model = new VTDetails();

            DataSet ds = new DataSet();
            DataTable ActiveDT = new DataTable();
            DataTable EnrolledDT = new DataTable();
            string str = "";

            try
            {
                str = "select only the active VT"; // update the query

                // Production
                //ActiveDT = dc.getQueryViaDataTable(str); 

                // Testing
                ActiveDT.Clear();
                ActiveDT.Columns.Add("VTCode");
                ActiveDT.Columns.Add("VTName");
                ActiveDT.Columns.Add("InstituteName");
                ActiveDT.Columns.Add("BranchName");
                ActiveDT.Columns.Add("CourseName");
                ActiveDT.Columns.Add("VTStartDate");
                ActiveDT.Columns.Add("VTEndDate");
                object[] a = { "01235", "Ramesh", "Vivekananda College", "Computer Science", "Bachlors in Technology", "25-Feb-2019", "25-March-2019" };
                ActiveDT.Rows.Add(a);
                object[] a1 = { "01232", "Rajveer", "Vivekananda Institute", "Electrical", "Bachlors in Technology", "25-Feb-2019", "25-March-2019" };
                ActiveDT.Rows.Add(a1);


                ds.Tables.Add(ActiveDT);

                str = "";
                str = "Selecting the list of just the enolled VT"; //Update the query

                //Production
                //EnrolledDT = dc.getQueryViaDataTable(str);

                // Testing
                EnrolledDT.Clear();
                EnrolledDT.Columns.Add("VTCode");
                EnrolledDT.Columns.Add("VTName");
                EnrolledDT.Columns.Add("InstituteName");
                EnrolledDT.Columns.Add("BranchName");
                EnrolledDT.Columns.Add("CourseName");
                EnrolledDT.Columns.Add("VTStartDate");
                EnrolledDT.Columns.Add("VTEndDate");
                object[] e = { "01235", "Anil", "Delhi College", "Computer Science", "Bachlors in Technology", "25-Feb-2019", "02-March-2019" };
                EnrolledDT.Rows.Add(e);
                object[] e1 = { "01232", "Ankush", "Birla Institute", "Electrical", "Bachlors in Technology", "25-Feb-2019", "02-March-2019" };
                EnrolledDT.Rows.Add(e1);

                ds.Tables.Add(EnrolledDT);

            }
            catch(Exception ex)
            {

            }
            

            return ds;                                                           
        }


        //public List<VTDetails> GetEnrolledVTList(int unitcode)
        //{
        //    List<VTDetails> datalist = new List<VTDetails>();
        //    DataTable dt = new DataTable();
        //    string str = "select VTCode from xys"; // Enter the command string 
        //    dt = dc.getQueryViaDataTable(str);
        //    datalist = (from DataRow row in dt.Rows
        //                select new VTDetails
        //                {
        //                    VTCode = row["VTCode"].ToString(),
        //                    VTName = row["VTName"].ToString(),
        //                    InstituteId = row["InstituteId"].ToString(),
        //                    BranchId = row["BranchId"].ToString(),
        //                    CourseId = row["CourseId"].ToString(),
        //                    VTStartDate = row["VTStartDate"].ToString(),
        //                    VTEndDate = row["VTEndDate"].ToString()
        //                }).ToList();


        //    return datalist;
        //}

        public DataSet GetEnrolledVTList()
        {
            VTDetails model = new VTDetails();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string str = "";

            try
            {
                str = " "; //Select command for quering the list of institutes

                //Production
                //dt = dc.getQueryViaDataTable(str);

                //Testing
                dt.Clear();
                dt.Columns.Add("VTCode");
                dt.Columns.Add("VTName");
                dt.Columns.Add("InstituteName");
                dt.Columns.Add("BranchName");
                dt.Columns.Add("CourseName");
                dt.Columns.Add("VTStartDate");
                dt.Columns.Add("VTEndDate");


                object[] e = { "01235", "Anil", "Delhi College", "Computer Science", "Bachlors in Technology", "25-Feb-2019", "02-March-2019" };
                dt.Rows.Add(e);
                object[] e1 = { "01232", "Ankush", "Birla Institute", "Electrical", "Bachlors in Technology", "25-Feb-2019", "02-March-2019" };
                dt.Rows.Add(e1);
                ds.Tables.Add(dt);
            }
            catch (Exception Ex)
            {

            }
            return ds;
        }
    }
}