using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class CommonType
    {
        public string CommonTypeId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string CanDelete { get; set; }
        public string TableColumUser { get; set; }
    }
}
