using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class User
    {
        public string UserId { get; set; }

        public string Pwd { get; set; }
        public string LastLogin { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string RoleId { get; set; }

        public User()
        {
            UserId = "";
            Pwd = "";
            LastLogin = "";
            Status = "";
            CreatedBy = "";
            CreatedDate = "";
            ModifiedBy = "";
            ModifiedDate = "";
        }
    }
}
