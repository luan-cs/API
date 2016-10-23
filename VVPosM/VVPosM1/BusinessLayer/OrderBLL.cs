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
    public class OrderBLL
    {
        private string errorString = "";
        private string[][] param;

        public DataTable GetDeskIdNo()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT `DeskId`,`DeskNo`
                            FROM `desk`";
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

        public DataTable SearchOrder(Order obj, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;

            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string[][] param = {
                new string[] {"p_OrderId", string.IsNullOrEmpty(obj.OrderId)? null : obj.OrderId},
                new string[] {"p_DeskId", string.IsNullOrEmpty(obj.DeskId) ? null : obj.DeskId},
                new string[] {"p_Note", null},
                new string[] {"p_Status", null},
                new string[] {"p_IsPrint", string.IsNullOrEmpty(obj.IsPrint) ? null : obj.IsPrint},

                new string[] {"p_TotalTax", null},
                new string[] {"p_TotalAmmount", string.IsNullOrEmpty(obj.TotalAmmount) ? null : double.Parse(obj.TotalAmmount).ToString()},
                new string[] {"p_TotalAmountBeforeTax", null},
                new string[] {"p_DisCountAmount", string.IsNullOrEmpty(obj.DisCountAmount) ? null :  double.Parse(obj.DisCountAmount).ToString()},
                new string[] {"p_TotalMoney", string.IsNullOrEmpty(obj.TotalMoney) ? null : double.Parse(obj.TotalMoney).ToString()},

                new string[] { "p_CreatedBy", string.IsNullOrEmpty(obj.CreatedBy) ? null : obj.CreatedBy },
                new string[] { "p_CreatedDateFrom",string.IsNullOrEmpty(obj.CreatedDateFrom) ? null : obj.CreatedDateFrom },
                new string[] { "p_CreatedDateTo",string.IsNullOrEmpty(obj.CreatedDateTo) ? null : obj.CreatedDateTo },

                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
                               };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Order", ref ds, param, ref errorString);

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

        public DataTable GetOrderDetailById(string orderid)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT `orders`.`OrderId`, `products`.`Name`,`products`.`Unit`,`orderdetails`.`Qty`,
                                `orderdetails`.`Price`,`orderdetails`.`AmmountBeforeTax`,`orderdetails`.`TaxAmmount`,`orderdetails`.`TotalAmmount`
                            FROM `orderdetails`,`orders`,`products`
                            WHERE `orders`.`OrderId`=`orderdetails`.`OrderId` AND `orderdetails`.`ProductId`=`products`.`ProductId`";
	        query += string.Format("AND `orders`.`OrderId` LIKE '%{0}%'", orderid);
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

        public int DeleteOrder(string orderid)
        {// cập nhật
            //1: thành công; 0: thất bại
            int res = 0;
            string queryStr = "";

            queryStr += "UPDATE `orders` SET ";
            queryStr += string.Format(" `Status` = '{0}'", "2");

            queryStr += @"WHERE `OrderId` = '" + orderid + "'";

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int PrintOrder(string orderid, string noiin)
        {
            // cập nhật
            //1: thành công; 0: thất bại
            int res = 0;


            Program.destopService.Print_Order(orderid, Common.clsLanguages.StrCulture, noiin,"0", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {//cập nhật trạng thái in

                string queryStr = "";

                queryStr += "UPDATE `orders` SET ";
                queryStr += string.Format(" `IsPrint` = '{0}'", "1");

                queryStr += @"WHERE `OrderId` = '" + orderid + "'";

                Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
                if (string.IsNullOrEmpty(errorString))
                {
                    res = 1;
                }
            }
            return res;
        }
    }
}
