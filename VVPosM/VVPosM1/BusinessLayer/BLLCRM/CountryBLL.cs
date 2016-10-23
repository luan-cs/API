using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using VVPosM1.Entities;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class CountryBLL:IObjectBLL<Country>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        } 

        public bool Add(Country obj)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Country obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT * FROM countries";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "Country", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["Country"];
            else
                return null;
        }

        public Country GetById(string id)
        {
            throw new NotImplementedException();
        }

        public string getCountryIdOT()
        {
            string queryStr = "SELECT * FROM countries Where CountryId = 'OT'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "Country", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["Country"].Rows[0]["CountryId"].ToString();
            else
                return null;
        }
    }
}
