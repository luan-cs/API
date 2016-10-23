using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class Regency
    {
        public int RegencyID { get; set; }
        public string RegencyName { get; set; }
        public string RegencyName2 { get; set; }
        public string RegencyName3 { get; set; }

        public Regency()
        {
            RegencyName = "";
            RegencyName2 = "";
            RegencyName3 = "";
        }
    }
}
