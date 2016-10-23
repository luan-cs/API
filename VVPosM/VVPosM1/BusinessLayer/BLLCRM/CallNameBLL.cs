using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using VVPosM1.Entities;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class CallNameBLL:IObjectBLL<CallName>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        } 

        public bool Add(CallName obj)
        {
            throw new NotImplementedException();
        }

        public bool Edit(CallName obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT * FROM CallNames";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "CallNames", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["CallNames"];
            else
                return null;
        }

        public CallName GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
