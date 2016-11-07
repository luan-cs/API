using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using VVPosM1.Entities;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    public class CategoryActionsBLL : IBoolObjectBLL<CategoryActions>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(CategoryActions obj)
        {
            string query = string.Format("INSERT INTO `CategoryActions` (CategoryActionID, CategoryActionName , CategoryActionName2, CategoryActionName3) VALUE ('{0}', '{1}', '{2}', '{3}')", DateTime.Now.ToString("yyyMddHmmss"), obj.CategoryActionName, obj.CategoryActionName2, obj.CategoryActionName3);
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
            if (string.IsNullOrEmpty(errorString))
                return true;
            else
                return false;
        }

        public bool Edit(CategoryActions obj)
        {
            string query = string.Format("UPDATE `CategoryActions` SET CategoryActionName = '{0}', CategoryActionName2 = '{1}', CategoryActionName3 = '{2}' WHERE CategoryActionID = '{3}'", obj.CategoryActionName, obj.CategoryActionName2, obj.CategoryActionName3, obj.CategoryActionID);
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
            if (string.IsNullOrEmpty(errorString))
                return true;
            else
                return false;
        }

        public bool Delete(string id)
        {
            //check as boss said
            string checkQuery = "SELECT count(*) AS total FROM `actionshistory` WHERE `CategoryActionID` = '" + id + "'";
            DataSet data = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, checkQuery, ref data, "x", ref errorString);
            if(!string.IsNullOrEmpty(errorString) || int.Parse(data.Tables["x"].Rows[0]["total"].ToString()) != 0) //delete failed
            {
                return false;
            }

            errorString = string.Empty;
            string query = "DELETE FROM `CategoryActions` WHERE CategoryActionID = '" + id + "'";
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT * FROM CategoryActions";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "CategoryActions", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["CategoryActions"];
            else
                return null;
        }

        public CategoryActions GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
