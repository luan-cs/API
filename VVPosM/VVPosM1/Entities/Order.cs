using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class Order
    {
        public string OrderId { get; set; }
        public string DeskId { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDateFrom { get; set; }
        public string CreatedDateTo { get; set; }
        public string TotalTax { get; set; }
        public string TotalAmmount { get; set; }
        public string TotalAmountBeforeTax { get; set; }
        public string DisCountAmount { get; set; }
        public string TotalMoney { get; set; }
        public string IsPrint { get; set; }
    }
}
