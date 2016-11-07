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
    public class ObjectBLL:IObjectBLL<Objects>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        

        public DataTable GetObjectByObjectId(string objectid)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_ObjectId",objectid},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Object_By_ObjectId", ref ds, param, ref errorString);

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

      

        public string Tao_ObjectID(string objGroup, string objType)
        {
            string st = "";
            string s_thang = "";
            string s_nam = "";
            //string tempStr = "";
            //int intStr = 0;

            if (!string.IsNullOrEmpty(objGroup) && objGroup.Length == 2)
            {
                st = st + objGroup;
            }
            else
            {
                st = st + "01";
            }
            if (!string.IsNullOrEmpty(objType) && objType.Length == 2)
            {
                st += objType;
            }
            else
            {
                st += "01";
            }

            //lay thang + nam hien tai
            int thang = DateTime.Now.Month;
            if (thang < 10)
                s_thang = "0" + thang.ToString();
            else
                s_thang = thang.ToString();
            int nam = DateTime.Now.Year;
            s_nam = (nam.ToString()).Substring(2);

            st = st + s_nam + s_thang;
            // 01 01 14 07
            int stt = 0;
            string SQLstr = @"SELECT `ObjectId` AS `Code` 
	                        FROM  `objects`
	                        WHERE LEFT(`ObjectId`,8)= '" + st + "' ORDER BY `ObjectId`;";
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
                        // 01 01 14 07 000001
                        stt = int.Parse((d["Code"].ToString()).Substring(8));//////////////
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

        public int Insert(Objects obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " objects(";
            if (!string.IsNullOrEmpty(obj.ObjectId))
            {
                queryStr += "`ObjectId`,";
            }
            if (!string.IsNullOrEmpty(obj.ObjectGroup))
            {
                queryStr += "`ObjectGroup`,";
            }
            if (!string.IsNullOrEmpty(obj.ObjectType))
            {
                queryStr += "`ObjectType`,";
            }
            if (!string.IsNullOrEmpty(obj.FullName))
            {
                queryStr += "`FullName`,";
            }
            if (!string.IsNullOrEmpty(obj.PID))
            {
                queryStr += "`PID`,";
            }
            if (!string.IsNullOrEmpty(obj.PIDState))
            {
                queryStr += "`PIDDate`,";
            }
            if (!string.IsNullOrEmpty(obj.PIDIssue))
            {
                queryStr += "`PIDIssue`,";
            }
            if (!string.IsNullOrEmpty(obj.DoB))
            {
                queryStr += "`DoB`,";
            }
            if (!string.IsNullOrEmpty(obj.PoB))
            {
                queryStr += "`PoB`,";
            }
            if (!string.IsNullOrEmpty(obj.PerAdd))
            {
                queryStr += "`PerAdd`,";
            }
            if (!string.IsNullOrEmpty(obj.TemAdd))
            {
                queryStr += "`TemAdd`,";
            }
            if (!string.IsNullOrEmpty(obj.Gender))
            {
                queryStr += "`Gender`,";
            }
            if (!string.IsNullOrEmpty(obj.ProvinceId))
            {
                queryStr += "`ProvinceId`,";
            }
            if (!string.IsNullOrEmpty(obj.Tel))
            {
                queryStr += "`Tel`,";
            }
            if (!string.IsNullOrEmpty(obj.Fax))
            {
                queryStr += "Fax,";
            }
            if (!string.IsNullOrEmpty(obj.Email))
            {
                queryStr += "`Email`,";
            }
            if (!string.IsNullOrEmpty(obj.Website))
            {
                queryStr += "Website,";
            }
            if (!string.IsNullOrEmpty(obj.TaxCode))
            {
                queryStr += "TaxCode,";
            }
            if (!string.IsNullOrEmpty(obj.Note))
            {
                queryStr += "`Note`,";
            }
            if (!string.IsNullOrEmpty(obj.Status))
            {
                queryStr += "`Status`,";
            }
            queryStr += "`CreatedBy`,";
            queryStr += "`CreatedDate`";
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(obj.ObjectId))
            {
                queryStr += string.Format("'{0}',", obj.ObjectId);
            }
            if (!string.IsNullOrEmpty(obj.ObjectGroup))
            {
                queryStr += string.Format("'{0}',", obj.ObjectGroup);
            }
            if (!string.IsNullOrEmpty(obj.ObjectType))
            {
                queryStr += string.Format("'{0}',", obj.ObjectType);
            }
            if (!string.IsNullOrEmpty(obj.FullName))
            {
                queryStr += string.Format("  '{0}',", obj.FullName);
            }
            if (!string.IsNullOrEmpty(obj.PID))
            {
                queryStr += string.Format("  '{0}',", obj.PID);
            }
            if (!string.IsNullOrEmpty(obj.PIDState))
            {
                queryStr += string.Format(" '{0}',", DateTime.Parse(obj.PIDState).ToString("yyyy-MM-dd HH:mm:ss"));
            }
            if (!string.IsNullOrEmpty(obj.PIDIssue))
            {
                queryStr += string.Format("  '{0}',", obj.PIDIssue);
            }
            if (!string.IsNullOrEmpty(obj.DoB))
            {
                queryStr += string.Format("'{0}',", DateTime.Parse(obj.DoB).ToString("yyyy-MM-dd HH:mm:ss"));
            }
            if (!string.IsNullOrEmpty(obj.PoB))
            {
                queryStr += string.Format(" '{0}',", obj.PoB);
            }
            if (!string.IsNullOrEmpty(obj.PerAdd))
            {
                queryStr += string.Format(" '{0}',", obj.PerAdd);
            }
            if (!string.IsNullOrEmpty(obj.TemAdd))
            {
                queryStr += string.Format("  '{0}',", obj.TemAdd);
            }
            if (!string.IsNullOrEmpty(obj.Gender))
            {
                queryStr += string.Format("b'{0}',", obj.Gender);
            }

            if (!string.IsNullOrEmpty(obj.ProvinceId))
            {
                queryStr += string.Format("  '{0}',", obj.ProvinceId);
            }
            if (!string.IsNullOrEmpty(obj.Tel))
            {
                queryStr += string.Format("  '{0}',", obj.Tel);
            }
            if (!string.IsNullOrEmpty(obj.Fax))
            {
                queryStr += string.Format("  '{0}',", obj.Fax);
            }
            if (!string.IsNullOrEmpty(obj.Email))
            {
                queryStr += string.Format("  '{0}',", obj.Email);
            }
            if (!string.IsNullOrEmpty(obj.Website))
            {
                queryStr += string.Format("  '{0}',", obj.Website);
            }
            if (!string.IsNullOrEmpty(obj.TaxCode))
            {
                queryStr += string.Format("  '{0}',", obj.TaxCode);
            }
            if (!string.IsNullOrEmpty(obj.Note))
            {
                queryStr += string.Format("  '{0}',", obj.Note);
            }
            if (!string.IsNullOrEmpty(obj.Status))
            {
                queryStr += string.Format("  '{0}',", obj.Status);
            }


            queryStr += string.Format("  '{0}'", Program.Username);
            queryStr += " , NOW()";
            queryStr += ")";

            //queryStr += string.Format(" WHERE Objectid = '{0}'", obj.ObjectId);


            // ObjectGroup, ObjectType, FullName, PID, PIDState, PIDIssue, DoB, PoB, PerAdd, TemAdd,";
            //queryStr += " Gender, ProvinceId, Tel, Fax, Email, Website, TaxCode, Note, Status, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)";
            //queryStr += " VALUES(";
            //queryStr += string.Format("'{0}'", obj.ObjectId);
            //queryStr += string.Format(", '{0}'", obj.ObjectGroup);
            //queryStr += string.Format(", '{0}'", obj.ObjectType);
            //queryStr += string.Format(", '{0}'", obj.FullName);
            //queryStr += string.Format(", '{0}'", obj.PID);
            //queryStr += string.Format(", '{0}'", obj.PIDState);
            //queryStr += string.Format(", '{0}'", obj.PIDIssue);
            //queryStr += string.Format(", '{0}'", obj.DoB);
            //queryStr += string.Format(", {0}", obj.PoB);
            //queryStr += string.Format(", '{0}'", obj.PerAdd);
            //queryStr += string.Format(", '{0}'", obj.TemAdd);
            //queryStr += string.Format(", '{0}'", obj.Gender);
            //queryStr += string.Format(", '{0}'", obj.ProvinceId);
            //queryStr += string.Format(", {0}", obj.Tel);
            //queryStr += string.Format(", {0}", obj.Fax);
            //queryStr += string.Format(", {0}", obj.Email);
            //queryStr += string.Format(", {0}", obj.Website);
            //queryStr += string.Format(", {0}", obj.TaxCode);
            //queryStr += string.Format(", {0}", obj.Note);
            //queryStr += string.Format(", {0}", obj.Status);
            //queryStr += string.Format(", {0}", obj.CreatedBy);
            //queryStr += ", NOW()";
            //queryStr += string.Format(", {0}", obj.ModifiedBy);
            //queryStr += ", NOW() )";
            //Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Update(Objects obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE objects SET ";
            if (!string.IsNullOrEmpty(obj.ObjectGroup))
            {
                queryStr += string.Format(" ObjectGroup = '{0}',", obj.ObjectGroup);
            }
            if (!string.IsNullOrEmpty(obj.ObjectType))
            {
                queryStr += string.Format(" ObjectType = '{0}',", obj.ObjectType);
            }
            //if (!string.IsNullOrEmpty(obj.FullName))
            //{
                queryStr += string.Format(" FullName = '{0}',", obj.FullName);
            //}
            //if (!string.IsNullOrEmpty(obj.PID))
            //{
                queryStr += string.Format(" PID = '{0}',", obj.PID);
            //}
            if (!string.IsNullOrEmpty(obj.PIDState))
            {
                queryStr += string.Format(" PIDDate = '{0}',", obj.PIDState);
            }
            //if (!string.IsNullOrEmpty(obj.PIDIssue))
            //{
                queryStr += string.Format(" PIDIssue = '{0}',", obj.PIDIssue);
            //}
            if (!string.IsNullOrEmpty(obj.DoB))
            {
                queryStr += string.Format(" DoB = '{0}',", obj.DoB);
            }
            //if (!string.IsNullOrEmpty(obj.PoB))
            //{
                queryStr += string.Format(" PoB = '{0}',", obj.PoB);
            //}
            //if (!string.IsNullOrEmpty(obj.PerAdd))
            //{
                queryStr += string.Format(" PerAdd = '{0}',", obj.PerAdd);
            //}
            if (!string.IsNullOrEmpty(obj.Gender))
            {
                queryStr += string.Format(" Gender = b'{0}',", obj.Gender);
            }
            //if (!string.IsNullOrEmpty(obj.TemAdd))
            //{
                queryStr += string.Format(" TemAdd = '{0}',", obj.TemAdd);
            //}
            if (!string.IsNullOrEmpty(obj.ProvinceId))
            {
                queryStr += string.Format(" ProvinceId = '{0}',", obj.ProvinceId);
            }
            //if (!string.IsNullOrEmpty(obj.Tel))
            //{
                queryStr += string.Format(" Tel = '{0}',", obj.Tel);
            //}
            //if (!string.IsNullOrEmpty(obj.Fax))
            //{
                queryStr += string.Format(" Fax = '{0}',", obj.Fax);
            //}
            //if (!string.IsNullOrEmpty(obj.Email))
            //{
                queryStr += string.Format(" Email = '{0}',", obj.Email);
            //}
            //if (!string.IsNullOrEmpty(obj.Website))
            //{
                queryStr += string.Format(" Website = '{0}',", obj.Website);
            //}
            //if (!string.IsNullOrEmpty(obj.TaxCode))
            //{
                queryStr += string.Format(" TaxCode = '{0}',", obj.TaxCode);
            //}
            //if (!string.IsNullOrEmpty(obj.Note))
            //{
                queryStr += string.Format(" Note = '{0}',", obj.Note);
            //}
                if (!string.IsNullOrEmpty(obj.Status))
                {
                    queryStr += string.Format("Status = '{0}',", obj.Status);
                }

            queryStr += string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += string.Format(" WHERE Objectid = '{0}'", obj.ObjectId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Delete(string id)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("UPDATE objects SET Status= 5 WHERE  ObjectId = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

       
        public DataTable GetProvince()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='VNLocation' ";
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


        public DataTable GetProvinceTheoID(string ProvinceId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='VNLocation' and `commonid`='" + ProvinceId + "'";
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

        public DataTable GetObjectGroup()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='ObjectGroup' ";
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

        public DataTable GetObjectType()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='ObjectType' ";
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

        public DataTable GetObjectGroupId(string id)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId`='ObjectGroup' and `CommonId`='" + id + "'";
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

        public DataTable SearchObjects(Objects obj, int page, out int TotalRecord)
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
                new string[] { "p_ObjectId", string.IsNullOrEmpty(obj.ObjectId)?null:obj.ObjectId },
                new string[] { "p_ObjectGroup", string.IsNullOrEmpty(obj.ObjectGroup)?null: obj.ObjectGroup},
                new string[] { "p_ObjectType", string.IsNullOrEmpty(obj.ObjectType )?null: obj.ObjectType },
                new string[] { "p_FullName", string.IsNullOrEmpty(obj.FullName)?null: obj.FullName  },
                new string[] { "p_PID", string.IsNullOrEmpty(obj.PID)?null:obj.PID },
                new string[] { "p_PIDDate", string.IsNullOrEmpty(obj.PIDState)?null:obj.PIDState },
                new string[] { "p_PIDIssue", string.IsNullOrEmpty(obj.PIDIssue)?null:obj.PIDIssue }, 
                new string[] { "p_DoB", string.IsNullOrEmpty(obj.DoB)?null:obj.DoB },
                new string[] { "p_PoB", string.IsNullOrEmpty(obj.PoB)?null:obj.PoB },
                new string[] { "p_PerAdd", string.IsNullOrEmpty(obj.PerAdd)?null:obj.PerAdd },
                new string[] { "p_TemAdd",string.IsNullOrEmpty(obj.TemAdd)?null:obj.TemAdd  },
                new string[] { "p_Gender",string.IsNullOrEmpty(obj.Gender)?null:obj.Gender   },
                new string[] { "p_ProvinceId", string.IsNullOrEmpty(obj.ProvinceId)?null:obj.ProvinceId },
                new string[] { "p_Tel", string.IsNullOrEmpty(obj.Tel)?null:obj.Tel },
                new string[] { "p_Fax", string.IsNullOrEmpty(obj.Fax)?null:obj.Fax },
                new string[] { "p_Email", string.IsNullOrEmpty(obj.Email)?null:obj.Email },
                new string[] { "p_Website", string.IsNullOrEmpty(obj.Website)?null:obj.Website },
                new string[] { "p_TaxCode", string.IsNullOrEmpty(obj.TaxCode)?null:obj.TaxCode },
                new string[] { "p_Note", string.IsNullOrEmpty(obj.Note)?null:obj.Note },
                new string[] { "p_Status", string.IsNullOrEmpty(obj.Status)?null:obj.Status },
                new string[] { "p_CreatedBy", string.IsNullOrEmpty(obj.CreatedBy)?null:obj.CreatedBy },
                new string[] { "p_CreatedDate", string.IsNullOrEmpty(obj.CreatedDate)?null:obj.CreatedDate },
                new string[] { "p_ModifiedBy", string.IsNullOrEmpty(obj.ModifiedBy)?null:obj.ModifiedBy },
                new string[] { "p_ModifiedDate", string.IsNullOrEmpty(obj.ModifiedDate)?null:obj.ModifiedDate },
                
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Objects", ref ds, param, ref errorString);

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

        public DataTable GetSupplier()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `objects`
                            WHERE `ObjectGroup` = '25'";
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

        public Objects GetObjectWithID(string id)
        {
            Objects reOb = new Objects();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `objects`
                            WHERE `ObjectId`='" + id + "' ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reOb.ObjectId = ds.Tables[0].Rows[0]["ObjectId"].ToString();
                reOb.ObjectGroup = ds.Tables[0].Rows[0]["ObjectGroup"].ToString();
                reOb.ObjectType = ds.Tables[0].Rows[0]["ObjectType"].ToString();
                reOb.FullName = ds.Tables[0].Rows[0]["FullName"].ToString();
                reOb.PID = ds.Tables[0].Rows[0]["PID"].ToString();
                reOb.PIDState = ds.Tables[0].Rows[0]["PIDDate"].ToString();
                reOb.PIDIssue = ds.Tables[0].Rows[0]["PIDIssue"].ToString();
                reOb.DoB = ds.Tables[0].Rows[0]["DoB"].ToString();
                reOb.PoB = ds.Tables[0].Rows[0]["PoB"].ToString();
                reOb.PerAdd = ds.Tables[0].Rows[0]["PerAdd"].ToString();
                reOb.TemAdd = ds.Tables[0].Rows[0]["TemAdd"].ToString();
                reOb.Gender = ds.Tables[0].Rows[0]["Gender"].ToString();
                reOb.ProvinceId = ds.Tables[0].Rows[0]["ProvinceId"].ToString();
                reOb.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                reOb.Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                reOb.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                reOb.Website = ds.Tables[0].Rows[0]["Website"].ToString();
                reOb.TaxCode = ds.Tables[0].Rows[0]["TaxCode"].ToString();
                reOb.Note = ds.Tables[0].Rows[0]["Note"].ToString();
                reOb.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                reOb.Image = ds.Tables[0].Rows[0]["Image"].ToString();
                reOb.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                reOb.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                reOb.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                reOb.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();


            }
            else
            {

                reOb = null;
            }
            return reOb;
        }

        public int SaveImageIntoWeb(Image img, string ObjectId, string Image)
        {
            //1: Thanh cong
            //0: That bai
            int res = 0;
            byte[] imgBuffer = imageToByteArray(img);
            Program.destopService.SaveImage_IntoObject(imgBuffer, ObjectId, Image, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;

            }
            return res;
        }


        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


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
