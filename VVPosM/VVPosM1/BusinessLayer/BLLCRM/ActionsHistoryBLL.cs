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
    public class ActionsHistoryBLL : IObjectBLL<ActionsHistory>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(ActionsHistory obj)
        {

            //string queryStr = "INSERT INTO";
            //queryStr += " `actions` (`ActionsID`, `ActionName`, `CustomID`, `ActionContent`, `CategoryActionID`, `UpdaterID`, `CreateDate`, `UpdateDate`, `ActionStatusID`, `UserActionID`, `FinishDate`, `UserActionNext`, `DeadLine`, `PriorityID`, `CreaterID`)";
            //queryStr += " VALUES(";
            //queryStr += string.Format("'{0}'", obj.ActionsID);
            //queryStr += string.Format(", '{0}'", obj.ActionName);
            //queryStr += string.Format(", '{0}'", obj.CustomID.MemberId);
            //queryStr += string.Format(", '{0}'", obj.ActionContent);
            //queryStr += string.Format(", '{0}'", obj.CatagogyActionID.CategoryActionID);

            //queryStr += string.Format(", '{0}'", Program.Username);
            //queryStr += string.Format(", '{0}'", obj.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
            //queryStr += string.Format(", '{0}'", obj.Update.ToString("yyyy-MM-dd HH:mm:ss"));
            //queryStr += string.Format(", '{0}'", obj.ActionStatusID.ActionStatusID);
            //queryStr += string.Format(", '{0}'", obj.UserActionID.EmployeeId);

            //queryStr += string.Format(", '{0}'", obj.FinishDate.ToString("yyyy-MM-dd HH:mm:ss"));
            //queryStr += string.Format(", '{0}'", obj.UserActionNext);
            //queryStr += string.Format(", '{0}'", obj.DeadLine);
            //queryStr += string.Format(", '{0}'", obj.PriorityID.PriorityID);
            //queryStr += string.Format(", '{0}')", obj.CreaterID.EmployeeId);

            //Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            ////MessageBox.Show(id + "");
            return false;
        }

        public bool Edit(ActionsHistory obj)
        {
            //string queryStr = "UPDATE Actions SET";
            //queryStr += string.Format(" ActionName = '{0}'", obj.ActionName);
            //queryStr += string.Format(" ,CustomID = '{0}'", obj.CustomID.MemberId);
            //queryStr += string.Format(" ,ActionContent = '{0}'", obj.ActionContent);
            //queryStr += string.Format(" ,CategoryActionID = '{0}'", obj.CatagogyActionID.CategoryActionID);
            //queryStr += string.Format(" ,UpdaterID = '{0}'", Program.Username);

            //queryStr += string.Format(" ,CreateDate = '{0}'", obj.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
            //queryStr += string.Format(" ,UpdateDate = '{0}'", obj.Update.ToString("yyyy-MM-dd HH:mm:ss"));
            //queryStr += string.Format(" ,ActionStatusID = '{0}'", obj.ActionStatusID.ActionStatusID);
            //queryStr += string.Format(" ,UserActionID = '{0}'", obj.UserActionID.EmployeeId);
            //queryStr += string.Format(" ,FinishDate = '{0}'", obj.FinishDate.ToString("yyyy-MM-dd HH:mm:ss"));

            //queryStr += string.Format(" ,UserActionNext = '{0}'", obj.UserActionNext);
            //queryStr += string.Format(" ,DeadLine = '{0}'", obj.DeadLine);
            //queryStr += string.Format(" ,PriorityID = '{0}'", obj.PriorityID.PriorityID);
            //queryStr += string.Format(" ,CreaterID = '{0}'", obj.CreaterID.EmployeeId);
            //queryStr += string.Format(" WHERE ActionsID = '{0}'", obj.ActionsID);

            //Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return false;
        }

        public bool Delete(string id)
        {
            //string queryStr = string.Format("Delete FROM Actions WHERE  ActionsID = '{0}' ", id);
            //Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return false;
        }

        public DataTable GetLists()
        {
            string queryStr = "SELECT  `actionshistory`.`ActionsID`, `actionshistory`.`ActionName`,   members.MemberName , `employees`.`EmployeeName`, `actionshistory`.`FinishDate`,  employeesNext.`EmployeeName`  As  EmployeeNameNext ,  `actionshistory`.`DeadLine` ";
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

            queryStr = queryStr + " FROM `actionshistory` LEFT JOIN `members` ON `actionshistory`.`CustomID` = `members`.`MemberID` ";
            queryStr = queryStr + "  LEFT JOIN `categoryactions` ON `actionshistory`.`CategoryActionID` = `categoryactions`.`CategoryActionID` ";
            queryStr = queryStr + "  LEFT JOIN `actionstatus` ON `actionshistory`.`ActionStatusID` = `actionstatus`.`ActionStatusID` ";
            queryStr = queryStr + "  LEFT JOIN  `priorities` ON  `actionshistory`.`PriorityID` = `priorities`.`PriorityID` ";
            queryStr = queryStr + "  LEFT JOIN `employees` ON `actionshistory`.`UserActionID` = `employees`.`EmployeeId` ";
            queryStr = queryStr + "  LEFT JOIN `employees` AS  employeesNext ON `actionshistory`.`UserActionNext` =  employeesNext.`EmployeeId` ";
            queryStr = queryStr + " ORDER BY`actionshistory`.CreateDate   Desc";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        //Danh sách các lịch sử của một cái Actions
        public DataTable GetListsHistoryID( string ppActionsID)
        {
            string queryStr = "SELECT  `actionshistory`.`ActionsID`, `actionshistory`.`ActionName`,   members.MemberName , `employees`.`EmployeeName`, `actionshistory`.`FinishDate`,  employeesNext.`EmployeeName`  As  EmployeeNameNext ,  `actionshistory`.`DeadLine` ";
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

            queryStr = queryStr + " FROM `actionshistory` LEFT JOIN `members` ON `actionshistory`.`CustomID` = `members`.`MemberID` ";
            queryStr = queryStr + "  LEFT JOIN `categoryactions` ON `actionshistory`.`CategoryActionID` = `categoryactions`.`CategoryActionID` ";
            queryStr = queryStr + "  LEFT JOIN `actionstatus` ON `actionshistory`.`ActionStatusID` = `actionstatus`.`ActionStatusID` ";
            queryStr = queryStr + "  LEFT JOIN  `priorities` ON  `actionshistory`.`PriorityID` = `priorities`.`PriorityID` ";
            queryStr = queryStr + "  LEFT JOIN `employees` ON `actionshistory`.`UserActionID` = `employees`.`EmployeeId` ";
            queryStr = queryStr + "  LEFT JOIN `employees` AS  employeesNext ON `actionshistory`.`UserActionNext` =  employeesNext.`EmployeeId` ";
            queryStr = queryStr + "WHERE `actionshistory`.ActionsID ='" + ppActionsID + "'";
            queryStr = queryStr + " ORDER BY`actionshistory`.CreateDate   Desc";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        public ActionsHistory GetById(string id)
        {
            ActionsHistory action = new ActionsHistory();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  actionshistory WHERE  ID = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                action.ActionsID = dataset.Tables["x"].Rows[0]["ActionsID"].ToString();
                action.ActionName = dataset.Tables["x"].Rows[0]["ActionName"].ToString();
                action.CustomID.MemberId = dataset.Tables["x"].Rows[0]["CustomID"].ToString();
                action.ActionContent = dataset.Tables["x"].Rows[0]["ActionContent"].ToString();
                action.CatagogyActionID.CategoryActionID = dataset.Tables["x"].Rows[0]["CategoryActionID"].ToString();

                action.UpdaterID.EmployeeId = dataset.Tables["x"].Rows[0]["UpdaterID"].ToString();
                action.CreateDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["CreateDate"].ToString());
                action.Update = DateTime.Parse(dataset.Tables["x"].Rows[0]["UpdateDate"].ToString());
                action.ActionStatusID.ActionStatusID = dataset.Tables["x"].Rows[0]["ActionStatusID"].ToString();
                action.UserActionID.EmployeeId = dataset.Tables["x"].Rows[0]["UserActionID"].ToString();

                action.FinishDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["FinishDate"].ToString());
                action.UserActionNext = dataset.Tables["x"].Rows[0]["UserActionNext"].ToString();
                action.DeadLine = dataset.Tables["x"].Rows[0]["DeadLine"].ToString();
                action.PriorityID.PriorityID = dataset.Tables["x"].Rows[0]["PriorityID"].ToString();
                action.CreaterID.EmployeeId = dataset.Tables["x"].Rows[0]["CreaterID"].ToString();
                action.FinishStatus = int.Parse(dataset.Tables["x"].Rows[0]["FinishStatus"].ToString());
            }
            else
                action = null;

            return action;
        }

        public DataTable SearchInformation(Dictionary<string, string> param)
        {

            string queryStr = "SELECT   `actionshistory`.`ID` , `actionshistory`.`ActionsID`, `actionshistory`.`ActionName`,   members.MemberName , `employees`.`EmployeeName`, `actionshistory`.`FinishDate`,  employeesNext.`EmployeeName`  As  EmployeeNameNext ,  `actionshistory`.`DeadLine` ";
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
            queryStr = queryStr + " FROM `actionshistory` LEFT JOIN `members` ON `actions`.`CustomID` = `members`.`MemberID` ";
            queryStr = queryStr + "  LEFT JOIN `categoryactions` ON `actionshistory`.`CategoryActionID` = `categoryactions`.`CategoryActionID` ";
            queryStr = queryStr + "  LEFT JOIN `actionstatus` ON `actionshistory`.`ActionStatusID` = `actionstatus`.`ActionStatusID` ";
            queryStr = queryStr + "  LEFT JOIN  `priorities` ON  `actionshistory`.`PriorityID` = `priorities`.`PriorityID` ";
            queryStr = queryStr + "  LEFT JOIN `employees` ON `actionshistory`.`UserActionID` = `employees`.`EmployeeId` ";
            queryStr = queryStr + "  LEFT JOIN `employees` AS  employeesNext ON `actionshistory`.`UserActionNext` =  employeesNext.`EmployeeId` ";
            queryStr = queryStr + " WHERE  ";
            foreach (var item in param)
            {
                if (!String.IsNullOrEmpty(item.Value))
                {
                    //Tìm theo mã hoạt động hay là chủ đề
                    if (item.Key.Equals("ActionsID")  )
                    {
                        queryStr += String.Format("actionshistory.{0} ='{1}'  AND ", item.Key, item.Value);
                    }                   
                    //Tìm theo ngày cập nhật
                    else if (item.Key.Equals("UpdateDate"))
                    {
                        string[] arr = item.Value.Split('@');
                        queryStr += String.Format("DATE_FORMAT( `actionshistory`.{0},  '%Y-%m-%d' ) BETWEEN '{1}' AND '{2}' AND ", item.Key, arr[0], arr[1]);
                    }
                    //Tìm theo ngày kết thúc
                    else if (item.Key.Equals("FinishDate"))
                    {
                        string[] arr = item.Value.Split('@');
                        queryStr += String.Format("DATE_FORMAT( `actionshistory`.{0},  '%Y-%m-%d' ) BETWEEN '{1}' AND '{2}' AND ", item.Key, arr[0], arr[1]);
                    }
                    else if (item.Key.Equals("DeadLine"))
                    {
                        string[] arr = item.Value.Split('@');
                        queryStr += String.Format("DATE_FORMAT( `actionshistory`.{0},  '%Y-%m-%d' ) BETWEEN '{1}' AND '{2}' AND ", item.Key, arr[0], arr[1]);
                    }
                }
            }
            queryStr = queryStr.Substring(0, queryStr.Length - 4);

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "actionshistory", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["actionshistory"];
            }
            else
                return null;
        }   
    }
}
