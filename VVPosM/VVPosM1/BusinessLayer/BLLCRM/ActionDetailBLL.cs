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
    class ActionDetailBLL 
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public void Add(Action_Detail obj)
        {

            string queryStr = "INSERT INTO";
            queryStr += " `action_detail` (`ActionID`, `Content`, `PIC`, `Status`, `Priority`, `CreatorID`, `CreatedDate`)";
            queryStr += " VALUES(";
            queryStr += string.Format("'{0}'", obj.ActionsID);
            queryStr += string.Format(", '{0}'", obj.Content);
            queryStr += string.Format(", '{0}'", obj.PIC.EmployeeId);
            queryStr += string.Format(", '{0}'", obj.Status.ActionStatusID);
            queryStr += string.Format(", '{0}'", obj.Priority.PriorityID);

            queryStr += string.Format(", '{0}'", Program.employee1.EmployeeId);          
            queryStr += string.Format(", {0})", "NOW()");

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            //MessageBox.Show(id + "");
        }

        public void AddIncludeDeadline(Action_Detail objActionDetail, string deadline)
        {
            if (!string.IsNullOrEmpty(deadline))
            {
                string query = "UPDATE `actions` SET `DeadLine` = '" + deadline + "' WHERE `ActionsID` = '" + objActionDetail.ActionsID + "'";
                Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
                if (string.IsNullOrEmpty(errorString))
                {
                    Add(objActionDetail);
                }
            }
            else
            {
                Add(objActionDetail);
            }
        }

        public void Edit(Action_Detail obj)
        {
            string queryStr = "UPDATE `action_detail` SET";
            queryStr += string.Format(" ActionID = '{0}'", obj.ActionsID);            
            queryStr += string.Format(" ,Content = '{0}'", obj.Content);                        

            queryStr += string.Format(" ,Status = '{0}'", obj.Status);
            
            queryStr += string.Format(" ,PIC = '{0}'", obj.PIC);
            
            queryStr += string.Format(" ,Priority = '{0}'", obj.Priority);            
            queryStr += string.Format(" WHERE id = '{0}'", obj.id);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        }

        public void Delete(string id, bool IsActionID)
        {
            string queryStr = "";
            if (IsActionID == true)
            {
                queryStr = string.Format("Delete FROM `action_detail` WHERE  ActionID = '{0}' ", id);
            }
            else
            {
                queryStr = string.Format("Delete FROM `action_detail` WHERE  id = '{0}' ", id);
            }
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        }

        public Member GetMember(string id)
        {
            Member mb = new Member();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  members WHERE  memberid = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                mb.MemberId = dataset.Tables["x"].Rows[0]["MemberId"].ToString();
                mb.MemberName = dataset.Tables["x"].Rows[0]["MemberName"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["MemberType"].ToString()))
                {
                    mb.MemberType.MemberTypeId = int.Parse(dataset.Tables["x"].Rows[0]["MemberType"].ToString());
                }
                mb.MobilePhone = dataset.Tables["x"].Rows[0]["MobilePhone"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["NumberOfVissits"].ToString()))
                {
                    mb.NumberOfVissits = int.Parse(dataset.Tables["x"].Rows[0]["NumberOfVissits"].ToString());
                }
                mb.PhoneNumber = dataset.Tables["x"].Rows[0]["PhoneNumber"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["Regency"].ToString()))
                {
                    mb.Regency = dataset.Tables["x"].Rows[0]["Regency"].ToString();
                }

                mb.TaxCode = dataset.Tables["x"].Rows[0]["TaxCode"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["TotalScore"].ToString()))
                {
                    mb.TotalScore = int.Parse(dataset.Tables["x"].Rows[0]["TotalScore"].ToString());
                }
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString()))
                {
                    mb.UpdatedDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["UpdatedDate"].ToString());
                }
                mb.Website = dataset.Tables["x"].Rows[0]["MemberId"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["IsDelete"].ToString()))
                {
                    mb.IsDelete = int.Parse(dataset.Tables["x"].Rows[0]["IsDelete"].ToString());
                }
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["IsLock"].ToString()))
                {
                    mb.IsLock = int.Parse(dataset.Tables["x"].Rows[0]["IsLock"].ToString());
                }
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["LastestDate"].ToString()))
                {
                    mb.LastestDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["LastestDate"].ToString());
                }
                mb.MemberCode = dataset.Tables["x"].Rows[0]["MemberCode"].ToString();
                if (!string.IsNullOrEmpty(dataset.Tables["x"].Rows[0]["LockDate"].ToString()))
                {
                    mb.LockDate = DateTime.Parse(dataset.Tables["x"].Rows[0]["LockDate"].ToString());
                }
            }
            else
                mb = null;

            return mb;
        }

        public string GetNameOrCompany(string id)
        {
            string query = "SELECT CASE WHEN `MemberName` = '' or `MemberName` is null THEN concat('[', `CompanyName`, ']') ELSE `MemberName` END AS MemberName FROM `members` WHERE `members`.`MemberId` = " + id;

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables["Member"].Rows.Count > 0)
            {
                return dataset.Tables["Member"].Rows[0]["MemberName"].ToString();
            }
            else
                return null;
        }

        public CategoryActions GetCategoryActions(string id)
        {
            CategoryActions cat = new CategoryActions();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  categoryactions WHERE  CategoryActionID = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                cat.CategoryActionID = dataset.Tables["x"].Rows[0]["CategoryActionID"].ToString();
                cat.CategoryActionName = dataset.Tables["x"].Rows[0]["CategoryActionName"].ToString();
                cat.CategoryActionName2 = dataset.Tables["x"].Rows[0]["CategoryActionName2"].ToString();
                cat.CategoryActionName3 = dataset.Tables["x"].Rows[0]["CategoryActionName3"].ToString();
               
            }
            else
                cat = null;

            return cat;
        }

        public ActionStatus GetActionStatus(string id)
        {
            ActionStatus aStt = new ActionStatus();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  actionstatus WHERE  ActionStatusID = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                aStt.ActionStatusID = dataset.Tables["x"].Rows[0]["ActionStatusID"].ToString();
                aStt.ActionName = dataset.Tables["x"].Rows[0]["ActionName"].ToString();
                aStt.ActionName2 = dataset.Tables["x"].Rows[0]["ActionName2"].ToString();
                aStt.ActionName3 = dataset.Tables["x"].Rows[0]["ActionName3"].ToString();

            }
            else
                aStt = null;

            return aStt;
        }

        public Priorities GetActionPriorities(string id)
        {
            Priorities pr = new Priorities();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  priorities WHERE  PriorityID = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                pr.PriorityID = dataset.Tables["x"].Rows[0]["PriorityID"].ToString();
                pr.PriorityName = dataset.Tables["x"].Rows[0]["PriorityName"].ToString();
                pr.PriorityName2 = dataset.Tables["x"].Rows[0]["PriorityName2"].ToString();
                pr.PriorityName3 = dataset.Tables["x"].Rows[0]["PriorityName3"].ToString();

            }
            else
                pr = null;

            return pr;
        }

        public Employees1 GetEmployees(string id)
        {
            Employees1 em = new Employees1();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  employees WHERE  EmployeeId = '{0}'", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                em.EmployeeId = dataset.Tables["x"].Rows[0]["EmployeeId"].ToString();
                em.EmployeeName = dataset.Tables["x"].Rows[0]["EmployeeName"].ToString();
                //pr.PriorityName2 = dataset.Tables["x"].Rows[0]["PriorityName2"].ToString();
               // pr.PriorityName3 = dataset.Tables["x"].Rows[0]["PriorityName3"].ToString();

            }
            else
                em = null;

            return em;
        }

        public DataTable GetListDetail(string id)
        {
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM  action_detail WHERE  actionid = '{0}' order by CreatedDate", id);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);
            return dataset.Tables[0];
        }

        //Danh sách các lịch sử của một cái Actions
        public DataSet GetInfoForActions(string id)
        {
            DataSet dataset = new DataSet();
            string[][] pr = { new string[] { "id", id } };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGetAction_ActionDetail", ref dataset,pr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                return dataset;
            }
            else
            {
                return null;
            }
        }

        //get last action_detail
        public DataRow GetLast(string actionID)
        {
            DataSet dataset = new DataSet();
            string query = "SELECT * FROM action_detail WHERE actionid = '" + actionID + "' AND id >= ALL (SELECT id FROM action_detail WHERE actionid = '" + actionID + "')";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "last", ref errorString);
            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
                return dataset.Tables[0].Rows[0];
            else
                return null;
        }
    }
}
