using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class Country
    {
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryName2 { get; set; }
        public string CountryName3 { get; set; }

        public Country()
        {
            CountryId = "";
            CountryName = "";
            CountryName2 = "";
            CountryName3 = "";
        }
    }
}
