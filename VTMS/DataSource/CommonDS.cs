using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VTMS.Models;

namespace VTMS.DataSource
{
    public class CommonDS
    {
        DataContext dc = new DataContext();

        public string GetInstituteName(int InstituteId)
        {
            try
            {
                string value = "";
                string str = "selecting insitute name where institute id = ";
                value = dc.ReturnScaler(str);
                return value;
            }
            catch(Exception ex)
            {
                string value = "";
                value = "";
                return value;
            }

        }

        public string GetUniversityName(int UniversityId)
        {
            try
            {
                string value = "";
                string str = "selecting university name where university id = ";
                value = dc.ReturnScaler(str);
                return value;
            }
            catch (Exception ex)
            {
                string value = "";
                value = "";
                return value;
            }
        }

        public string GetBranchName(string BranchId)
        {
            try
            {
                string value = "";
                string str = "selecting branch name where branch id = ";
                value = dc.ReturnScaler(str);
                return value;
            }
            catch (Exception ex)
            {
                string value = "";
                value = "";
                return value;
            }
        }

        public string GetCourseName(string BranchId)
        {
            try
            {
                string value = "";
                string str = "selecting course name where course id = ";
                value = dc.ReturnScaler(str);
                return value;
            }
            catch (Exception ex)
            {
                string value = "";
                value = "";
                return value;
            }
        }
    }
}