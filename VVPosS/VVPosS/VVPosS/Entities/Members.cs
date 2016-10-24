using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosS.Entities
{
    public class Members
    {
        public string MemberId { get; set; }
        public string MemberCode { get; set; }
        public string ObjectId { get; set; }
        public string NumberOfVissits { get; set; }
        public string LastestDate { get; set; }
        public string MemberType { get; set; }
        public string CountryId { get; set; }
        public string IsLock { get; set; }
        public string LockDate { get; set; }
        public string IsDelete { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string MemberScore { get; set; }
    }
}
