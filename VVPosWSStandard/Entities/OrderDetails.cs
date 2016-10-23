using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosWS.Entities
{
    public class OrderDetails
    {
        public string ODID { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Qty { get; set; }
        public string Price { get; set; }
        public string CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string IsPrint { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        // 0: chưa thanh toán
        // 1: đã ra hóa đơn ( tất cả detail )
        public string AmmountBeforeTax { get; set; }
        public string TaxAmmount { get; set; }
        public string TotalAmount { get; set; }
    }
}
