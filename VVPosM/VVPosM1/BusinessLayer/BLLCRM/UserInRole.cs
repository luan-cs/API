using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using VVPosM1.Entities;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class UserInRole:IObjectBLL<User_in_role>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        } 

        public bool Add(User_in_role obj)
        {
            throw new NotImplementedException();
        }

        public bool Edit(User_in_role obj)
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

        public User_in_role GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetRoleOfUser(string employeeId)
        {
            List<string> lst = new List<string>();
            string queryStr = String.Format("SELECT * FROM user_in_roles WHERE EmployeeId = '{0}'", employeeId);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                DataTable dtRoleOfUser = dataset.Tables["x"];
                if (dtRoleOfUser != null)
                {
                    for (int i = 0; i < dtRoleOfUser.Rows.Count; i++)
                    {
                        lst.Add(dtRoleOfUser.Rows[i]["RoleId"].ToString());
                    }
                }
                
            }

            return lst;
        }
    }
}
