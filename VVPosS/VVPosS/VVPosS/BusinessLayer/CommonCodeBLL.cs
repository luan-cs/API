using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using VVPosS.Entities;
using System.Configuration;

namespace VVPosS.BusinessLayer
{
    public class CommonCodeBLL
    {
        #region Biến

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

        private DataSet ds = new DataSet();

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        #endregion

        public DataTable GetMenus(string commonType, int page, out int TotalRecord, string level, bool Node)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxMenu"]);
            if (Node) RecordPerPage = RecordPerPage - 1;
            int limit = (page - 1) * RecordPerPage;
            TotalRecord = 0;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            string[][] param ={
                new string[] { "p_Level", string.IsNullOrEmpty(level)?null:level },
                new string[] { "p_CommonType", string.IsNullOrEmpty(commonType)?null:commonType },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGetMenu", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                dt = ds.Tables[0];
                TotalRecord = int.Parse(ds.Tables[1].Rows[0][0].ToString());
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public DataTable LstChildNode(string ParentId, string CommonType)
        {
            string[][] param = {
                new string[] { "p_CommonTypeId", string.IsNullOrEmpty(CommonType)?null: CommonType },
                new string[] { "p_ParentId", string.IsNullOrEmpty(ParentId)?null: ParentId }
            };
            //spGet_ListChildMenu_By_ParentId
            ds = new DataSet();
            DataTable dt = new DataTable();
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGet_ListChildMenu_By_ParentId", ref ds, param, ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
                //Xu ly o Giao dien
                //foreach (DataRow r in ds.Tables[0].Rows)
                //{
                //    string sNodeParent = r["CommonId"].ToString();
                //    if (ParentId != sNodeParent)
                //        sLst += sNodeParent + ",";
                //    this.LstChildNode(sNodeParent);
                //}
            }
            else dt = null;
            return dt;
        }

        public string GetListBuffet() {
            string sBuffet = "";

            string query = "SELECT CommonId FROM commoncode WHERE commontypeid = 'ProductType' AND isbuffet = '1'";
            DataSet dataset = new DataSet();

            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Products", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in dataset.Tables[0].Rows) {
                    sBuffet += "'" + r[0].ToString() + "',";
                }
            }
            return sBuffet;
        }


        #region Get CommonCode By CommonTypeID
        public DataTable GetCommonCodeByCommonTypeID(string CommonTypeId)
        {
            string[][] param ={
                new string[] {"_CommonTypeId", CommonTypeId},
            };
            ds = new DataSet();
            DataTable res = new DataTable();
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_CommonCode_By_CommonTypeId", ref ds, param, ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                res = ds.Tables[0];
                /////////////////////

            }
            else
            {
                res = null;
            }



            return res;
        }
        #endregion
    }
}
