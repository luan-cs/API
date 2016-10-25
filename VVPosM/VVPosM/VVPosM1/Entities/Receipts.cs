using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class Receipts
    {
        public string ReceiptType { get; set; }//Deposit or Withdraw

        public string ReceiptId { get; set; }
        public string Note { get; set; }
        public string NoOfCustumers { get; set; }
        //public string group { get; set; }
        public string Status { get; set; }

        public string TotalAmountBeforeTax { get; set; }
        public string TotalTax { get; set; }
        public string TotalAmount { get; set; }
        public string DiscountPercent { get; set; }
        public string DiscountAmount { get; set; }
        public string TotalMoney { get; set; }

        public string CashPayAmt { get; set; }
        public string CardPayAmt { get; set; }
        public string CouponCodePayAmt { get; set; }
        public string ReturnAmt { get; set; }

        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }

        //Object
        public string ObjectId { get; set; }
        public string FullName { get; set; }

        //User
        public string UserId { get; set; }

        public string User { get; set; }

        //ReceiptsCard
        public string CardNo { get; set; }
        public string CardType { get; set; }
        public string Bank { get; set; }

        /*Add for 12 Items Report*/
        public string NumberofSettlementperday { get; set; }
        public string NumOfTran { get; set; }
        public string TotalWithDraw { get; set; }
    }

    public class ReceiptsCard
    {
        public string id { get; set; }
        public string ReceiptId { get; set; }
        public string CardNo { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiredDate { get; set; }

        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string CardType { get; set; }
        public string Bank { get; set; }
        public string TotalAmount { get; set; }

        public string TerminalId { get; set; }
        public string MerchantId { get; set; }
        public string TransType { get; set; }
        public string BatchNo { get; set; }
        public string TraceNo { get; set; }
        public string RefNo { get; set; }
        public string AppCode { get; set; }
        public string CanUpdate { get; set; }


    }

    public class ReceiptsAll
    {
        public Receipts receipt { get; set; }
        public List<ReceiptDetails> lst_Detail { get; set; }
        public List<ReceiptsCard> lst_card { get; set; }
        public ReceiptMember receiptMember { get; set; }
        public ReceiptInfo receiptInfo { get; set; }
    }

    public class ListReceipts
    {
        public List<Receipts> lst_re { get; set; }
    }

    public class ReceiptObject
    {
        //Receipt
        public string TotalAmountBeforeTax { get; set; }
        public string TotalTax { get; set; }
        public string TotalAmount { get; set; }
        public string DiscountAmount { get; set; }
        public string TotalMoney { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        //Object
        public string ObjectId { get; set; }
        public string FullName { get; set; }

        //User
        public string UserId { get; set; }

        public string User { get; set; }
    }
}
