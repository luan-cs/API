using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class Input
    {
        public string InputId { get; set; }
        public string Ballot { get; set; }
        public string BallotDate { get; set; }
        public string ReceiptId { get; set; }
        public string ReceiptDate { get; set; }
        public string SupplierId { get; set; }
        public string StoreId { get; set; }
        public string Paid { get; set; }
        public string InputDiscount { get; set; }
        public string InputNote { get; set; }
        public string InputVat { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }
}
