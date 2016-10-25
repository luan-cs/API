using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;

namespace VVPosM1.BusinessLayer
{
    public class IngredientBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }
        public DataTable GetIngredients()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `ingredient` ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public int Update(MeasureDetail obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE measuredetail SET ";
            if (!string.IsNullOrEmpty(obj.MeasureQty))
            {
                queryStr += string.Format(" MeasureQty = '{0}'", obj.MeasureQty);
            }
            queryStr += string.Format(" WHERE MeasureId = '{0}' AND IngredientId = '{1}'", obj.MeasureId, obj.IngredientId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }


        public int Insert(MeasureDetail obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " measuredetail (";
            if (!string.IsNullOrEmpty(obj.MeasureId))
            {
                queryStr += "`MeasureId`,";
            }
            if (!string.IsNullOrEmpty(obj.IngredientId))
            {
                queryStr += "`IngredientId`,";
            }
            if (!string.IsNullOrEmpty(obj.MeasureQty))
            {
                queryStr += "`MeasureQty`";
            }
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(obj.MeasureId))
            {
                queryStr += string.Format("'{0}',", obj.MeasureId);
            }
            if (!string.IsNullOrEmpty(obj.IngredientId))
            {
                queryStr += string.Format("'{0}',", obj.IngredientId);
            }
            if (!string.IsNullOrEmpty(obj.MeasureQty))
            {
                queryStr += string.Format("'{0}'", obj.MeasureQty);
            }
            queryStr += ")";
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;

        }

        public DataTable GetMeasureDetailById(string measureId, string ingredientId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `measuredetail`
                            WHERE `MeasureId`='" + measureId + "' AND `IngredientId` = '" + ingredientId + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }
    }
}
