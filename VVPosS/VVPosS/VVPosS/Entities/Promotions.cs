using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosS.Entities
{
    public class Promotions
    {
        public string PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string BeginDateTime { get; set; }
        public string EndDateTime { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
