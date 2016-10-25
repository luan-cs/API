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
    public class OrderBLL:IObjectBLL<Orders>
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
        /// Get list Orders
        /// </summary>
        /// <returns></returns>
        public DataTable GetLists(string sCondition)
        {
            DataTable res = new DataTable();
            string query = @"SELECT *
                            FROM orders
                            WHERE 1=1";
            if (sCondition != "") query += " AND OrderId ='" + sCondition + "'";
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

        public DataTable GetCountOrderByStatus(string status) {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_Status",status},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Count_Order_By_Status", ref ds, param, ref errorString);

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

        public DataTable GetDeskInfo(string DeskID)
        {
            DataTable res = new DataTable();
            string query = @"SELECT *
                            FROM `desk`
                            WHERE  DeskId ='" + DeskID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "desk", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = dataset.Tables["desk"];
            }
            else
            {
                res = null;
            }
            return res;
        }


        public DataTable GetOrders_For_Payment(int Option)
        {
            DataTable res = new DataTable();
            DataSet dataset = new DataSet();
            string StoreProc = "spSelect_Orders_For_Payment";
            if (Option == 1) StoreProc = "spSelect_Orders_For_Payment_Desk";
            Program.destopService.DataStoreProcQuery(Program.Username, Program.Password, StoreProc, ref dataset, ref errorString);

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

        

        public void Add(Orders obj, string[][][] param1, bool Print, Desk desk, ref string OrderId) {

            string[][] param = {
                new string[] {"order_id",obj.OrderId},
                new string[] {"desk_id",obj.DeskId},
                new string[] {"note_s",obj.Note},
                new string[] {"create_by",obj.CreatedBy},
                new string[] {"status_s",obj.Status},
                new string[] {"total_tax",double.Parse(obj.TotalTax).ToString()},
                new string[] {"total_ammount",double.Parse(obj.TotalAmmount).ToString()},
                new string[] {"total_ammount_before_tax",double.Parse(obj.TotalAmountBeforeTax).ToString()},
                new string[] {"dis_count_amount",double.Parse(obj.DisCountAmount).ToString()},
                new string[] {"tolal_Money",double.Parse(obj.TotalMoney).ToString()},
            };

            //string[][] paramDesk = {
            //    new string[] {"_DeskId", int.Parse(desk.DeskId).ToString()},
            //    new string[] {"_IsUsing", int.Parse(desk.IsUsing).ToString()},

            //};
            //Program.destopService.Tran_Insert_for_Order(Program.Username, Program.Password, Common.clsLanguages.StrCulture,
            //    ConfigurationManager.AppSettings["PrinterKitchen"], param, param1, paramDesk, ref errorString, ref res, ref Print, ref OrderId);
            Program.destopService.Tran_Insert_for_Order_Nodesk(Program.Username, Program.Password, Common.clsLanguages.StrCulture,
               ConfigurationManager.AppSettings["PrinterKitchen"], param, param1, ref errorString, ref res, ref Print, ref OrderId);

        }

        public DataTable GetPaymentOfOrder(string OrderID)
        {
            DataSet dataset = new DataSet();
            dataset.Tables.Clear();
            string[][] param = {
                new string[] {"p_OrderId",OrderID}
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_PaymentOfOrder", ref dataset, param, ref errorString);
            if (dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
            {
                return dataset.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable GetOrderDetailByDeskId(string DeskId)
        {
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            string[][] param = {
                new string[] {"p_DeskId", DeskId}
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGet_OrderInformation_By_Desk", ref ds, param, ref errorString);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public bool UpdateDeskIdForOrder(string[] OrderId, string DeskIdTo, string DeskIdFrom)
        {
            Program.destopService.Update_DeskId_For_Order(Program.Username, Program.Password, OrderId, DeskIdTo, DeskIdFrom, ref errorString, ref res);
            return res;
        }

        public bool CancelOrder(string OrderId) {
            string queryStr = "";

            queryStr += "UPDATE `orders` SET ";
            queryStr += string.Format(" `Status` = '{0}'", "2");

            queryStr += @"WHERE `OrderId` = '" + OrderId + "'";

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = true;
            }
            return res;
        }

        public bool PrintOrder(string OrderId) {
            Program.destopService.Print_Order(OrderId, Common.clsLanguages.StrCulture, 
                ConfigurationManager.AppSettings["PrinterKitchen"], "1", ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = true;
            }
            return res;
        }
        #region Lấy tất cả thông tin của 1 HD
        public OrderAll GetOrderInfo(string OrderID)
        {
            OrderAll res = new OrderAll();
            ProductsBLL productsBLL = new BusinessLayer.ProductsBLL();
            DeskBLL deskBLL = new DeskBLL();

            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_OrderId", OrderID},
            };
            string errorString = "";
            //string cnStr = GetConnectionString();
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Order_AllInfo", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString) && ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    DataRow dr = dt.Rows[0];
                    Orders rc = new Orders();
                    rc.OrderId = dr["OrderId"].ToString();
                    rc.CreatedBy = dr["CreatedBy"].ToString();
                    rc.CreateDate = dr["CreatedDate"].ToString();
                    rc.TotalAmountBeforeTax = double.Parse(dr["TotalAmountBeforeTax"].ToString()).ToString("0,0");
                    rc.TotalTax = double.Parse(dr["TotalTax"].ToString()).ToString("0,0");
                    rc.TotalMoney = double.Parse(dr["TotalMoney"].ToString()).ToString("0,0");
                    rc.DisCountAmount = double.Parse(dr["DisCountAmount"].ToString()).ToString("0,0");

                    rc.DeskId = deskBLL.GetDeskNO(dr["DeskId"].ToString());

                    res.order = rc;
                }
                /////
                if (ds.Tables[1].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[1];
                    List<OrderDetails> lst = new List<OrderDetails>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        OrderDetails rc = new OrderDetails();
                        rc.OrderId = dr["OrderId"].ToString();
                        rc.ProductId = dr["ProductId"].ToString();
                        rc.ProductName = productsBLL.GetProductName(dr["ProductId"].ToString());
                        rc.Qty = double.Parse(dr["Qty"].ToString()).ToString("0,0");
                        rc.Price = double.Parse(dr["Price"].ToString()).ToString("0,0");
                        rc.AmmountBeforeTax = double.Parse(dr["AmmountBeforeTax"].ToString()).ToString("0,0");
                        rc.TaxAmmount = double.Parse(dr["TaxAmmount"].ToString()).ToString("0,0");
                        rc.TotalAmount = double.Parse(dr["TotalAmmount"].ToString()).ToString("0,0");
                        rc.Status = dr["Status"].ToString();
                        rc.Note = dr["Note"].ToString();

                        lst.Add(rc);
                    }
                    res.lst_Detail = lst;
                }



            }
            else
            {
                res = null;
            }

            return res;
        }

        public bool HaveProIsBuffet(int DeskId)
        {
            bool res = false;
            //
            string query = @"SELECT OrderId
                            FROM `orders`
                            WHERE  DeskId = " + DeskId + " AND `Status` = 0";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables["x"].Rows.Count > 0)
            {
                string OrderId = "";
                foreach (DataRow r in dataset.Tables[0].Rows)
                {
                    OrderId += "'" + r[0].ToString() + "',";
                }
                //Check HaveProIsBuffet in Orderdetails
                string stt = "'2'";//(1 đã thanh toán: đã bỏ ra vì có thể thanh toán rồi nhưng vẫn còn người ngồi lại uống các sp trong buffet), 2 đã cancel
                string query1 = @"SELECT OrderId
                            FROM `orderdetails`
                            WHERE  OrderId IN (" + OrderId.Trim().Trim(',') + ") AND `Status` NOT IN (" + stt + ") AND IsBuffet = '1' AND Price > 0";
                DataSet dataset1 = new DataSet();
                Program.destopService.DataQuery(Program.Username, Program.Password, query1, ref dataset1, "x", ref errorString);
                 if (string.IsNullOrEmpty(errorString) && dataset1.Tables["x"].Rows.Count > 0)
                 {
                     res = true;
                 }
            }
            return res;
        }

        #endregion
    }
}
