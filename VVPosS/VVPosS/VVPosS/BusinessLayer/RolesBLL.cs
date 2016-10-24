using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosS.Entities;
using System.Data;

namespace VVPosS.BusinessLayer
{
    public class RolesBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
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
