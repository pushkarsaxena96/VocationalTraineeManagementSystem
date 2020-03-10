using System;
using System.Data;
using VTMS.Models;

namespace VTMS.DataSource
{
    public class InstituteDS
    {
        DataContext dc = new DataContext();

        public DataSet GetListOfInstitutes()
        {
            InstituteModel model = new InstituteModel();
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
                dt.Columns.Add("InstituteCode");
                dt.Columns.Add("InstituteName");
                dt.Columns.Add("InstituteType");
                dt.Columns.Add("UniversityName");
                dt.Columns.Add("InstituteState");
                dt.Columns.Add("InstituteDistrict");
                
                object[] a = { "2629", "ANU PG Campus Ongole", "PG Center / Off-Campus Center", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Gurtur" };
                dt.Rows.Add(a);
                object[] a1 = { "32620", "P.N.C.A Degree College", "Affiliated College", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Gurtur" };
                dt.Rows.Add(a1);
                object[] a2 = { "32621", "Venigalla Jayasri Ram College", "Affiliated College", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Gurtur" };
                dt.Rows.Add(a2);
                object[] a3 = { "32622", "S.N.B.T.M. College of Education", "Affiliated College", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Prakasam" };
                dt.Rows.Add(a3);
                object[] a4 = { "32623", "V.T.J.M. & I.V.T.R. Degree College", "Affiliated College", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Prakasam" };
                dt.Rows.Add(a4);
                object[] a5 = { "32624", "Govt. Degree College, Chebrolu", "PG Center / Off-Campus Center", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Prakasam" };
                dt.Rows.Add(a5);
                object[] a6 = { "32627", "S.S. Arts & Science College", "PG Center / Off-Campus Center", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Prakasam" };
                dt.Rows.Add(a6);
                object[] a7 = { "32628", "G.C.K.V.N. Degree College", "PG Center / Off-Campus Center", "Acharya Nagarjuna University, Guntur", "Andhra Pradesh", "Prakasam" };
                dt.Rows.Add(a7);
                ds.Tables.Add(dt);
            }
            catch (Exception Ex)
            {

            }
            return ds;
        }


    }
}