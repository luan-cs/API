using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using VVPosM1.Entities;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class ActionStatusBLL : IObjectBLL<ActionStatus>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(ActionStatus obj)
        {
            throw new NotImplementedException();
        }

        public bool Edit(ActionStatus obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT * FROM ActionStatus";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "ActionStatus", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["ActionStatus"];
            else
                return null;
        }

        public ActionStatus GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
