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
    public class OrderDetailBLL:IObjectBLL<OrderDetails>
    {

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
        /// <summary>
        /// Get list products
        /// </summary>
        /// <returns></returns>
        public DataTable GetLists(string OrderID)
        {
            DataTable res = new DataTable();
            string query = @"SELECT *
                            FROM orderdetails
                            WHERE 1=1";
            if (OrderID != "") query += " AND OrderId ='" + OrderID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Orders", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = dataset.Tables["Orders"];
            }
            else
            {
                res = null;
            }
            return res;
           
        }

        public DataTable GetLastOrderId() {
            DataTable res = new DataTable();
            DataSet dataset = new DataSet();
            Program.destopService.DataStoreProcQuery(Program.Username, Program.Password, "spSelect_Orders", ref dataset, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = dataset.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public void Add(OrderDetails obj)
        {
            DataSet dataset = new DataSet();
            string[][] param = {
                new string[] {"@OrderId",obj.OrderId},
                new string[] {"@ProductId",obj.ProductId},
                new string[] {"@Qty",obj.Qty},
                new string[] {"@Price",obj.Price},
                new string[] {"@Status",obj.Status},
                new string[] {"@CreateBy",obj.CreateBy},
                new string[] {"@Status",obj.Status},
                new string[] {"@AmmountBeforeTax",obj.AmmountBeforeTax},
                new string[] {"@TaxAmmount",obj.TaxAmmount},
                new string[] {"@TotalAmount",obj.TotalAmount},

            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spInsert_OrderDetail", ref dataset, param, ref errorString);
        }

        public DataTable GetListsDetailForPayment(string OrderID)
        {
            DataTable res = new DataTable();
            string query = @"SELECT od.*, o.DeskId
                            FROM orderdetails od, orders o
                            WHERE o.OrderId = od.OrderId";
            if (OrderID != "") query += " AND od.OrderId ='" + OrderID + "' and od.Status='0'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Orders", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = dataset.Tables["Orders"];
            }
            else
            {
                res = null;
            }
            return res;

        }

        public bool UpdateOrderDetail(string EmployeeId, string Note, string OrderId, bool bHaveDiscount, DataTable dt_ODnew, bool IsPrint, double dbTotalMoney)
        {
            double dbDiscount = 0;
            if (bHaveDiscount && dt_ODnew.Rows[dt_ODnew.Rows.Count - 1]["colStatus"].ToString() != "2") {
                dbDiscount = double.Parse(dt_ODnew.Rows[dt_ODnew.Rows.Count - 1]["colPrice"].ToString());
                if (dbDiscount >= dbTotalMoney) { 
                    dbDiscount = 0;
                    errorString = "DISCOUNT";
                    res = false;
                    return res;
                }
            }
            string[][] prm_O = {
                new string[] {"p_OrderId", OrderId},
                new string[] {"p_EmployeeId", EmployeeId},
                new string[] {"p_ModifiedBy",Program.Username},
                new string[] {"p_Note", Note},
                new string[] {"p_DisCountAmount", System.Math.Abs(dbDiscount).ToString()}
            };
            string[][][] lst_prm_ODNew = new string[dt_ODnew.Rows.Count][][];
            int i = 0;
            foreach (DataRow r in dt_ODnew.Rows)
            {
                string[][] prm_ODNew = { 
                    new string[] {"p_OrderId", r["colOrderId"].ToString()},
                    new string[] {"p_ProductId", r["colProductId"].ToString()},  
                    new string[] {"p_ProductName", r["colProductName"].ToString()},
                    new string[] {"p_Qty", r["colQty"].ToString()},
                    new string[] {"p_Price", double.Parse(r["colPrice"].ToString()).ToString()},
                    new string[] {"p_ModifiedBy", Program.Username},
                    new string[] {"p_Status", r["colStatus"].ToString()},
                    new string[] {"p_AmmountBeforeTax", double.Parse(r["colAmmountBeforeTax"].ToString()).ToString()},
                    new string[] {"p_TaxAmmount", double.Parse(r["colTaxAmmount"].ToString()).ToString()},
                    new string[] {"p_TotalAmmount", double.Parse(r["colTotalAmmount"].ToString()).ToString()},
                    new string[] {"p_Note", r["colNote"].ToString()},
                    };
                lst_prm_ODNew[i] = prm_ODNew;
                i++;
            }
            Program.destopService.Update_Order_Detail(Program.Username, Program.Password, Common.clsLanguages.StrCulture,
                ConfigurationManager.AppSettings["PrinterKitchen"], OrderId, prm_O, lst_prm_ODNew, IsPrint, bHaveDiscount, ref errorString, ref res); 
            return res;
        }
    }
}
