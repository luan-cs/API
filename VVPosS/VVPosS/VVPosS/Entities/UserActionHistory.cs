using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosS.Entities
{
    public class UserActionHistory
    {
        public string Time { get; set; }
        public string UserId { get; set; }
        public string Object { get; set; }
        public string Verb { get; set; }
        public string Param { get; set; }
        public string Value { get; set; }
    }
}
