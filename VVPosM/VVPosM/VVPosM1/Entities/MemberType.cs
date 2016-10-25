using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class MemberType
    {
        public int MemberTypeId { get; set; }
        public string MemberTypeCode { get; set; }
        public string MemberTypeName { get; set; }
        public string MemberTypeName2 { get; set; }
        public string MemberTypeName3 { get; set; }

        public MemberType()
        {
            MemberTypeCode = "";
            MemberTypeName = null;
            MemberTypeName2 = null;
            MemberTypeName3 = null;
        }
    }
}
