using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;

namespace VVPosM1.BusinessLayer
{
    class EmployBLL:IEmployBLL<Employees>
        
    {

        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }
        public int Insert(Employees employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " employees(";
            if (!string.IsNullOrEmpty(employ.EmployeeId))
            {
                queryStr += "`EmployeeId`,";
            }
            if (!string.IsNullOrEmpty(employ.EmployeeCode))
            {
                queryStr += "`EmployeeCode`,";
            }
            if (!string.IsNullOrEmpty(employ.ObjectId))
            {
                queryStr += "`ObjectId`,";
            }
            if (!string.IsNullOrEmpty(employ.Notes))
            {
                queryStr += "`Notes`,";
            }
            if (!string.IsNullOrEmpty(employ.Status))
            {
                queryStr += "`Status`,";
            }
            if (!string.IsNullOrEmpty(employ.PositionId))
            {
                queryStr += "`PositionId`,";
            }
            queryStr += "`CreatedBy`,";
            queryStr += "`CreatedDate`"; 
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(employ.EmployeeId))
            {
                queryStr += string.Format("'{0}',", employ.EmployeeId);
            }
            if (!string.IsNullOrEmpty(employ.EmployeeCode))
            {
                queryStr += string.Format("'{0}',", employ.EmployeeCode);
            }
            if (!string.IsNullOrEmpty(employ.ObjectId))
            {
                queryStr += string.Format("'{0}',", employ.ObjectId);
            }
            if (!string.IsNullOrEmpty(employ.Notes))
            {
                queryStr += string.Format("'{0}',", employ.Notes);
            }
            if (!string.IsNullOrEmpty(employ.Status))
            {
                queryStr += string.Format("'{0}',", employ.Status);
            }
            if (!string.IsNullOrEmpty(employ.PositionId))
            {
                queryStr += string.Format("'{0}',", employ.PositionId);
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
        public string Tao_EmployeeID()
        {
            string st = "02";
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

        public int Update(Employees employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE employees SET ";
           
            if (!string.IsNullOrEmpty(employ.EmployeeCode))
            {
                queryStr += string.Format(" EmployeeCode = '{0}',", employ.EmployeeCode);
            }
            if (!string.IsNullOrEmpty(employ.ObjectId))
            {
                queryStr += string.Format(" ObjectId = '{0}',", employ.ObjectId);
            }
            //if (!string.IsNullOrEmpty(employ.Notes))
            //{
                queryStr += string.Format(" Notes = '{0}',", employ.Notes);
            //}
            //if (!string.IsNullOrEmpty(employ.Status))
            //{
                queryStr += string.Format(" Status = '{0}',", employ.Status);
            //}
            //if (!string.IsNullOrEmpty(employ.PositionId))
            //{
                queryStr += string.Format(" PositionId = '{0}',", employ.PositionId);
            //}
            queryStr += string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += string.Format(" WHERE EmployeeId = '{0}'", employ.EmployeeId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int DeleteNV(string id)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("UPDATE employees SET Status= 5 WHERE  EmployeeId = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

       


        public DataTable GetObjectByObjectId(string employeeId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_EmployeeId",employeeId},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Employ_By_EmployId", ref ds, param, ref errorString);

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

        public Employees GetEmployeeCode(string id)
        {
            Employees reEmp = new Employees();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `employees`
                            WHERE `EmployeeCode`='" + id + "' ";
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

        public DataTable SearchEmployees(Employees employ, int page, out int TotalRecord)
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
                new string[] { "p_EmployeeId", string.IsNullOrEmpty(employ.ObjectId)?null:employ.EmployeeId },
                new string[] { "p_EmployeeCode", string.IsNullOrEmpty(employ.EmployeeCode)?null: employ.EmployeeCode},
                new string[] { "p_ObjectId", string.IsNullOrEmpty(employ.ObjectId )?null: employ.ObjectId},
                new string[] { "p_Notes", string.IsNullOrEmpty(employ.Note)?null:employ.Note },
                new string[] { "p_Status", string.IsNullOrEmpty(employ.Status)?null:employ.Status },
                new string[] { "p_CreatedBy", string.IsNullOrEmpty(employ.CreatedBy)?null:employ.CreatedBy },
                new string[] { "p_CreatedDate", string.IsNullOrEmpty(employ.CreatedDate)?null:employ.CreatedDate },
                new string[] { "p_ModifiedBy", string.IsNullOrEmpty(employ.ModifiedBy)?null:employ.ModifiedBy },
                new string[] { "p_ModifiedDate", string.IsNullOrEmpty(employ.ModifiedDate)?null:employ.ModifiedDate },
                new string[] { "p_PositionId", string.IsNullOrEmpty(employ.PositionId)?null: employ.PositionId  },
                
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };


            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Employees", ref ds, param, ref errorString);

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

        public int SaveImageEmpIntoWeb(Image img, string EmployeeId)
        {
            //1: Thanh cong
            //0: That bai
            int res = 0;
            byte[] imgBuffer = imageEmpToByteArray(img);
            Program.destopService.SaveImage_IntoEmployee(imgBuffer, EmployeeId, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;

            }
            return res;
        }
        public static byte[] imageEmpToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
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
                if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count >0)
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
        public DataTable GetEmployPositionId()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='PositionId' ";
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

        public DataTable GetPositionTheoID(string PositionId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='PositionId' and `commonid`='" + PositionId + "'";
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
