using System;
using System.Data;
using VTMS.Models;

namespace VTMS.DataSource
{
    public class UserLoginDS
    {
        /* Making an object of the datacontext class */
         DataContext dc = new DataContext();


        /* This function will check the login and access grants */
        public bool CheckLogin(UserLoginModel user)
        {   
            
            // production
            try
            {
                string LoginResult = "";
                string func = "SELECT FC_CHECK_PASSWORD('" + user.PERSONAL_NO + "','" + user.PASSWORD + "') FROM DUAL"; 
                LoginResult = dc.ReturnScaler(func);
                string AccessResult = "";
                string func1 = "SELECT COUNT(*) FROM VTMS_PRG_ACCESS_RIGHTS WHERE PERSONAL_NO ='" + user.PERSONAL_NO + "'"; 
                AccessResult = dc.ReturnScaler(func1);
                // This block will hold the access rights control 
                if (LoginResult == "1" && Convert.ToInt32(AccessResult) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }



            //Testing without Schema
            //return true;
        }

        public UserLoginModel GetEmployeeDetails(string personalno)
        {
            UserLoginModel employee = new UserLoginModel();

            // PRODUCTION CODE
            try
            {
                DataSet ds = new DataSet();
                string str = "";
                str = "SELECT A.PERSONAL_NO, A.GRADE_CODE, A.EMP_NAME, A.DESIGNATION, A.UNIT_NAME, A.UNIT_CODE from GESS.VW_GBL_SUGG_USER A WHERE  A.PERSONAL_NO='" + personalno + "'";
                ds = dc.QueryViaDataset(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    employee.PERSONAL_NO = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    employee.GRADE_CODE = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    employee.NAME = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    employee.DESIGNATION = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    employee.UNIT_NAME = ds.Tables[0].Rows[0].ItemArray[4].ToString();                  
                    employee.UNIT_CODE = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            return employee;

            //TESTING WITHOUT SCHEMA
            //employee.NAME = "Pushkar Saxena";
            //employee.GRADE_CODE = "l1";
            //employee.PERSONAL_NO = "110342";
            //employee.DESIGNATION = "Jr. Assistant(I.T. Services)";
            //employee.UNIT_CODE = "3";
            //employee.UNIT_NAME = "Aonla Unit";
            //return employee;

        }

    }
}