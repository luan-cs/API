using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;

namespace VVPosM1.BusinessLayer
{
    class InventoryBLL: IObjectBLL<ReportInventory>
    {
        private string errorString = "";
        public DataTable GetAll()
        {
            string query = "Select * From `inventory`";
            DataTable result = new DataTable();

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "inventory", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                result = dataset.Tables["inventory"];
            }
            //else
            //{
            //    result = null;
            //}

            return result;
        }
        public DataTable GetById(string id)
        {
            string query = string.Format("Select * From `inventory` where IngredientId='{0}'", id);
            DataTable result = new DataTable();

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "inventory", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                result = dataset.Tables["inventory"];
            }
            //else
            //{
            //    result = null;
            //}

            return result;
        }
    }
}
