using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class Products
    {
        //public string ProductId { get; set; }
        //public string ProductName { get; set; }
        //public string ProductGroupId { get; set; }
        //public string Price { get; set; }
        public string ProductId { get; set; }
        public string productCode { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Image { get; set; }
        public string IsPrint { get; set; }
        public string Notes { get; set; }
        public string Price { get; set; }
        public string Time { get; set; }
        public string CreatedDate { get; set; }
        public string IsDelete { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ProductType { get; set; }
    }
}
