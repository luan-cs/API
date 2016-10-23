using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class CategoryActions
    {
        public string CategoryActionID { get; set; }
        public string CategoryActionName { get; set; }
        public string CategoryActionName2 { get; set; }
        public string CategoryActionName3 { get; set; }
        public int Ordering { get; set; }

        public CategoryActions()
        {
            CategoryActionID = "";
            CategoryActionName = "";
            CategoryActionName2 = "";
            CategoryActionName3 = "";
            Ordering = 1;
        }
    }
}
