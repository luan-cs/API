using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosS.Entities
{
    public class OrderObject
    {
        public Orders order { get; set; }
        public List<OrderDetails> ListOrederDetail { get; set; }
    }
}
