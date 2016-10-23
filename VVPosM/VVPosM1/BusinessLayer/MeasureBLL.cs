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
    public class MeasureBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public DataTable SearchProducts(Measure measure, int page, out int TotalRecord)
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
                new string[] { "p_ProductId", string.IsNullOrEmpty(measure.ProductId)?null:measure.ProductId },
                new string[] { "p_MeasureId", string.IsNullOrEmpty(measure.MeasureId)?null:measure.MeasureId },
                new string[] { "p_Note", string.IsNullOrEmpty(measure.MeasureNote)?null:measure.MeasureNote },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearchMeasureL", ref ds, param, ref errorString);

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

        public DataTable getProducts()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `product` ";
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

        public Measure GetMeasureWithID(string id)
        {
            Measure reEmp = new Measure();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `measure`
                            WHERE `MeasureId`='" + id + "' ";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reEmp.ProductId = ds.Tables[0].Rows[0]["ProductId"].ToString();
                reEmp.MeasureId = ds.Tables[0].Rows[0]["MeasureId"].ToString();
                reEmp.MeasureNote = ds.Tables[0].Rows[0]["MeasureNote"].ToString();
                reEmp.CreatedDate = ds.Tables[0].Rows[0]["CreatedDate"].ToString();
                reEmp.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
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
            string queryStr = string.Format("DELETE FROM measure WHERE MeasureId = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public int Update(Measure obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE measure SET ";

            if (!string.IsNullOrEmpty(obj.ProductId))
            {
                queryStr += string.Format(" ProductId = '{0}',", obj.ProductId);
            }
            queryStr += string.Format(" MeasureNote = '{0}',", obj.MeasureNote);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }

        public string Tao_ProductID()
        {
            string st = "07";
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
            string SQLstr = @"SELECT `MeasureId` AS `Code` 
	                        FROM  `measure`
	                        WHERE LEFT(`MeasureId`,6)= '" + st + "' ORDER BY `MeasureId`;";
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

        public int Insert(Measure obj)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " measure (";
            if (!string.IsNullOrEmpty(obj.MeasureId))
            {
                queryStr += "`MeasureId`,";
            }
            if (!string.IsNullOrEmpty(obj.ProductId))
            {
                queryStr += "`ProductId`,";
            }
            if (!string.IsNullOrEmpty(obj.MeasureNote))
            {
                queryStr += "`MeasureNote`,";
            }
            if (!string.IsNullOrEmpty(Program.Username))
            {
                queryStr += "`CreatedBy`";
            }
            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(obj.MeasureId))
            {
                queryStr += string.Format("'{0}',", obj.MeasureId);
            }
            if (!string.IsNullOrEmpty(obj.ProductId))
            {
                queryStr += string.Format("'{0}',", obj.ProductId);
            }
            if (!string.IsNullOrEmpty(obj.MeasureNote))
            {
                queryStr += string.Format("'{0}',", obj.MeasureNote);
            }
            if (!string.IsNullOrEmpty(Program.Username))
            {
                queryStr += string.Format("'{0}'", Program.Username);
            }
            queryStr += ")";
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;

        }

        public DataTable GetDetails(string measureId)
        {
            string SQLstr = @"SELECT m.*, i.`IngredientName`, i.`IngredientUnit` FROM `measuredetail` AS m LEFT JOIN `ingredient` AS i ON m.`IngredientId` = i.`IngredientId` WHERE m.`MeasureId` = '" + measureId +"'" ;
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
