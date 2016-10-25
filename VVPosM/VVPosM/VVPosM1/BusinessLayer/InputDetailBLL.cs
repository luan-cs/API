using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;

namespace VVPosM1.BusinessLayer
{
    public class InputDetailBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }
        public DataTable GetInputDetailById(string inputId, string ingredientId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `inputdetail`
                            WHERE `InputId`='" + inputId + "' AND `IngredientId` = '" + ingredientId + "'";
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

        public int Update(InputDetail obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE inputdetail SET ";
            if (!string.IsNullOrEmpty(obj.IngredientExpDate))
            {
                queryStr += string.Format(" IngredientExpDate = '{0}',", obj.IngredientExpDate);
            }
            if (!string.IsNullOrEmpty(obj.IngredientQty))
            {
                queryStr += string.Format(" IngredientQty = '{0}',", obj.IngredientQty);
            }
            if (!string.IsNullOrEmpty(obj.IngredientPrice))
            {
                queryStr += string.Format(" IngredientPrice = '{0}',", obj.IngredientPrice);
            }
            if (!string.IsNullOrEmpty(obj.IngredientVat))
            {
                queryStr += string.Format(" IngredientVat = '{0}',", obj.IngredientVat);
            }
            if (!string.IsNullOrEmpty(obj.IngredientDiscount))
            {
                queryStr += string.Format(" IngredientDiscount = '{0}',", obj.IngredientDiscount);
            }
            queryStr += string.Format(" WHERE InputId = '{0}' AND IngredientId = '{1}'", obj.InputId, obj.IngredientId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }


        public int Insert(InputDetail obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " inputdetail (";
            if (!string.IsNullOrEmpty(obj.InputId))
            {
                queryStr += "`InputId`,";
            }
            if (!string.IsNullOrEmpty(obj.IngredientId))
            {
                queryStr += "`IngredientId`,";
            }
            if (!string.IsNullOrEmpty(obj.IngredientExpDate))
            {
                queryStr += "`IngredientExpDate`,";
            }
            if (!string.IsNullOrEmpty(obj.IngredientQty))
            {
                queryStr += "`IngredientQty`,";
            }
            if (!string.IsNullOrEmpty(obj.IngredientPrice))
            {
                queryStr += "`IngredientPrice`,";
            }
            if (!string.IsNullOrEmpty(obj.IngredientVat))
            {
                queryStr += "`IngredientVat`,";
            }
            if (!string.IsNullOrEmpty(obj.IngredientDiscount))
            {
                queryStr += "`IngredientDiscount`";
            }
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(obj.InputId))
            {
                queryStr += string.Format("'{0}',", obj.InputId);
            }
            if (!string.IsNullOrEmpty(obj.IngredientId))
            {
                queryStr += string.Format("'{0}',", obj.IngredientId);
            }
            if (!string.IsNullOrEmpty(obj.IngredientExpDate))
            {
                queryStr += string.Format("'{0}',", obj.IngredientExpDate);
            }
            if (!string.IsNullOrEmpty(obj.IngredientQty))
            {
                queryStr += string.Format("'{0}',", obj.IngredientQty);
            }
            if (!string.IsNullOrEmpty(obj.IngredientPrice))
            {
                queryStr += string.Format("'{0}',", obj.IngredientPrice);
            }
            if (!string.IsNullOrEmpty(obj.IngredientVat))
            {
                queryStr += string.Format("'{0}',", obj.IngredientVat);
            }
            if (!string.IsNullOrEmpty(obj.IngredientDiscount))
            {
                queryStr += string.Format("'{0}'", obj.IngredientDiscount);
            }
            queryStr += ")";
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;

        }

    }
}
