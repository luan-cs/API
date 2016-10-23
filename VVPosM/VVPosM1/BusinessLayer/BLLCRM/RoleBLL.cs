using System;
using System.Data;
using VVPosM1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace VVPosM1.BusinessLayer.BLLCRM
{
    class RoleBLL : IObjectBLL<Roles>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(Roles obj)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Roles obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetLists()
        {
            throw new NotImplementedException();
        }

        public Roles GetById(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetByUserId(string pUserId)
        {
            string queryStr = String.Format("SELECT * FROM user_in_roles WHERE EmployeeId = '{0}'", pUserId);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        public void UpdateRoleByUserId(string pUserId, DataTable pTableRole)
        {
            ArrayList arrString = new ArrayList();

            arrString.Add(String.Format("DELETE FROM user_in_roles WHERE EmployeeId = '{0}'", pUserId));
            if (pTableRole.Rows.Count > 0)
            {
                foreach (DataRow row in pTableRole.Rows)
                {
                    string str = String.Format("INSERT INTO `user_in_roles` (`EmployeeId`,`RoleId`) VALUES('{0}','{1}')", row["EmployeeId"], row["RoleId"]);
                    arrString.Add(str);
                }
            }
            string[] arrQuery = (String[])arrString.ToArray(typeof(string));
            Program.destopService.DataMultiExecute(Program.Username, Program.Password, arrQuery, ref errorString);
        }
    }
}
