using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosS.Entities
{
    public class Products
    {
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Image { get; set; }
        public string IsPrint { get; set; }
        public string Notes { get; set; }
        public string CreatedDate { get; set; }
        public string IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ProductType { get; set; }

        public string IsBuffet { get; set; }
    }
}
