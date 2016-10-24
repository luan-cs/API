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
        #endregion

        #region Thêm mới 1 Receipts
        public void AddNew(Receipts Receipt, 
            List<ReceiptDetails> lst_RD, 
            List<ReceiptsCard> lst_Card, 
            ReceiptInfo ri, 
            ReceiptMember rm, ref string ReceiptID)
        {
            ReceiptID = "";
            string[][] prm_R = {
                new string[] {"ReceiptId",""},
                new string[] {"Note",Receipt.Note},
                //new string[] {"NoOfCustumers",Receipt.NoOfCustumers},
                new string[] {"NoOfCustumers","0"},
                new string[] {"CreatedBy",Receipt.CreatedBy},
                new string[] {"Status",Receipt.Status},
                new string[] {"TotalTax",double.Parse(Receipt.TotalTax).ToString()},
                new string[] {"TotalAmount",double.Parse(Receipt.TotalAmount).ToString()},
                new string[] {"TotalAmountBeforeTax",double.Parse(Receipt.TotalAmountBeforeTax).ToString()},
                new string[] {"DiscountAmount",double.Parse(Receipt.DiscountAmount).ToString()},
                new string[] {"TotalMoney",double.Parse(Receipt.TotalMoney).ToString()},
                new string[] {"CashPayAmt",double.Parse(Receipt.CashPayAmt).ToString()},
                new string[] {"CardPayAmt",double.Parse(Receipt.CardPayAmt).ToString()},
                new string[] {"ReturnAmt",double.Parse(Receipt.ReturnAmt).ToString()},
                new string[] {"ServiceCostAmount",double.Parse(Receipt.ServiceCostAmount).ToString()}
            };

            string[][][] prm_RD = new string[lst_RD.Count][][];
            int i = 0;
            foreach (ReceiptDetails rdt in lst_RD) //'TotalAmmount' 
            {
                string[][] prm = {
                new string[] {"ReceiptId",""},
                new string[] {"ProductId",rdt.ProductId},
                new string[] {"PromotionId",rdt.PromotionId},
                new string[] {"CreatedBy",rdt.CreatedBy},
                new string[] {"Status",rdt.Status},
                new string[] {"Qty",double.Parse(rdt.Qty).ToString()},
                new string[] {"Price",double.Parse(rdt.Price).ToString()},
                new string[] {"TotalAmountBeforeTax",double.Parse(rdt.TotalAmountBeforeTax).ToString()},
                new string[] {"TaxAmount",double.Parse(rdt.TaxAmount).ToString()},
                new string[] {"TotalAmount",double.Parse(rdt.TotalAmount).ToString()},
                new string[] {"RefOrderId",rdt.RefOrderId},
                new string[] {"DeskId",rdt.DeskId}
                };
                prm_RD[i] = prm;
                i++;
            }

            string[][][] prm_Card = null;
            if (lst_Card == null || lst_Card.Count == 0)
            {
                prm_Card = null;
            }
            else
            {
                i = 0;
                prm_Card = new string[lst_Card.Count][][];
                foreach (ReceiptsCard rc in lst_Card)
                {
                    string[][] prm = {
                        new string[] {"ReceiptId",""},
                        new string[] {"CardNo",rc.CardNo},
                        new string[] {"CardHolderName",rc.CardHolderName},
                        new string[] {"ExpiredDate",rc.ExpiredDate},
                        new string[] {"CreatedBy",rc.CreatedBy},
                        new string[] {"TotalAmount",double.Parse(rc.TotalAmount).ToString()},
                        new string[] {"Bank",rc.Bank},
                        new string[] {"CardType",rc.CardType},

                        new string[] {"TerminalId",rc.TerminalId},
                        new string[] {"MerchantId",rc.MerchantId},
                        new string[] {"TransType",rc.TransType},
                        new string[] {"BatchNo",rc.BatchNo},
                        new string[] {"TraceNo",rc.TraceNo},
                        new string[] {"RefNo",rc.RefNo},
                        new string[] {"AppCode",rc.AppCode}
                    };
                    prm_Card[i] = prm;
                    i++;
                }
            }
            ///////
            string[][] prm_RI = { };
            if (ri != null)
            {
                string[][] prm = {
                        new string[] {"ReceiptId",""},
                        new string[] {"CustomerName",ri.CustomerName},
                        new string[] {"Address",ri.Address},
                        new string[] {"Phone",ri.Phone},
                        new string[] {"Note",ri.Note}                       
                    };
                prm_RI = prm;
            }
            else
            {
                prm_RI = null;
            }

            ////////////////
            string[][] prm_RM = { };
            if (rm != null)
            {
                string[][] prm = {
                        new string[] {"ReceiptId",""},
                        new string[] {"MemberId",rm.MemberId},
                        new string[] {"Score",null},
                        new string[] {"CreatedBy",rm.CreatedBy}              
                    };
                prm_RM = prm;
            }
            else
            {
                prm_RM = null;
            }


            Program.destopService.Tran_Insert_Receipt(Program.Username, Program.Password, ref errorString,
                prm_R, prm_RD, prm_Card,prm_RM,prm_RI,
                ref res, ref ReceiptID);
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

                    rc.ServiceCostAmount = double.Parse(dr["ServiceCostAmount"].ToString()).ToString("0,0");

                    res.receipt = rc;
                }
                /////
                if (ds.Tables[1].Rows.Count > 0)
                {
                    Tuple<string, string> result;
                    DataTable dt = ds.Tables[1];
                    List<ReceiptDetails> lst = new List<ReceiptDetails>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        ReceiptDetails rc = new ReceiptDetails();
                        rc.ReceiptId = dr["ReceiptId"].ToString();
                        rc.ProductId = dr["ProductId"].ToString();
                        if (dr["ProductId"].ToString() != "DISCOUNT"){
                            result = GetProductInfoForReceipt(dr["ProductId"].ToString());
                            //rc.ProductName = GetProductName(dr["ProductId"].ToString());
                            rc.ProductName = result.Item1;
                            rc.IsBuffet = result.Item2;
                        }
                        else {
                            rc.ProductName = dr["ProductId"].ToString();
                            rc.IsBuffet = "0";
                        }

                        rc.Qty = double.Parse(dr["Qty"].ToString()).ToString("0,0");
                        rc.Price = double.Parse(dr["Price"].ToString()).ToString("0,0");                        
                        rc.TotalAmountBeforeTax = double.Parse(dr["TotalAmountBeforeTax"].ToString()).ToString("0,0");
                        rc.TaxAmount = double.Parse(dr["TaxAmount"].ToString()).ToString("0,0");
                        rc.TotalAmount = double.Parse(dr["TotalAmount"].ToString()).ToString("0,0");

                        lst.Add(rc);
                    }

                    //Duyệt lại lst va set theo thu tu
                    List<ReceiptDetails> lstNew = new List<ReceiptDetails>();
                    //Lấy sp khác buffet
                    foreach (ReceiptDetails rd in lst) {
                        ReceiptDetails rds = new ReceiptDetails();
                        if (rd.IsBuffet != "1") {
                            rds.ReceiptId = rd.ReceiptId;
                            rds.ProductId = rd.ProductId;

                            rds.ProductName = rd.ProductName;
                            rds.IsBuffet = rd.IsBuffet;

                            rds.Qty = rd.Qty;
                            rds.Price = rd.Price;
                            rds.TotalAmountBeforeTax = rd.TotalAmountBeforeTax;
                            rds.TaxAmount = rd.TaxAmount;
                            rds.TotalAmount = rd.TotalAmount;

                            lstNew.Add(rds);
                        }
                    }
                    if(lst.Count > lstNew.Count){
                        //Lấy sp là buffet và price != 0
                        foreach (ReceiptDetails rd in lst)
                        {
                            ReceiptDetails rds1 = new ReceiptDetails();
                            if (rd.IsBuffet == "1" && double.Parse(rd.Price) > 0)
                            {
                                rds1.ReceiptId = rd.ReceiptId;
                                rds1.ProductId = rd.ProductId;

                                rds1.ProductName = rd.ProductName;
                                rds1.IsBuffet = rd.IsBuffet;

                                rds1.Qty = rd.Qty;
                                rds1.Price = rd.Price;
                                rds1.TotalAmountBeforeTax = rd.TotalAmountBeforeTax;
                                rds1.TaxAmount = rd.TaxAmount;
                                rds1.TotalAmount = rd.TotalAmount;

                                lstNew.Add(rds1);
                            }
                        }

                        foreach (ReceiptDetails rd in lst)
                        {
                            ReceiptDetails rds2 = new ReceiptDetails();
                            if (rd.IsBuffet == "1" && double.Parse(rd.Price) == 0)
                            {
                                rds2.ReceiptId = rd.ReceiptId;
                                rds2.ProductId = rd.ProductId;

                                rds2.ProductName = rd.ProductName;
                                rds2.IsBuffet = rd.IsBuffet;

                                rds2.Qty = rd.Qty;
                                rds2.Price = rd.Price;
                                rds2.TotalAmountBeforeTax = rd.TotalAmountBeforeTax;
                                rds2.TaxAmount = rd.TaxAmount;
                                rds2.TotalAmount = rd.TotalAmount;

                                lstNew.Add(rds2);
                            }
                        }
                    }
                    res.lst_Detail = lstNew;
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

        public DataTable GetReceipts()
        {
            DataSet ds = new DataSet();
            Program.destopService.DataStoreProcQuery(Program.Username, Program.Password, "spSelect_Receipts", ref ds, ref errorString);

            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
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

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
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

        public Tuple<string, string> GetProductInfoForReceipt(string ProID)
        {
            string sName = "", sType = "", isbuffet = "";
            DataTable dt = new DataTable();
            string query = @"SELECT *
                            FROM `products`
                            WHERE  `ProductId` ='" + ProID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Products", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
            {
                dt = dataset.Tables["Products"];
                sName = dt.Rows[0]["name"].ToString();
                sType = dt.Rows[0]["ProductType"].ToString();
                //spSelect_Desk_Status_StrValues
                DataSet ds1 = new DataSet();
                string query1 = @"SELECT *
                            FROM `commoncode`
                            WHERE  `CommonTypeId` ='ProductType' AND `CommonId` = '" + sType + "'";
                Program.destopService.DataQuery(Program.Username, Program.Password, query1, ref ds1, "x", ref errorString);
                if (string.IsNullOrEmpty(errorString) && ds1.Tables[0].Rows.Count > 0)
                {
                    isbuffet = ds1.Tables["x"].Rows[0]["IsBuffet"].ToString();
                }
            }

            return new Tuple<string, string>(sName, isbuffet);
        }

        public DataTable GetMemberInfo(string MemberID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT *
                            FROM `members`
                            WHERE  `members`.`MemberCode` ='" + MemberID + "'";
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

        // Hùng
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
