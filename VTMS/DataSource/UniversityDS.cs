using System;
using System.Data;
using VTMS.Models;

namespace VTMS.DataSource
{
    public class UniversityDS
    {
        DataContext dc = new DataContext();

        public DataSet GetListOfUniversities()
        {
            UniversityModel model = new UniversityModel();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string str = "";

            try
            {
                str = "SELECT A.UNIVERSITY_ID , A.UNIVERSITY_NAME , A.CITY FROM VTMS_UNIVERSITY_MSTS A"; //Select command for quering the list of universities

                //Production
                dt = dc.getQueryViaDataTable(str);

                //Testing
                //dt.Clear();
                //dt.Columns.Add("UniversityCode");
                //dt.Columns.Add("UniversityName");
                //dt.Columns.Add("UniversityArea");
                //object[] a = { "0001", "A.P. Horticulture University Venkannagudem", "West Godawari" };
                //dt.Rows.Add(a);
                //object[] a1 = { "0003", "Acharya Nagarjuna University", "Guntur" };
                //dt.Rows.Add(a1);
                //object[] a2 = { "0004", "Acharya NG Ranga Agricultural University", "Hyderabad" };
                //dt.Rows.Add(a2);
                //object[] a3 = { "0005", "Adikavi Nannaya University, Rajahmundry", "East Godawari" };
                //dt.Rows.Add(a3);
                //object[] a4 = { "0006", "Andhra University", "Visakhapatnam" };
                //dt.Rows.Add(a4);
                //object[] a5 = { "0009", "Dr.B.R.Ambedkar University", "Etcherla" };
                //dt.Rows.Add(a5);
                //object[] a6 = { "0011", "Gandhi Institute of Technology & Management (GITAM) University", "Visakhapatnam" };
                //dt.Rows.Add(a6);


                ds.Tables.Add(dt);
            }
            catch (Exception Ex)
            {

            }
            return ds;
        }
    }
}