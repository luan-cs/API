using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosS.Entities;

namespace VVPosS.BusinessLayer
{
    class BankCardBLL
    {

        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }


        public DataTable SearchObjects(ReceiptsCard receiptCardSea, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string[][] param ={
              
                new string[] { "p_id", string.IsNullOrEmpty(receiptCardSea.id)?null:receiptCardSea.id },
                new string[] { "p_ReceiptId", string.IsNullOrEmpty(receiptCardSea.ReceiptId)?null:receiptCardSea.ReceiptId },
                new string[] { "p_CardNo", string.IsNullOrEmpty(receiptCardSea.CardNo)?null: receiptCardSea.CardNo},
                new string[] { "p_CardHolderName", string.IsNullOrEmpty(receiptCardSea.CardHolderName )?null: receiptCardSea.CardHolderName },
                new string[] { "p_ExpiredDate", string.IsNullOrEmpty(receiptCardSea.ExpiredDate)?null: receiptCardSea.ExpiredDate  },
                new string[] { "p_CardType", string.IsNullOrEmpty(receiptCardSea.CardType)?null:receiptCardSea.CardType },
                new string[] { "p_Bank", string.IsNullOrEmpty(receiptCardSea.Bank)?null:receiptCardSea.Bank },
                new string[] { "p_TotalAmount", string.IsNullOrEmpty(receiptCardSea.TotalAmount)?null:receiptCardSea.TotalAmount }, 
                new string[] { "p_TerminalId", string.IsNullOrEmpty(receiptCardSea.TerminalId)?null:receiptCardSea.TerminalId},
                new string[] { "p_MerchantId", string.IsNullOrEmpty(receiptCardSea.MerchantId)?null:receiptCardSea.MerchantId },
                new string[] { "p_TransType", string.IsNullOrEmpty(receiptCardSea.TransType)?null:receiptCardSea.TransType },
                new string[] { "p_BatchNo",string.IsNullOrEmpty(receiptCardSea.BatchNo)?null:receiptCardSea.BatchNo  },
                new string[] { "p_TraceNo",string.IsNullOrEmpty(receiptCardSea.TraceNo)?null:receiptCardSea.TraceNo   },
                new string[] { "p_RefNo", string.IsNullOrEmpty(receiptCardSea.RefNo)?null:receiptCardSea.RefNo },
                new string[] { "p_CreatedBy", string.IsNullOrEmpty(receiptCardSea.CreatedBy)?null:receiptCardSea.CreatedBy },
                new string[] { "p_CreatedDate", string.IsNullOrEmpty(receiptCardSea.CreatedDate)?null:receiptCardSea.CreatedDate },
                new string[] { "p_ModifiedBy", string.IsNullOrEmpty(receiptCardSea.ModifiedBy)?null:receiptCardSea.ModifiedBy },
                new string[] { "p_ModifiedDate", string.IsNullOrEmpty(receiptCardSea.ModifiedDate)?null:receiptCardSea.ModifiedDate },
                new string[] { "p_Appcode", string.IsNullOrEmpty(receiptCardSea.AppCode)?null:receiptCardSea.AppCode },
                
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_ReceiptCard", ref ds, param, ref errorString);

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

        public ReceiptsCard GetReceiptCardWithID(string id)
        {
            ReceiptsCard reCard = new ReceiptsCard();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `receiptscard`
                            WHERE `Id`='" + id + "' ";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reCard.id = ds.Tables[0].Rows[0]["id"].ToString();
                reCard.ReceiptId = ds.Tables[0].Rows[0]["ReceiptId"].ToString();
                reCard.CardNo = ds.Tables[0].Rows[0]["CardNo"].ToString();
                reCard.CardHolderName = ds.Tables[0].Rows[0]["CardHolderName"].ToString();
                reCard.ExpiredDate = ds.Tables[0].Rows[0]["ExpiredDate"].ToString();
                reCard.CardType = ds.Tables[0].Rows[0]["CardType"].ToString();
                reCard.Bank = ds.Tables[0].Rows[0]["Bank"].ToString();
                reCard.TotalAmount = ds.Tables[0].Rows[0]["TotalAmount"].ToString();
                reCard.TerminalId = ds.Tables[0].Rows[0]["TerminalId"].ToString();
                reCard.MerchantId = ds.Tables[0].Rows[0]["MerchantId"].ToString();
                reCard.TransType = ds.Tables[0].Rows[0]["TransType"].ToString();
                reCard.BatchNo = ds.Tables[0].Rows[0]["BatchNo"].ToString();
                reCard.TraceNo = ds.Tables[0].Rows[0]["TraceNo"].ToString();
                reCard.RefNo = ds.Tables[0].Rows[0]["RefNo"].ToString();
                reCard.AppCode = ds.Tables[0].Rows[0]["AppCode"].ToString();
                reCard.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                reCard.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                reCard.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                reCard.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();

            }
            else
            {

                reCard = null;
            }
            return reCard;
        }

        public int Update(ReceiptsCard obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE receiptscard SET ";
            if (!string.IsNullOrEmpty(obj.Bank))
            {
                queryStr += string.Format(" Bank = '{0}',", obj.Bank);
            }
            if (!string.IsNullOrEmpty(obj.CardType))
            {
                queryStr += string.Format(" CardType = '{0}',", obj.CardType);
            }

            queryStr += string.Format(" CardNo = '{0}',", obj.CardNo);

            queryStr += string.Format(" CardHolderName = '{0}',", obj.CardHolderName);
            
            if (!string.IsNullOrEmpty(obj.ExpiredDate))
            {
                queryStr += string.Format(" ExpiredDate = '{0}',", obj.ExpiredDate);
            }

            queryStr += string.Format(" AppCode = '{0}',", obj.AppCode);


            queryStr += string.Format(" BatchNo = '{0}',", obj.BatchNo);

            queryStr += string.Format(" TransType = '{0}',", obj.TransType);
            queryStr += string.Format(" MerchantId = '{0}',", obj.MerchantId);

            queryStr += string.Format(" TerminalId = '{0}',", obj.TerminalId);


            queryStr += string.Format(" TraceNo = '{0}',", obj.TraceNo);

            queryStr += string.Format(" RefNo = '{0}',", obj.RefNo);
           
           
           
            queryStr += string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += string.Format(" WHERE id = '{0}'", obj.id);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public DataTable GetBankName(string commonId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT * FROM `commoncode` where `CommonId` ='" + commonId + "' AND  `CommonTypeId` ='BankName'";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }
        public DataTable GetCardType(string commonId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT * FROM `commoncode` where `CommonId` ='" + commonId + "' AND  `CommonTypeId` ='CardBankType'";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
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
