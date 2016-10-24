using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosS.Entities;
using System.Data;
using System.Configuration;

namespace VVPosS.BusinessLayer
{
    public class DeskBLL:IObjectBLL<Desk>
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

        private DataSet ds = new DataSet();

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        /// <summary>
        /// Get list products
        /// </summary>
        /// <returns></returns>
        public DataTable GetLists(string status)
        {
            string query = @"SELECT *    
                            FROM desk 
                            WHERE 1=1";
            if (status != "") query += " AND Status = '" + status + "'";
            
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Desk", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["Desk"];
            }
            else
                return null;
        }


        public DataTable GetLists(Desk obj, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable();
            ds = new DataSet();
            string[][] param ={
                new string[] {"p_DeskNo",obj.DeskNo},
                new string[] {"p_Description",obj.Description},
                new string[] {"p_Status",obj.Status},
                new string[] {"p_DeskLocation",obj.DeskLocation},
                new string[] {"p_NoOfSeat",obj.NoOfSeat.ToString()},
                new string[] {"p_NoStart", limit.ToString()},
                new string[] {"p_NoEnd", RecordPerPage.ToString()},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Desk", ref ds, param, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = ds.Tables[0];
                /////////////////////
                DataSet dataset1 = new DataSet();
                string[][] param1 ={
                    new string[] {"p_DeskNo",obj.DeskNo},
                    new string[] {"p_Description",obj.Description},
                    new string[] {"p_Status",obj.Status},
                    new string[] {"p_DeskLocation",obj.DeskLocation},
                    new string[] {"p_NoOfSeat",obj.NoOfSeat.ToString()},
                };
                Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Desk_Count", ref dataset1, param1, ref errorString);
                TotalRecord = dataset1.Tables[0].Rows.Count;
            }
            else
            {
                res = null;
            }



            return res;

        }

        public void Add(Desk obj)
        {
            string[][] param ={
                new string[] {"desk_no",obj.DeskNo},
                new string[] {"description_s",obj.Description},
                new string[] {"status_s",obj.Status},
                new string[] {"desk_location",obj.DeskLocation},
                new string[] {"no_of_seat", int.Parse(obj.NoOfSeat).ToString()},
            };
            Program.destopService.DataStoreProcExecute(Program.Username, Program.Password, "spInsert_Desk", ref errorString, param, ref res);
        }


        public void Update(Desk obj)
        {
            string[][] param ={
                new string[] {"_DeskId", int.Parse(obj.DeskId).ToString()},
                new string[] {"_DeskNo",obj.DeskNo},
                new string[] {"_Descripton",obj.Description},
                new string[] {"_DeskLocation",obj.DeskLocation},
                new string[] {"_Status",obj.Status},
                new string[] {"_NoOfSeat",int.Parse(obj.NoOfSeat).ToString()},
                new string[] {"_sCondition", int.Parse(obj.sCondition).ToString()},
            };
            Program.destopService.DataStoreProcExecute(Program.Username, Program.Password, "spUpdate_Desks", ref errorString, param, ref res);
        }

        public void Delete(Desk obj)
        {
            string[][] param ={
                new string[] {"p_DeskId",obj.DeskId},
            };
            Program.destopService.DataStoreProcExecute(Program.Username, Program.Password, "spDelete_Desk", ref errorString, param, ref res);
        }

        public DataTable GetStatus(CommonCode obj) {
            string[][] param ={
                new string[] {"_CommonTypeId", obj.CommonTypeId},
            };
            ds = new DataSet();
            DataTable res = new DataTable();
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_CommonCode_By_CommonTypeId", ref ds, param, ref errorString);
            if (string.IsNullOrEmpty(errorString))
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

        public DataTable GetStatusName(CommonCode obj)
        {
            string[][] param ={
                new string[] {"_CommonTypeId", obj.CommonTypeId},
                new string[] {"_CommonId", obj.CommonId},
            };
            ds = new DataSet();
            DataTable res = new DataTable();
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Desk_Status_StrValues", ref ds, param, ref errorString);
            if (string.IsNullOrEmpty(errorString))
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

        public DataTable GetDeskByIsUsing(string isusing)
        {
            string[][] param ={
                new string[] {"p_IsUsing", isusing},
            };
            ds = new DataSet();
            DataTable res = new DataTable();
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGet_Desk_By_IsUsing", ref ds, param, ref errorString);
            if (string.IsNullOrEmpty(errorString))
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

        public DataTable CheckExitByNameAndNotINId(string _sDeskNo, int _iDeskId)
        {
            string query = @"SELECT *    
                            FROM desk 
                            WHERE DeskNo='" + _sDeskNo + "' AND DeskId NOT IN("+_iDeskId+")";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Desk", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["Desk"];
            }
            else
                return null;
        }

        public List<Desk> GetListByDeskLocation(string DeskLocation, string IsUsing)
        {
            List<Desk> lst = new List<Desk>();
            string[][] param ={ 
                new string[] {"p_DeskLocation", DeskLocation},
                new string[] {"p_IsUsing", IsUsing}
            };
            ds = new DataSet();
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spGetDesk_By_DeskLocation", ref ds, param, ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows) {
                    Desk dk = new Desk();
                    dk.DeskId = r["DeskId"].ToString();
                    dk.DeskNo = r["DeskNo"].ToString();
                    dk.Description = r["Description"].ToString();
                    dk.DeskLocation = r["DeskLocation"].ToString();
                    dk.Status = r["Status"].ToString();
                    dk.IsUsing = r["IsUsing"].ToString();
                    lst.Add(dk);
                }

            }
            else
            {
                lst = null;
            }
            return lst;
        }

        public string GetDeskNO(string DeskId)
        {
            string res = "";
            DataTable dt = new DataTable();
            string query = @"SELECT *
                            FROM `desk`
                            WHERE  `DeskId` ='" + DeskId + "'";
            DataSet dataset = new DataSet();
            string errorString = "";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Desk", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
            {
                dt = dataset.Tables["Desk"];
                res = dt.Rows[0]["DeskNo"].ToString();
            }
            else
            {
                res = null;
            }
            return res;
        }
    }
}
