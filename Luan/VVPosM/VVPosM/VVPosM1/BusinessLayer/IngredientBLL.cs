using System;
using System.Collections.Generic;
using System.Configuration;
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



    public DataTable SearchIngredient(Ingreadient sup, int page, out int TotalRecord)
    {
        int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
        int limit = (page - 1) * RecordPerPage;
        //int offset = limit + RecordPerPage;
        TotalRecord = 0;
        DataTable res = new DataTable();
        DataSet ds = new DataSet();

        ///p_CreateBy	VARCHAR(20),
        //p_CreatedDate	DATETIME,
        //p_ModifiedBy	VARCHAR(20), p_SupplierId 		VARCHAR(20)  ,
        string[][] param ={
                new string[] { "p_IngredientId", string.IsNullOrEmpty(sup.IngredientId)?null:sup.IngredientId },
                new string[] { "p_IngredientName", string.IsNullOrEmpty(sup.IngredientName)?null:sup.IngredientName },
                new string[] { "p_IngredientMeasure", string.IsNullOrEmpty(sup.IngredientMeasure)?null: sup.IngredientMeasure },
                new string[] { "p_IngredientExchange", string.IsNullOrEmpty(sup.IngredientExchange )?null: sup.IngredientExchange },
                new string[] { "p_IngredientUnit", string.IsNullOrEmpty(sup.IngredientUnit )?null: sup.IngredientUnit },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

        Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Ingredients", ref ds, param, ref errorString);

        if (string.IsNullOrEmpty(errorString))
        {
            res = ds.Tables[0];
            TotalRecord = int.Parse(ds.Tables[1].Rows[0][0].ToString());
        }
        else
        {
            res = null;
        }

        return res;

    }

    public Ingreadient GetIngredientWithID(string id)
    {
            Ingreadient reEmp = new Ingreadient();
        DataSet ds = new DataSet();
        string query = @"SELECT *
                            FROM `ingredient`
                            WHERE `IngredientId`='" + id + "' ";
        //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
        Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
        if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
        {
            reEmp.IngredientId = ds.Tables[0].Rows[0]["IngredientId"].ToString();
            reEmp.IngredientName = ds.Tables[0].Rows[0]["IngredientName"].ToString();
            reEmp.IngredientMeasure = ds.Tables[0].Rows[0]["IngredientMeasure"].ToString();
            reEmp.IngredientExchange = ds.Tables[0].Rows[0]["IngredientExchange"].ToString();
            reEmp.IngredientUnit = ds.Tables[0].Rows[0]["IngredientUnit"].ToString();
            reEmp.IntakeUnit = ds.Tables[0].Rows[0]["IntakeUnit"].ToString();
            }
        else
        {

            reEmp = null;
        }

        return reEmp;
    }

    public int UpdateIngredient(Ingreadient employ)
    {
        /// 1: update thành công
        /// 0: Update ko thành công
        int res = 0;
        string queryStr = "UPDATE ingredient SET ";

        if (!string.IsNullOrEmpty(employ.IngredientName))
        {
            queryStr += string.Format(" IngredientName = '{0}',", employ.IngredientName);
        }
        //if (!string.IsNullOrEmpty(employ.Unit))
        //{
        queryStr += string.Format(" IngredientMeasure = '{0}',", employ.IngredientMeasure);
        //}
        //if (!string.IsNullOrEmpty(employ.Notes))
        //{
        queryStr += string.Format(" IngredientExchange = '{0}',", employ.IngredientExchange);
        //}
        queryStr += string.Format(" IngredientUnit = '{0}',", employ.IngredientUnit);
        queryStr += string.Format(" IntakeUnit = '{0}'", employ.IntakeUnit);

            queryStr += string.Format(" WHERE IngredientId = '{0}'", employ.IngredientId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);

        if (string.IsNullOrEmpty(errorString))
        {
            res = 1;
        }

        return res;
    }
    public string CreateSupplierId()
    {
        string supplierId = string.Empty;
        DataTable res = new DataTable();
        DataSet dataset = new DataSet();
        string sqlStr = "SELECT `IngredientId` FROM `ingredient` WHERE SUBSTRING(`IngredientId`, 3, 8) = CURDATE() + 0 ORDER BY `IngredientId` DESC LIMIT 0,1; ";

        Program.destopService.DataQuery(Program.Username, Program.Password, sqlStr, ref dataset, "x", ref errorString);

        if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
        {
            res = dataset.Tables[0];
            supplierId = (Int64.Parse(res.Rows[0][0].ToString()) + 1).ToString();
        }
        else
        {
            supplierId = "99" + DateTime.Today.ToString("yyyyMMdd") + "00001";
        }

        return supplierId;
    }

    public int InsertIngredient(Ingreadient employ)
    {
        /// 1: update thành công
        /// 0: Update ko thành công

        int res = 0;
        string queryStr = "INSERT INTO";
        queryStr += " ingredient (";
        if (!string.IsNullOrEmpty(employ.IngredientId))
        {
            queryStr += "`IngredientId`,";
        }
        if (!string.IsNullOrEmpty(employ.IngredientName))
        {
            queryStr += "`IngredientName`,";
        }
        if (!string.IsNullOrEmpty(employ.IngredientMeasure))
        {
            queryStr += "`IngredientMeasure`,";
        }
        if (!string.IsNullOrEmpty(employ.IngredientExchange))
        {
            queryStr += "`IngredientExchange`,";
        }
        if (!string.IsNullOrEmpty(employ.IngredientUnit))
        {
            queryStr += "`IngredientUnit`,";
        }
            queryStr += "`IntakeUnit`";

            queryStr += ") VALUES (";

        if (!string.IsNullOrEmpty(employ.IngredientId))
        {
            queryStr += string.Format("'{0}',", employ.IngredientId);
        }
        if (!string.IsNullOrEmpty(employ.IngredientName))
        {
            queryStr += string.Format("'{0}',", employ.IngredientName);
        }
        if (!string.IsNullOrEmpty(employ.IngredientMeasure))
        {
            queryStr += string.Format("'{0}',", employ.IngredientMeasure);
        }
        if (!string.IsNullOrEmpty(employ.IngredientExchange))
        {
            queryStr += string.Format("'{0}',", employ.IngredientExchange);
        }
        if (!string.IsNullOrEmpty(employ.IngredientUnit))
        {
            queryStr += string.Format("'{0}',", employ.IngredientUnit);
        }
            queryStr += string.Format("'{0}'", employ.IntakeUnit);
            queryStr += ")";
        Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        if (string.IsNullOrEmpty(errorString))
        {
            res = 1;
        }
        return res;

    }

    public int DeleteIngredient(string id)
    {
        /// 1: xóa thành công
        /// 0: xóa ko thành công
        int res = 0;
        string queryStr = string.Format("DELETE FROM ingredient WHERE IngredientId = '{0}'", id);
        Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        if (string.IsNullOrEmpty(errorString))
        {
            res = 1;
        }
        return res;
    }
  }
}
