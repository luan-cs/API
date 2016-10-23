using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Data;
using System.Configuration;
using VVPosM1.BusinessLayer;
using System.Drawing;
using System.IO;

namespace VVPosM1.BusinessLayer
{
    public class ProductsBLL : IObjectBLL<Products>
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
            int limit = (page - 1) * RecordPerPage;
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
                if (string.IsNullOrEmpty(errorString))
                {
                    TotalRecord = string.IsNullOrEmpty(dataset1.Tables["Products1"].Rows[0]["TotalRecord"].ToString()) ? 0 : int.Parse(dataset1.Tables["Products1"].Rows[0]["TotalRecord"].ToString());
                }
            }
            else
            {
                res = null;
            }



            return res;

        }

        public DataTable GetProductType()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `productgroup` ";
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

        public DataTable SearchProducts(Products pro, int page, out int TotalRecord)
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
                new string[] { "p_ProductId", string.IsNullOrEmpty(pro.ProductId)?null:pro.ProductId },
                new string[] { "p_Name", string.IsNullOrEmpty(pro.ProductName)?null: pro.ProductName },
                new string[] { "p_ProductType", string.IsNullOrEmpty(pro.ProductGroupId)?null: pro.ProductGroupId },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearchProductL", ref ds, param, ref errorString);

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
        public DataTable GetProductTypeId(string id)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `productgroup`
                            WHERE `ProductGroupId`='" + id + "'";
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
        public Products GetProductWithID(string id)
        {
            Products reEmp = new Products();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `product`
                            WHERE `ProductId`='" + id + "' ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reEmp.ProductId = ds.Tables[0].Rows[0]["ProductId"].ToString();
                reEmp.ProductName = ds.Tables[0].Rows[0]["ProductName"].ToString();
                reEmp.Price = ds.Tables[0].Rows[0]["Price"].ToString();
                reEmp.ProductGroupId = ds.Tables[0].Rows[0]["ProductGroupId"].ToString();
                //reEmp.ProductType = ds.Tables[0].Rows[0]["ProductType"].ToString();
                //reEmp.Notes = ds.Tables[0].Rows[0]["Notes"].ToString();
                //reEmp.Image = ds.Tables[0].Rows[0]["Image"].ToString();
                //reEmp.CreateBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                //reEmp.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                //reEmp.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                //reEmp.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();



            }
            else
            {

                reEmp = null;
            }
            return reEmp;
        }

        public int Update(Products employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE product SET ";

            if (!string.IsNullOrEmpty(employ.ProductName))
            {
                queryStr += string.Format(" ProductName = '{0}',", employ.ProductName);
            }
            queryStr += string.Format(" ProductGroupId = '{0}',", employ.ProductGroupId);
            queryStr += string.Format(" Price = '{0}',", employ.Price);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }
        public string Tao_ProductID()
        {
            string st = "03";
            string s_thang = "";
            string s_nam = "";
            //string tempStr = "";
            //int intStr = 0;

            //lay thang + nam hien tai
            int thang = DateTime.Now.Month;
            if (thang < 10)
                s_thang = "0" + thang.ToString();
            else
                s_thang = thang.ToString();
            int nam = DateTime.Now.Year;
            s_nam = (nam.ToString()).Substring(2);

            st = st + s_nam + s_thang;
            // 01 14 07
            int stt = 0;
            string SQLstr = @"SELECT `ProductId` AS `Code` 
	                        FROM  `product`
	                        WHERE LEFT(`ProductId`,6)= '" + st + "' ORDER BY `ProductId`;";
            DataSet ds = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, SQLstr, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow d = dt.Rows[i];
                        //  01 14 07 000001
                        stt = int.Parse((d["Code"].ToString()).Substring(6));//////////////
                        if (stt != i + 1)
                        {
                            stt = i + 1;
                            break;
                        }
                    }
                    // MessageBox.Show(i.ToString());
                    if (i == dt.Rows.Count)
                    {
                        stt = dt.Rows.Count + 1;
                    }
                }
                else
                {
                    stt = 1;
                }
            }
            else
            {
                stt = 1;
            }
            string s_stt = "";
            if (stt < 10)
                s_stt = "00000" + stt.ToString();
            else if ((stt < 100) && (stt >= 10))
                s_stt = "0000" + stt.ToString();
            else if ((stt < 1000) && (stt >= 100))
                s_stt = "000" + stt.ToString();
            else if ((stt < 10000) && (stt >= 1000))
                s_stt = "00" + stt.ToString();
            else if ((stt < 100000) && (stt >= 10000))
                s_stt = "0" + stt.ToString();
            else
                s_stt = stt.ToString();
            //xet sau ky tu cuoi
            //foreach (var str in obj.ObjectId)
            //{
            //    tempStr = tempStr.Substring(9, str.ToString().Length - 8);
            //    intStr = int.Parse(tempStr) + 1;
            //    if (intStr < 1000000)
            //    {
            //        tempStr = intStr.ToString();
            //        intStr = tempStr.Length;
            //        while (intStr <= tempStr.Length)
            //        {
            //            tempStr = "0" + tempStr;
            //        }
            //    }
            //}
            st += s_stt;
            return st;
        }

        public int Update(Employees employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE employees SET ";

            if (!string.IsNullOrEmpty(employ.EmployeeCode))
            {
                queryStr += string.Format(" EmployeeCode = '{0}',", employ.EmployeeCode);
            }
            if (!string.IsNullOrEmpty(employ.ObjectId))
            {
                queryStr += string.Format(" ObjectId = '{0}',", employ.ObjectId);
            }
            if (!string.IsNullOrEmpty(employ.Notes))
            {
                queryStr += string.Format(" Notes = '{0}',", employ.Notes);
            }
            if (!string.IsNullOrEmpty(employ.Status))
            {
                queryStr += string.Format(" Status = '{0}',", employ.Status);
            }
            if (!string.IsNullOrEmpty(employ.PositionId))
            {
                queryStr += string.Format(" PositionId = '{0}',", employ.PositionId);
            }
            queryStr += string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += string.Format(" WHERE EmployeeId = '{0}'", employ.EmployeeId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }


        public int Insert(Products employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " product (";
            if (!string.IsNullOrEmpty(employ.ProductId))
            {
                queryStr += "`ProductId`,";
            }
            if (!string.IsNullOrEmpty(employ.ProductName))
            {
                queryStr += "`ProductName`,";
            }
            if (!string.IsNullOrEmpty(employ.ProductGroupId))
            {
                queryStr += "`ProductGroupId`,";
            }
            if (!string.IsNullOrEmpty(employ.Price))
            {
                queryStr += "`Price`";
            }
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(employ.ProductId))
            {
                queryStr += string.Format("'{0}',", employ.ProductId);
            }
            if (!string.IsNullOrEmpty(employ.ProductName))
            {
                queryStr += string.Format("'{0}',", employ.ProductName);
            }
            if (!string.IsNullOrEmpty(employ.ProductGroupId))
            {
                queryStr += string.Format("'{0}',", employ.ProductGroupId);
            }
            if (!string.IsNullOrEmpty(employ.Price))
            {
                queryStr += string.Format("'{0}'", employ.Price);
            }
            queryStr += ")";
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;

        }
        public int SaveImageIntoWeb(Image img, string ObjectId, string Image)
        {
            //1: Thanh cong
            //0: That bai
            int res = 0;
            byte[] imgBuffer = imageToByteArray(img);
            Program.destopService.SaveImage_IntoProduct(imgBuffer, ObjectId, Image, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;

            }
            return res;
        }
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public int Delete(string id)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("DELETE FROM product WHERE Productid = '{0}'", id);
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
