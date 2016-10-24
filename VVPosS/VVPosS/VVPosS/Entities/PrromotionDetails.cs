using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosS.Entities
{
    public class PrromotionDetails
    {
        public string PromotionId { get; set; }
        public string ProductId { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string TaxAmmount { get; set; }
    }
}
