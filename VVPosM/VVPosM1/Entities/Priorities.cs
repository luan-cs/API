using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class Priorities
    {
        public string PriorityID { get; set; }
        public string PriorityName { get; set; }
        public string PriorityName2 { get; set; }
        public string PriorityName3 { get; set; }

        public Priorities()
        {
            PriorityID = "";
            PriorityName = "";
            PriorityName2 = "";
            PriorityName3 = "";
        }
    }
}
