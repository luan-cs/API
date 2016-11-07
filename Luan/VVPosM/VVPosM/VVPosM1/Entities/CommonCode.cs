using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class CommonCode
    {
       public string CommonTypeId { get; set; }
       public string CommonId { get; set; }
       public string StrValue1 { get; set; }
       public string StrValue2 { get; set; }
       public string NumValue1 { get; set; }
       public string NumValue2 { get; set; }
       public string CreatedBy { get; set; }
       public string CreatedDate { get; set; }
       public string ModifiedBy { get; set; }
       public string ModifiedDate { get; set; }
       public string CanDelete { get; set; }
       public string ParentId { get; set; }
       public string IsBuffet { get; set; }
    }
}
