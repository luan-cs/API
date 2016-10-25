using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosM1.Entities;

namespace VVPosM1.BusinessLayer
{
    public class InputBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public DataTable SearchInputs(Input obj, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            ///p_CreateBy	VARCHAR(20),
            //p_CreatedDate	DATETIME,
            //p_ModifiedBy	VARCHAR(20),
            string[][] param ={
                new string[] { "p_InputId", string.IsNullOrEmpty(obj.InputId)?null:obj.InputId },
                new string[] { "p_Ballot", string.IsNullOrEmpty(obj.Ballot)?null:obj.Ballot },
                new string[] { "p_BallotDate", string.IsNullOrEmpty(obj.BallotDate)?null:obj.BallotDate },
                new string[] { "p_ReceiptId", string.IsNullOrEmpty(obj.ReceiptId)?null:obj.ReceiptId },
                new string[] { "p_ReceiptDate", string.IsNullOrEmpty(obj.ReceiptDate)?null:obj.ReceiptDate },
                new string[] { "p_SupplierId", string.IsNullOrEmpty(obj.SupplierId)?null:obj.SupplierId },
                new string[] { "p_Paid", string.IsNullOrEmpty(obj.Paid)?null:obj.Paid },
                new string[] { "p_InputDiscount", string.IsNullOrEmpty(obj.InputDiscount)?null:obj.InputDiscount },
                new string[] { "p_inputNote", string.IsNullOrEmpty(obj.InputNote)?null:obj.InputNote },
                new string[] { "p_inputVAT", string.IsNullOrEmpty(obj.InputVat)?null:obj.InputVat },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearchInputL", ref ds, param, ref errorString);

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

        public Input GetInputWithID(string id)
        {
            Input reEmp = new Input();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `input`
                            WHERE `InputId`='" + id + "' ";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reEmp.InputId = ds.Tables[0].Rows[0]["InputId"].ToString();
                reEmp.Ballot = ds.Tables[0].Rows[0]["Ballot"].ToString();
                reEmp.BallotDate = ds.Tables[0].Rows[0]["BallotDate"].ToString();
                reEmp.ReceiptId = ds.Tables[0].Rows[0]["ReceiptId"].ToString();
                reEmp.ReceiptDate = ds.Tables[0].Rows[0]["ReceiptDate"].ToString();
                reEmp.SupplierId = ds.Tables[0].Rows[0]["SupplierId"].ToString();
                reEmp.StoreId = ds.Tables[0].Rows[0]["StoreId"].ToString();
                reEmp.Paid = ds.Tables[0].Rows[0]["Paid"].ToString();
                reEmp.InputDiscount = ds.Tables[0].Rows[0]["InputDiscount"].ToString();
                reEmp.InputNote = ds.Tables[0].Rows[0]["InputNote"].ToString();
                reEmp.InputVat = ds.Tables[0].Rows[0]["InputVat"].ToString();
                reEmp.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                reEmp.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
            }
            else
            {

                reEmp = null;
            }
            return reEmp;
        }

        public int Delete(string id)
        {
            /// 1: xóa thành công
            /// 0: xóa ko thành công
            int res = 0;
            string queryStr = string.Format("DELETE FROM input WHERE InputId = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Update(Input obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE input SET ";

            if (!string.IsNullOrEmpty(obj.Ballot))
            {
                queryStr += string.Format(" Ballot = '{0}',", obj.Ballot);
            }
            if (!string.IsNullOrEmpty(obj.BallotDate))
            {
                queryStr += string.Format(" BallotDate = '{0}',", obj.BallotDate);
            }
            if (!string.IsNullOrEmpty(obj.ReceiptId))
            {
                queryStr += string.Format(" ReceiptId = '{0}',", obj.ReceiptId);
            }
            if (!string.IsNullOrEmpty(obj.ReceiptDate))
            {
                queryStr += string.Format(" ReceiptDate = '{0}',", obj.ReceiptDate);
            }
            if (!string.IsNullOrEmpty(obj.SupplierId))
            {
                queryStr += string.Format(" SupplierId = '{0}',", obj.SupplierId);
            }
            if (!string.IsNullOrEmpty(obj.StoreId))
            {
                queryStr += string.Format(" StoreId = '{0}',", obj.StoreId);
            }
            if (!string.IsNullOrEmpty(obj.Paid))
            {
                queryStr += string.Format(" Paid = '{0}',", obj.Paid);
            }
            if (!string.IsNullOrEmpty(obj.InputDiscount))
            {
                queryStr += string.Format(" InputDiscount = '{0}',", obj.InputDiscount);
            }
            if (!string.IsNullOrEmpty(obj.InputNote))
            {
                queryStr += string.Format(" InputNote = '{0}',", obj.InputNote);
            }
            if (!string.IsNullOrEmpty(obj.InputVat))
            {
                queryStr += string.Format(" InputVat = '{0}',", obj.InputVat);
            }
            if (!string.IsNullOrEmpty(obj.CreatedBy))
            {
                queryStr += string.Format(" CreatedBy = '{0}'", obj.CreatedBy);
            }

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public string Tao_ProductID()
        {
            string st = "08";
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
            string SQLstr = @"SELECT `InputId` AS `Code` 
	                        FROM  `input`
	                        WHERE LEFT(`InputId`,6)= '" + st + "' ORDER BY `InputId`;";
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
            st += s_stt;
            return st;
        }

        public int Insert(Input obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " input (";
            if (!string.IsNullOrEmpty(obj.InputId))
            {
                queryStr += "`InputId`,";
            }
            if (!string.IsNullOrEmpty(obj.Ballot))
            {
                queryStr += "`Ballot`,";
            }
            if (!string.IsNullOrEmpty(obj.BallotDate))
            {
                queryStr += "`BallotDate`,";
            }
            if (!string.IsNullOrEmpty(obj.ReceiptId))
            {
                queryStr += "`ReceiptId`,";
            }
            if (!string.IsNullOrEmpty(obj.ReceiptDate))
            {
                queryStr += "`ReceiptDate`,";
            }
            if (!string.IsNullOrEmpty(obj.SupplierId))
            {
                queryStr += "`SupplierId`,";
            }
            if (!string.IsNullOrEmpty(obj.StoreId))
            {
                queryStr += "`StoreId`,";
            }
            if (!string.IsNullOrEmpty(obj.Paid))
            {
                queryStr += "`Paid`,";
            }
            if (!string.IsNullOrEmpty(obj.InputDiscount))
            {
                queryStr += "`InputDiscount`,";
            }
            if (!string.IsNullOrEmpty(obj.InputNote))
            {
                queryStr += "`InputNote`,";
            }
            if (!string.IsNullOrEmpty(obj.InputVat))
            {
                queryStr += "`InputVat`,";
            }
            if (!string.IsNullOrEmpty(obj.CreatedBy))
            {
                queryStr += "`CreatedBy`";
            }
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(obj.InputId))
            {
                queryStr += string.Format("'{0}',", obj.InputId);
            }
            if (!string.IsNullOrEmpty(obj.Ballot))
            {
                queryStr += string.Format("'{0}',", obj.Ballot);
            }
            if (!string.IsNullOrEmpty(obj.BallotDate))
            {
                queryStr += string.Format("'{0}',", obj.BallotDate);
            }
            if (!string.IsNullOrEmpty(obj.ReceiptId))
            {
                queryStr += string.Format("'{0}',", obj.ReceiptId);
            }
            if (!string.IsNullOrEmpty(obj.ReceiptDate))
            {
                queryStr += string.Format("'{0}',", obj.ReceiptDate);
            }
            if (!string.IsNullOrEmpty(obj.SupplierId))
            {
                queryStr += string.Format("'{0}',", obj.SupplierId);
            }
            if (!string.IsNullOrEmpty(obj.StoreId))
            {
                queryStr += string.Format("'{0}',", obj.StoreId);
            }
            if (!string.IsNullOrEmpty(obj.Paid))
            {
                queryStr += string.Format("'{0}',", obj.Paid);
            }
            if (!string.IsNullOrEmpty(obj.InputDiscount))
            {
                queryStr += string.Format("'{0}',", obj.InputDiscount);
            }
            if (!string.IsNullOrEmpty(obj.InputNote))
            {
                queryStr += string.Format("'{0}',", obj.InputNote);
            }
            if (!string.IsNullOrEmpty(obj.InputVat))
            {
                queryStr += string.Format("'{0}',", obj.InputVat);
            }
            if (!string.IsNullOrEmpty(obj.CreatedBy))
            {
                queryStr += string.Format("'{0}'", obj.CreatedBy);
            }
            queryStr += ")";
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;

        }

        public DataTable GetDetails(string inputId)
        {
            string SQLstr = @"SELECT m.*, i.`IngredientName` FROM `inputdetail`AS m LEFT JOIN `ingredient` AS i ON m.`IngredientId` = i.`IngredientId` WHERE m.`InputId` = '" + inputId + "'";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Program.destopService.DataQuery(Program.Username, Program.Password, SQLstr, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
    }
}
