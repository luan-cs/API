using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class ActionStatus
    {
        public string ActionStatusID { get; set; }
        public string ActionName { get; set; }
        public string ActionName2 { get; set; }
        public string ActionName3 { get; set; }
        public int Ordering { get ; set; }
        public ActionStatus()
        {
            ActionStatusID = "";
            ActionName = "";
            ActionName2 = "";
            ActionName3 = "";
            Ordering = 1;
        }
    }
}
