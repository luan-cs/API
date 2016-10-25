using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class Measure
    {
        public string MeasureId { get; set; }
        public string ProductId { get; set; }
        public string MeasureNote { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }
}
