using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Data;

namespace VVPosM1.BusinessLayer
{
    public class RolesBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public DataTable GetRoleOfUser(string RoleId)
        {
            string queryStr = String.Format("SELECT * FROM roles WHERE RoleId = '{0}'", RoleId);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }
    }
}
