using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class CallName
    {
        public int CallNameID { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }

        public CallName()
        {            
            Name1 = "";
            Name2 = "";
            Name3 = "";
        }
    }
}
