using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosS.Entities;
using System.Data;

namespace VVPosS.BusinessLayer
{
    public class UsersBLL : IObjectBLL<Users>
    {

        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        private bool res = false;

        public bool Res
        {
            get { return res; }
            set { res = value; }
        }

        public void Add(Users obj)
        {
            long id = 0;
            string queryStr = "INSERT INTO";
            queryStr += " users(UserId, Pwd, ObjectId, LastLogin, Status, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, RoleId)";
            queryStr += " VALUES(";
            queryStr += string.Format("'{0}'", obj.UserId);
            queryStr += string.Format(", '{0}'", obj.Pwd);
            queryStr += string.Format(", '{0}'", obj.ObjectId);
            queryStr += string.Format(", '{0}'", obj.LastLogin);
            queryStr += string.Format(", '{0}'", obj.Status);
            queryStr += string.Format(", '{0}'", obj.CreatedBy);
            queryStr += ", NOW()";
            queryStr += string.Format(", '{0}'", obj.ModifiedBy);
            queryStr += ", NOW()";
            queryStr += string.Format(", '{0})'", obj.RoleId);
            //Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            Program.destopService.DataExecuteId(Program.Username, Program.Password, queryStr, ref id, ref errorString);
            //MessageBox.Show(id + "");
        }

        public void Edit(Users obj)
        {
            string queryStr = "UPDATE users SET";
            queryStr += string.Format(" Pwd = '{0}'", obj.Pwd);
            queryStr += string.Format(" ,ObjectId = '{0}'", obj.ObjectId);
            queryStr += string.Format(" ,LastLogin = '{0}'", obj.LastLogin);
            queryStr += string.Format(" ,Status = '{0}'", obj.Status);
            queryStr += string.Format(" ,ModifiedBy = '{0}'", obj.ModifiedBy);
            queryStr += " ,ModifiedBy = NOW()";
            queryStr += string.Format(" ,ModifiedBy = '{0}'", obj.ModifiedBy);
            queryStr += string.Format(", '{0})'", obj.RoleId);
            queryStr += string.Format(" WHERE UserId = '{0}'", obj.UserId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        }

        public bool CheckLogin(string pIdOrUsername, string pPassword)
        {
            bool ok = Program.destopService.IsUser(pIdOrUsername, pPassword, ref errorString);

            if (ok == true)
            {
                Program.Username = pIdOrUsername;
                Program.Password = pPassword;
                Program.users = GetByIdOrUsername(pIdOrUsername);
            }

            return ok;
        }

        public DataTable GetObjectIdByUserId(string userid) {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_UserId",userid},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_ObjectId_By_UserId", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public void ChangePassword(Users obj)
        {
            string[][] param ={
                new string[] {"p_UserId", obj.UserId},
                new string[] {"p_Pwd",obj.Pwd},
            };
            Program.destopService.DataStoreProcExecute(Program.Username, Program.Password, "spChangePassword_User", ref errorString, param, ref res);
        }


        public void Delete(string id)
        {
            //
        }
        public void Delete(string id, string stt)
        {
            string queryStr = string.Format("UPDATE users SET Status = '{0}' WHERE  UserId = '{1}'", stt, id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        }

        public Users GetByIdOrUsername(string pIdOrUsername)
        {
            Users user = new Users();
            DataSet dataset = new DataSet();
            string queryStr = string.Format("SELECT * FROM users WHERE  UserId = '{0}'", pIdOrUsername);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {

                user.ObjectId = dataset.Tables["x"].Rows[0]["ObjectId"].ToString();
                user.LastLogin = dataset.Tables["x"].Rows[0]["LastLogin"].ToString();
                user.Status = dataset.Tables["x"].Rows[0]["Status"].ToString();
                user.CreatedBy = dataset.Tables["x"].Rows[0]["CreatedBy"].ToString();
                user.CreatedDate = dataset.Tables["x"].Rows[0]["CreatedDate"].ToString();
                user.ModifiedBy = dataset.Tables["x"].Rows[0]["ModifiedBy"].ToString();
                user.ModifiedDate = dataset.Tables["x"].Rows[0]["ModifiedDate"].ToString();
                user.RoleId = dataset.Tables["x"].Rows[0]["RoleId"].ToString();
            }
            else
                user = null;

            return user;
        }
    }
}
