using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Data;

namespace VVPosM1.BusinessLayer
{
    public class rptProductPriceBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public DataTable GetProduct()
        {
            DataTable res;
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `products`";
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

        public DataTable GetReport(string proID)
        {
            DataTable res;
            DataSet ds = new DataSet();
            string query = @"SELECT a.`ProductId`,a.`Name` as `Product_Name`,a.`Unit` as `Product_Unit`,b.`Price`,b.`Time` as `Time_Of_Update`,b.`CreatedId` as `CreatedBy`
                            FROM `products` a INNER JOIN `productprice` b ON a.`ProductId`=b.`ProductId`";
            if (proID != "")
            {
                            query += " WHERE a.`ProductId`='" + proID + "'";
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

        public DataTable GetReportSTT(string proID)
        {
            DataTable dt = new DataTable("rptProductPrice");
            // // Create second column.
            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "STT";
            dt.Columns.Add(column);

            // // 
            DataColumn column1 = new DataColumn();
            column1.DataType = Type.GetType("System.String");
            column1.ColumnName = "ProductId";
            dt.Columns.Add(column1);

            // // 
            DataColumn column2 = new DataColumn();
            column2.DataType = Type.GetType("System.String");
            column2.ColumnName = "Product_Name";
            dt.Columns.Add(column2);

            // // 
            DataColumn column3 = new DataColumn();
            column3.DataType = Type.GetType("System.String");
            column3.ColumnName = "Product_Unit";
            dt.Columns.Add(column3);

            // // 
            DataColumn column4 = new DataColumn();
            column4.DataType = Type.GetType("System.String");
            column4.ColumnName = "Price";
            dt.Columns.Add(column4);
            // // 
            DataColumn column5 = new DataColumn();
            column5.DataType = Type.GetType("System.String");
            column5.ColumnName = "Time_Of_Update";
            dt.Columns.Add(column5);
            // // 
            DataColumn column6 = new DataColumn();
            column6.DataType = Type.GetType("System.String");
            column6.ColumnName = "CreatedBy";
            dt.Columns.Add(column6);

            DataTable dt1 = GetReport(proID);
            if (dt1 != null)
            {
                int i = 0;
                foreach (DataRow dr in dt1.Rows)
                {
                    DataRow dra = dt.NewRow();
                    dra["STT"] = (i+1).ToString();
                    dra["ProductId"] = dr["ProductId"].ToString();
                    dra["Product_Name"] = dr["Product_Name"].ToString();
                    dra["Product_Unit"] = dr["Product_Unit"].ToString();

                   // dra["Price"] = string.Format("{0:0,0.00}", dr["Price"]); 
                    string a1 = string.Format("{0:0,0}", dr["Price"]);
                    dra["Price"] = a1.Replace(".", ",");

                    dra["Time_Of_Update"] = dr["Time_Of_Update"].ToString();
                    dra["CreatedBy"] = dr["CreatedBy"].ToString();
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
    }
}
