using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosWS.Entities
{
    public class Orders
    {
        public string OrderId { get; set; }
        public string DeskId { get; set; }
        public string DeskName { get; set; }
        public string Note { get; set; }
        public string CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string TotalAmountBeforeTax { get; set; }
        public string TotalTax { get; set; }
        public string TotalAmmount { get; set; }
        public string Status { get; set; }
        // 0: chưa thanh toán
        // 1: đã ra hóa đơn ( tất cả detail )
        public string DisCountAmount { get; set; }
        public string TotalMoney { get; set; }
    }

    public class OrderAll
    {
        public Orders order { get; set; }
        public List<OrderDetails> lst_Detail { get; set; }
    }
}
