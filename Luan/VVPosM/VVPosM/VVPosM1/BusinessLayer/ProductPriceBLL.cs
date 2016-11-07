using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;

namespace VVPosM1.BusinessLayer
{
    public class ProductPriceBLL:IObjectBLL<ProductPrice>
    {
        private ProductsBLL productsBLL;
        private Products objPro;

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
        public DataTable GetProductsPriceByProductId(string sProductId)
        {
            DataTable res = new DataTable(); 
            string query = @"SELECT `productprice`.`Price`
                            FROM `productprice`
                            WHERE `productprice`.`ProductId` = '"+sProductId+"'";
                   query += @" ORDER BY `productprice`.`Time` DESC
                            LIMIT 0,1 ";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "ProductPrice", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = dataset.Tables["ProductPrice"];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public List<Products> ReadListFromAutoComplete(string str)
        {
            List<Products> res = new List<Products>();
            try
            {
                DataSet ds = new DataSet();
                string query = @"SELECT *
                            FROM `products`
                            WHERE `ProductId` LIKE '%" + str + "%' OR `Name` LIKE '%" + str + "%'";
                //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
                if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Products ob = new Products();
                        ob.ProductId = dr["ProductId"].ToString();
                        ob.Name = dr["Name"].ToString();         
                        res.Add(ob);
                    }
                }
                else
                {
                    res = null;
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }

        public DataTable SearchProductPrice(ProductPrice proPrice, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string[][] param ={
                new string[] { "p_ProductId", string.IsNullOrEmpty(proPrice.ProductId)?null:proPrice.ProductId },
                new string[] { "p_Time", string.IsNullOrEmpty(proPrice.Time)?null:proPrice.Time}, 
                new string[] { "p_Price", string.IsNullOrEmpty(proPrice.Price)?null:double.Parse(proPrice.Price).ToString() },          
                new string[] { "p_CreatedId", string.IsNullOrEmpty(proPrice.CreatedId)?null: proPrice.CreatedId}, 
                
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };


            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_ProPrice", ref ds, param, ref errorString);

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

        public DataTable GetNameTheoProductID(string ProductId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `products`
                            WHERE `ProductId`='" + ProductId + "'";
            
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }
        public DataTable GetRoleNameTheoCreateID(string CreateId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `roles`
                            WHERE `RoleId`='" + CreateId + "'";

            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        // update gia trong product
        public void UpdatePriceInProduct(ProductPrice proPrice)
        {
            string queryStr = "UPDATE `products` ";
            queryStr += " SET `Price` ='" + double.Parse(proPrice.Price).ToString() + "'" + ", `ModifiedDate`= NOW()," + "`ModifiedBy`='" +Program.Username+ "'";
            queryStr += " WHERE `ProductId`='" + proPrice.ProductId + "'";

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);

        }

        public int Insert(ProductPrice proPrice)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " productprice(";
            if (!string.IsNullOrEmpty(proPrice.ProductId))
            {
                queryStr += "`ProductId`,";
            }
            queryStr += "`Time`,";
            if (!string.IsNullOrEmpty(proPrice.Price))
            {
                queryStr += "`Price`,";
            }          
            queryStr += "`CreatedId`";
            
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(proPrice.ProductId))
            {
                queryStr += string.Format("'{0}',", proPrice.ProductId);
            }
            queryStr += " NOW() ,";


            if (!string.IsNullOrEmpty(proPrice.Price))
            {
                queryStr += string.Format("'{0}',", double.Parse(proPrice.Price).ToString());
            }          
            queryStr += string.Format("  '{0}'", Program.Username);
          
            queryStr += ")";
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;

        }

        public ProductPrice GetProPriceWithID(string id)
        {
            ProductPrice reEmp = new ProductPrice();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `ProductPrice`
                            WHERE `ProductId`='" + id + "' ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reEmp.ProductId = ds.Tables[0].Rows[0]["ProductId"].ToString();
                reEmp.Price = ds.Tables[0].Rows[0]["Price"].ToString();

                //Created by Huynh Dung on 27/11/2014
                objPro = new Products();
                productsBLL = new ProductsBLL();
                objPro = productsBLL.GetProductWithID(reEmp.ProductId);

                //reEmp.ProductName = objPro.Name;
           }
            else
            {

                reEmp = null;
            }
            return reEmp;
        }

        public int DeleteNV(string id,string time)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("DELETE FROM `productprice` WHERE  `ProductId` = '{0}'", id);
            queryStr += string.Format(" AND `Time`= '{0}'", time);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public string GetDMY()
        {
            string st = "";
            string s = "";
            int t;
            //lay ngay + thang + nam hien tai
            t = DateTime.Now.Day;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Month;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Year;
            st += (t.ToString()).Substring(2);

            return st;
        }
        public string GetHMS()
        {
            string st = "";
            string s = "";
            int t;
            //lay ngay + thang + nam hien tai
            t = DateTime.Now.Hour;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Minute;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Second;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;

            return st;
        }

    }
}
