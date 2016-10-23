using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Data;

namespace VVPosM1.BusinessLayer
{
    public class rptDoanhThuBLL
    {
        
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

//        public List<rptDoanhThu> ReadListFromAutoComplete(string str)
//        {
//            List<rptDoanhThu> res = new List<rptDoanhThu>();
//            try
//            {
             
//                DataSet ds = new DataSet();
//                string query = @"SELECT *
//                            FROM `employee` a INNER JOIN `objects` b ON a.`ObjectId`=b.`ObjectId`
//                            WHERE a.`empoyeeId` LIKE '%" + str + "%' OR b.`FullName` LIKE '%" + str + "%'";
//                //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
//                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
//                if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
//                {
//                    foreach (DataRow dr in ds.Tables[0].Rows)
//                    {
//                        rptDoanhThu ob = new rptDoanhThu();
//                        ob.EmployeeId = dr["EmployeeId"].ToString();
//                        ob.FullName = dr["FullName"].ToString();
                        
//                        res.Add(ob);
//                    }
//                }
//                else
//                {
//                    res = null;
//                }
//            }
//            catch (Exception e)
//            {
//                res = null;
//            }
//            return res;
//        }


        public DataTable GetUser()
        {
            DataTable res;
            DataSet ds = new DataSet();
           
            string query = @"SELECT *
                           FROM `employees` Where `UserName`!=''";
            
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

//        public DataTable GetUser()
//        {
//            DataTable res = new DataTable();
//            DataSet ds = new DataSet();
            
//            string query = @"SELECT *
//                            FROM users";
//            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
//            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
//            if (string.IsNullOrEmpty(errorString))
//            {
//                res = ds.Tables[0];
//            }
//            else
//            {
//                res = null;
//            }

//            return res;
//        }

        public DataTable GetReportSTT(string userID,string tuNgay,string denNgay, int check)
        {string dateStart= tuNgay;
            string dateEnd=denNgay;
            
            DataTable dt = new DataTable("rptDoanhThu");
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
            column1.ColumnName = "FullName";
            dt.Columns.Add(column1);
         
            // // 
            //DataColumn column2 = new DataColumn();
            //column2.DataType = Type.GetType("System.String");
            //column2.ColumnName = "Status";
            //dt.Columns.Add(column2);
            // // 
            DataColumn column2 = new DataColumn();
            column2.DataType = Type.GetType("System.String");
            column2.ColumnName = "TotalAmountBeforeTax";
            dt.Columns.Add(column2);
            // // 
            DataColumn column3 = new DataColumn();
            column3.DataType = Type.GetType("System.String");
            column3.ColumnName = "TotalTax";
            dt.Columns.Add(column3);
            // // 
            DataColumn column4 = new DataColumn();
            column4.DataType = Type.GetType("System.String");
            column4.ColumnName = "TotalAmount";
            dt.Columns.Add(column4);
            // // 
            DataColumn column5 = new DataColumn();
            column5.DataType = Type.GetType("System.String");
            column5.ColumnName = "DiscountAmount";
            dt.Columns.Add(column5);
            // // 
            DataColumn column6 = new DataColumn();
            column6.DataType = Type.GetType("System.String");
            column6.ColumnName = "TotalMoney";
            dt.Columns.Add(column6);
            // // 
          

            DataTable dt1 = GetReport(userID,tuNgay,denNgay, check);
            if (dt1 != null)
            {
                string str;
                int i = 0;
                foreach (DataRow dr in dt1.Rows)
                {
                    DataRow dra = dt.NewRow();
                    dra["STT"] = (i + 1).ToString();
                    dra["FullName"] = Common.clsLanguages.GetResource("EmployeeCode") + ": " + dr["UserName"].ToString() + "\n" + Common.clsLanguages.GetResource("EmployeeName") + ": " + dr["EmployeeName"].ToString();
                    
                    //str = "";
                    //if (dr["Status"].ToString() == "0")
                    //    str = VVPosM1.Common.clsLanguages.GetResource("Status_0");
                    //if (dr["Status"].ToString() == "1")
                    //    str = VVPosM1.Common.clsLanguages.GetResource("Status_1");
                    //if (dr["Status"].ToString() == "2")
                    //    str = VVPosM1.Common.clsLanguages.GetResource("Status_2");
                    //dra["Status"] = str;
                    
                    //string a1 = string.Format("{0:0,0}", dr["DoanhThuTruocThue"]);
                    //dra["TotalAmountBeforeTax"] = a1.Replace(".", ",");
                    dra["TotalAmountBeforeTax"] = String.Format("{0:0.##}", double.Parse(dr["DoanhThuTruocThue"].ToString()));
                                        
                    //string a2 = string.Format("{0:0,0}", dr["TongTienThue"]);
                    //dra["TotalTax"] = a2.Replace(".", ",");
                    dra["TotalTax"] = String.Format("{0:0.##}", double.Parse(dr["TongTienThue"].ToString()));

                    //string a3 = string.Format("{0:0,0}", dr["TongTien"]);
                    //dra["TotalAmount"] = a3.Replace(".", ",");                   
                    dra["TotalAmount"] = String.Format("{0:0.##}", double.Parse(dr["TongTien"].ToString()));

                    //string a4 = string.Format("{0:0,0}", dr["TongTienGiamGia"]);
                    //dra["DiscountAmount"] = a4.Replace(".", ",");
                    dra["DiscountAmount"] = String.Format("{0:0.##}", double.Parse(dr["TongTienGiamGia"].ToString()));

                    //string a5 = string.Format("{0:0,0}", dr["DoanhThuCuoi"]);
                    //dra["TotalMoney"] = a5.Replace(".", ",");
                    dra["TotalMoney"] = String.Format("{0:0.##}", double.Parse(dr["DoanhThuCuoi"].ToString()));

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
        public DataTable GetReport(string userID,string tuNgay, string denNgay, int check)
        {
           
            DataTable res= new DataTable();
            DataSet ds = new DataSet();
            string query = @" SELECT b.`EmployeeName`,b.`UserName`,SUM(a.`TotalMoney`) AS `DoanhThuCuoi`, SUM(a.`TotalAmountBeforeTax`) AS `DoanhThuTruocThue`, SUM(a.`TotalTax`) AS `TongTienThue`, SUM(a.`DiscountAmount`) AS `TongTienGiamGia`, SUM(a.`TotalAmount`) AS `TongTien`
                         FROM `receipts` a                         
                         INNER JOIN `employees` b
                          ON a.`CreatedBy`=b.`UserName`                        
                          WHERE a.`CreatedBy` IN (" + userID + ") ";
            if(check!=0){
             query +="AND DATE(a.`CreatedDate`) BETWEEN  '" + tuNgay + "' AND '" + denNgay + "' ";
            }
             query += "GROUP BY a.`CreatedBy`";

            //SELECT * ,SUM(a.`TotalAmount`) AS `Doanh Thu`
            //                FROM `receipts` a INNER JOIN `users` b ON a.`CreatedBy`=b.`UserId`                                             
            //                GROUP BY `ReceiptId`

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
