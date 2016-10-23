using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class Actions
    {
        public string ActionsID { get; set; }
        public string ActionName { get; set; }
        public Member CustomID { get; set; }
      
        public string BriefContent { get; set; }
    
        public CategoryActions CategoryID { get; set; }
        public ActionStatus Status { get; set; }

        public DateTime FinishedDate { get; set; }
        
        public DateTime DeadLine { get; set; }

        public Priorities Priority { get; set; }

        public Employees1 CreatorID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Employees1 UpdaterID { get; set; }        
        public DateTime UpdatedDate { get; set; }

        public Actions()
        {
            ActionsID = "";
            ActionName = "";
            CustomID = new Member();
            BriefContent = "";
            CategoryID = new CategoryActions();
            UpdaterID = new Employees1();
            FinishedDate = new DateTime();
            UpdatedDate = new DateTime();
            Status = new ActionStatus();
            CreatorID = new Employees1();
            FinishedDate = new DateTime();
            //UserActionNext = "";
            DeadLine = new DateTime();
            Priority =  new Priorities();
            UpdaterID = new Employees1();
           
        }
    }

    public class Action_Detail
    {
        public int id { get; set; }
        public string ActionsID { get; set; }
        public string Content { get; set; }

        public Employees1 PIC { get; set; }
        public Employees1 AssignTo { get; set; }
        public ActionStatus Status { get; set; }

        public Priorities Priority { get; set; }
        public Employees1 CreatorID { get; set; }
        public DateTime CreatedDate { get; set; }

        public Action_Detail()
        {
            ActionsID = "";
            id = 0;
           
            Content = "";
           
            PIC = new Employees1();          
            Status = new ActionStatus();
            AssignTo = new Employees1();          
           
            Priority =  new Priorities();
            CreatorID = new Employees1();
            CreatedDate = new DateTime();           
        }
    }


}
