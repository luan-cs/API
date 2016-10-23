using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.IO;
using VVPosM1.Entities;

namespace VVPosM1.BusinessLayer
{
    public class CommonCodeBLL
    {
        private string errorString = "";
        private string[][] param;

        public DataTable GetCommonTypeId()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT distinct  `CommonTypeId`,`Description`
                            FROM `commontype`";
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

        public DataTable SearchCommonCode(CommonCode obj, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;

            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string[][] param = {
                new string[] { "p_CommonTypeId", string.IsNullOrEmpty(obj.CommonTypeId) ? null : obj.CommonTypeId },
                new string[] { "p_CommonId", string.IsNullOrEmpty(obj.CommonId) ? null : obj.CommonId },
                new string[] { "p_StrValue1", string.IsNullOrEmpty(obj.StrValue1) ? null : obj.StrValue1 },
                new string[] { "p_StrValue2", string.IsNullOrEmpty(obj.StrValue2) ? null : obj.StrValue2 },
                new string[] { "p_ParentId", string.IsNullOrEmpty(obj.ParentId) ? null : obj.ParentId },
                new string[] { "p_NumValue1", string.IsNullOrEmpty(obj.NumValue1) ? null : double.Parse(obj.NumValue1).ToString() },
                new string[] { "p_NumValue2", string.IsNullOrEmpty(obj.NumValue2) ? null : double.Parse(obj.NumValue2).ToString()},
                new string[] { "p_CreatedBy", null },
                new string[] { "p_CreatedDate", null },
                new string[] { "p_ModifiedBy", null },
                new string[] { "p_ModifiedDate", null },
                new string[] { "P_IsBuffet",string.IsNullOrEmpty(obj.IsBuffet) ? null : obj.IsBuffet },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
                               };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_CommonCode", ref ds, param, ref errorString);

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

        public CommonCode GetCommonCodeById(string commontypeid, string commonid)
        {
            CommonCode res = new CommonCode();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE `CommonTypeId` = '" + commontypeid + "'" + "&&" + "`CommonId` = '" + commonid+ "'";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);

            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res.CommonTypeId = ds.Tables[0].Rows[0]["CommonTypeId"].ToString();
                res.CommonId = ds.Tables[0].Rows[0]["CommonId"].ToString();
                res.ParentId = ds.Tables[0].Rows[0]["ParentId"].ToString();
                res.StrValue1 = ds.Tables[0].Rows[0]["StrValue1"].ToString();
                res.StrValue2 = ds.Tables[0].Rows[0]["StrValue2"].ToString();
                res.NumValue1 = string.Format("{0}",ds.Tables[0].Rows[0]["NumValue1"]);
                res.NumValue2 = string.Format("{0}", ds.Tables[0].Rows[0]["NumValue2"]);
                res.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                res.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                res.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                res.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();
                res.CanDelete = ds.Tables[0].Rows[0]["CanDelete"].ToString();
            }
            else
            {
                res = null;
            }

            return res;
        }

        public int Detele(string commontypeid, string commonid)
        {
            int res = 0;

            string queryStr = @"DELETE FROM `commoncode`
                                WHERE `CommonTypeId` = '" + commontypeid + "'" + "&&" + "`CommonId` = '" + commonid + "'";

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }

            return res;
        }

        public int Update(CommonCode obj)
        {// cập nhật
            //1: thành công; 0: thất bại
            int res = 0;
            string queryStr = "";

            queryStr += "UPDATE `commoncode` SET ";
            queryStr += string.IsNullOrEmpty(obj.CommonTypeId) ? "" : string.Format(" `CommonTypeId` = '{0}',", obj.CommonTypeId);
            queryStr += string.IsNullOrEmpty(obj.CommonId) ? "" : string.Format(" `CommonId` = '{0}',", obj.CommonId);
            queryStr += string.IsNullOrEmpty(obj.ParentId) ? " `ParentId` = null ," : string.Format(" `ParentId` = '{0}',", obj.ParentId);
            queryStr += " StrValue1= '" + obj.StrValue1 + "', ";
            queryStr += " StrValue2= '" + obj.StrValue2 + "', ";
            
            if (obj.NumValue1 != "")
            {
                queryStr += string.Format(" `NumValue1` = '{0}',", double.Parse(obj.NumValue1).ToString());
            }
            else
            {
                queryStr += " NumValue1= null, ";
            }
            if (obj.NumValue2 != "")
            {
                queryStr += string.Format(" `NumValue2` = '{0}',", double.Parse(obj.NumValue2).ToString());
            }
            else
            {
                queryStr += " NumValue2= null, ";
            }

            queryStr += string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += "WHERE `CommonTypeId` = '" + obj.CommonTypeId + "'" + "&&" + "`CommonId` = '" + obj.CommonId + "'";
          
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }

