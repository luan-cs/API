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
    public class SupplierBLL
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public DataTable GetSuppliers()
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `supplier` ";
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

        public DataTable SearchSupplier(Supplier sup, int page, out int TotalRecord)
        {
            int RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int limit = (page - 1) * RecordPerPage;
            //int offset = limit + RecordPerPage;
            TotalRecord = 0;
            DataTable res = new DataTable();
            DataSet ds = new DataSet();

            ///p_CreateBy	VARCHAR(20),
            //p_CreatedDate	DATETIME,
            //p_ModifiedBy	VARCHAR(20), p_SupplierId 		VARCHAR(20)  ,
                string[][] param ={
                new string[] { "p_SupplierId", string.IsNullOrEmpty(sup.SupplierId)?null:sup.SupplierId },
                new string[] { "p_SupplierName", string.IsNullOrEmpty(sup.SupplierName)?null:sup.SupplierName },
                new string[] { "p_SupplierAddress", string.IsNullOrEmpty(sup.SupplierAddress)?null: sup.SupplierAddress },
                new string[] { "p_SupplierPhone", string.IsNullOrEmpty(sup.SupplierPhone )?null: sup.SupplierPhone },
                new string[] { "p_SupplierEmail", string.IsNullOrEmpty(sup.SupplierEmail )?null: sup.SupplierEmail },
                new string[] { "p_SupplierWebsite", string.IsNullOrEmpty(sup.SupplierWebsite)?null: sup.SupplierWebsite },
                new string[] { "p_NoStart", limit.ToString() },
                new string[] { "p_NoEnd", RecordPerPage.ToString()}
            };

            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSearch_Suppliers", ref ds, param, ref errorString);

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

        public Supplier GetSupplierWithID(string id)
        {
            Supplier reEmp = new Supplier();
            DataSet ds = new DataSet();
            string query = @"SELECT *
                            FROM `supplier`
                            WHERE `SupplierId`='" + id + "' ";
            //Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref ds, "X", ref errorString);
            if (string.IsNullOrEmpty(errorString) && ds.Tables[0].Rows.Count > 0)
            {
                reEmp.SupplierId = ds.Tables[0].Rows[0]["SupplierId"].ToString();
                reEmp.SupplierName = ds.Tables[0].Rows[0]["SupplierName"].ToString();
                reEmp.SupplierAddress = ds.Tables[0].Rows[0]["SupplierAddress"].ToString();
                reEmp.SupplierPhone = ds.Tables[0].Rows[0]["SupplierPhone"].ToString();
                reEmp.SupplierEmail = ds.Tables[0].Rows[0]["SupplierEmail"].ToString();
                reEmp.SupplierWebsite = ds.Tables[0].Rows[0]["SupplierWebsite"].ToString();

            }
            else
            {

                reEmp = null;
            }

            return reEmp;
        }

        public int Update(Supplier employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công
            int res = 0;
            string queryStr = "UPDATE supplier SET ";

            if (!string.IsNullOrEmpty(employ.SupplierName))
            {
                queryStr += string.Format(" SupplierName = '{0}',", employ.SupplierName);
            }
            //if (!string.IsNullOrEmpty(employ.Unit))
            //{
            queryStr += string.Format(" SupplierAddress = '{0}',", employ.SupplierAddress);
            //}
            //if (!string.IsNullOrEmpty(employ.Notes))
            //{
            queryStr += string.Format(" SupplierPhone = '{0}',", employ.SupplierPhone);
            //}
            queryStr += string.Format(" SupplierEmail = '{0}',", employ.SupplierEmail);

            queryStr += string.Format(" SupplierWebsite = '{0}'", employ.SupplierWebsite);

            queryStr += string.Format(" WHERE SupplierId = '{0}'", employ.SupplierId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }

            return res;
        }
        public string CreateSupplierId()
        {
            string supplierId = string.Empty;
            DataTable res = new DataTable();
            DataSet dataset = new DataSet();
            string sqlStr = "SELECT `SupplierId` FROM `supplier` WHERE SUBSTRING(`SupplierId`, 3, 8) = CURDATE() + 0 ORDER BY `SupplierId` DESC LIMIT 0,1; ";

            Program.destopService.DataQuery(Program.Username, Program.Password, sqlStr, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString) && dataset.Tables[0].Rows.Count > 0)
            {
                res = dataset.Tables[0];
                supplierId = (Int64.Parse(res.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                supplierId = "98" + DateTime.Today.ToString("yyyyMMdd") + "00001"; 
            }

            return supplierId;
        }

        public int Insert(Supplier employ)
        {
            /// 1: update thành công
            /// 0: Update ko thành công

            int res = 0;
            string queryStr = "INSERT INTO";
            queryStr += " supplier (";
            if (!string.IsNullOrEmpty(employ.SupplierId))
            {
                queryStr += "`SupplierId`,";
            }
            if (!string.IsNullOrEmpty(employ.SupplierName))
            {
                queryStr += "`SupplierName`,";
            }
            if (!string.IsNullOrEmpty(employ.SupplierAddress))
            {
                queryStr += "`SupplierAddress`,";
            }
            if (!string.IsNullOrEmpty(employ.SupplierPhone))
            {
                queryStr += "`SupplierPhone`,";
            }
            if (!string.IsNullOrEmpty(employ.SupplierEmail))
            {
                queryStr += "`SupplierEmail`,";
            }
            if (!string.IsNullOrEmpty(employ.SupplierWebsite))
            {
                queryStr += "`SupplierWebsite`";
            }

            queryStr += ") VALUES (";

            if (!string.IsNullOrEmpty(employ.SupplierId))
            {
                queryStr += string.Format("'{0}',", employ.SupplierId);
            }
            if (!string.IsNullOrEmpty(employ.SupplierName))
            {
                queryStr += string.Format("'{0}',", employ.SupplierName);
            }
            if (!string.IsNullOrEmpty(employ.SupplierAddress))
            {
                queryStr += string.Format("'{0}',", employ.SupplierAddress);
            }
            if (!string.IsNullOrEmpty(employ.SupplierPhone))
            {
                queryStr += string.Format("'{0}',", employ.SupplierPhone);
            }
            if (!string.IsNullOrEmpty(employ.SupplierEmail))
            {
                queryStr += string.Format("'{0}',", employ.SupplierEmail);
            }
            if (!string.IsNullOrEmpty(employ.SupplierWebsite))
            {
                queryStr += string.Format("'{0}'", employ.SupplierWebsite);
            }

            queryStr += ")";
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
            string queryStr = string.Format("DELETE FROM supplier WHERE Supplierid = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                res = 1;
            }
            return res;
        }
    }
}
