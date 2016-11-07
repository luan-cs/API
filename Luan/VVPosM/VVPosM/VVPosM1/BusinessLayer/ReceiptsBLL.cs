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
    public class ReceiptsBLL : IObjectBLL<Receipts>
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

        private DataSet ds = new DataSet();

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        #endregion

     

        #region Lấy tất cả thông tin của 1 HD
        public ReceiptsAll GetAllInfo(string ReceiptID)
        {
            ReceiptsAll res = new ReceiptsAll();

            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_ReceiptId", ReceiptID},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Receipt_AllInfo", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString) && ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {                    
                    DataTable dt = ds.Tables[0];
                    DataRow dr = dt.Rows[0];
                    Receipts rc = new Receipts();
                    rc.ReceiptId = dr["ReceiptId"].ToString();
                    rc.CreatedBy = dr["CreatedBy"].ToString();
                    rc.CreatedDate = dr["CreatedDate"].ToString();
                    rc.TotalAmountBeforeTax = double.Parse(dr["TotalAmountBeforeTax"].ToString()).ToString("0,0");
                    rc.TotalTax = double.Parse(dr["TotalTax"].ToString()).ToString("0,0");
                    rc.TotalAmount = double.Parse(dr["TotalAmount"].ToString()).ToString("0,0");
                    rc.DiscountAmount = double.Parse(dr["DiscountAmount"].ToString()).ToString("0,0");
                    rc.TotalMoney = double.Parse(dr["TotalMoney"].ToString()).ToString("0,0");
                    rc.CashPayAmt = double.Parse(dr["CashPayAmt"].ToString()).ToString("0,0");
                    rc.CardPayAmt = double.Parse(dr["CardPayAmt"].ToString()).ToString("0,0");
                    rc.ReturnAmt = double.Parse(dr["ReturnAmt"].ToString()).ToString("0,0");
                    res.receipt = rc;
                }
                /////
                if (ds.Tables[1].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[1];
                    List<ReceiptDetails> lst = new List<ReceiptDetails>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        ReceiptDetails rc = new ReceiptDetails();
                        rc.ReceiptId = dr["ReceiptId"].ToString();
                        rc.ProductId = dr["ProductId"].ToString();
                        rc.ProductName = GetProductName(dr["ProductId"].ToString());
                        rc.Qty = double.Parse(dr["Qty"].ToString()).ToString("0,0");
                        rc.Price = double.Parse(dr["Price"].ToString()).ToString("0,0");                        
                        rc.TotalAmountBeforeTax = double.Parse(dr["TotalAmountBeforeTax"].ToString()).ToString("0,0");
                        rc.TaxAmount = double.Parse(dr["TaxAmount"].ToString()).ToString("0,0");
                        rc.TotalAmount = double.Parse(dr["TotalAmount"].ToString()).ToString("0,0");
                      
                        lst.Add(rc);
                    }
                    res.lst_Detail = lst;
                }
                ///thẻ
                if (ds.Tables[2].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[2];
                    List<ReceiptsCard> lst = new List<ReceiptsCard>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        ReceiptsCard rc = new ReceiptsCard();
                        rc.ReceiptId = dr["ReceiptId"].ToString();
                        rc.CardNo = dr["CardNo"].ToString();
                        rc.CardHolderName = dr["CardHolderName"].ToString();
                        rc.ExpiredDate = dr["ExpiredDate"].ToString();
                        rc.CardType = dr["CardType"].ToString();
                        rc.Bank = dr["Bank"].ToString();
                        rc.TotalAmount = double.Parse(dr["TotalAmount"].ToString()).ToString("0,0");   
                        lst.Add(rc);
                    }
                    res.lst_card = lst;
                }
                
                // ReceiptInfo
                if (ds.Tables[3].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[3];
                    DataRow dr = dt.Rows[0];
                    ReceiptInfo rc = new ReceiptInfo();
                    rc.ReceiptId = dr["ReceiptId"].ToString();
                    rc.CustomerName = dr["CustomerName"].ToString();
                    rc.Address = dr["Address"].ToString();
                    rc.Phone = dr["Phone"].ToString();
                    rc.Note = dr["Note"].ToString();
                    res.receiptInfo = rc;
                }
                
                // ReceiptMember
                if (ds.Tables[4].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[4];
                    DataRow dr = dt.Rows[0];
                    ReceiptMember rc = new ReceiptMember();
                    rc.ReceiptId = dr["ReceiptId"].ToString();
                    rc.MemberId = dr["MemberId"].ToString();
                    rc.CreatedBy = dr["CreatedBy"].ToString();
                    DataTable dte = GetMemberInfo(dr["MemberId"].ToString());
                    if (dte != null)
                    {
                        DataRow drr = dte.Rows[0];
                        rc.MemberCode = drr["MemberCode"].ToString();
                        rc.ObjectId = drr["ObjectId"].ToString();
                        rc.NumberOfVissits = drr["NumberOfVissits"].ToString();
                        rc.LastestDate = drr["LastestDate"].ToString();
                        rc.MemberType = drr["MemberType"].ToString();

                        rc.MemberScore = drr["MemberScore"].ToString();
                        rc.ObjectGroup = drr["ObjectGroup"].ToString();
                        rc.ObjectType = drr["ObjectType"].ToString();
                        rc.Tel = drr["Tel"].ToString();
                        rc.Email = drr["Email"].ToString();
                        rc.MemberCode = drr["Gender"].ToString();
                        rc.FullName = drr["FullName"].ToString();
                        rc.TemAdd = drr["TemAdd"].ToString();
                    }
                    res.receiptMember = rc;
                }

            }
            else
            {
                res = null;
            }
            
            return res;
        }
        public string GetProductName(string ProID)
        {
            string res = "";
            DataTable dt = new DataTable();
            string query = @"SELECT *
                            FROM `products`
                            WHERE  `ProductId` ='" + ProID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Products", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                dt = dataset.Tables["Products"];
                res = dt.Rows[0]["name"].ToString();
            }
            else
            {
                res = null;
            }            
            return res;
        }
        public DataTable GetMemberInfo(string MemberID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT `members`.`MemberId`,`members`.`MemberCode`,`members`.`ObjectId`,`members`.`NumberOfVissits`,`members`.`LastestDate`,`members`.`MemberType`,`members`.`MemberScore`,
                            `objects`.`ObjectGroup`,`objects`.`ObjectType`,`objects`.`Tel`,`objects`.`Email`,`objects`.`Gender`,`objects`.`FullName`,`objects`.`TemAdd`
                            FROM `members` INNER JOIN `objects` ON `members`.`ObjectId`=`objects`.`ObjectId`
                            WHERE  `members`.`MemberId` ='" + MemberID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "X", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count>0)
            {
                dt = dataset.Tables["X"];                
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        #endregion

        #region
        public DataTable GetValidPromotionToPrint()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT *
                            FROM `promotions`
                            WHERE NOW() BETWEEN `BeginDateTime` AND `EndDateTime`
                            AND `PrintToBill`='1'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "X", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
            {
                dt = dataset.Tables["X"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }
         
        #endregion

        public ReceiptDetails GetReceDeWithID(string id)
        {
            ReceiptDetails reOb = new ReceiptDetails();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `receptdetail`
                            WHERE `ReceptId`='" + id + "' ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reOb.ODId = ds.Tables[0].Rows[0]["ODId"].ToString();
                reOb.ReceiptId = ds.Tables[0].Rows[0]["ReceiptId"].ToString();
                reOb.ProductId = ds.Tables[0].Rows[0]["ProductId"].ToString();
                reOb.PromotionId = ds.Tables[0].Rows[0]["PromotionId"].ToString();
                reOb.Qty = ds.Tables[0].Rows[0]["Qty"].ToString();
                reOb.Price = ds.Tables[0].Rows[0]["Price"].ToString();
                reOb.TotalAmountBeforeTax = ds.Tables[0].Rows[0]["TotalAmountBeforeTax"].ToString();
                reOb.TaxAmount = ds.Tables[0].Rows[0]["TaxAmount"].ToString();
                reOb.TotalAmount = ds.Tables[0].Rows[0]["TotalAmount"].ToString();
                reOb.Status = ds.Tables[0].Rows[0]["STatus"].ToString();
                reOb.RefOrderId = ds.Tables[0].Rows[0]["RefOrderId"].ToString();
                reOb.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                reOb.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                reOb.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                reOb.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();
                
            }
            else
            {

                reOb = null;
            }
            return reOb;
        }

        public DataTable searchReceiptsDetails(string receiptId) {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string query = @"SELECT a.*,b.`Name`
                            FROM `receiptdetails` a
                            LEFT JOIN `products` b
                            ON a.`productId`=b.`productId`
                            WHERE `ReceiptId`='" + receiptId + "' ;";
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

        public DataTable searchReceiptsCard(string receiptId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string query = @"SELECT *
                            FROM `receiptscard`
                            WHERE `ReceiptId`='" + receiptId + "' ;";
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

        public DataTable searchReceiptInfo(string receiptId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string query = @"SELECT *
                            FROM `receiptinfo`
                            WHERE `ReceiptId`='" + receiptId + "' ;";
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

        public DataTable searchReceiptMember(string receiptId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string query = @"SELECT *
                            FROM `receiptmember`
                            WHERE `ReceiptId`='" + receiptId + "' ;";
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

        public DataTable SearchReceipts0(Receipts receipts, string tuNgay, string denNgay, int page, out int TotalRecord)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            TotalRecord = 0;
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;

            string[][] param ={
                new string[] { "p_ReceiptId", string.IsNullOrEmpty(receipts.ReceiptId)?null:receipts.ReceiptId },
                new string[] { "p_TotalMoney", string.IsNullOrEmpty(receipts.TotalAmount)?null:double.Parse(receipts.TotalAmount).ToString() },
                new string[] { "p_CreatedBy", string.IsNullOrEmpty(receipts.CreatedBy)?null:receipts.CreatedBy },
                new string[] { "p_CreatedDateTu",tuNgay  },
                new string[] { "p_CreatedDateDen", denNgay },
                 
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };
            
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Receipts", ref ds, param, ref errorString);

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

        // ma the
        public DataTable SearchReceipts1(string id, string tuNgay, string denNgay, int page, out int TotalRecord)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            TotalRecord = 0;
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;

            string[][] param ={
                new string [] {"p_Id",string.IsNullOrEmpty(id)?null:id},
                new string[] { "p_CreatedDateTu",tuNgay  },
                new string[] { "p_CreatedDateDen", denNgay },
                 
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Receipts_1", ref ds, param, ref errorString);

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

        public DataTable SearchReceipts2(string id, string tuNgay, string denNgay, int page, out int TotalRecord)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            TotalRecord = 0;
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;

            string[][] param ={
                new string [] {"p_Id",string.IsNullOrEmpty(id)?null:id},
                new string[] { "p_CreatedDateTu",tuNgay  },
                new string[] { "p_CreatedDateDen", denNgay },
                 
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Receipts_2", ref ds, param, ref errorString);

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


//        public DataTable GetReceiptIdInCard(string id)
//        {
//            //int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
//            //int limit = (page - 1) * RecordPerPage;
//            //int offset = limit + RecordPerPage;
//            //TotalRecord = 0;
//            DataTable res = new DataTable();
//            DataSet ds = new DataSet();
//            string query = @"SELECT *
//                            FROM `receiptscard`
//                            WHERE `CardNo` like '%" + id + "%'"; 
//            //LIMIT " + limit.ToString() + "," + RecordPerPage.ToString() + " ; ";
//            //query = query + " SELECT count(*) as `Total` FROM `receiptscard` WHERE `CardNo` like '%" + id + "%';
            
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
        public DataTable GetReceiptIdInMember(string id)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `receiptmember`
                            WHERE `MemberId`like '%" + id + "%'";
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

        public int PrintReceipt(string receiptid, string noiin)
        {
            // cập nhật
            //1: thành công; 0: thất bại
            int res = 0;


            Program.destopService.Print_Order(receiptid, Common.clsLanguages.StrCulture, noiin,"0", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {//cập nhật trạng thái in

                string queryStr = "";

                queryStr += "UPDATE `orders` SET ";
                queryStr += string.Format(" `IsPrint` = '{0}'", "1");

                queryStr += @"WHERE `OrderId` = '" + receiptid + "'";

                Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
                if (string.IsNullOrEmpty(errorString))
                {
                    res = 1;
                }
            }
            return res;
        }

        public DataTable GetProductRPHourAllProduct(DateTime from, DateTime to, string ProductId)
        {

            DataTable dt = new DataTable();
          //  DataTable dtProduct = GetProductList(ProductId);// spSearch_ProductB          
            dt.Columns.Add("ProductId");
            dt.Columns.Add("Name");
            dt.Columns["Name"].DefaultValue = "";
            dt.Columns.Add("Revenue");
            dt.Columns["Revenue"].DefaultValue = "0";
            dt.Columns.Add("TotalCustomer");
            dt.Columns["TotalCustomer"].DefaultValue = "0";
            dt.Columns.Add("CreateHour");
            dt.Columns["CreateHour"].DefaultValue = "0";
           
                    
                    //DataRow drTot = dt.NewRow();
                    DataTable dtDetail = GetProductRPHourDetail(from, to, ProductId);
                    if (dtDetail != null)
                    {
                        int i = 0;
                        foreach (DataRow dr in dtDetail.Rows)
                        {
                            DataRow drr = dt.NewRow();
                            drr["ProductId"] = Common.clsLanguages.GetResource("ProductID") + ": " + dr["ProductId"].ToString() + "\n" + Common.clsLanguages.GetResource("ProductName") + ": " + dr["Name"].ToString();
                            drr["Name"] = dr["Name"].ToString();
                            drr["CreateHour"] = dr["CreateHour"].ToString();
                            drr["Revenue"] = String.Format("{0:0.##}", double.Parse(dr["DoanhThu"].ToString()));
                            drr["TotalCustomer"] = String.Format("{0:0.##}", double.Parse(dr["TotalCustomer"].ToString()));
                            dt.Rows.Add(drr);
                            i++;
                        }
                    }
                    else
                    {
                        dt = null;
                    }                  
                return dt;
                }

        public DataTable GetProductGroupRPHourAllProduct(DateTime from, DateTime to, string ProductId)
        {

            DataTable dt = new DataTable();
            //  DataTable dtProduct = GetProductList(ProductId);// spSearch_ProductB          
            dt.Columns.Add("ProductId");          
            dt.Columns.Add("Revenue");
            dt.Columns["Revenue"].DefaultValue = "0";
            dt.Columns.Add("TotalCustomer");
            dt.Columns["TotalCustomer"].DefaultValue = "0";
            dt.Columns.Add("CreateHour");
            dt.Columns["CreateHour"].DefaultValue = "0";


            //DataRow drTot = dt.NewRow();
            DataTable dtDetail = GetGroupProductRPHourDetail(from, to, ProductId);
            if (dtDetail != null)
            {
                int i = 0;
                foreach (DataRow dr in dtDetail.Rows)
                {
                    DataRow drr = dt.NewRow();
                    drr["ProductId"] = Common.clsLanguages.GetResource("GroupId") + ": " + dr["ProductType"].ToString() + "\n" + Common.clsLanguages.GetResource("GroupName") + ": " + dr["StrValue1"].ToString();                    
                    drr["CreateHour"] = dr["CreateHour"].ToString();
                    drr["Revenue"] = String.Format("{0:0.##}", double.Parse(dr["DoanhThu"].ToString()));
                    drr["TotalCustomer"] = String.Format("{0:0.##}", double.Parse(dr["TotalCustomer"].ToString()));
                    dt.Rows.Add(drr);
                    i++;
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }
          
        

        //public DataTable GetGroupProductRPHourAllProduct(DateTime from, DateTime to, string ProductType)
        //{

        //    DataTable dt = new DataTable();
        //    DataTable dtProduct = GetGroupProductList(ProductType);
        //    dt.Columns.Add("STT");
        //    dt.Columns.Add("ProductId");
        //    dt.Columns.Add("Name");
        //    dt.Columns["Name"].DefaultValue = "";
        //    dt.Columns.Add("Revenue");
        //    dt.Columns["Revenue"].DefaultValue = "0";
        //    dt.Columns.Add("TotalCustomer");
        //    dt.Columns["TotalCustomer"].DefaultValue = "0";
        //    dt.Columns.Add("HH08_Total_Sales");
        //    dt.Columns["HH08_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH08_Total_Times");
        //    dt.Columns["HH08_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH09_Total_Sales");
        //    dt.Columns["HH09_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH09_Total_Times");
        //    dt.Columns["HH09_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH10_Total_Sales");
        //    dt.Columns["HH10_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH10_Total_Times");
        //    dt.Columns["HH10_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH11_Total_Sales");
        //    dt.Columns["HH11_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH11_Total_Times");
        //    dt.Columns["HH11_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH12_Total_Sales");
        //    dt.Columns["HH12_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH12_Total_Times");
        //    dt.Columns["HH12_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH13_Total_Sales");
        //    dt.Columns["HH13_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH13_Total_Times");
        //    dt.Columns["HH13_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH14_Total_Sales");
        //    dt.Columns["HH14_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH14_Total_Times");
        //    dt.Columns["HH14_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH15_Total_Sales");
        //    dt.Columns["HH15_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH15_Total_Times");
        //    dt.Columns["HH15_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH16_Total_Sales");
        //    dt.Columns["HH16_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH16_Total_Times");
        //    dt.Columns["HH16_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH17_Total_Sales");
        //    dt.Columns["HH17_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH17_Total_Times");
        //    dt.Columns["HH17_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH18_Total_Sales");
        //    dt.Columns["HH18_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH18_Total_Times");
        //    dt.Columns["HH18_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH19_Total_Sales");
        //    dt.Columns["HH19_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH19_Total_Times");
        //    dt.Columns["HH19_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH20_Total_Sales");
        //    dt.Columns["HH20_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH20_Total_Times");
        //    dt.Columns["HH20_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH21_Total_Sales");
        //    dt.Columns["HH21_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH21_Total_Times");
        //    dt.Columns["HH21_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH22_Total_Sales");
        //    dt.Columns["HH22_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH22_Total_Times");
        //    dt.Columns["HH22_Total_Times"].DefaultValue = "0";
        //    dt.Columns.Add("HH23_Total_Sales");
        //    dt.Columns["HH23_Total_Sales"].DefaultValue = "0";
        //    dt.Columns.Add("HH23_Total_Times");
        //    dt.Columns["HH23_Total_Times"].DefaultValue = "0";
        //    if (dtProduct != null)
        //    {
        //        int j = 0;
        //        foreach (DataRow dr in dtProduct.Rows)
        //        {

        //            double TT_rev = 0;
        //            double TT_Tim = 0;

        //            DataRow drr = dt.NewRow();
        //            //DataRow drTot = dt.NewRow();
        //            drr["STT"] = (j + 1).ToString();
        //            drr["ProductId"] = Common.clsLanguages.GetResource("GroupId") + ": " + dr["ProductType"].ToString() + "\n" + Common.clsLanguages.GetResource("GroupName") + ": " + dr["StrValue1"].ToString();
        //            drr["Name"] = "";

        //            for (int i = 8; i < 24; i++)
        //            {
        //                DataTable dtDetail = GetGroupProductRPHourDetail(from, to, dr["ProductType"].ToString(), i.ToString());
        //                string stt = i.ToString();
        //                if (stt.Length == 1)
        //                {
        //                    stt = "0" + stt;
        //                }
        //                if (dtDetail != null)
        //                {
        //                    drr["HH" + stt + "_Total_Sales"] = String.Format("{0:0.##}", double.Parse(dtDetail.Rows[0]["DoanhThu"].ToString()));
        //                    //string a1 = string.Format("{0:0,0}", dtDetail.Rows[0]["DoanhThu"]);
        //                    //drr["HH" + stt + "_Total_Sales"] = a1.Replace(".", ",");

        //                    drr["HH" + stt + "_Total_Times"] = double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString()).ToString("0,0");
        //                    TT_rev = TT_rev + double.Parse(dtDetail.Rows[0]["DoanhThu"].ToString());
        //                    TT_Tim = TT_Tim + double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString());
        //                }
        //                else
        //                {
        //                    drr["HH" + stt + "_Total_Sales"] = "0.0";
        //                    drr["HH" + stt + "_Total_Times"] = "0";
        //                }

        //            }
        //            j++;
        //            drr["Revenue"] = String.Format("{0:0.##}", TT_rev);
        //            drr["TotalCustomer"] = TT_Tim.ToString("0,0");

        //            dt.Rows.Add(drr);

        //        }
        //    }
        //    else
        //    {
        //        dt = null;
        //    }
        //    return dt;

        //}

        //public DataTable GetGroupProductRPHourAllProduct(DateTime from, DateTime to, string groupProduct)
        //{

        //    DataTable dt = new DataTable();
        //    DataTable dtProduct = GetGroupProductList(groupProduct);
        //    dt.Columns.Add("ProductId");
        //    dt.Columns.Add("Name");
        //    dt.Columns.Add("Revenue");
        //    dt.Columns.Add("TotalCustomer");

        //    dt.Columns.Add("HH08_Total_Sales");
        //    dt.Columns.Add("HH08_Total_Times");

        //    dt.Columns.Add("HH09_Total_Sales");
        //    dt.Columns.Add("HH09_Total_Times");

        //    dt.Columns.Add("HH10_Total_Sales");
        //    dt.Columns.Add("HH10_Total_Times");

        //    dt.Columns.Add("HH11_Total_Sales");
        //    dt.Columns.Add("HH11_Total_Times");

        //    dt.Columns.Add("HH12_Total_Sales");
        //    dt.Columns.Add("HH12_Total_Times");

        //    dt.Columns.Add("HH13_Total_Sales");
        //    dt.Columns.Add("HH13_Total_Times");

        //    dt.Columns.Add("HH14_Total_Sales");
        //    dt.Columns.Add("HH14_Total_Times");

        //    dt.Columns.Add("HH15_Total_Sales");
        //    dt.Columns.Add("HH15_Total_Times");

        //    dt.Columns.Add("HH16_Total_Sales");
        //    dt.Columns.Add("HH16_Total_Times");

        //    dt.Columns.Add("HH17_Total_Sales");
        //    dt.Columns.Add("HH17_Total_Times");

        //    dt.Columns.Add("HH18_Total_Sales");
        //    dt.Columns.Add("HH18_Total_Times");

        //    dt.Columns.Add("HH19_Total_Sales");
        //    dt.Columns.Add("HH19_Total_Times");

        //    dt.Columns.Add("HH20_Total_Sales");
        //    dt.Columns.Add("HH20_Total_Times");

        //    dt.Columns.Add("HH21_Total_Sales");
        //    dt.Columns.Add("HH21_Total_Times");

        //    dt.Columns.Add("HH22_Total_Sales");
        //    dt.Columns.Add("HH22_Total_Times");

        //    dt.Columns.Add("HH23_Total_Sales");
        //    dt.Columns.Add("HH23_Total_Times");
        //    if (dtProduct != null)
        //    {
        //        foreach (DataRow dr in dtProduct.Rows)
        //        {
        //            double TT_rev = 0;
        //            double TT_Tim = 0;

        //            DataRow drr = dt.NewRow();
        //            //DataRow drTot = dt.NewRow();
        //            drr["ProductId"] = "";
        //            drr["Name"] = dr["Name"].ToString();

        //            for (int i = 8; i < 24; i++)
        //            {
        //                DataTable dtDetail = GetGroupProductRPHourDetail(from, to, dr["ProductType"].ToString(), i.ToString());
        //                string stt = i.ToString();
        //                if (stt.Length == 1)
        //                {
        //                    stt = "0" + stt;
        //                }
        //                if (dtDetail != null)
        //                {
        //                    drr["HH" + stt + "_Total_Sales"] = double.Parse(dtDetail.Rows[0]["Revenue"].ToString()).ToString("0,0.0");
        //                    drr["HH" + stt + "_Total_Times"] = double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString()).ToString("0,0");
        //                    TT_rev = TT_rev + double.Parse(dtDetail.Rows[0]["Revenue"].ToString());
        //                    TT_Tim = TT_Tim + double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString());
        //                }
        //                else
        //                {
        //                    drr["HH" + stt + "_Total_Sales"] = "0.0";
        //                    drr["HH" + stt + "_Total_Times"] = "0";
        //                }
        //            }

        //            drr["Revenue"] = TT_rev.ToString("0,0.0");
        //            drr["TotalCustomer"] = TT_Tim.ToString("0,0");

        //            dt.Rows.Add(drr);

        //        }
        //    }
        //    else
        //    {
        //        dt = null;
        //    }
        //    return dt;

        //}

        public DataTable GetProductRPHourDetail(DateTime from, DateTime to, string productID)
        {
            string query = @"SELECT a.`ProductId`, b.`Name`,HOUR( a.`CreatedDate`) as CreateHour,                              
                                a.`TotalAmount` AS `DoanhThu`,
                                a.`ReceiptId` AS TotalCustomer
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
                            WHERE ";
            query += String.Format("DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) >= '{0}' ", from.ToString("yyyy-MM-dd"));
            query += String.Format("AND DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) <= '{0}' ", to.ToString("yyyy-MM-dd"));
            query += String.Format("AND a.`Status` = '1' ");
            if (productID != "")
            {
                query += String.Format(" AND a.`ProductId` = '{0}' ", productID);
            }
            query += " ORDER BY HOUR( a.`CreatedDate`)";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Receipt", ref errorString);

            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["Receipt"].Rows.Count != 0)
            {
                DataTable dt = new DataTable("Receipt");
                dt = dataset.Tables[0];
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetGroupProductRPHourDetail(DateTime from, DateTime to, string ProductType)
        {
            string query = @"SELECT b.`ProductType`, b.`ProductType`,d.`StrValue1`,HOUR( a.`CreatedDate`) as CreateHour,                               
                                a.`TotalAmount` AS `DoanhThu`,
                                a.`ReceiptId` AS TotalCustomer
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
                                                    INNER JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId`
						    WHERE d.`CommonTypeId`='ProductType' AND ";                     
            query += String.Format("DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) >= '{0}' ", from.ToString("yyyy-MM-dd"));
            query += String.Format("AND DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) <= '{0}' ", to.ToString("yyyy-MM-dd"));
            query += String.Format("AND a.`Status` = '1' ");
            if (ProductType != "")
            {
                query += String.Format(" AND b.`ProductType` = '{0}' ", ProductType);
            }
            query += " ORDER BY HOUR( a.`CreatedDate`)";
           

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Receipt", ref errorString);

            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["Receipt"].Rows.Count != 0)
            {
                DataTable dt = new DataTable("Receipt");
                dt = dataset.Tables[0];
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetProductList(string ProductId)
        {

          
            string query = @"SELECT *
                 FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`   
                                          
                             ";
            if (ProductId != "")
            {
                query += "WHERE a.`ProductId`=" + ProductId;
            }
            query += " GROUP BY a.`ProductId`";      
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

        public DataTable GetProductListMonth(string sMon, string sYea, string ProductId)
        {
            // = '{0}' ", sDate.ToString("yyyy-MM-dd"));


            string query = @"SELECT *
                FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`   
                                        INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
                                   
                 WHERE  MONTH(a.`CreatedDate`)=" + sMon;
            query += " AND YEAR(a.`CreatedDate`) = " + sYea;
            if (ProductId != "")
            {
                query += " AND a.`ProductId`= " + ProductId;
            }
            query += " AND `c`.`Status` = '1' ";
            query += " GROUP BY a.`ProductId` ";


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

        public DataTable GetGroupProductList(string ProductType)
        {


            string query = @"SELECT b.`ProductType`,d.`StrValue1`                            
                               
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
						    INNER JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId`
						    WHERE d.`CommonTypeId`='ProductType'";
            if (ProductType != "") {
                query += " AND b.`ProductType`='"+ProductType+"'"; 
            }
                    query +=" GROUP BY b.`ProductType`";                   
                                

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

        public DataTable GetProduct()
        {
            string query = @"SELECT b.`ProductId`, b.`Name`                            
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`                                                						    
						     GROUP BY b.`ProductId`  
                                                    
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
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
						    INNER JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId`
						    WHERE d.`CommonTypeId`='ProductType'
                          
                            GROUP BY b.`ProductType`                   
                            ";
            //                           WHERE `CommonTypeId`='ProductType'

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


         //Báo cáo số lượng khách theo thángfdslkjflsjflds

        public DataTable GetProductNoOfCustomersMonthAll(string sMonth, string sYear, string ProductId)
        {
            DataTable dt = new DataTable();
            // test
                    
            dt.Columns.Add("ProductId");
            dt.Columns.Add("Revenue");
            dt.Columns["Revenue"].DefaultValue = "0";
            dt.Columns.Add("TotalCustomer");
            dt.Columns["TotalCustomer"].DefaultValue = "0";
            dt.Columns.Add("CreatedDate");
            dt.Columns["CreatedDate"].DefaultValue = "0";
           
                //int year = int.Parse(sYear);
                //int month = int.Parse(sMonth);
           
                DataTable dtDetail = GetProductNoOfCustomers(sMonth, sYear, ProductId);
                if (dtDetail != null)
                {
                    foreach (DataRow dr in dtDetail.Rows)
                    {                      
                        DataRow drr = dt.NewRow();                     
                        drr["ProductId"] = Common.clsLanguages.GetResource("ProductID") + ": " + dr["ProductId"].ToString() + "\n" + Common.clsLanguages.GetResource("ProductName") + ": " + dr["Name"].ToString();
                        //drr["HH" + stt + "_Total_Sales"] = double.Parse(dtDetail.Rows[0]["Revenue"].ToString()).ToString("0,0.0");
                        drr["CreatedDate"] = dr["CreatedDate"].ToString();
                        drr["Revenue"] = String.Format("{0:0.##}", double.Parse(dr["Revenue"].ToString()));
                        drr["TotalCustomer"] = String.Format("{0:0.##}", double.Parse(dr["TotalCustomer"].ToString()));
                        dt.Rows.Add(drr);
                    }
                }
                
            else
            {
                dt = null;
            }
            return dt;
                    //drr["Revenue"] = String.Format("{0:0.##}", TT_rev);
                    //drr["TotalCustomer"] = TT_Tim.ToString("0,0");                                                       
        }

        public DataTable GetProductGroupNoOfCustomersMonthAll(string sMonth, string sYear, string ProductId)
        {
            DataTable dt = new DataTable();
            // test

            dt.Columns.Add("ProductId");
            dt.Columns.Add("Revenue");
            dt.Columns["Revenue"].DefaultValue = "0";
            dt.Columns.Add("TotalCustomer");
            dt.Columns["TotalCustomer"].DefaultValue = "0";
            dt.Columns.Add("CreatedDate");
            dt.Columns["CreatedDate"].DefaultValue = "0";

            //int year = int.Parse(sYear);
            //int month = int.Parse(sMonth);

            DataTable dtDetail = GetProductGroupNoOfCustomersDay(sMonth, sYear, ProductId);
            if (dtDetail != null)
            {
                foreach (DataRow dr in dtDetail.Rows)
                {
                    DataRow drr = dt.NewRow();
                    drr["ProductId"] = Common.clsLanguages.GetResource("GroupId") + ": " + dr["ProductType"].ToString() + "\n" + Common.clsLanguages.GetResource("GroupName") + ": " + dr["StrValue1"].ToString();
                    //drr["HH" + stt + "_Total_Sales"] = double.Parse(dtDetail.Rows[0]["Revenue"].ToString()).ToString("0,0.0");
                    drr["CreatedDate"] = dr["CreatedDate"].ToString();
                    drr["Revenue"] = String.Format("{0:0.##}", double.Parse(dr["Revenue"].ToString()));
                    drr["TotalCustomer"] = String.Format("{0:0.##}", double.Parse(dr["TotalCustomer"].ToString()));
                    dt.Rows.Add(drr);
                }
            }

            else
            {
                dt = null;
            }
            return dt;                                                      
        }

        //public DataTable GetProductGroupNoOfCustomersMonthAll(string sMonth, string sYear, string ProductType)
        //{
        //    DataTable dt = new DataTable();
        //    // test


        //    DataTable dtProduct = GetGroupProductLis(ProductType);
        //    dt.Columns.Add("STT");
        //    dt.Columns.Add("ProductId");
        //    dt.Columns.Add("Revenue");
        //    dt.Columns["Revenue"].DefaultValue = "0";
        //    dt.Columns.Add("TotalCustomer");
        //    dt.Columns["TotalCustomer"].DefaultValue = "0";
        //    dt.Columns.Add("DD01");
        //    dt.Columns["DD01"].DefaultValue = "0";
        //    dt.Columns.Add("DD02");
        //    dt.Columns["DD02"].DefaultValue = "0";
        //    dt.Columns.Add("DD03");
        //    dt.Columns["DD03"].DefaultValue = "0";
        //    dt.Columns.Add("DD04");
        //    dt.Columns["DD04"].DefaultValue = "0";
        //    dt.Columns.Add("DD05");
        //    dt.Columns["DD05"].DefaultValue = "0";
        //    dt.Columns.Add("DD06");
        //    dt.Columns["DD06"].DefaultValue = "0";
        //    dt.Columns.Add("DD07");
        //    dt.Columns["DD07"].DefaultValue = "0";
        //    dt.Columns.Add("DD08");
        //    dt.Columns["DD08"].DefaultValue = "0";
        //    dt.Columns.Add("DD09");
        //    dt.Columns["DD09"].DefaultValue = "0";
        //    dt.Columns.Add("DD10");
        //    dt.Columns["DD10"].DefaultValue = "0";
        //    dt.Columns.Add("DD11");
        //    dt.Columns["DD11"].DefaultValue = "0";
        //    dt.Columns.Add("DD12");
        //    dt.Columns["DD12"].DefaultValue = "0";
        //    dt.Columns.Add("DD13");
        //    dt.Columns["DD13"].DefaultValue = "0";
        //    dt.Columns.Add("DD14");
        //    dt.Columns["DD14"].DefaultValue = "0";
        //    dt.Columns.Add("DD15");
        //    dt.Columns["DD15"].DefaultValue = "0";
        //    dt.Columns.Add("DD16");
        //    dt.Columns["DD16"].DefaultValue = "0";
        //    dt.Columns.Add("DD17");
        //    dt.Columns["DD17"].DefaultValue = "0";
        //    dt.Columns.Add("DD18");
        //    dt.Columns["DD18"].DefaultValue = "0";
        //    dt.Columns.Add("DD19");
        //    dt.Columns["DD19"].DefaultValue = "0";
        //    dt.Columns.Add("DD20");
        //    dt.Columns["DD20"].DefaultValue = "0";
        //    dt.Columns.Add("DD21");
        //    dt.Columns["DD21"].DefaultValue = "0";
        //    dt.Columns.Add("DD22");
        //    dt.Columns["DD22"].DefaultValue = "0";
        //    dt.Columns.Add("DD23");
        //    dt.Columns["DD23"].DefaultValue = "0";
        //    dt.Columns.Add("DD24");
        //    dt.Columns["DD24"].DefaultValue = "0";
        //    dt.Columns.Add("DD25");
        //    dt.Columns["DD25"].DefaultValue = "0";
        //    dt.Columns.Add("DD26");
        //    dt.Columns["DD26"].DefaultValue = "0";
        //    dt.Columns.Add("DD27");
        //    dt.Columns["DD27"].DefaultValue = "0";
        //    dt.Columns.Add("DD28");
        //    dt.Columns["DD28"].DefaultValue = "0";
        //    dt.Columns.Add("DD29");
        //    dt.Columns["DD29"].DefaultValue = "0";
        //    dt.Columns.Add("DD30");
        //    dt.Columns["DD30"].DefaultValue = "0";
        //    dt.Columns.Add("DD31");
        //    dt.Columns["DD31"].DefaultValue = "0";
        //    dt.Columns.Add("RR01");
        //    dt.Columns["RR01"].DefaultValue = "0";
        //    dt.Columns.Add("RR02");
        //    dt.Columns["RR02"].DefaultValue = "0";
        //    dt.Columns.Add("RR03");
        //    dt.Columns["RR03"].DefaultValue = "0";
        //    dt.Columns.Add("RR04");
        //    dt.Columns["RR04"].DefaultValue = "0";
        //    dt.Columns.Add("RR05");
        //    dt.Columns["RR05"].DefaultValue = "0";
        //    dt.Columns.Add("RR06");
        //    dt.Columns["RR06"].DefaultValue = "0";
        //    dt.Columns.Add("RR07");
        //    dt.Columns["RR07"].DefaultValue = "0";
        //    dt.Columns.Add("RR08");
        //    dt.Columns["RR08"].DefaultValue = "0";
        //    dt.Columns.Add("RR09");
        //    dt.Columns["RR09"].DefaultValue = "0";
        //    dt.Columns.Add("RR10");
        //    dt.Columns["RR10"].DefaultValue = "0";
        //    dt.Columns.Add("RR11");
        //    dt.Columns["RR11"].DefaultValue = "0";
        //    dt.Columns.Add("RR12");
        //    dt.Columns["RR12"].DefaultValue = "0";
        //    dt.Columns.Add("RR13");
        //    dt.Columns["RR13"].DefaultValue = "0";
        //    dt.Columns.Add("RR14");
        //    dt.Columns["RR14"].DefaultValue = "0";
        //    dt.Columns.Add("RR15");
        //    dt.Columns["RR15"].DefaultValue = "0";
        //    dt.Columns.Add("RR16");
        //    dt.Columns["RR16"].DefaultValue = "0";
        //    dt.Columns.Add("RR17");
        //    dt.Columns["RR17"].DefaultValue = "0";
        //    dt.Columns.Add("RR18");
        //    dt.Columns["RR18"].DefaultValue = "0";
        //    dt.Columns.Add("RR19");
        //    dt.Columns["RR19"].DefaultValue = "0";
        //    dt.Columns.Add("RR20");
        //    dt.Columns["RR20"].DefaultValue = "0";
        //    dt.Columns.Add("RR21");
        //    dt.Columns["RR21"].DefaultValue = "0";
        //    dt.Columns.Add("RR22");
        //    dt.Columns["RR22"].DefaultValue = "0";
        //    dt.Columns.Add("RR23");
        //    dt.Columns["RR23"].DefaultValue = "0";
        //    dt.Columns.Add("RR24");
        //    dt.Columns["RR24"].DefaultValue = "0";
        //    dt.Columns.Add("RR25");
        //    dt.Columns["RR25"].DefaultValue = "0";
        //    dt.Columns.Add("RR26");
        //    dt.Columns["RR26"].DefaultValue = "0";
        //    dt.Columns.Add("RR27");
        //    dt.Columns["RR27"].DefaultValue = "0";
        //    dt.Columns.Add("RR28");
        //    dt.Columns["RR28"].DefaultValue = "0";
        //    dt.Columns.Add("RR29");
        //    dt.Columns["RR29"].DefaultValue = "0";
        //    dt.Columns.Add("RR30");
        //    dt.Columns["RR30"].DefaultValue = "0";
        //    dt.Columns.Add("RR31");
        //    dt.Columns["RR31"].DefaultValue = "0";

        //    if (dtProduct != null)
        //    {
        //        int year = int.Parse(sYear);
        //        int month = int.Parse(sMonth);
        //        int j = 0;
        //        foreach (DataRow dr in dtProduct.Rows)
        //        {
        //            double TT_rev = 0;
        //            double TT_Tim = 0;

        //            DataRow drr = dt.NewRow();
        //            //DataRow drTot = dt.NewRow();
        //            drr["STT"] = (j + 1).ToString();
        //            drr["ProductId"] = Common.clsLanguages.GetResource("GroupId") + ": " + dr["ProductType"].ToString() + "\n" + Common.clsLanguages.GetResource("GroupName") + ": " + dr["StrValue1"].ToString();
        //            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
        //            {
        //                DateTime dat = new DateTime(year, month, i);

        //                DataTable dtDetail = GetProductGroupNoOfCustomersDay(dat, dr["ProductType"].ToString());
        //                string stt = i.ToString();
        //                if (stt.Length == 1)
        //                {
        //                    stt = "0" + stt;
        //                }
        //                if (dtDetail != null)
        //                {
        //                    //drr["HH" + stt + "_Total_Sales"] = double.Parse(dtDetail.Rows[0]["Revenue"].ToString()).ToString("0,0.0");
        //                    drr["DD" + stt + ""] = double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString()).ToString("0,0");
        //                    drr["RR" + stt + ""] = String.Format("{0:0.##}", double.Parse(dtDetail.Rows[0]["Revenue"].ToString()));
        //                    TT_rev = TT_rev + double.Parse(dtDetail.Rows[0]["Revenue"].ToString());
        //                    TT_Tim = TT_Tim + double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString());
        //                }
        //                else
        //                {
        //                    // drr["HH" + stt + "_Total_Sales"] = "0.0";
        //                    drr["DD" + stt + ""] = "0";
        //                    drr["RR" + stt + ""] = "0";
        //                }
        //            }
        //            j++;
        //            drr["Revenue"] = String.Format("{0:0.##}", TT_rev);
        //            drr["TotalCustomer"] = TT_Tim.ToString("0,0");

        //            dt.Rows.Add(drr);

        //        }

        //    }
        //    else
        //    {
        //        dt = null;
        //    }
        //    return dt;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sDate"></param>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        //product group
        public DataTable GetProductGroupNoOfCustomersDay(string sMonth, string sYear, string ProductType)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT b.`ProductType`,d.`StrValue1`, DAY( a.`CreatedDate`) as CreatedDate,                                
                                a.`TotalAmount` AS `Revenue`,
                                c.`NoOfCustumers` AS TotalCustomer
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                      INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId` 
                                      LEFT JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId`             
                            WHERE d.`CommonTypeId`='ProductType' AND ";
            query += " MONTH( a.`CreatedDate`) = " + sMonth;
            query += " AND YEAR( a.`CreatedDate`) =  " + sYear;
            if (ProductType != "")
            {
                query += String.Format(" AND b.`ProductType` = '{0}' ", ProductType);
            }
            //query += " GROUP BY `a`.`ProductId`";
            query += " ORDER BY DAY( a.`CreatedDate`)";

            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "Receipt", ref errorString);

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

        public DataTable GetProductNoOfCustomers(string sMonth, string sYear, string ProductId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT a.`ProductId`, b.`Name`,  DAY( a.`CreatedDate`) as CreatedDate,                            
                               a.`TotalAmount` AS `Revenue`,
                                c.`NoOfCustumers` AS TotalCustomer
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                      INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`              
                            WHERE ";
            query += " MONTH( a.`CreatedDate`) = " +sMonth;
            query += " AND YEAR( a.`CreatedDate`) =  " +sYear;
            if (ProductId != "")
            {
                query += String.Format(" AND `a`.`ProductId` = '{0}' ", ProductId);
            }
            //query += " GROUP BY `a`.`ProductId`";
            query += " ORDER BY DAY( a.`CreatedDate`)";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "Receipt", ref errorString);

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

        #region Begin Dung get in Store Aeon

        public DataTable GetProductRPHourAllProduct_Aeon(DateTime from, DateTime to, string ProductId)
        {
            DataTable dt = new DataTable();
            DataTable dtProduct = GetProductList_Aeon(ProductId, from, to);// spSearch_ProductB
            dt.Columns.Add("STT");
            dt.Columns.Add("ProductId");
            dt.Columns.Add("Name");
            dt.Columns["Name"].DefaultValue = "";
            dt.Columns.Add("Revenue");
            dt.Columns["Revenue"].DefaultValue = "0";
            dt.Columns.Add("TotalCustomer");
            dt.Columns["TotalCustomer"].DefaultValue = "0";
            dt.Columns.Add("HH08_Total_Sales");
            dt.Columns["HH08_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH08_Total_Times");
            dt.Columns["HH08_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH09_Total_Sales");
            dt.Columns["HH09_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH09_Total_Times");
            dt.Columns["HH09_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH10_Total_Sales");
            dt.Columns["HH10_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH10_Total_Times");
            dt.Columns["HH10_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH11_Total_Sales");
            dt.Columns["HH11_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH11_Total_Times");
            dt.Columns["HH11_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH12_Total_Sales");
            dt.Columns["HH12_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH12_Total_Times");
            dt.Columns["HH12_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH13_Total_Sales");
            dt.Columns["HH13_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH13_Total_Times");
            dt.Columns["HH13_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH14_Total_Sales");
            dt.Columns["HH14_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH14_Total_Times");
            dt.Columns["HH14_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH15_Total_Sales");
            dt.Columns["HH15_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH15_Total_Times");
            dt.Columns["HH15_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH16_Total_Sales");
            dt.Columns["HH16_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH16_Total_Times");
            dt.Columns["HH16_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH17_Total_Sales");
            dt.Columns["HH17_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH17_Total_Times");
            dt.Columns["HH17_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH18_Total_Sales");
            dt.Columns["HH18_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH18_Total_Times");
            dt.Columns["HH18_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH19_Total_Sales");
            dt.Columns["HH19_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH19_Total_Times");
            dt.Columns["HH19_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH20_Total_Sales");
            dt.Columns["HH20_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH20_Total_Times");
            dt.Columns["HH20_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH21_Total_Sales");
            dt.Columns["HH21_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH21_Total_Times");
            dt.Columns["HH21_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH22_Total_Sales");
            dt.Columns["HH22_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH22_Total_Times");
            dt.Columns["HH22_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH23_Total_Sales");
            dt.Columns["HH23_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH23_Total_Times");
            dt.Columns["HH23_Total_Times"].DefaultValue = "0";
            if (dtProduct != null)
            {
                int j = 0;
                foreach (DataRow dr in dtProduct.Rows)
                {

                    double TT_rev = 0;
                    double TT_Tim = 0;

                    DataRow drr = dt.NewRow();
                    //DataRow drTot = dt.NewRow();
                    drr["STT"] = (j + 1).ToString();
                    drr["ProductId"] = Common.clsLanguages.GetResource("ProductID")
                        + ": \n" + dr["ProductId"].ToString() + "\n" + Common.clsLanguages.GetResource("ProductName") + ": \n" + dr["Name"].ToString();
                    drr["Name"] = dr["Name"].ToString();

                    for (int i = 8; i < 24; i++)
                    {
                        DataTable dtDetail = GetProductRPHourDetail_Aeon(from, to, dr["ProductId"].ToString(), i.ToString());
                        string stt = i.ToString();
                        if (stt.Length == 1)
                        {
                            stt = "0" + stt;
                        }
                        if (dtDetail != null)
                        {
                            drr["HH" + stt + "_Total_Sales"] = String.Format("{0:0.##}", double.Parse(dtDetail.Rows[0]["DoanhThu"].ToString()));

                            drr["HH" + stt + "_Total_Times"] = double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString()).ToString("0,0");
                            TT_rev = TT_rev + double.Parse(dtDetail.Rows[0]["DoanhThu"].ToString());
                            TT_Tim = TT_Tim + double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString());
                        }
                        else
                        {
                            drr["HH" + stt + "_Total_Sales"] = "0.0";
                            drr["HH" + stt + "_Total_Times"] = "0";
                        }

                    }
                    j++;
                    drr["Revenue"] = String.Format("{0:0.##}", TT_rev);
                    drr["TotalCustomer"] = TT_Tim.ToString("0,0");

                    dt.Rows.Add(drr);

                }
            }
            else
            {
                dt = null;
            }
            return dt;

        }

        public DataTable GetProductList_Aeon(string ProductId, DateTime from, DateTime to)
        {
            string query = @"SELECT *
                 FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                         INNER JOIN `receipts` p ON a.`ReceiptId` = p.`ReceiptId`   
                                         WHERE p.`Status` = '1' AND
                             ";
            query += String.Format("DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) >= '{0}' ", from.ToString("yyyy-MM-dd"));
            query += String.Format("AND DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) <= '{0}' ", to.ToString("yyyy-MM-dd"));
            if (ProductId != "")
            {
                query += " AND a.`ProductId`=" + ProductId;
            }
            query += " GROUP BY a.`ProductId`";
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

        public DataTable GetProductRPHourDetail_Aeon(DateTime from, DateTime to, string productID, string timeF)
        {
            string query = @"SELECT a.`ProductId`, b.`Name`,                              
                                SUM(a.`TotalAmount`) AS `DoanhThu`,
                                COUNT(a.`ReceiptId`) AS TotalCustomer
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
                                            
                                         WHERE c.`Status` = '1'
                            AND ";
            query += String.Format("DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) >= '{0}' ", from.ToString("yyyy-MM-dd"));
            query += String.Format("AND DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) <= '{0}' ", to.ToString("yyyy-MM-dd"));
            query += String.Format("AND a.`Status` = '1' ");
            query += String.Format(" AND HOUR(a.`CreatedDate`) ='{0}' ", timeF);
            query += String.Format(" AND a.`ProductId` = '{0}' ", productID);
            query += "GROUP BY a.`ProductId`";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Receipt", ref errorString);

            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["Receipt"].Rows.Count != 0)
            {
                DataTable dt = new DataTable("Receipt");
                dt = dataset.Tables[0];
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetGroupProductRPHourAllProduct_Aeon(DateTime from, DateTime to, string ProductType)
        {

            DataTable dt = new DataTable();
            DataTable dtProduct = GetGroupProductList(ProductType, from, to);
            dt.Columns.Add("STT");
            dt.Columns.Add("ProductId");
            dt.Columns.Add("Name");
            dt.Columns["Name"].DefaultValue = "";
            dt.Columns.Add("Revenue");
            dt.Columns["Revenue"].DefaultValue = "0";
            dt.Columns.Add("TotalCustomer");
            dt.Columns["TotalCustomer"].DefaultValue = "0";
            dt.Columns.Add("HH08_Total_Sales");
            dt.Columns["HH08_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH08_Total_Times");
            dt.Columns["HH08_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH09_Total_Sales");
            dt.Columns["HH09_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH09_Total_Times");
            dt.Columns["HH09_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH10_Total_Sales");
            dt.Columns["HH10_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH10_Total_Times");
            dt.Columns["HH10_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH11_Total_Sales");
            dt.Columns["HH11_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH11_Total_Times");
            dt.Columns["HH11_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH12_Total_Sales");
            dt.Columns["HH12_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH12_Total_Times");
            dt.Columns["HH12_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH13_Total_Sales");
            dt.Columns["HH13_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH13_Total_Times");
            dt.Columns["HH13_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH14_Total_Sales");
            dt.Columns["HH14_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH14_Total_Times");
            dt.Columns["HH14_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH15_Total_Sales");
            dt.Columns["HH15_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH15_Total_Times");
            dt.Columns["HH15_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH16_Total_Sales");
            dt.Columns["HH16_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH16_Total_Times");
            dt.Columns["HH16_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH17_Total_Sales");
            dt.Columns["HH17_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH17_Total_Times");
            dt.Columns["HH17_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH18_Total_Sales");
            dt.Columns["HH18_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH18_Total_Times");
            dt.Columns["HH18_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH19_Total_Sales");
            dt.Columns["HH19_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH19_Total_Times");
            dt.Columns["HH19_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH20_Total_Sales");
            dt.Columns["HH20_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH20_Total_Times");
            dt.Columns["HH20_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH21_Total_Sales");
            dt.Columns["HH21_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH21_Total_Times");
            dt.Columns["HH21_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH22_Total_Sales");
            dt.Columns["HH22_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH22_Total_Times");
            dt.Columns["HH22_Total_Times"].DefaultValue = "0";
            dt.Columns.Add("HH23_Total_Sales");
            dt.Columns["HH23_Total_Sales"].DefaultValue = "0";
            dt.Columns.Add("HH23_Total_Times");
            dt.Columns["HH23_Total_Times"].DefaultValue = "0";
            if (dtProduct != null)
            {
                int j = 0;
                foreach (DataRow dr in dtProduct.Rows)
                {

                    double TT_rev = 0;
                    double TT_Tim = 0;

                    DataRow drr = dt.NewRow();
                    //DataRow drTot = dt.NewRow();
                    drr["STT"] = (j + 1).ToString();
                    drr["ProductId"] = Common.clsLanguages.GetResource("GroupId") + ": " + dr["ProductType"].ToString() + "\n" + Common.clsLanguages.GetResource("GroupName") + ": " + dr["StrValue1"].ToString();
                    drr["Name"] = "";

                    for (int i = 8; i < 24; i++)
                    {
                        DataTable dtDetail = GetGroupProductRPHourDetail(from, to, dr["ProductType"].ToString(), i.ToString());
                        string stt = i.ToString();
                        if (stt.Length == 1)
                        {
                            stt = "0" + stt;
                        }
                        if (dtDetail != null)
                        {
                            drr["HH" + stt + "_Total_Sales"] = String.Format("{0:0.##}", double.Parse(dtDetail.Rows[0]["DoanhThu"].ToString()));
                            drr["HH" + stt + "_Total_Times"] = double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString()).ToString("0,0");
                            TT_rev = TT_rev + double.Parse(dtDetail.Rows[0]["DoanhThu"].ToString());
                            TT_Tim = TT_Tim + double.Parse(dtDetail.Rows[0]["TotalCustomer"].ToString());
                        }
                        else
                        {
                            drr["HH" + stt + "_Total_Sales"] = "0.0";
                            drr["HH" + stt + "_Total_Times"] = "0";
                        }

                    }
                    j++;
                    drr["Revenue"] = String.Format("{0:0.##}", TT_rev);
                    drr["TotalCustomer"] = TT_Tim.ToString("0,0");

                    dt.Rows.Add(drr);

                }
            }
            else
            {
                dt = null;
            }
            return dt;

        }

        public DataTable GetGroupProductRPHourDetail(DateTime from, DateTime to, string ProductType, string timeF)
        {
            string query = @"SELECT b.`ProductType`,                              
                                SUM(a.`TotalAmount`) AS `DoanhThu`,
                                COUNT(a.`ReceiptId`) AS TotalCustomer
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
                            WHERE c.`Status` = '1' AND
                           
                                ";
            query += String.Format("DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) >= '{0}' ", from.ToString("yyyy-MM-dd"));
            query += String.Format("AND DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) <= '{0}' ", to.ToString("yyyy-MM-dd"));
            query += String.Format("AND a.`Status` = '1' ");
            query += String.Format(" AND HOUR(a.`CreatedDate`) ='{0}' ", timeF);
            query += String.Format(" AND b.`ProductType` = '{0}' ", ProductType);
            query += "GROUP BY b.`ProductType`";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Receipt", ref errorString);

            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["Receipt"].Rows.Count != 0)
            {
                DataTable dt = new DataTable("Receipt");
                dt = dataset.Tables[0];
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetGroupProductList(string ProductType, DateTime from, DateTime to)
        {


            string query = @"SELECT b.`ProductType`,d.`StrValue1`                            
                               
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`
						    INNER JOIN `commoncode` d  ON b.`ProductType`=d.`CommonId`
                                            
                                         WHERE c.`Status` = '1' AND
						     d.`CommonTypeId`='ProductType' AND ";
            query += String.Format("DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) >= '{0}' ", from.ToString("yyyy-MM-dd"));
            query += String.Format("AND DATE_FORMAT( a.`CreatedDate`,  '%Y-%m-%d' ) <= '{0}' ", to.ToString("yyyy-MM-dd"));
            if (ProductType != "")
            {
                query += " AND b.`ProductType`='" + ProductType + "'";
            }
            query += " GROUP BY b.`ProductType`";


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
        #endregion End Dung get in Store Aeon

        // hung 19-1-2014
        public List<Receipts> GetQtyCardBank(string fromdate, string todate, string month, string year, string CardNo)
        {
            List<Receipts> lrc1 = new List<Receipts>();
            string[][] param ={
                new string[] {"p_Fromdate", string.IsNullOrEmpty(fromdate)?null:fromdate},
                new string[] {"p_Todate", string.IsNullOrEmpty(todate)?null:todate},
                new string[] {"p_Month", string.IsNullOrEmpty(month)?null:month.ToString()},
                new string[] {"p_Year", string.IsNullOrEmpty(year)?null:year.ToString()},
                new string[] {"p_CardNo", string.IsNullOrEmpty(CardNo)?null:CardNo},
            };
            ds = new DataSet();

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spQtyCardBank", ref ds, param, ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                /*
                 * ------------------------Set List<ReceiptObject>----------------------------*
                 */
                receiptsBLL = new ReceiptsBLL();
                DataTable dtBank = receiptsBLL.GetBank();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Receipts rc = new Receipts();
                    rc.ReceiptId = r["ReceiptId"].ToString();

                    rc.CardNo = r["CardNo"].ToString();
                    //
                    DataTable dtCardType = receiptsBLL.GetBankType(r["Bank"].ToString());
                    if (dtCardType != null && dtCardType.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtCardType.Rows)
                        {
                            if (r["CardType"].ToString() == row["CommonId"].ToString())
                                rc.CardType = row["StrValue1"].ToString();
                        }
                    }
                    else rc.CardType = r["CardType"].ToString();
                    //
                    if (dtBank != null && dtBank.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtBank.Rows)
                        {
                            if (r["Bank"].ToString() == row["CommonId"].ToString())
                                rc.Bank = row["StrValue1"].ToString();
                        }
                    }
                    else rc.Bank = r["Bank"].ToString();

                    rc.TotalAmount = String.Format("{0:0.##}", double.Parse(r["TotalAmount"].ToString()));

                    rc.CreatedBy = r["CreatedBy"].ToString();
                    rc.CreatedDate = r["CreatedDate"].ToString();

                    lrc1.Add(rc);
                }
            }
            else
            {
                lrc1 = null;
            }

            return lrc1;
        }

        public ReceiptsBLL receiptsBLL { get; set; }

        public DataTable GetBank()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='BankName' ";
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
        //bankType
        public DataTable GetBankType(string commonId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='CardBankType'";
            if (commonId != "")
            {
                query += " AND `StrValue2`=" + commonId;
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
