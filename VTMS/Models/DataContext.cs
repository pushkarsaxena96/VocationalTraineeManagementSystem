using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace VTMS.Models
{
    public class DataContext
    {
        private OracleConnection con;


        public string ReturnScaler(string cmd, string personalNumber, string password)
        { // For credential verification
            /* Form a function around this */
            string constr = ConfigurationManager.AppSettings["Connect"].ToString();
            con = new OracleConnection(constr); 
            /*---------------------------------*/
            OracleCommand Command = new OracleCommand(); 
            string value = "";
            try
            {
                Command.CommandText = cmd.ToString();
                Command.BindByName = true;
                Command.Parameters.Add(new OracleParameter("@PersonalNumber", personalNumber));
                Command.Parameters.Add(new OracleParameter("@Password", password));
                Command.Connection = con;
                con.Open();
                value = Command.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {

            }
            return value;
        }

        public string ReturnScaler(string cmd)
        {
            /* Form a function around this */
            string constr = ConfigurationManager.AppSettings["Connect"].ToString();
            con = new OracleConnection(constr);
            /*---------------------------------*/
            OracleCommand Command = new OracleCommand();
            string value = "";
            try
            {
                Command.CommandText = cmd.ToString();
                Command.Connection = con;
                con.Open();
                value = Command.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {

            }
            return value;
        }

        public DataSet QueryViaDataset(string cmd)
        {
            /* Form a function around this */
            string constr = ConfigurationManager.AppSettings["Connect"].ToString();
            con = new OracleConnection(constr);
            /*---------------------------------*/
            DataSet ds = new DataSet();
            OracleCommand Command = new OracleCommand();
            try
            {
                Command.CommandText = cmd.ToString();
                Command.Connection = con;
                con.Open();
                OracleDataAdapter da = new OracleDataAdapter(Command);
                da.Fill(ds);
                da.Dispose();
                con.Close();
                return ds;
            }
            catch (Exception Exp)
            {
                ds = null;
                return ds;
            }
        }

        public DataTable getQueryViaDataTable(string cmd)
        {
            /* Form a function around this */
            string constr = ConfigurationManager.AppSettings["Connect"].ToString();
            con = new OracleConnection(constr);
            /*---------------------------------*/
            DataTable dt = new DataTable();
            OracleDataAdapter da = null;
            DataSet ds = new DataSet();
            OracleCommand Command = new OracleCommand();
            try
            {
                Command.CommandText = cmd.ToString();
                Command.Connection = con;
                con.Open();
                da = new OracleDataAdapter(Command);
                da.Fill(dt);
                da.Dispose();
                con.Close();
            }
            catch (Exception Ex)
            {
                dt = null;
            }
            return dt;
        }

        public bool insertToDB(string sql)
        {
            string constr = ConfigurationManager.AppSettings["Connect"].ToString();
            con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = sql.ToString();
                cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}