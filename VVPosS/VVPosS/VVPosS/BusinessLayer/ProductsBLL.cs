using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosS.Entities;
using System.Data;
using System.Configuration;

namespace VVPosS.BusinessLayer
{
    public class ProductsBLL:IObjectBLL<Products>
    {

        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        /// <summary>
        /// Get list products
        /// </summary>
        /// <returns></returns>
        public DataTable GetLists(string sCondition, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecord"]);
            int limit = (page-1)*RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable(); 
            string query = @"SELECT 
                                    products.ProductId,
                                    products.Name,
                                    products.Unit,
                                    products.Image,
                                    products.IsPrint,
                                    products.Notes,
                                    products.CreatedDate,
                                    products.IsDelete,
                                    products.CreatedBy,
                                    products.ModifiedDate,
                                    products.ModifiedBy,
                                    products.ProductType,
                                    commoncode.CommonId,
                                    commoncode.StrValue1   

                            FROM products LEFT JOIN commoncode ON products.ProductType = commoncode.CommonId 
                            WHERE products.IsDelete = '0'
                            AND commoncode.`CommonTypeId`='ProductType' ";
            if (sCondition != "") query += " AND ProductType ='" + sCondition + "'";
            query += " LIMIT " + limit + "," + RecordPerPage;
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Products", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = dataset.Tables["Products"];
                /////////////////////
                string query1 = @"SELECT COUNT(*) AS TotalRecord
                            FROM products LEFT JOIN commoncode ON products.ProductType = commoncode.CommonId 
                            WHERE products.IsDelete = '0' AND commoncode.`CommonTypeId`='ProductType' ";
                if (sCondition != "") query1 += " AND ProductType ='" + sCondition + "'";
                DataSet dataset1 = new DataSet();
                Program.destopService.DataQuery(Program.Username, Program.Password, query1, ref dataset1, "Products1", ref errorString);
                if(string.IsNullOrEmpty(errorString)){
                    TotalRecord = string.IsNullOrEmpty(dataset1.Tables["Products1"].Rows[0]["TotalRecord"].ToString()) ? 0 : int.Parse(dataset1.Tables["Products1"].Rows[0]["TotalRecord"].ToString());
                }
            }
            else
            {
                res = null;
            }

            

            return res;
           
        }

        public DataTable GetList(string ProductType, int page, out int TotalRecord) {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecord"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            string[][] param = {
                new string[] { "p_ProductType", string.IsNullOrEmpty(ProductType)? null:ProductType},
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGetProducts", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                dt = ds.Tables[0];
                TotalRecord = int.Parse(ds.Tables[1].Rows[0][0].ToString());
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public DataTable GetListNotBuffet(string ProductType, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecord"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            string[][] param = {
                new string[] { "p_ProductType", string.IsNullOrEmpty(ProductType)? null:ProductType},
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGetProductsNotBuffet", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                dt = ds.Tables[0];
                TotalRecord = int.Parse(ds.Tables[1].Rows[0][0].ToString());
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public string GetProductName(string ProID)
        {
            //Tuple<string, string> TpS = new Tuple<string, string>();
            string res = "";
            DataTable dt = new DataTable();
            string query = @"SELECT *
                            FROM `products`
                            WHERE  `ProductId` ='" + ProID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Products", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
            {
                dt = dataset.Tables["Products"];
                res = dt.Rows[0]["name"].ToString();
            }
            else
            {
                res = null;
            }
            return res;
           // return t
        }

        public Tuple<string, string> GetProductInfoForReceipt(string ProID)
        {
            string sName = "", sType = "", isbuffet = "";
            DataTable dt = new DataTable();
            string query = @"SELECT *
                            FROM `products`
                            WHERE  `ProductId` ='" + ProID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Products", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
            {
                dt = dataset.Tables["Products"];
                sName = dt.Rows[0]["Name"].ToString();
                sType = dt.Rows[0]["ProductType"].ToString();
                //spSelect_Desk_Status_StrValues
                DataSet ds1 = new DataSet();
                string query1 = @"SELECT *
                            FROM `commoncode`
                            WHERE  `CommonTypeId` ='ProductType' AND `CommonId` = '" + sType + "'";
                Program.destopService.DataQuery(Program.Username, Program.Password, query1, ref dataset, "x", ref errorString);
                if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
                {
                    isbuffet = ds1.Tables["x"].Rows[0]["IsBuffet"].ToString();
                }
            }

            return new Tuple<string, string>(sName, isbuffet);
        }
    }
}
