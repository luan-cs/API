using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using VVPosM1.Entities;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class RegencyBLL:IObjectBLL<Regency>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(Regency obj)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Regency obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT * FROM Regencies";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "Regencies", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["Regencies"];
            else
                return null;
        }

        public Regency GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