            return res;
        
        }

        public int Update2(CommonCode obj, string parentId) {
            int res = 0;
            string queryStr = "";
            queryStr += "UPDATE `commoncode` SET ";
            queryStr += string.IsNullOrEmpty(obj.ParentId) ? null : string.Format(" `ParentId` = '{0}',", obj.ParentId);
            queryStr += string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += "WHERE `CommonTypeId` = '" + obj.CommonTypeId + "'" + "&&" + "`parentId` = '" + parentId + "'";

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }

            return res;

        }

        public int Insert(CommonCode obj)
        {//Thêm mới
            //1: thành công; 0: thất bại
            int res = 0;
            string queryStr = "INSERT INTO `commoncode` (";
            queryStr += string.IsNullOrEmpty(obj.CommonTypeId) ? "" : "`CommonTypeId`, ";
            queryStr += string.IsNullOrEmpty(obj.CommonId) ? "" : "`CommonId`, ";
            queryStr += string.IsNullOrEmpty(obj.ParentId) ? "" : "`ParentId`, ";
            queryStr += string.IsNullOrEmpty(obj.StrValue1) ? "" : "`StrValue1`, ";
            queryStr += string.IsNullOrEmpty(obj.StrValue2) ? "" : "`StrValue2`, ";
            queryStr += string.IsNullOrEmpty(obj.NumValue1) ? "" : "`NumValue1`, ";
            queryStr += string.IsNullOrEmpty(obj.NumValue2) ? "" : "`NumValue2`, ";

            queryStr += "`CreatedBy`, ";
            queryStr += "`CreatedDate` ";

            queryStr += ") VALUES ( ";

            queryStr += string.IsNullOrEmpty(obj.CommonTypeId) ? "" : string.Format("'{0}', ", obj.CommonTypeId);
            queryStr += string.IsNullOrEmpty(obj.CommonId) ? "" : string.Format("'{0}', ", obj.CommonId);
            queryStr += string.IsNullOrEmpty(obj.ParentId) ? "" : string.Format("'{0}', ", obj.ParentId);
            queryStr += string.IsNullOrEmpty(obj.StrValue1) ? "" : string.Format("'{0}', ", obj.StrValue1);
            queryStr += string.IsNullOrEmpty(obj.StrValue2) ? "" : string.Format("'{0}', ", obj.StrValue2);
            queryStr += string.IsNullOrEmpty(obj.NumValue1) ? "" : string.Format("'{0}',", double.Parse(obj.NumValue1).ToString());
            queryStr += string.IsNullOrEmpty(obj.NumValue2) ? "" : string.Format("'{0}',", double.Parse(obj.NumValue2).ToString());

            queryStr += "'" + Program.Username + "',";
            queryStr += "NOW())";

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
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

        // hung 19-01-2015  getParent

             public DataTable GetParent(string commonTypeId, string commonId)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `commoncode`
                            WHERE 1=1 ";
            if (commonTypeId != "")
            {
                query += " AND `CommonTypeId`='" + commonTypeId + "'";
            }
           if(commonId!=null)
                query += " AND `ParentId`='" + commonId + "'";
                 else
               query += " AND `ParentId` IS NULL";
         
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

             // hung 19-01-2015  getParent

             public DataTable GetChildren(string commonTypeId, string commonId)
             {
                 DataTable res = new DataTable();
                 DataSet ds = new DataSet();
                 string query = @"SELECT *
                            FROM `commoncode`
                            WHERE 1=1 ";
                 if (commonTypeId != "")
                 {
                     query += " AND `CommonTypeId`='" + commonTypeId + "'";
                 }
                 if (commonId != null)
                     query += " AND `ParentId`='" + commonId + "'";
                 else
                     query += " AND `ParentId` IS NULL";

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

             public Boolean CheckUser(string table, string column, string commonId) 
             {
                 DataTable res = new DataTable();
                 DataSet ds = new DataSet();
                 string query = @"SELECT count(*) as total FROM `" + table + "` WHERE `" + column + "` = '" + commonId + "'";
                 Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "count", ref errorString);
                 if (!string.IsNullOrEmpty(errorString) || int.Parse(ds.Tables["count"].Rows[0]["total"].ToString()) != 0)
                 {
                     return false;
                 }
                 else
                     return true;

             }
             public CommonType GetTableColumnByCommonTypeId(string commontypeid)
             {
                 CommonType res = new CommonType();
                 DataSet ds = new DataSet();
                 string query = @"SELECT *
                            FROM `commontype`
                            WHERE `CommonTypeId` = '" + commontypeid + "'";
                 Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);

                 if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
                 {
                     res.CommonTypeId = ds.Tables[0].Rows[0]["CommonTypeId"].ToString();
                     res.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                     res.Note = ds.Tables[0].Rows[0]["Note"].ToString();
                     res.TableColumUser = ds.Tables[0].Rows[0]["TableColumUser"].ToString();
                     res.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                     res.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                     res.ModifiedBy = ds.Tables[0].Rows[0]["ModifiedBy"].ToString();
                     res.ModifiedDate = ds.Tables[0].Rows[0]["ModifiedDate"].ToString();
                     res.CanDelete = ds.Tables[0].Rows[0]["CanDelete"].ToString();
                 }
                 else
                 {
                     res = null;
                 }

                 return res;
             }
    
    }
}
