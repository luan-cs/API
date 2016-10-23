using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    class rptDoanhThu
    {

        public string STT { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ReceiptId {get;set;}
        public string TotalAmount{get;set;}
        public string Status { get; set; }
        public string TotalMoney { get; set; }
        public string TotalAmountBeforeTax { get; set; }
        public string TotalTax{ get; set; }
        public string DiscountAmount{ get; set; }       
    }
}
