using System;
using System.Data;
using System.Drawing;
using System.IO;
using VVPosM1.Entities;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VVPosM1.BusinessLayer.BLLCRM
{
    public class ActionsBLL : IObjectBLL<Actions>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(Actions obj)
        {

            string queryStr = "INSERT INTO";
            queryStr += " `actions` (`ActionName`, `CustomID`, `BriefContent`, `CategoryID`, `Status`, `FinishedDate`, `DeadLine`,`Priority`, `CreatorID`,`CreatedDate`, `UpdatedDate`)";
            queryStr += " VALUES(";
            //queryStr += string.Format("'{0}'", obj.ActionsID);
            queryStr += string.Format("'{0}'", obj.ActionName);
            queryStr += string.Format(", '{0}'", obj.CustomID.MemberId);
            queryStr += string.Format(", '{0}'", obj.BriefContent);
            queryStr += string.Format(", '{0}'", obj.CategoryID.CategoryActionID);
            queryStr += string.Format(", '{0}'", obj.Status.ActionStatusID);
            queryStr += string.Format(", {0}", "NULL");
            queryStr += string.Format(", '{0}'", obj.DeadLine.ToString("yyyy-MM-dd HH:mm:ss"));
            queryStr += string.Format(", '{0}'", obj.Priority.PriorityID);
            queryStr += string.Format(", '{0}'", Program.employee1.EmployeeId);
            queryStr += string.Format(", {0}", "NOW()");
            queryStr += string.Format(", {0}", "NOW())");                       
            
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public int Add_New(Actions obj)
        {


            string queryStr = "INSERT INTO";
            queryStr += " `actions` (`ActionName`, `CustomID`, `BriefContent`, `CategoryID`, `Status`, `FinishedDate`, `DeadLine`,`Priority`, `CreatorID`,`CreatedDate`)";
            queryStr += " VALUES(";
            //queryStr += string.Format("'{0}'", obj.ActionsID);
            queryStr += string.Format("'{0}'", obj.ActionName);
            queryStr += string.Format(", '{0}'", obj.CustomID.MemberId);
            queryStr += string.Format(", '{0}'", obj.BriefContent);
            queryStr += string.Format(", '{0}'", obj.CategoryID.CategoryActionID);
            queryStr += string.Format(", '{0}'", obj.Status.ActionStatusID);
            queryStr += string.Format(", {0}", "NULL");
            queryStr += string.Format(", '{0}'", obj.DeadLine.ToString("yyyy-MM-dd HH:mm:ss"));
            queryStr += string.Format(", '{0}'", obj.Priority.PriorityID);
            queryStr += string.Format(", '{0}'", Program.employee1.EmployeeId);
            queryStr += string.Format(", {0}", "NOW())");
            //queryStr += string.Format(", '{0}'", obj.CreatorID.EmployeeId);
            //queryStr += string.Format(", '{0}'", obj.UpdaterID.EmployeeId);  
            //queryStr += string.Format(", '{0}')", obj.UpdatedDate.ToString("yyyy-MM-dd HH:mm:ss"));


            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //MessageBox.Show(id + "");
        }

        public bool Edit(Actions obj)
        {
            string queryStr = "UPDATE Actions SET";
            queryStr += string.Format(" ActionName = '{0}'", obj.ActionName);
            queryStr += string.Format(" ,CustomID = '{0}'", obj.CustomID.MemberId);
            queryStr += string.Format(" ,BriefContent = '{0}'", obj.BriefContent);
            queryStr += string.Format(" ,CategoryID = '{0}'", obj.CategoryID.CategoryActionID);
            queryStr += string.Format(" ,UpdaterID = '{0}'", Program.employee1.EmployeeId);

            //queryStr += string.Format(" ,CreatedDate = '{0}'", obj.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss"));
            queryStr += string.Format(" ,UpdatedDate = {0}", "NOW()" );
            queryStr += string.Format(" ,Status = '{0}'", obj.Status.ActionStatusID);
           // queryStr += string.Format(" ,UserActionID = '{0}'", obj.UserActionID.EmployeeId);
            //queryStr += string.Format(" ,FinishedDate = '{0}'", obj.FinishedDate.ToString("yyyy-MM-dd HH:mm:ss"));

            //queryStr += string.Format(" ,UserActionNext = '{0}'", obj.UserActionNext);
            queryStr += string.Format(" ,DeadLine = '{0}'", obj.DeadLine.ToString("yyyy-MM-dd HH:mm:ss"));
            queryStr += string.Format(" ,Priority = '{0}'", obj.Priority.PriorityID);
            //queryStr += string.Format(" ,CreatorID = '{0}'", obj.CreatorID.EmployeeId);
            queryStr += string.Format(" WHERE ActionsID = {0}", obj.ActionsID);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public void Edit_Only(Actions obj)
        {
            string queryStr = "UPDATE Actions SET";
            queryStr += string.Format(" ActionName = '{0}'", obj.ActionName);            
            queryStr += string.Format(" ,BriefContent = '{0}'", obj.BriefContent);

            queryStr += string.Format(" WHERE ActionsID = {0}", obj.ActionsID);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        }

        public bool Delete(string id)
        {
            string queryStr = string.Format("Delete FROM Actions WHERE  ActionsID = {0} ", id);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT  `actions`.`ActionsID`, `actions`.`ActionName`,   members.MemberName , `employees`.`EmployeeName`, `actions`.`FinishDate`,  employeesNext.`EmployeeName`  As  EmployeeNameNext ,  `actions`.`DeadLine` ";
            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            {
                queryStr = queryStr + " ,`categoryactions`.`CategoryActionName` as CategoryActionName";
                queryStr = queryStr + " ,  `actionstatus`.`ActionName` as ActionNameStatus ";
                queryStr = queryStr + " ,`priorities`.`PriorityName`  as PriorityName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            {
                queryStr = queryStr + " ,`categoryactions`.`CategoryActionName2` as CategoryActionName";
                queryStr = queryStr + " ,  `actionstatus`.`ActionName2` as ActionNameStatus ";
                queryStr = queryStr + " ,`priorities`.`PriorityName2`  as PriorityName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            {
                queryStr = queryStr + " ,`categoryactions`.`CategoryActionName3` as CategoryActionName";
                queryStr = queryStr + " ,  `actionstatus`.`ActionName3` as ActionNameStatus ";
                queryStr = queryStr + " ,`priorities`.`PriorityName3`  as PriorityName";
            }

            queryStr = queryStr + " FROM `actions` LEFT JOIN `members` ON `actions`.`CustomID` = `members`.`MemberID` ";
            queryStr = queryStr + "  LEFT JOIN `categoryactions` ON `actions`.`CategoryActionID` = `categoryactions`.`CategoryActionID` ";
            queryStr = queryStr + "  LEFT JOIN `actionstatus` ON `actions`.`ActionStatusID` = `actionstatus`.`ActionStatusID` ";
            queryStr = queryStr + "  LEFT JOIN  `priorities` ON  `actions`.`PriorityID` = `priorities`.`PriorityID` ";
            queryStr = queryStr + "  LEFT JOIN `employees` ON `actions`.`UserActionID` = `employees`.`EmployeeId` ";
            queryStr = queryStr + "  LEFT JOIN `employees` AS  employeesNext ON `actions`.`UserActionNext` =  employeesNext.`EmployeeId` ";
            queryStr = queryStr + " ORDER BY`actions`.CreateDate   Desc";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        public Actions GetById(string id)
        {
            Actions action = new Actions();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  Actions WHERE ActionsID = {0}", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
              {
                action.ActionsID = dataset.Tables["x"].Rows[0]["ActionsID"].ToString();
                action.ActionName = dataset.Tables["x"].Rows[0]["ActionName"].ToString();
                action.CustomID.MemberId = dataset.Tables["x"].Rows[0]["CustomID"].ToString();
                action.BriefContent = dataset.Tables["x"].Rows[0]["BriefContent"].ToString();
                action.CategoryID.CategoryActionID = dataset.Tables["x"].Rows[0]["CategoryID"].ToString();

                action.UpdaterID.EmployeeId = dataset.Tables["x"].Rows[0]["UpdaterID"].ToString();
                action.CreatedDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["CreatedDate"].ToString());
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString()))
                {
                    action.UpdatedDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString());
                }
                action.Status.ActionStatusID = dataset.Tables["x"].Rows[0]["Status"].ToString();
                //action.UserActionID.EmployeeId = dataset.Tables["x"].Rows[0]["UserActionID"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["FinishedDate"].ToString()))
                {
                    action.FinishedDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["FinishedDate"].ToString());
                }               
                    //action.UserActionNext = dataset.Tables["x"].Rows[0]["UserActionNext"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["DeadLine"].ToString()))
                {
                    action.DeadLine = DateTime.Parse(dataset.Tables["x"].Rows[0]["DeadLine"].ToString());
                }
                action.Priority.PriorityID = dataset.Tables["x"].Rows[0]["Priority"].ToString();
                action.CreatorID.EmployeeId = dataset.Tables["x"].Rows[0]["CreatorID"].ToString();
                //action.FinishStatus =int.Parse(dataset.Tables["x"].Rows[0]["FinishStatus"].ToString());
            }
            else
                action = null;

            return action;
        }

        public DataTable SearchInformation(Dictionary<string, string> param)
        {
            string queryStr = "SELECT (select count(*) from `action_detail` where `action_detail`.`ActionID` = `actions`.`ActionsID`) as follow, `actions`.* ";
            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            {
                queryStr = queryStr + " ,`categoryactions`.`CategoryActionName` as CategoryActionName";
                queryStr = queryStr + " ,  `actionstatus`.`ActionName` as ActionNameStatus ";
                queryStr = queryStr + " ,`priorities`.`PriorityName`  as PriorityName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            {
                queryStr = queryStr + " ,`categoryactions`.`CategoryActionName2` as CategoryActionName";
                queryStr = queryStr + " ,  `actionstatus`.`ActionName2` as ActionNameStatus ";
                queryStr = queryStr + " ,`priorities`.`PriorityName2`  as PriorityName";
            }
            else if (Common.clsLanguages.StrCulture.Equals("en-US"))
            {
                queryStr = queryStr + " ,`categoryactions`.`CategoryActionName3` as CategoryActionName";
                queryStr = queryStr + " ,  `actionstatus`.`ActionName3` as ActionNameStatus ";
                queryStr = queryStr + " ,`priorities`.`PriorityName3`  as PriorityName";
            }
            //MemberName
            queryStr = queryStr + " ,`members`.`MemberName` as MemberName  ";
            queryStr = queryStr + " ,`employees`.`EmployeeName` as CreatorName  ";
            queryStr = queryStr + " ,`employeesUp`.`EmployeeName` as UpdaterName  ";

            queryStr = queryStr + " FROM `actions` LEFT JOIN `members` ON `actions`.`CustomID` = `members`.`MemberID` ";
            queryStr = queryStr + "  LEFT JOIN `categoryactions` ON `actions`.`CategoryID` = `categoryactions`.`CategoryActionID` ";
            queryStr = queryStr + "  LEFT JOIN `actionstatus` ON `actions`.`Status` = `actionstatus`.`ActionStatusID` ";
            queryStr = queryStr + "  LEFT JOIN  `priorities` ON  `actions`.`Priority` = `priorities`.`PriorityID` ";
            queryStr = queryStr + "  LEFT JOIN `employees` ON `actions`.`CreatorID` = `employees`.`EmployeeId` ";
            queryStr = queryStr + "  LEFT JOIN `employees` AS  employeesUp ON `actions`.`UpdaterID` =  employeesUp.`EmployeeId` ";

            //add where clause
            queryStr = queryStr + " WHERE  ";
            string conditionOp = "";
            if(param.ContainsKey("KeyWord")) //find by key word
            {
                queryStr += string.Format("(actions.ActionsID {0} OR actions.ActionName {0} OR actions.BriefContent {0} OR MemberName {0})", "LIKE '%" + param["KeyWord"] + "%'");
                conditionOp = " AND ";
            }

            if(param.ContainsKey("CategoryID"))
            {
                queryStr += conditionOp + "actions.CategoryID = '" + param["CategoryID"] + "'";
                conditionOp = " AND ";
            }

            if (param.ContainsKey("Priority"))
            {
                queryStr += conditionOp + "actions.Priority = '" + param["Priority"] + "'";
                conditionOp = " AND ";
            }

            if (param.ContainsKey("CustomID"))
            {
                queryStr += conditionOp + "actions.CustomID = '" + param["CustomID"] + "'";
                conditionOp = " AND ";
            }

            if (param.ContainsKey("Status"))
            {
                queryStr += conditionOp + "actions.Status = '" + param["Status"] + "'";
                conditionOp = " AND ";
            }

            if (param.ContainsKey("DeadLine"))
            {
                string[] arr = param["DeadLine"].Split('@');
                queryStr += conditionOp + String.Format("(DATE_FORMAT( `actions`.DeadLine,  '%Y-%m-%d' ) BETWEEN '{0}' AND '{1}')", arr[0], arr[1]);
                conditionOp = " AND ";
            }
            queryStr += conditionOp + "`members`.`IsDelete` = 0 ORDER BY `actions`.`UpdatedDate` DESC";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "ActionsExt", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["ActionsExt"];
            }
            else
                return null;
        }
             
        //Điệp Add 20140418   
        /// <summary>
        /// Auoto ActionsID from max ActionsID
        /// </summary>
        /// <returns></returns>
        public string GetActionsCode()
        {
            string query = String.Format("SELECT  Max( RIGHT(ActionsID,5) ) as SoCuoi	FROM  Actions ");
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);
            if (String.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["x"].Rows[0]["SoCuoi"].ToString();
            }
            else
            {
                return null;
            }
            //End Điệp add 20140418
        }

        public string stringGetFollowUp(string ActionID)
        {
            string query = "SELECT COUNT(*) AS follow FROM `action_detail` WHERE 'ActionID` = '" + ActionID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);
            if (String.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["x"].Rows[0]["follow"].ToString();
            }
            else
            {
                return String.Empty;
            }
        }
        /**
     * Check if a ActionsID is exist
     * return: 1 if ActionsID is exist, 0 if not, -1 if error
     */
        public int ActionsIdExist(string id)
        {
            string query = "SELECT COUNT(*) AS total FROM `actions` WHERE `ActionsID` = '" + id + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);
            if (String.IsNullOrEmpty(errorString) && dataset.Tables["x"].Rows.Count > 0)
            {
                if ("1".Equals(dataset.Tables["x"].Rows[0]["total"].ToString()))
                    return 1;
                else
                    return 0;
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM219"),
                         Common.clsLanguages.GetResource("CRM11"),
                         Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                         Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                return -1;
            }
        }
    }
}
