using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class ActionsHistory
    {
        public int ID { get; set; }
        public string ActionsID { get; set; }
        public string ActionName { get; set; }
        public Member CustomID { get; set; }
        public string ActionContent { get; set; }
        public CategoryActions CatagogyActionID { get; set; }
        public Employees1 UpdaterID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Update { get; set; }
        public ActionStatus ActionStatusID { get; set; }
        public Employees1 UserActionID { get; set; }
        public DateTime FinishDate { get; set; }
        public string UserActionNext { get; set; }
        public string DeadLine { get; set; }
        public Priorities PriorityID { get; set; }
        public Employees1 CreaterID { get; set; }
        public int FinishStatus { get; set; }


        public ActionsHistory()
        {
            ID = 0;
            ActionsID = "";
            ActionName = "";
            CustomID = new Member();
            ActionContent = "";
            CatagogyActionID =  new CategoryActions();
            UpdaterID = new Employees1();
            CreateDate = new DateTime();
            Update = new DateTime();
            ActionStatusID = new ActionStatus();
            UserActionID = new Employees1();
            FinishDate = new DateTime();
            UserActionNext = "";
            DeadLine = "";
            PriorityID =  new Priorities();
            CreaterID = new Employees1();
            FinishStatus = 0;
        }
    }
}
