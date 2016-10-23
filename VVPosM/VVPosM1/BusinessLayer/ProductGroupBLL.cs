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
    public class ProductGroupBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }

        }

        public DataTable SearchProductGroup(ProductGroup pro, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            ///p_CreateBy	VARCHAR(20),
            //p_CreatedDate	DATETIME,
            //p_ModifiedBy	VARCHAR(20),
            string[][] param ={
                new string[] { "p_ProductGroupId", string.IsNullOrEmpty(pro.ProductGroupId)?null:pro.ProductGroupId },
                new string[] { "p_Name", string.IsNullOrEmpty(pro.ProductGroupName)?null: pro.ProductGroupName },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearchProductGroupL", ref ds, param, ref errorString);

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

        public ProductGroup GetProductGroupId(string id)
        {
            ProductGroup pro = new ProductGroup();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `productgroup`
                            WHERE `ProductGroupId`='" + id + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
               pro.ProductGroupId = ds.Tables[0].Rows[0]["ProductGroupId"].ToString();
                pro.ProductGroupName = ds.Tables[0].Rows[0]["ProductGroupName"].ToString();
            }
            else
            {
                pro = null;
            }
            return pro;
        }

        public int DeleteProduct(string id)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("DELETE FROM product WHERE ProductGroupId = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Delete(string id)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("DELETE FROM productgroup WHERE ProductGroupid = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Update(ProductGroup employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE productgroup SET ";

            if (!string.IsNullOrEmpty(employ.ProductGroupName))
            {
                queryStr += string.Format(" ProductGroupName = '{0}',", employ.ProductGroupName);
            }
            queryStr += string.Format(" WHERE ProductGroupId = '{0}'", employ.ProductGroupId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }


        public int Insert(ProductGroup employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " productgroup (";
            if (!string.IsNullOrEmpty(employ.ProductGroupName))
            {
                queryStr += "`ProductGroupName`";
            }
            
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(employ.ProductGroupName))
            {
                queryStr += string.Format("'{0}'", employ.ProductGroupName);
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
