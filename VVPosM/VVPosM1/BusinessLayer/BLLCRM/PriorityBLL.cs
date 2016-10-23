using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using VVPosM1.Entities;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class PriorityBLL : IObjectBLL<Priorities>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(Priorities obj)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Priorities obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT * FROM Priorities";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "Priorities", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["Priorities"];
            else
                return null;
        }

        public Priorities GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
