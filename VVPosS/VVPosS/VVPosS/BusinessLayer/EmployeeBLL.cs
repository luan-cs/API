using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using VVPosS.Entities;
using System.Drawing;
using System.IO;

namespace VVPosS.BusinessLayer
{
    public class EmployeeBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        private bool res = false;

        public bool Res
        {
            get { return res; }
            set { res = value; }
        }

        public Employees GetEmployeeCode(string id)
        {
            Employees employee = new Employees();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `employees`
                            WHERE `EmployeeCode`='" + id + "' ";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                employee.EmployeeId = ds.Tables["x"].Rows[0]["EmployeeId"].ToString();
                employee.EmployeeName = ds.Tables["x"].Rows[0]["EmployeeName"].ToString();
                employee.BirthDate = ds.Tables["x"].Rows[0]["BirthDate"].ToString();
                employee.PhoneNumber = ds.Tables["x"].Rows[0]["PhoneNumber"].ToString();
                employee.Email = ds.Tables["x"].Rows[0]["Email"].ToString();
                employee.CreatedDate = ds.Tables["x"].Rows[0]["CreatedDate"].ToString();
                employee.Address = ds.Tables["x"].Rows[0]["Address"].ToString();
                employee.Image = ds.Tables["x"].Rows[0]["Image"].ToString();
                employee.HourlyWages = ds.Tables["x"].Rows[0]["HourlyWages"].ToString();
                employee.EmployeeTypeId = ds.Tables["x"].Rows[0]["EmployeeTypeId"].ToString();
                employee.CountryId = ds.Tables["x"].Rows[0]["CountryId"].ToString();
                employee.UserName = ds.Tables["x"].Rows[0]["UserName"].ToString();
                employee.Password = ds.Tables["x"].Rows[0]["Password"].ToString();
                employee.IsDelete = ds.Tables["x"].Rows[0]["IsDelete"].ToString();
                employee.UpdatedDate = ds.Tables["x"].Rows[0]["UpdatedDate"].ToString();
                employee.Gender = ds.Tables["x"].Rows[0]["Gender"].ToString();
                employee.EmployeeCode = ds.Tables["x"].Rows[0]["EmployeeCode"].ToString();
            }
            else
            {
                employee = null;
            }
            return employee;
        }
        public bool CheckLogin(string pIdOrUsername, string pPassword)
        {
            bool ok = Program.destopService.IsUser(pIdOrUsername, pPassword, ref errorString);

            if (ok == true)
            {
                Program.Username = pIdOrUsername;
                Program.Password = pPassword;
                Program.users = GetByIdOrUsername(pIdOrUsername);
            }

            return ok;
        }

        public Employees GetByIdOrUsername(string pIdOrUsername)
        {
            Employees employee = new Employees();
            DataSet dataset = new DataSet();
            //hung 09-12-2014
            string queryStr = string.Format("SELECT * FROM users WHERE  UserId = '{0}'", pIdOrUsername);
            //string queryStr = string.Format("SELECT * FROM employees WHERE  UserName = '{0}'", pIdOrUsername);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                employee.EmployeeId = dataset.Tables["x"].Rows[0]["EmployeeId"].ToString();
                employee.EmployeeName = dataset.Tables["x"].Rows[0]["EmployeeName"].ToString();
                employee.BirthDate = dataset.Tables["x"].Rows[0]["BirthDate"].ToString();
                employee.PhoneNumber = dataset.Tables["x"].Rows[0]["PhoneNumber"].ToString();
                employee.Email = dataset.Tables["x"].Rows[0]["Email"].ToString();
                employee.CreatedDate = dataset.Tables["x"].Rows[0]["CreatedDate"].ToString();
                employee.Address = dataset.Tables["x"].Rows[0]["Address"].ToString();
                employee.Image = dataset.Tables["x"].Rows[0]["Image"].ToString();
                employee.HourlyWages = dataset.Tables["x"].Rows[0]["HourlyWages"].ToString();
                employee.EmployeeTypeId = dataset.Tables["x"].Rows[0]["EmployeeTypeId"].ToString();
                employee.CountryId = dataset.Tables["x"].Rows[0]["CountryId"].ToString();
                employee.UserName = dataset.Tables["x"].Rows[0]["UserName"].ToString();
                employee.Password = dataset.Tables["x"].Rows[0]["Password"].ToString();
                employee.IsDelete = dataset.Tables["x"].Rows[0]["IsDelete"].ToString();
                employee.UpdatedDate = dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString();
                employee.Gender = dataset.Tables["x"].Rows[0]["Gender"].ToString();
                employee.EmployeeCode = dataset.Tables["x"].Rows[0]["EmployeeCode"].ToString();
            }
            else
                employee = null;

            return employee;
        }

        public DataTable CheckRole(string employeeId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT * FROM `user_in_roles` where `EmployeeId` ='" + employeeId + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public Image GetImage(string pEmployeeId)
        {
            DataSet dataset = new DataSet();
            string queryStr = String.Format("SELECT Image FROM employees WHERE EmployeeId = '{0}'", pEmployeeId);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (dataset.Tables["x"].Rows.Count <= 0)
                return null;

            if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["Image"].ToString()))
            {
                MemoryStream stream = new MemoryStream((Byte[])dataset.Tables["x"].Rows[0]["Image"]);
                return Image.FromStream(stream);
            }

            return null;
        }

        public void ChangePassword(Employees obj)
        {
            string[][] param ={
                new string[] {"p_UserName", obj.UserName},
                new string[] {"p_Password",obj.Password}
            };
            Program.destopService.DataStoreProcExecute(Program.Username, Program.Password, "spUpdate_Pwd_Employee", ref errorString, param, ref res);
        }
    }
}
