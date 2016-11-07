using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.IO;


namespace VVPosM1.BusinessLayer
{
    class rptByProductBLL
    {
        #region Biến
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        private bool res = false;

        public bool Res
        {
            get { return res; }
            set { res = value; }
        }


        #endregion
        public DataTable GetProduct()
        {


            string query = @"SELECT *
                            FROM `products`                          
                                ";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "product", ref errorString);

            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["product"].Rows.Count != 0)
            {
                DataTable dt = new DataTable("product");
                dt = dataset.Tables[0];
                return dt;
            }
            else
            {
                return null;
            }
        }

        //load loại sản phẩm
        public DataTable GetProductType()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT b.`ProductType`,d.`StrValue1`                            
                               
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`                                               
						    INNER JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId`
						    WHERE d.`CommonTypeId`='ProductType'
                          
                            GROUP BY b.`ProductType`                   
                            ";
            //                           WHERE `CommonTypeId`='ProductType'
            //  INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
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

      

        public DataTable GetProductList(string ProductId)
        {


            string query = @"SELECT *
                FROM `products`                            
                             ";
            if (ProductId != "")
            {
                query += "WHERE `ProductId`=" + ProductId;
            }
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "product", ref errorString);

            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["product"].Rows.Count != 0)
            {
                DataTable dt = new DataTable("product");
                dt = dataset.Tables[0];
                return dt;
            }
            else
            {
                return null;
            }
        }


        public DataTable GetReportSTT(string productID, string tuNgay, string denNgay)
        {
          DataTable dt = new DataTable("rptByProduct");
            // // Create second column.
            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "STT";
            dt.Columns.Add(column);

            // // 
            //DataColumn column1 = new DataColumn();
            //column1.DataType = Type.GetType("System.String");
            //column1.ColumnName = "EmployeeId";
            //dt.Columns.Add(column1);


            //// // 
            DataColumn column1 = new DataColumn();
            column1.DataType = Type.GetType("System.String");
            column1.ColumnName = "TTSPham";
            dt.Columns.Add(column1);

            // // 
            DataColumn column2 = new DataColumn();
            column2.DataType = Type.GetType("System.String");
            column2.ColumnName = "TotalQty";
            dt.Columns.Add(column2);
            // // 
            DataColumn column3 = new DataColumn();
            column3.DataType = Type.GetType("System.String");
            column3.ColumnName = "TotalAmountBeforeTax";
            dt.Columns.Add(column3);

            // // 
            DataColumn column4 = new DataColumn();
            column4.DataType = Type.GetType("System.String");
            column4.ColumnName = "TotalAmount";
            dt.Columns.Add(column4);
            // // 
            DataColumn column5 = new DataColumn();
            column5.DataType = Type.GetType("System.String");
            column5.ColumnName = "TaxAmount";
            dt.Columns.Add(column5);

            DataTable dt1 = GetReport(productID, tuNgay, denNgay);
            if (dt1 != null)
            {
                string str;
                int i = 0;
                foreach (DataRow dr in dt1.Rows)
                {
                    DataRow dra = dt.NewRow();
                    dra["STT"] = (i + 1).ToString();
                    dra["TTSPham"] = Common.clsLanguages.GetResource("ProductID")+": " + dr["ProductId"].ToString() + "\n"+Common.clsLanguages.GetResource("ProductName")+": " + dr["Name"].ToString();

                    //string a1 = string.Format("{0:###,###,###}", dr["SoLuong"]);
                    //dra["TotalQty"] = a1.Replace(".", ",");
                    dra["TotalQty"] = String.Format("{0:0.##}", double.Parse(dr["SoLuong"].ToString()));

                    //string a2 = string.Format("{0:###,###,###}", dr["TongTienTruocThue"]);
                    //dra["TotalAmountBeforeTax"] = a2.Replace(".", ",");
                     dra["TotalAmountBeforeTax"] = String.Format("{0:0.##}", double.Parse(dr["TongTienTruocThue"].ToString()));
                   // dra["TotalAmountBeforeTax"] = String.Format("{0:0}", double.Parse(dr["TongTienTruocThue"].ToString()));
                   // dra["TotalAmountBeforeTax"] = double.Parse(dr["TongTienTruocThue"].ToString());

                    //string a3 = string.Format("{0:0,0}", dr["TongTienThue"]);
                    //dra["TaxAmount"] = a3.Replace(".", ",");
                    dra["TaxAmount"] = String.Format("{0:0.##}", double.Parse(dr["TongTienThue"].ToString()));

                    //string a4 = string.Format("{0:###,###,###}", dr["DoanhThu"]);
                    //dra["TotalAmount"] = a4.Replace(".", ",");
                    dra["TotalAmount"] = String.Format("{0:0.##}", double.Parse(dr["DoanhThu"].ToString()));

                    dt.Rows.Add(dra);
                    i++;
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public DataTable GetReportSTTGroup(string productID, string tuNgay, string denNgay)
        {
            DataTable dt = new DataTable("rptByProduct");
            // // Create second column.
            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "STT";
            dt.Columns.Add(column);

            // // 
            //DataColumn column1 = new DataColumn();
            //column1.DataType = Type.GetType("System.String");
            //column1.ColumnName = "EmployeeId";
            //dt.Columns.Add(column1);


            //// // 
            DataColumn column1 = new DataColumn();
            column1.DataType = Type.GetType("System.String");
            column1.ColumnName = "TTSPham";
            dt.Columns.Add(column1);

            // // 
            DataColumn column2 = new DataColumn();
            column2.DataType = Type.GetType("System.String");
            column2.ColumnName = "TotalQty";
            dt.Columns.Add(column2);
            // // 
            DataColumn column3 = new DataColumn();
            column3.DataType = Type.GetType("System.String");
            column3.ColumnName = "TotalAmountBeforeTax";
            dt.Columns.Add(column3);

            // // 
            DataColumn column4 = new DataColumn();
            column4.DataType = Type.GetType("System.String");
            column4.ColumnName = "TotalAmount";
            dt.Columns.Add(column4);
            // // 
            DataColumn column5 = new DataColumn();
            column5.DataType = Type.GetType("System.String");
            column5.ColumnName = "TaxAmount";
            dt.Columns.Add(column5);

            DataTable dt1 = GetReportGroup(productID, tuNgay, denNgay);
            if (dt1 != null)
            {
                string str;
                int i = 0;
                foreach (DataRow dr in dt1.Rows)
                {
                    DataRow dra = dt.NewRow();
                    dra["STT"] = (i + 1).ToString();
                    dra["TTSPham"] = Common.clsLanguages.GetResource("GroupId")+": " + dr["ProductType"].ToString() + "\n"+Common.clsLanguages.GetResource("GroupId")+":" + dr["StrValue1"].ToString();


                    string a1 = string.Format("{0:###,###,###}", dr["SoLuong"]);
                    dra["TotalQty"] = a1.Replace(".", ",");



                    string a2 = string.Format("{0:###,###,###}", dr["TongTienTruocThue"]);
                    dra["TotalAmountBeforeTax"] = a2.Replace(".", ",");


                    string a3 = string.Format("{0:0,0}", dr["TongTienThue"]);
                    dra["TaxAmount"] = a3.Replace(".", ",");



                    string a4 = string.Format("{0:###,###,###}", dr["DoanhThu"]);
                    dra["TotalAmount"] = a4.Replace(".", ",");
                    dt.Rows.Add(dra);
                    i++;
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        public DataTable GetReport(string productID, string tuNgay, string denNgay)
        {

            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT a.`ProductId`, b.`Name`,                              
                                SUM(a.`TotalAmount`) AS `DoanhThu`,
                                SUM(a.`Qty`) AS `SoLuong`,
                                SUM(a.`TaxAmount`) AS `TongTienThue`,
                                SUM(a.`TotalAmountBeforeTax`)AS `TongTienTruocThue`
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId` WHERE";                         
                            query +=  " DATE(a.`CreatedDate`) BETWEEN  '" + tuNgay + "' AND '" + denNgay+"'";
             if(productID!="")
             {
                 query  += " AND a.`ProductId` = '" + productID +"'"; 
             }
             query += "GROUP BY a.`ProductId`";
        
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

        // tính tổng theo sản phẩm
        public DataTable GetReportTong(string productID, string tuNgay, string denNgay)
        {

            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT a.`ProductId`, b.`Name`,                              
                                SUM(a.`TotalAmount`) AS `DoanhThu`,
                                SUM(a.`Qty`) AS `SoLuong`,
                                SUM(a.`TaxAmount`) AS `TongTienThue`,
                                SUM(a.`TotalAmountBeforeTax`)AS `TongTienTruocThue`
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId` WHERE";
            query += " DATE(a.`CreatedDate`) BETWEEN  '" + tuNgay + "' AND '" + denNgay + "'";
            if (productID != "")
            {
                query += " AND a.`ProductId` = '" + productID + "'";
            }
           

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

        public DataTable GetReportGroup(string productID, string tuNgay, string denNgay)
        {

            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT a.`ProductId`, b.`ProductType`,d.`StrValue1`,                              
                                SUM(a.`TotalAmount`) AS `DoanhThu`,
                                SUM(a.`Qty`) AS `SoLuong`,
                                SUM(a.`TaxAmount`) AS `TongTienThue`,
                                SUM(a.`TotalAmountBeforeTax`)AS `TongTienTruocThue`
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId` 
                                                        WHERE d.`CommonTypeId`='ProductType' AND";
            query += " DATE(a.`CreatedDate`) BETWEEN  '" + tuNgay + "' AND '" + denNgay + "'";
            query += " AND a.`Status` = '1' ";
            if (productID != "")
            {
                query += " AND b.`ProductType` = '" + productID + "'";
            }
            query += "GROUP BY b.`ProductType`";

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

        //tong group
        public DataTable GetReportGroupTong(string productID, string tuNgay, string denNgay)
        {

            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT a.`ProductId`, b.`ProductType`,d.`StrValue1`,                              
                                SUM(a.`TotalAmount`) AS `DoanhThu`,
                                SUM(a.`Qty`) AS `SoLuong`,
                                SUM(a.`TaxAmount`) AS `TongTienThue`,
                                SUM(a.`TotalAmountBeforeTax`)AS `TongTienTruocThue`
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId` 
                                                        WHERE d.`CommonTypeId`='ProductType' AND";
            query += " DATE(a.`CreatedDate`) BETWEEN  '" + tuNgay + "' AND '" + denNgay + "'";
            query += " AND a.`Status` = '1' ";
            if (productID != "")
            {
                query += " AND b.`ProductType` = '" + productID + "'";
            }
           

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
