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
                new string[] { "p_ProductId", string.IsNullOrEmpty(measure.ProductId)?null:measure.ProductId },
                new string[] { "p_MeasureId", string.IsNullOrEmpty(measure.MeasureId)?null:measure.MeasureId },
                new string[] { "p_Note", string.IsNullOrEmpty(measure.MeasureNote)?null:measure.MeasureNote },
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
    }
}
