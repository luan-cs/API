using System;
using System.Data;
using System.Drawing;
using System.IO;
using VVPosM1.Entities;
using System.Text;
using System.Windows.Forms;

namespace VVPosM1.BusinessLayer.BLLCRM
{
    public class EmployeeBLL : IObjectBLL<Employees1>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }


        public bool Add(Employees1 obj)
        {
            long id = 0;
            string queryStr = "INSERT INTO";
            queryStr += " employees(EmployeeId, EmployeeCode, EmployeeName, BirthDate, PhoneNumber, Email, Address, Notes, HourlyWages, EmployeeTypeId, CountryId, UserName, Password, IsDelete, CreatedDate, UpdatedDate, Gender)";
            queryStr += " VALUES(";
            queryStr += string.Format("'{0}'", obj.EmployeeId);
            queryStr += string.Format(", '{0}'", obj.EmployeeCode);
            queryStr += string.Format(", '{0}'", obj.EmployeeName);
            queryStr += string.Format(", '{0}'", obj.BirthDate.ToString("yyyy-MM-dd HH:mm:ss"));
            queryStr += string.Format(", '{0}'", obj.PhoneNumber);
            queryStr += string.Format(", '{0}'", obj.Email);
            queryStr += string.Format(", '{0}'", obj.Address);
            queryStr += string.Format(", '{0}'", obj.Notes);
            queryStr += string.Format(", {0}", obj.HourlyWages);
            queryStr += string.Format(", '{0}'", obj.EmployeeType.EmployeeTypeId);
            queryStr += string.Format(", '{0}'", obj.Country.CountryId);
            queryStr += string.Format(", '{0}'", obj.UserName);
            queryStr += string.Format(", '{0}'", obj.Password);
            queryStr += string.Format(", {0}", obj.IsDelete);
            queryStr += ", NOW()";
            queryStr += ", NOW()";
            queryStr += string.Format(", {0})", obj.Gender);

            Program.destopService.DataExecuteId(Program.Username, Program.Password, queryStr, ref id, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }
        //lay ma nhan vien tu dong tang
        public string AddReturnId(Employees1 obj)
        {
            long id = 0;
            string queryStr = "INSERT INTO";
            queryStr += " employees( EmployeeCode, EmployeeName, BirthDate, PhoneNumber, Email, Address, Notes, HourlyWages, EmployeeTypeId, CountryId, UserName, Password, IsDelete, CreatedDate, UpdatedDate, Gender)";
            queryStr += " VALUES(";
            //queryStr += string.Format("'{0}'", obj.EmployeeId);
            queryStr += string.Format(" '{0}'", obj.EmployeeCode);
            queryStr += string.Format(", '{0}'", obj.EmployeeName);
            queryStr += string.Format(", '{0}'", obj.BirthDate.ToString("yyyy-MM-dd HH:mm:ss"));
            queryStr += string.Format(", '{0}'", obj.PhoneNumber);
            queryStr += string.Format(", '{0}'", obj.Email);
            queryStr += string.Format(", '{0}'", obj.Address);
            queryStr += string.Format(", '{0}'", obj.Notes);
            queryStr += string.Format(", {0}", obj.HourlyWages);
            queryStr += string.Format(", '{0}'", obj.EmployeeType.EmployeeTypeId);
            queryStr += string.Format(", '{0}'", obj.Country.CountryId);
            queryStr += string.Format(", '{0}'", obj.UserName);
            queryStr += string.Format(", '{0}'", obj.Password);
            queryStr += string.Format(", {0}", obj.IsDelete);
            queryStr += ", NOW()";
            queryStr += ", NOW()";
            queryStr += string.Format(", {0})", obj.Gender);
            //Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            Program.destopService.DataExecuteId(Program.Username, Program.Password, queryStr, ref id, ref errorString);
            return id.ToString();
            //MessageBox.Show(id + "");
        }

        public bool Edit(Employees1 obj)
        {
            string queryStr = "UPDATE employees SET";
            queryStr += string.Format(" EmployeeCode = '{0}'", obj.EmployeeCode);
            queryStr += string.Format(" ,EmployeeName = '{0}'", obj.EmployeeName);
            queryStr += string.Format(" ,BirthDate = '{0}'", obj.BirthDate.ToString("yyyy-MM-dd HH:mm"));
            queryStr += string.Format(" ,PhoneNumber = '{0}'", obj.PhoneNumber);
            queryStr += string.Format(" ,Email = '{0}'", obj.Email);
            queryStr += string.Format(" ,Address = '{0}'", obj.Address);
            queryStr += string.Format(" ,Notes = '{0}'", obj.Notes);
            queryStr += string.Format(" ,HourlyWages = {0}", obj.HourlyWages);
            queryStr += string.Format(" ,EmployeeTypeId = '{0}'", obj.EmployeeType.EmployeeTypeId);
            queryStr += string.Format(" ,CountryId = '{0}'", obj.Country.CountryId);
            queryStr += string.Format(" ,UserName = '{0}'", obj.UserName);
            queryStr += string.Format(" ,Password = '{0}'", obj.Password);
            queryStr += string.Format(" ,IsDelete = {0}", obj.IsDelete);
            queryStr += " ,UpdatedDate = NOW()";
            queryStr += string.Format(" ,Gender = {0}", obj.Gender);
            queryStr += string.Format(" WHERE EmployeeId = '{0}'", obj.EmployeeId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public bool Delete(string id)
        {
            string queryStr = string.Format("UPDATE employees SET IsDelete = 1 WHERE  EmployeeId = '{0}' And UserName !='{1}'", id, Program.Username);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        //public DataTable GetListName()
        //{
        //    string queryStr = "SELECT employees.EmployeeId, employees.EmployeeName WHERE IsDelete = 0";
        //}
        public DataTable GetLists()
        {
            string queryStr = "SELECT employees.EmployeeId";
            queryStr = queryStr + " ,employees.EmployeeCode";
            queryStr = queryStr + " ,employees.EmployeeName";
            queryStr = queryStr + " ,DATE_FORMAT(employees.BirthDate,'%Y-%m-%d') AS BirthDate";

            queryStr = queryStr + " ,CASE employees.Gender WHEN 0 THEN ";
            queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";

            //if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            //{
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";
            //}
            //else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            //{
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";
            //}
            //else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            //{
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";
            //}
            //queryStr = queryStr + " ,CASE employees.Gender WHEN 1 THEN 'Nam' WHEN 0 THEN 'Nữ' END AS Gender";
            // queryStr = queryStr + " ,employees.Gender";
            //queryStr = queryStr + " ,employees.Gender AS IntGender";

            queryStr = queryStr + " ,employees.PhoneNumber";
            queryStr = queryStr + " ,employees.Email";
            queryStr = queryStr + " ,employees.Address";
            queryStr = queryStr + " ,employees.Notes";
            //queryStr = queryStr + " ,employees.EmployeeTypeId";

            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            {
                queryStr = queryStr + " ,employee_types.EmployeeTypeName as EmployeeTypeName";
                queryStr = queryStr + " ,countries.CountryName as CountryName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            {
                queryStr = queryStr + " ,employee_types.EmployeeTypeName2 as EmployeeTypeName";
                queryStr = queryStr + " ,countries.CountryName2 as CountryName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            {
                queryStr = queryStr + " ,employee_types.EmployeeTypeName3 as EmployeeTypeName";
                queryStr = queryStr + " ,countries.CountryName3 as CountryName";
            }


            //queryStr = queryStr + " ,employee_types.EmployeeTypeName";
            //queryStr = queryStr + " ,employee_types.EmployeeTypeName2";
            //queryStr = queryStr + " ,employee_types.EmployeeTypeName3";
            //queryStr = queryStr + " ,employees.CountryId";
            //queryStr = queryStr + " ,countries.CountryName";
            //queryStr = queryStr + " ,countries.CountryName2";
            //queryStr = queryStr + " ,countries.CountryName3";
            queryStr = queryStr + " ,employees.UserName";
            //queryStr = queryStr + " ,employees.Password";
            //queryStr = queryStr + " ,CASE employees.IsDelete WHEN 0 THEN 'Chưa xóa' WHEN 1 THEN 'Đã xóa' END AS IsDelete";
            //queryStr = queryStr + " ,employees.IsDelete AS IntIsDelete";
            queryStr = queryStr + " ,employees.HourlyWages";
            queryStr = queryStr + " ,DATE_FORMAT(employees.CreatedDate,'%Y-%m-%d') AS CreatedDate";
            queryStr = queryStr + " ,DATE_FORMAT(employees.UpdatedDate,'%Y-%m-%d') AS UpdatedDate";
            //queryStr = queryStr + " ,DATE_FORMAT(employees.BirthDate,'%Y-%m-%d') AS BirthDateYMD";
            queryStr = queryStr + " FROM employees INNER JOIN employee_types ON employees.EmployeeTypeId = employee_types.EmployeeTypeId";
            queryStr = queryStr + " INNER JOIN countries ON employees.CountryId = countries.CountryId";
            queryStr = queryStr + " WHERE IsDelete = 0";
            queryStr = queryStr + " ORDER BY EmployeeId ASC";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        public Employees1 GetById(string id)
        {
            Employees1 employee = new Employees1();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM employees WHERE EmployeeId = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                employee.EmployeeId = dataset.Tables["x"].Rows[0]["EmployeeId"].ToString();
                employee.EmployeeName = dataset.Tables["x"].Rows[0]["EmployeeName"].ToString();
                string a = dataset.Tables["x"].Rows[0]["BirthDate"].ToString();
                employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["BirthDate"].ToString());
                employee.Gender = int.Parse(dataset.Tables["x"].Rows[0]["Gender"].ToString());
                employee.PhoneNumber = dataset.Tables["x"].Rows[0]["PhoneNumber"].ToString();
                employee.Email = dataset.Tables["x"].Rows[0]["Email"].ToString();
                employee.Address = dataset.Tables["x"].Rows[0]["Address"].ToString();
                employee.Notes = dataset.Tables["x"].Rows[0]["Notes"].ToString();
                employee.HourlyWages = decimal.Parse(dataset.Tables["x"].Rows[0]["HourlyWages"].ToString());
                employee.EmployeeType.EmployeeTypeId = dataset.Tables["x"].Rows[0]["EmployeeTypeId"].ToString();
                employee.Country.CountryId = dataset.Tables["x"].Rows[0]["CountryId"].ToString();
                employee.UserName = dataset.Tables["x"].Rows[0]["UserName"].ToString();
                employee.Password = dataset.Tables["x"].Rows[0]["Password"].ToString();
                employee.CreatedDate =DateTime.Parse(dataset.Tables["x"].Rows[0]["CreatedDate"].ToString());
                employee.UpdatedDate =DateTime.Parse(dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString());

                employee.EmployeeCode = dataset.Tables["x"].Rows[0]["EmployeeCode"].ToString();

                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["Image"].ToString()))
                {
                    MemoryStream stream = new MemoryStream((Byte[])dataset.Tables["x"].Rows[0]["Image"]);
                    employee.Image = Image.FromStream(stream);
                }
            }
            else
                employee = null;

            return employee;
        }

        public Employees1 GetByIdOrUsername(string pIdOrUsername)
        {
            Employees1 employee = new Employees1();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM employees WHERE EmployeeId = '{0}' OR UserName = '{0}'", pIdOrUsername);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {

                employee.EmployeeId = dataset.Tables["x"].Rows[0]["EmployeeId"].ToString();
                employee.EmployeeName = dataset.Tables["x"].Rows[0]["EmployeeName"].ToString();
                employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["BirthDate"].ToString());
                employee.Gender = int.Parse(dataset.Tables["x"].Rows[0]["Gender"].ToString());
                employee.PhoneNumber = dataset.Tables["x"].Rows[0]["PhoneNumber"].ToString();
                employee.Email = dataset.Tables["x"].Rows[0]["Email"].ToString();
                employee.Address = dataset.Tables["x"].Rows[0]["Address"].ToString();
                employee.Notes = dataset.Tables["x"].Rows[0]["Notes"].ToString();
                employee.HourlyWages = decimal.Parse(dataset.Tables["x"].Rows[0]["HourlyWages"].ToString());
                employee.EmployeeType.EmployeeTypeId = dataset.Tables["x"].Rows[0]["EmployeeTypeId"].ToString();
                employee.Country.CountryId = dataset.Tables["x"].Rows[0]["CountryId"].ToString();
                employee.UserName = dataset.Tables["x"].Rows[0]["UserName"].ToString();
                employee.Password = dataset.Tables["x"].Rows[0]["Password"].ToString();
                employee.CreatedDate = employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["CreatedDate"].ToString());
                employee.UpdatedDate = employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString());

                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["Image"].ToString()))
                {
                    MemoryStream stream = new MemoryStream((Byte[])dataset.Tables["x"].Rows[0]["Image"]);
                    employee.Image = Image.FromStream(stream);
                }
            }
            else
                employee = null;

            return employee;
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

        public void SaveImage(Employees1 obj, string imageParth)
        {
            //if (!string.IsNullOrEmpty(imageParth))
            //{
            //    FileStream stream = new FileStream(imageParth, FileMode.Open, FileAccess.Read);
            //    BinaryReader reader = new BinaryReader(stream);
            //    byte[] buffer = new byte[stream.Length];
            //    reader.Read(buffer, 0, Convert.ToInt32(stream.Length));
            //    stream.Close();

            //    Program.destopService.DataSaveImage(Program.Username, Program.Password, buffer, obj.EmployeeCode, "EmployeeCode", "Image", "employees", ref errorString);
            //}
            //Diep sửa lại convert ảnh
            //
            byte[] ImageData = null;
            if (!string.IsNullOrEmpty(imageParth))
            {
                Bitmap bmp = new Bitmap(imageParth);
                Image img = ImageHandler.Save(bmp, Common.Config.pWidth, Common.Config.pHeight);

                ImageConverter converter = new ImageConverter();
                ImageData = (byte[])converter.ConvertTo(img, typeof(byte[]));
                Program.destopService.DataSaveImage(Program.Username, Program.Password, ImageData, obj.EmployeeCode, "EmployeeCode", "Image", "employees", ref errorString);
            }
        }

        public bool CheckLogin(string pIdOrUsername, string pPassword)
        {
            bool ok = Program.destopService.IsUser(pIdOrUsername, pPassword, ref errorString);

            if (ok == true)
            {
                Program.Username = pIdOrUsername;
                Program.Password = pPassword;
                Program.employee1 = GetByIdOrUsername(pIdOrUsername);
            }

            return ok;
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="newPass"></param>
        public void ChangePassword(Employees1 obj, string newPass)
        {
            string query = String.Format("UPDATE employees SET employees.Password = '{0}' WHERE employees.EmployeeId = '{1}'", newPass, obj.EmployeeId);
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
        }

        /// <summary>
        /// get employee by code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Employees1 GetByEmployeeCode(string code)
        {
            Employees1 employee = new Employees1();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM employees WHERE EmployeeCode = '{0}'", code);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                employee.EmployeeId = dataset.Tables["x"].Rows[0]["EmployeeId"].ToString();
                employee.EmployeeName = dataset.Tables["x"].Rows[0]["EmployeeName"].ToString();
                employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["BirthDate"].ToString());
                employee.Gender = int.Parse(dataset.Tables["x"].Rows[0]["Gender"].ToString());
                employee.PhoneNumber = dataset.Tables["x"].Rows[0]["PhoneNumber"].ToString();
                employee.Email = dataset.Tables["x"].Rows[0]["Email"].ToString();
                employee.Address = dataset.Tables["x"].Rows[0]["Address"].ToString();
                employee.Notes = dataset.Tables["x"].Rows[0]["Notes"].ToString();
                employee.HourlyWages = decimal.Parse(dataset.Tables["x"].Rows[0]["HourlyWages"].ToString());
                employee.EmployeeType.EmployeeTypeId = dataset.Tables["x"].Rows[0]["EmployeeTypeId"].ToString();
                employee.Country.CountryId = dataset.Tables["x"].Rows[0]["CountryId"].ToString();
                employee.UserName = dataset.Tables["x"].Rows[0]["UserName"].ToString();
                employee.Password = dataset.Tables["x"].Rows[0]["Password"].ToString();
                employee.CreatedDate = employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["CreatedDate"].ToString());
                employee.UpdatedDate = employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString());

                employee.EmployeeCode = dataset.Tables["x"].Rows[0]["EmployeeCode"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["Image"].ToString()))
                {
                    MemoryStream stream = new MemoryStream((Byte[])dataset.Tables["x"].Rows[0]["Image"]);
                    employee.Image = Image.FromStream(stream);
                }
            }
            else
                employee = null;

            return employee;
        }

        /// <summary>
        /// Check employee is deleted or not
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckEmployeeIsDelete(string code)
        {
            bool blag = false;
            string query = String.Format("SELECT * FROM employees WHERE employees.EmployeeCode = '{0}' AND employees.IsDelete = '1'", code);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Employee", ref errorString);

            if (dataset.Tables["Employee"].Rows.Count != 0)
            {
                if (dataset.Tables["Employee"].Rows[0]["IsDelete"].ToString().Equals("1"))
                {
                    blag = true;
                }
            }
            return blag;
        }

        /// <summary>
        /// Check employee is exist in database or not
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckEmployeeIsExist(string code)
        {
            bool blag = false;
            string query = String.Format("SELECT * FROM employees WHERE employees.EmployeeCode = '{0}'  AND employees.IsDelete = '0'", code);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Employee", ref errorString);

            if (dataset.Tables["Employee"].Rows.Count != 0)
            {
                blag = true;
            }
            return blag;
        }

        ///
        /// Diep search employeeId, Name, Code from EmployeeTypeId
        ///
        public DataTable GetInToComnobox(string id)
        {
            Employees1 employee = new Employees1();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT EmployeeId, EmployeeName, EmployeeCode FROM employees WHERE EmployeeTypeId = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        public string GetEmployeeIdByEmployeeName(string name)
        {
            string query = String.Format("Select * from employees WHERE EmployeeName = '{0}'", name);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);
            if (String.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["x"].Rows[0]["EmployeeId"].ToString();
            }
            else
            {
                return null;
            }
        }

        public DataTable GetEmployeesByCodeOrName(string code, string name)
        {
            string queryStr = "SELECT employees.EmployeeId";
            queryStr = queryStr + " ,employees.EmployeeCode";
            queryStr = queryStr + " ,employees.EmployeeName";
            queryStr = queryStr + " ,DATE_FORMAT(employees.BirthDate,%Y-%m-%d') AS BirthDate";
            queryStr = queryStr + " ,CASE employees.Gender WHEN 1 THEN 'Nam' WHEN 0 THEN 'Nữ' END AS Gender";
            queryStr = queryStr + " ,employees.Gender AS IntGender";
            queryStr = queryStr + " ,employees.PhoneNumber";
            queryStr = queryStr + " ,employees.Email";
            queryStr = queryStr + " ,employees.Address";
            queryStr = queryStr + " ,employees.Notes";
            queryStr = queryStr + " ,employees.EmployeeTypeId";
            queryStr = queryStr + " ,employee_types.EmployeeTypeName";
            queryStr = queryStr + " ,employees.CountryId";
            queryStr = queryStr + " ,countries.CountryName";
            queryStr = queryStr + " ,employees.UserName";
            queryStr = queryStr + " ,employees.Password";
            queryStr = queryStr + " ,CASE employees.IsDelete WHEN 0 THEN 'Chưa xóa' WHEN 1 THEN 'Đã xóa' END AS IsDelete";
            queryStr = queryStr + " ,employees.IsDelete AS IntIsDelete";
            queryStr = queryStr + " ,employees.HourlyWages";
            queryStr = queryStr + " ,DATE_FORMAT(employees.CreatedDate,'%Y-%m-%d') AS CreatedDate";
            queryStr = queryStr + " ,DATE_FORMAT(employees.UpdatedDate,'%Y-%m-%d') AS UpdatedDate";
            queryStr = queryStr + " ,DATE_FORMAT(employees.BirthDate,'%Y-%m-%d') AS BirthDateYMD";
            queryStr = queryStr + " FROM employees INNER JOIN employee_types ON employees.EmployeeTypeId = employee_types.EmployeeTypeId";
            queryStr = queryStr + " INNER JOIN countries ON employees.CountryId = countries.CountryId WHERE ";

            if (!String.IsNullOrEmpty(code))
            {
                queryStr += String.Format("EmployeeCode = '{0}' OR ", code);
            }
            if (!String.IsNullOrEmpty(name))
            {
                queryStr += String.Format("EmployeeName LIKE '%{0}%' OR ", name);
            }
            queryStr = queryStr.Substring(0, queryStr.Length - 3);
            queryStr = queryStr + " ORDER BY EmployeeId ASC";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "Employee", ref errorString);
            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["Employee"].Rows.Count != 0)
            {
                return dataset.Tables["Employee"];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Check employee is exist in database or not
        /// For update or insert
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckEmployeeIsExist(string code, string pEmployeeId)
        {
            bool blag = false;
            string query = "";
            if (string.IsNullOrEmpty(pEmployeeId))
            {
                //case: Add
                query = String.Format("SELECT * FROM employees WHERE employees.EmployeeCode = '{0}'", code);
            }
            else //case: Update
            {
                query = String.Format("SELECT * FROM employees WHERE employees.EmployeeCode = '{0}'And employees.EmployeeId not in (Select p.EmployeeId From Employees p Where p.EmployeeId = '{1}')", code, pEmployeeId);
            }
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Employee", ref errorString);

            if (dataset.Tables["Employee"].Rows.Count != 0)
            {
                blag = true;
            }
            return blag;
        }

        public DataTable SearchEmployee(string keyword)
        {
            string queryStr = "SELECT employees.EmployeeId";
            queryStr = queryStr + " ,employees.EmployeeCode";
            queryStr = queryStr + " ,employees.EmployeeName";
            queryStr = queryStr + " ,DATE_FORMAT(employees.BirthDate,'%Y-%m-%d') AS BirthDate";

            queryStr = queryStr + " ,CASE employees.Gender WHEN 0 THEN ";
            queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";

            //if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            //{
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";
            //}
            //else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            //{
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";
            //}
            //else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            //{
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM342") + "' When 1 Then ";
            //    queryStr = queryStr + " '" + Common.clsLanguages.GetResource("CRM520") + "' End As  Gender";
            //}
            //queryStr = queryStr + " ,CASE employees.Gender WHEN 1 THEN 'Nam' WHEN 0 THEN 'Nữ' END AS Gender";
            // queryStr = queryStr + " ,employees.Gender";
            //queryStr = queryStr + " ,employees.Gender AS IntGender";

            queryStr = queryStr + " ,employees.PhoneNumber";
            queryStr = queryStr + " ,employees.Email";
            queryStr = queryStr + " ,employees.Address";
            queryStr = queryStr + " ,employees.Notes";
            //queryStr = queryStr + " ,employees.EmployeeTypeId";

            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            {
                queryStr = queryStr + " ,employee_types.EmployeeTypeName as EmployeeTypeName";
                queryStr = queryStr + " ,countries.CountryName as CountryName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            {
                queryStr = queryStr + " ,employee_types.EmployeeTypeName2 as EmployeeTypeName";
                queryStr = queryStr + " ,countries.CountryName2 as CountryName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            {
                queryStr = queryStr + " ,employee_types.EmployeeTypeName3 as EmployeeTypeName";
                queryStr = queryStr + " ,countries.CountryName3 as CountryName";
            }
            //queryStr = queryStr + " ,employee_types.EmployeeTypeName";
            //queryStr = queryStr + " ,employee_types.EmployeeTypeName2";
            //queryStr = queryStr + " ,employee_types.EmployeeTypeName3";
            //queryStr = queryStr + " ,employees.CountryId";
            //queryStr = queryStr + " ,countries.CountryName";
            //queryStr = queryStr + " ,countries.CountryName2";
            //queryStr = queryStr + " ,countries.CountryName3";
            queryStr = queryStr + " ,employees.UserName";
            //queryStr = queryStr + " ,employees.Password";
            //queryStr = queryStr + " ,CASE employees.IsDelete WHEN 0 THEN 'Chưa xóa' WHEN 1 THEN 'Đã xóa' END AS IsDelete";
            //queryStr = queryStr + " ,employees.IsDelete AS IntIsDelete";
            queryStr = queryStr + " ,employees.HourlyWages";
            queryStr = queryStr + " ,DATE_FORMAT(employees.CreatedDate,'%Y-%m-%d') AS CreatedDate";
            queryStr = queryStr + " ,DATE_FORMAT(employees.UpdatedDate,'%Y-%m-%d') AS UpdatedDate";
            //queryStr = queryStr + " ,DATE_FORMAT(employees.BirthDate,'%Y-%m-%d') AS BirthDateYMD";
            queryStr = queryStr + " FROM employees INNER JOIN employee_types ON employees.EmployeeTypeId = employee_types.EmployeeTypeId";
            queryStr = queryStr + " INNER JOIN countries ON employees.CountryId = countries.CountryId";
            queryStr = queryStr + " WHERE employees.IsDelete = '0'";

            if(!string.IsNullOrEmpty(keyword))
            {
                queryStr += string.Format(" And (`employees`.`EmployeeTypeId` = '{0}' OR `employees`.`EmployeeCode` {1} OR `employees`.`EmployeeName` {1} OR `employees`.`PhoneNumber` {1} OR `employees`.`Email` {1} OR `employees`.`Address` {1} OR `employees`.`Notes` {1})", keyword, "LIKE '%" + keyword + "%'");
            }
            queryStr = queryStr + " ORDER BY `EmployeeId` ASC";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        //Điệp
        public Employees1 GetByEmployeeName_ForCheckTime(string code)
        {
            Employees1 employee = new Employees1();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM employees WHERE EmployeeCode = '{0}'", code);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {                
                employee.EmployeeName = dataset.Tables["x"].Rows[0]["EmployeeName"].ToString();
                employee.BirthDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["BirthDate"].ToString());
            }
            else
                employee = null;

            return employee;
        }

        public DataTable GetListName()
        {
            string query = "SElect `EmployeeId`, `EmployeeName` FROM `employees`";
            DataSet dataset = new DataSet();
            try
            {
                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "a", ref errorString);
                if (string.IsNullOrEmpty(errorString))
                {
                    return dataset.Tables["a"];
                }
                else return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
