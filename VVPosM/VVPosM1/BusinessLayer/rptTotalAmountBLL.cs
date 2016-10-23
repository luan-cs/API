using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.IO;
using VVPosM1.Entities;

namespace VVPosM1.BusinessLayer
{
    public class rptTotalAmountBLL
    {
        private string errorString = "";
        private string[][] param;

        public DataTable GetCommonType()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT `CommonId`,`StrValue1`
                                FROM `commoncode`
                                WHERE `CommonTypeId` = 'ProductType'";

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

        public DataTable GetProductByTypeId(string typeid)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT DISTINCT `products`.`ProductId`,`products`.`Name`
                            FROM `products` INNER JOIN `commoncode`
                                ON `products`.`ProductType` = `commoncode`.`CommonId`
                            WHERE `CommonId` = ";
            query += '"' + typeid + '"';

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

        public DataTable GetTotalAmountByProductTime(string[][] p)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "`spGet_TotalAmount_ByProduct_Time1`", ref ds, p, ref errorString);

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

        public DataTable GetReport(string[][] p)
        {
            DataTable res = new DataTable();
            DataTable temp = GetTotalAmountByProductTime(p);

            #region Thêm STT vào DataTable

            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "STT";
            res.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            res.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "TotalAmount";
            res.Columns.Add(column);

            if (temp != null)
            {
                int i = 0;
                foreach (DataRow dr in temp.Rows)
                {
                    DataRow dra = res.NewRow();
                    dra["STT"] = (i + 1).ToString();
                    dra["Name"] = dr["Name"].ToString();
                    dra["TotalAmount"] = dr["TotalAmount"].ToString();
                    res.Rows.Add(dra);
                    i++;
                }
            }
            else
            {
                res = null;
            }
            #endregion
            return res;
        }

        public DataTable GetReportDT(string[][] p)
        {
            DataTable res = new DataTable();
            DataTable temp = GetTotalAmountByProductTime(p);

            #region Thêm STT vào DataTable

            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "STT";
            res.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ProductId";
            res.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            res.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "TotalPrice";
            res.Columns.Add(column);

            if (temp != null)
            {
                int i = 0;
                foreach (DataRow dr in temp.Rows)
                {
                    DataRow dra = res.NewRow();
                    dra["STT"] = (i + 1).ToString();
                    dra["ProductId"] = dr["ProductId"].ToString();
                    dra["Name"] = dr["Name"].ToString();
                    dra["TotalAmount"] = dr["TotalAmount"].ToString();
                    res.Rows.Add(dra);
                    i++;
                }
            }
            else
            {
                res = null;
            }
            #endregion
            return res;
        }
    }
}
