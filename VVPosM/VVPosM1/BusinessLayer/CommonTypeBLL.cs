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
    public class CommonTypeBLL
    {
        private string errorString = "";
        private string[][] param;

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public DataTable SearchCommonType(CommonType obj, int page, out int TotalRecord)
        {
            //
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;

            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            string[][] param = {
                new string[] { "p_CommonTypeId", string.IsNullOrEmpty(obj.CommonTypeId) ? null : obj.CommonTypeId },
                new string[] { "p_Description", string.IsNullOrEmpty(obj.Description) ? null : obj.Description },
                new string[] { "p_note", string.IsNullOrEmpty(obj.Note) ? null : obj.Note },
                new string[] { "p_createdby", string.IsNullOrEmpty(obj.CreatedBy) ? null : obj.CreatedBy },
                new string[] { "p_createddate", string.IsNullOrEmpty(obj.CreatedDate) ? null : obj.CreatedDate },
                new string[] { "p_modifiedby", string.IsNullOrEmpty(obj.ModifiedBy) ? null : obj.ModifiedBy },
                new string[] { "p_modifieddate", string.IsNullOrEmpty(obj.ModifiedDate) ? null : obj.ModifiedDate },
                               
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
                               };

            //Call StoreProduct spSearch_CommonType
            //Ket qua tra ve: DataSet ds; String errorString
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_CommonType", ref ds, param, ref errorString);

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
        // lấy dữ liệu theo ID
        public CommonType GetCommonTypeById(string commontypeid)
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
        
        public int Update(CommonType obj)
        {// cập nhật
            //1: thành công; 0: thất bại
            int res = 0;
            string queryStr = "";

            queryStr += "UPDATE `commontype` SET ";
            queryStr += string.IsNullOrEmpty(obj.Description) ? "" : string.Format(" Description = '{0}',", obj.Description);
            queryStr += string.Format(" Note = '{0}',", obj.Note);
            queryStr += string.IsNullOrEmpty(obj.ModifiedBy) ? "" : string.Format(" ModifiedBy = '{0}',", Program.Username);
            queryStr += " ModifiedDate = NOW()";
            queryStr += string.Format(" WHERE `CommonTypeId` = '{0}'", obj.CommonTypeId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }

            return res;
        }

        public int Detele(string commontypeid)
        {
            //1: thành công; 0:thất bại
            int res = 0;

            string queryStr = string.Format("DELETE FROM `commontype` WHERE  `CommonTypeId` = '{0}'", commontypeid);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Insert(CommonType obj)
        {//Thêm mới
            //1: thành công; 0: thất bại
            int res = 0;
            string queryStr = "INSERT INTO `commontype` (";
            queryStr += string.IsNullOrEmpty(obj.CommonTypeId) ? "" : "`CommonTypeId`, ";
            queryStr += string.IsNullOrEmpty(obj.Description) ? "" : "`Description`, ";
            queryStr += string.IsNullOrEmpty(obj.Note) ? "" : "`Note`, ";
            queryStr += "`CreatedBy`, ";
            queryStr += "`CreatedDate`, ";
            queryStr += "`CanDelete`";
            queryStr += ") VALUES ( ";
            queryStr += string.IsNullOrEmpty(obj.CommonTypeId) ? "" : string.Format("'{0}', ", obj.CommonTypeId);
            queryStr += string.IsNullOrEmpty(obj.Description) ? "" : string.Format("'{0}', ", obj.Description);
            queryStr += string.IsNullOrEmpty(obj.Note) ? "" : string.Format("'{0}', ", obj.Note);
            queryStr += "'admin', ";
            queryStr += "NOW(), b'1')";

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
    }
}
