using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosS.Entities
{
    public class MemberScore
    {
        public string Id { get; set; }
        public string MemberId { get; set; }
        public string RefReceipt { get; set; }
        public string TotalScore { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
