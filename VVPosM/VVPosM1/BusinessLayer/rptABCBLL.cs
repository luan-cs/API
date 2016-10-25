using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Data;


namespace VVPosM1.BusinessLayer
{
   public class rptABCBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public DataTable GetReportSTT(DateTime from, DateTime to,double a, double b)
        {
            
            double tongDoanhThu = 0; 
            int tongSoLuong=0;
            double tyLeDoanhThu = 0;
            double tongLuyKe = 0;
            
            DataTable dt = new DataTable("rptABC");
            // // Create second column.
            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "STT";
            dt.Columns.Add(column);

            // // 
            DataColumn column1 = new DataColumn();
            column1.DataType = Type.GetType("System.String");
            column1.ColumnName = "TTSanPham";
            dt.Columns.Add(column1);

            // // 
            DataColumn column2 = new DataColumn();
            column2.DataType = Type.GetType("System.String");
            column2.ColumnName = "DonGia";
            dt.Columns.Add(column2);

            // // 
            DataColumn column3 = new DataColumn();
            column3.DataType = Type.GetType("System.String");
            column3.ColumnName = "DoanhSo";
            dt.Columns.Add(column3);

            // // 
            DataColumn column4 = new DataColumn();
            column4.DataType = Type.GetType("System.String");
            column4.ColumnName = "DoanhThu";
            dt.Columns.Add(column4);
            // // 
            DataColumn column5 = new DataColumn();
            column5.DataType = Type.GetType("System.String");
            column5.ColumnName = "TyLeDoanhThu";
            dt.Columns.Add(column5);
            // // 
            DataColumn column6 = new DataColumn();
            column6.DataType = Type.GetType("System.String");
            column6.ColumnName = "TongLuyKe";
            dt.Columns.Add(column6);
            DataColumn column7 = new DataColumn();
            column7.DataType = Type.GetType("System.String");
            column7.ColumnName = "TyLeLuyKe";
            dt.Columns.Add(column7);
            DataColumn column8 = new DataColumn();
            column8.DataType = Type.GetType("System.String");
            column8.ColumnName = "PhanLoai";
            dt.Columns.Add(column8);

            DataTable dt1 = GetReport(from, to);
            if (dt1 != null)
            {
               
                int i = 0;

                foreach (DataRow dr in dt1.Rows)
                {
                    tongDoanhThu += double.Parse(dr["DoanhThu"].ToString());
                    tongSoLuong += int.Parse(dr["SoLuong"].ToString());
                    
                }
                foreach (DataRow dr in dt1.Rows)
                {
                    double donGiaTB, doanhThu, soLuong;
                    double tyLeLuyKe;
                    string phanLoai;

                // đơn giá trung bình
                    doanhThu = double.Parse(dr["DoanhThu"].ToString());
                    soLuong = double.Parse(dr["SoLuong"].ToString());
                    if (soLuong == 0)
                        {
                            donGiaTB = 0;
                        }
                    else
                        {
                            donGiaTB = doanhThu / soLuong;
                        }

                 // Tỷ lệ doanh thu
                    if (tongDoanhThu == 0) 
                        {
                            tyLeDoanhThu = 0;
                        }
                    else
                        tyLeDoanhThu = doanhThu * 100 / tongDoanhThu;

                    //Tong luy ke
                    tongLuyKe += double.Parse(dr["DoanhThu"].ToString());

                    // tỷ lệ lũy kế
                    if (tongDoanhThu == 0)
                    {
                        tyLeLuyKe = 0;
                    }
                    else
                    {
                        tyLeLuyKe = tongLuyKe * 100 / tongDoanhThu;
                    }
                    
                    // phân loại
                    if(tyLeLuyKe<=a)
                    {
                    phanLoai= "A";
                    }
                    else if(a < tyLeLuyKe && tyLeLuyKe<=a+b)
                    {
                    phanLoai="B";
                    }
                    else
                        phanLoai="C";


                    DataRow dra = dt.NewRow();
                    dra["STT"] = (i + 1).ToString();
                    dra["TTSanPham"] = Common.clsLanguages.GetResource("Id")+": "+dr["ProductId"].ToString() + "\n" + Common.clsLanguages.GetResource("Name")+": "+dr["Name"].ToString();
                    string dongia=string.Format("{0:0,0}", donGiaTB);
                    dra["DonGia"] = dongia.Replace(".", ",");

                   // dra["DoanhSo"] = string.Format("{0,0}", dr["SoLuong"]);
                    string soluong = string.Format("{0:0,0}", dr["SoLuong"]);
                    dra["DoanhSo"] = soluong.Replace(".", ",");

                    string a2 = string.Format("{0:0,0}", dr["DoanhThu"]);
                    dra["DoanhThu"] = a2.Replace(".",",");

                    //dra["DoanhThu"] = string.Format("{0:###.###.###}", dr["DoanhThu"]);
                  // dra["TyLeDoanhThu"] = string.Format("{0:0,0.00}", tyLeDoanhThu);
                    //dra["TyLeDoanhThu"] = tyLeDoanhThu.ToString();
                    string a3 = string.Format("{0:0,0.00}", tyLeDoanhThu);
                    dra["TyLeDoanhThu"] = a3.Replace(",", ".");
                    string tongluyke = string.Format("{0:0,0}", tongLuyKe);
                    dra["TongLuyKe"] = tongluyke.Replace(".", ","); 

                  // dra["TyLeLuyKe"] = string.Format("{0:0,0.00}", tyLeLuyKe);
                    string a4 = string.Format("{0:###,###,###.##}", tyLeLuyKe);
                    dra["TyLeLuyKe"] = a4.Replace(",", "."); 
                    dra["PhanLoai"] = phanLoai;
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
     
        public DataTable GetReport(DateTime from, DateTime to) {
            DataTable res;
            DataSet ds = new DataSet();
            string query = @"SELECT a.`ProductId`, b.`Name`,                              
                                SUM(a.`TotalAmount`) AS `DoanhThu`,
                                SUM(a.`Qty`) AS `SoLuong`
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
                            WHERE ";
            query += String.Format("DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) >= '{0}' ", from.ToString("yyyy-MM-dd"));
            query += String.Format("AND DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) <= '{0}' ", to.ToString("yyyy-MM-dd"));
            query += String.Format("AND a.`Status` = '1' ");           
            query +="GROUP BY a.`ProductId`";
            query += " ORDER By `DoanhThu` DESC";
            
                            
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = ds.Tables[0];
            }
            else {
                res = null;
            }
            return res;
        }

    }
}
