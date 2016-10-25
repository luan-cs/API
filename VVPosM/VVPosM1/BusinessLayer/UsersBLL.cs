using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.IO;


namespace VVPosM1.BusinessLayer
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



        public bool CheckLogin(string pIdOrUsername, string pPassword)
        {
            bool ok = Program.destopService.IsUser(pIdOrUsername, pPassword, ref errorString);

            if (ok == true)
            {
                Program.Username = pIdOrUsername;
                Program.Password = pPassword;
                Program.user = GetByIdOrUsername(pIdOrUsername);
                /// Cập nhật thời gian đăng nhập
                //  int i = UpdateLastLogin(pIdOrUsername);
            }

            return ok;
        }

        public DataTable CheckRole(string employeeId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT * FROM `user_in_roles` where `EmployeeId` ='" + employeeId + "' And `RoleId`='admin'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public int UpdateLastLogin(string id)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE `users` SET ";
            queryStr += " `LastLogin` = NOW()";
            queryStr += string.Format(" WHERE UserId = '{0}'", id);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public DataTable GetRoleByRoleId()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT * FROM `roles`";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public DataTable GetRoleByRoleId(string roleId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT * FROM `roles` where `RoleId` ='" + roleId + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public DataTable GetEmployeesByUserId(string userid)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_UserName",userid},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Employees_By_UserName", ref ds, param, ref errorString);

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

        public User GetByIdOrUsername(string pIdOrUsername)
        {
            User user = new User();
            DataSet dataset = new DataSet();
            //hung 09-12-2014
            //  string queryStr = string.Format("SELECT * FROM users WHERE  UserId = '{0}'", pIdOrUsername);
            string queryStr = string.Format("SELECT * FROM users WHERE  UserId = '{0}'", pIdOrUsername);
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "x", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
                return null;

            if (dataset.Tables["x"].Rows.Count > 0)
            {
                user.UserId = dataset.Tables["x"].Rows[0]["UserId"].ToString();
                user.Pwd = dataset.Tables["x"].Rows[0]["Pwd"].ToString();
                user.LastLogin = dataset.Tables["x"].Rows[0]["LastLogin"].ToString();
                user.Status = dataset.Tables["x"].Rows[0]["Status"].ToString();
                user.CreatedBy = dataset.Tables["x"].Rows[0]["CreatedBy"].ToString();
                user.CreatedDate =  dataset.Tables["x"].Rows[0]["CreatedDate"].ToString();
                user.ModifiedBy = dataset.Tables["x"].Rows[0]["ModifiedBy"].ToString();
                user.ModifiedDate =  dataset.Tables["x"].Rows[0]["ModifiedDate"].ToString();
                user.RoleId = dataset.Tables["x"].Rows[0]["RoleId"].ToString();
            }
            else
                user = null;

            return user;
        }

        public DataTable SearchUsers(Users user, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            #region Đếm biến
            /////Dem
            //int i = 0;
            //if (!string.IsNullOrEmpty(obj.ObjectId))
            //{               
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ObjectGroup))
            //{               
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ObjectType))
            //{               
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.FullName))
            //{               
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PID))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PIDState))
            //{              
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PIDIssue))
            //{               
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.DoB))
            //{                
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PoB))
            //{               
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PerAdd))
            //{             
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.TemAdd))
            //{               
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Gender))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ProvinceId))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Tel))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Fax))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Email))
            //{                
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Website))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.TaxCode))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Note))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Status))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.CreatedBy))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.CreatedDate))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ModifiedBy))
            //{
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ModifiedDate))
            //{
            //    i++;
            //}
            //////////////////////////
            ///////////////////////////////
            //string[][] param = new string[i + 2][];
            //i = 0;
            //if (!string.IsNullOrEmpty(obj.ObjectId))
            //{
            //    param[i] = new string[] { "p_ObjectId", obj.ObjectId };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ObjectGroup))
            //{
            //    param[i] = new string[] { "p_ObjectGroup", obj.ObjectGroup };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ObjectType))
            //{
            //    param[i] = new string[] { "p_ObjectType", obj.ObjectType };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.FullName))
            //{
            //    param[i] = new string[] { "p_FullName", obj.FullName };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PID))
            //{
            //    param[i] = new string[] { "p_PID", obj.PID };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PIDState))
            //{
            //    param[i] = new string[] { "p_PIDState", obj.PIDState };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PIDIssue))
            //{
            //    param[i] = new string[] { "p_PIDIssue", obj.PIDIssue };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.DoB))
            //{
            //    param[i] = new string[] { "p_DoB", obj.DoB };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PoB))
            //{
            //    param[i] = new string[] { "p_PoB", obj.PoB };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.PerAdd))
            //{
            //    param[i] = new string[] { "p_PerAdd", obj.PerAdd };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.TemAdd))
            //{
            //    param[i] = new string[] { "p_TemAdd", obj.TemAdd };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Gender))
            //{
            //    param[i] = new string[] { "p_Gender", obj.Gender };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ProvinceId))
            //{
            //    param[i] = new string[] { "p_ProvinceId", obj.ProvinceId };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Tel))
            //{
            //    param[i] = new string[] { "p_Tel", obj.Tel };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Fax))
            //{
            //    param[i] = new string[] { "p_Fax", obj.Fax };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Email))
            //{
            //    param[i] = new string[] { "p_Email", obj.Email };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Website))
            //{
            //    param[i] = new string[] { "p_Website", obj.Website };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.TaxCode))
            //{
            //    param[i] = new string[] { "p_TaxCode", obj.TaxCode };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Note))
            //{
            //    param[i] = new string[] { "p_Note", obj.Note };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.Status))
            //{
            //    param[i] = new string[] { "p_Status", obj.Status };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.CreatedBy))
            //{
            //    param[i] = new string[] { "p_CreatedBy", obj.CreatedBy };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.CreatedDate))
            //{
            //    param[i] = new string[] { "p_CreatedDate", obj.CreatedDate };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ModifiedBy))
            //{
            //    param[i] = new string[] { "p_ModifiedBy", obj.ModifiedBy };
            //    i++;
            //}
            //if (!string.IsNullOrEmpty(obj.ModifiedDate))
            //{
            //    param[i] = new string[] { "p_ModifiedDate", obj.ModifiedDate };
            //    i++;
            //}

            //param[i] = new string[] { "p_NoStart", limit.ToString() };
            //param[i + 1] = new string[] { "p_NoEnd", RecordPerPage.ToString() };

            #endregion

            string[][] param ={

                new string[] { "p_UserId", string.IsNullOrEmpty(user.UserId)?null:user.UserId },
                new string[] { "p_Pwd", string.IsNullOrEmpty(user.Pwd)?null:user.Pwd },
                new string[] { "p_ObjectId", string.IsNullOrEmpty(user.ObjectId )?null: user.ObjectId},
                new string[] { "p_Status", string.IsNullOrEmpty(user.Status)?null:user.Status },
                new string[] { "p_RoleId", string.IsNullOrEmpty(user.RoleId)?null:user.RoleId },
                new string[] { "p_LastLogin", string.IsNullOrEmpty(user.LastLogin)?null:user.LastLogin },
                new string[] { "p_CreatedBy", string.IsNullOrEmpty(user.CreatedBy)?null:user.CreatedBy },
                new string[] { "p_CreatedDate", string.IsNullOrEmpty(user.CreatedDate)?null:user.CreatedDate },
                new string[] { "p_ModifiedBy", string.IsNullOrEmpty(user.ModifiedBy)?null:user.ModifiedBy },
                new string[] { "p_ModifiedDate", string.IsNullOrEmpty(user.ModifiedDate)?null:user.ModifiedDate },
                
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Users", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = ds.Tables[0];
                TotalRecord = int.Parse(ds.Tables[1].Rows[0][0].ToString());
            }
            else
            {
                res = null;
            }
            return res;

        }
        public DataTable GetObjectTypeId(string id)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='ObjectType' and `CommonId`='" + id + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
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
        public DataTable GetObjectTheoID(string ObjectId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `objects`
                            WHERE `ObjectId`='" + ObjectId + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }

        public DataTable GetUserTheoID(string UserId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `users`
                            WHERE `UserId`='" + UserId + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }
        public DataTable GetRoleTheoID(string RoleId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='VNLocation' and `commonid`='" + RoleId + "'";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
            }
            else
            {
                res = null;
            }
            return res;
        }
        public Users GetUserWithID(string id)
        {
            Users reUser = new Users();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `users`
                            WHERE `UserId`='" + id + "' ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reUser.UserId = ds.Tables[0].Rows[0]["UserId"].ToString();
                reUser.Pwd = ds.Tables[0].Rows[0]["Pwd"].ToString();
                reUser.ObjectId = ds.Tables[0].Rows[0]["ObjectId"].ToString();
                reUser.LastLogin = ds.Tables[0].Rows[0]["LastLogin"].ToString();
                reUser.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                reUser.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                reUser.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                reUser.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                reUser.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();

                reUser.RoleId = ds.Tables[0].Rows[0]["RoleId"].ToString();

            }
            else
            {

                reUser = null;
            }

            return reUser;
        }

        public Employees GetEmployeeWithID(string id)
        {
            Employees reEmp = new Employees();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `employees`
                            WHERE `EmployeeId`='" + id + "' ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reEmp.EmployeeId = ds.Tables[0].Rows[0]["EmployeeId"].ToString();
                reEmp.EmployeeCode = ds.Tables[0].Rows[0]["EmployeeCode"].ToString();
                reEmp.ObjectId = ds.Tables[0].Rows[0]["ObjectId"].ToString();
                reEmp.Image = ds.Tables[0].Rows[0]["Image"].ToString();
                reEmp.Notes = ds.Tables[0].Rows[0]["Notes"].ToString();
                reEmp.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                reEmp.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                reEmp.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                reEmp.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                reEmp.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();

                reEmp.PositionId = ds.Tables[0].Rows[0]["PositionId"].ToString();

            }
            else
            {

                reEmp = null;
            }
            return reEmp;
        }

        public int DeleteNV(string id)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("UPDATE users SET Status= 5 WHERE  UserId = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Update(Users user)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE users SET ";

            if (!string.IsNullOrEmpty(user.Pwd))
            {
                queryStr += string.Format(" Pwd = '{0}',", user.Pwd);
            }
            if (!string.IsNullOrEmpty(user.ObjectId))
            {
                queryStr += string.Format(" ObjectId = '{0}',", user.ObjectId);
            }

            if (!string.IsNullOrEmpty(user.Status))
            {
                queryStr += string.Format(" Status = '{0}',", user.Status);
            }
            if (!string.IsNullOrEmpty(user.RoleId))
            {
                queryStr += string.Format(" RoleId = '{0}',", user.RoleId);
            }
            queryStr += string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += string.Format(" WHERE UserId = '{0}'", user.UserId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }
        public string Tao_EmployeeID()
        {
            string st = "01";
            string s_thang = "";
            string s_nam = "";
            //string tempStr = "";
            //int intStr = 0;

            //lay thang + nam hien tai
            int thang = DateTime.Now.Month;
            if (thang < 10)
                s_thang = "0" + thang.ToString();
            else
                s_thang = thang.ToString();
            int nam = DateTime.Now.Year;
            s_nam = (nam.ToString()).Substring(2);

            st = st + s_nam + s_thang;
            // 01 14 07
            int stt = 0;
            string SQLstr = @"SELECT `EmployeeId` AS `Code` 
	                        FROM  `employees`
	                        WHERE LEFT(`EmployeeId`,6)= '" + st + "' ORDER BY `EmployeeId`;";
            DataSet ds = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, SQLstr, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow d = dt.Rows[i];
                        //  01 14 07 000001
                        stt = int.Parse((d["Code"].ToString()).Substring(6));//////////////
                        if (stt != i + 1)
                        {
                            stt = i + 1;
                            break;
                        }
                    }
                    // MessageBox.Show(i.ToString());
                    if (i == dt.Rows.Count)
                    {
                        stt = dt.Rows.Count + 1;
                    }
                }
                else
                {
                    stt = 1;
                }
            }
            else
            {
                stt = 1;
            }
            string s_stt = "";
            if (stt < 10)
                s_stt = "00000" + stt.ToString();
            else if ((stt < 100) && (stt >= 10))
                s_stt = "0000" + stt.ToString();
            else if ((stt < 1000) && (stt >= 100))
                s_stt = "000" + stt.ToString();
            else if ((stt < 10000) && (stt >= 1000))
                s_stt = "00" + stt.ToString();
            else if ((stt < 100000) && (stt >= 10000))
                s_stt = "0" + stt.ToString();
            else
                s_stt = stt.ToString();
            //xet sau ky tu cuoi
            //foreach (var str in obj.ObjectId)
            //{
            //    tempStr = tempStr.Substring(9, str.ToString().Length - 8);
            //    intStr = int.Parse(tempStr) + 1;
            //    if (intStr < 1000000)
            //    {
            //        tempStr = intStr.ToString();
            //        intStr = tempStr.Length;
            //        while (intStr <= tempStr.Length)
            //        {
            //            tempStr = "0" + tempStr;
            //        }
            //    }
            //}
            st += s_stt;
            return st;
        }

        public int Insert(Users user)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " users(";
            if (!string.IsNullOrEmpty(user.UserId))
            {
                queryStr += "`UserId`,";
            }
            if (!string.IsNullOrEmpty(user.Pwd))
            {
                queryStr += "`Pwd`,";
            }
            if (!string.IsNullOrEmpty(user.ObjectId))
            {
                queryStr += "`ObjectId`,";
            }

            if (!string.IsNullOrEmpty(user.Status))
            {
                queryStr += "`Status`,";
            }
            if (!string.IsNullOrEmpty(user.RoleId))
            {
                queryStr += "`RoleId`,";
            }
            queryStr += "`CreatedBy`,";
            queryStr += "`CreatedDate`";
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(user.UserId))
            {
                queryStr += string.Format("'{0}',", user.UserId);
            }
            if (!string.IsNullOrEmpty(user.Pwd))
            {
                queryStr += string.Format("'{0}',", user.Pwd);
            }
            if (!string.IsNullOrEmpty(user.ObjectId))
            {
                queryStr += string.Format("'{0}',", user.ObjectId);
            }

            if (!string.IsNullOrEmpty(user.Status))
            {
                queryStr += string.Format("'{0}',", user.Status);
            }
            if (!string.IsNullOrEmpty(user.RoleId))
            {
                queryStr += string.Format("'{0}',", user.RoleId);
            }

            queryStr += string.Format("  '{0}'", Program.Username);
            queryStr += " , NOW() ";
            queryStr += ")";
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;

        }

        public List<Objects> ReadListFromAutoComplete(string str)
        {
            List<Objects> res = new List<Objects>();
            try
            {
                DataSet ds = new DataSet();
                string query = @"SELECT *
                            FROM `objects`
                            WHERE `ObjectId` LIKE '%" + str + "%' OR `FullName` LIKE '%" + str + "%'";
                //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
                if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Objects ob = new Objects();
                        ob.ObjectId = dr["ObjectId"].ToString();
                        ob.FullName = dr["FullName"].ToString();
                        ob.ObjectGroup = dr["ObjectGroup"].ToString();
                        ob.ObjectType = dr["ObjectType"].ToString();
                        ob.PID = dr["PID"].ToString();
                        ob.PIDState = dr["PIDDate"].ToString();
                        ob.PIDIssue = dr["PIDIssue"].ToString();
                        ob.DoB = dr["DoB"].ToString();
                        ob.PoB = dr["PoB"].ToString();
                        ob.PerAdd = dr["PerAdd"].ToString();
                        ob.TemAdd = dr["TemAdd"].ToString();
                        ob.Gender = dr["Gender"].ToString();
                        ob.ProvinceId = dr["ProvinceId"].ToString();
                        ob.Tel = dr["Tel"].ToString();
                        ob.Fax = dr["Fax"].ToString();
                        ob.Email = dr["Email"].ToString();
                        ob.Website = dr["Website"].ToString();
                        ob.TaxCode = dr["TaxCode"].ToString();
                        ob.Note = dr["Note"].ToString();
                        ob.Status = dr["Status"].ToString();
                        ob.CreatedBy = dr["CreatedBy"].ToString();
                        ob.CreatedDate = dr["CreatedDate"].ToString();
                        ob.ModifiedBy = dr["ModifiedBy"].ToString();
                        ob.ModifiedDate = dr["ModifiedDate"].ToString();

                        ob.ObjectGroup = dr["ObjectGroup"].ToString();
                        res.Add(ob);
                    }
                }
                else
                {
                    res = null;
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }

        // lay ngay thang
        public string GetDMY()
        {
            string st = "";
            string s = "";
            int t;
            //lay ngay + thang + nam hien tai
            t = DateTime.Now.Day;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Month;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Year;
            st += (t.ToString()).Substring(2);

            return st;
        }
        public string GetHMS()
        {
            string st = "";
            string s = "";
            int t;
            //lay ngay + thang + nam hien tai
            t = DateTime.Now.Hour;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Minute;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;
            t = DateTime.Now.Second;
            if (t < 10)
                s = "0" + t.ToString();
            else
                s = t.ToString();
            st += s;

            return st;
        }



    }
}
