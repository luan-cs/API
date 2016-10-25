using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VVPosM1.Entities;
using System.Data;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class PromotionBLL : IObjectBLL<Promotion>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(Promotion obj)
        {
            string queryStr = "";
            if (string.IsNullOrEmpty(obj.BeginTime) && string.IsNullOrEmpty(obj.EndTime))
            {
                queryStr = string.Format("Insert into Promotions(PromotionName, BeginDateTime, EndDateTime, PercenDiscount, PromotionTypeId, CreatedDate, UpdatedDate, Creator, PromotionName2, PromotionName3, Product, Type) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}', '{11}')", obj.PromotionName, obj.BeginDateTime.ToString("yyyy-MM-dd HH:mm"), obj.EndDateTime.ToString("yyyy-MM-dd HH:mm"), obj.PercentDiscount, obj.PromotionType.PromotionTypeId, obj.CreateDate.ToString("yyyy-MM-dd HH:mm"), obj.UpdateDate.ToString("yyyy-MM-dd HH:mm"), obj.Creator.EmployeeId, obj.PromotionName2, obj.PromotionName3, obj.Product, obj.Type);
            }
            else
            {
                queryStr = string.Format("Insert into Promotions(PromotionName, BeginDateTime, EndDateTime, BeginTime, EndTime, PercenDiscount, PromotionTypeId, CreatedDate, UpdatedDate, Creator, PromotionName2, PromotionName3, Product, Type) values('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}','{11}', '{12}', '{13}')", obj.PromotionName, obj.BeginDateTime.ToString("yyyy-MM-dd HH:mm"), obj.EndDateTime.ToString("yyyy-MM-dd HH:mm"), obj.BeginTime, obj.EndTime, obj.PercentDiscount, obj.PromotionType.PromotionTypeId, obj.CreateDate.ToString("yyyy-MM-dd HH:mm"), obj.UpdateDate.ToString("yyyy-MM-dd HH:mm"), obj.Creator.EmployeeId, obj.PromotionName2, obj.PromotionName3, obj.Product, obj.Type);
            }
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);

            return (string.IsNullOrEmpty(errorString)) ? true : false;

        }

        public bool Edit(Promotion obj)
        {
            string queryStr = "";
            if (string.IsNullOrEmpty(obj.BeginTime) && string.IsNullOrEmpty(obj.EndTime))
            {
                queryStr = string.Format("Update Promotions set PromotionName='{0}', BeginDateTime='{1}', EndDateTime='{2}', BeginTime=null, EndTime=null, PercenDiscount='{3}', PromotionTypeId='{4}', UpdatedDate='{5}', PromotionName2='{6}', PromotionName3= '{7}', Product ='{8}', Type ='{9}' Where PromotionId='{10}' ", obj.PromotionName, obj.BeginDateTime.ToString("yyyy-MM-dd HH:mm"), obj.EndDateTime.ToString("yyyy-MM-dd HH:mm"), obj.PercentDiscount, obj.PromotionType.PromotionTypeId, obj.UpdateDate.ToString("yyyy-MM-dd HH:mm"), obj.PromotionName2, obj.PromotionName3, obj.Product, obj.Type , obj.PromotionId);
            }
            else
            {
                queryStr = string.Format("Update Promotions set PromotionName='{0}', BeginDateTime='{1}', EndDateTime='{2}', BeginTime='{3}', EndTime='{4}', PercenDiscount='{5}', PromotionTypeId='{6}', UpdatedDate='{7}', PromotionName2='{8}', PromotionName3= '{9}', Product ='{10}', Type ='{11}' Where PromotionId='{12}' ", obj.PromotionName, obj.BeginDateTime.ToString("yyyy-MM-dd HH:mm"), obj.EndDateTime.ToString("yyyy-MM-dd HH:mm"), obj.BeginTime, obj.EndTime, obj.PercentDiscount, obj.PromotionType.PromotionTypeId, obj.UpdateDate.ToString("yyyy-MM-dd HH:mm"), obj.PromotionName2, obj.PromotionName3, obj.Product, obj.Type, obj.PromotionId);
            }
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);

            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public bool Delete(string id)
        {
            string queryStr = string.Format("Delete From Promotions Where PromotionId ='{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);

            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        /// <summary>
        /// Get list promotions
        /// </summary>
        /// <returns></returns>
        public DataTable GetLists()
        {
            string query = "SELECT A.PromotionId, A.PromotionName, A.PromotionName2, A.PromotionName3, date_format(A.BeginDateTime, '%Y-%m-%d') As BeginDateTime, date_format(A.EndDateTime, '%Y-%m-%d') As EndDateTime, A.BeginTime, A.EndTime, A.PercenDiscount, A.Product, A.PromotionTypeId, B.PromotionTypeName, B.PromotionTypeName2, B.PromotionTypeName3, date_format(A.CreatedDate, '%Y-%m-%d %h:%i %p') As CreatedDate, date_format(A.UpdatedDate, '%Y-%m-%d %h:%i %p') As UpdatedDate, A.Creator, C.EmployeeName FROM promotions as A Left join promotion_types B on A.PromotionTypeId = B.PromotionTypeId Left join Employees as C on A.Creator = C.EmployeeId Order by A.PromotionId Desc";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Promotion", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["Promotion"];
            else
                return null;
        }


        /// <summary>
        /// Get promotion by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Promotion GetById(string id)
        {
            Promotion promotion = new Promotion();
            string query = String.Format("SELECT * FROM promotions WHERE promotions.PromotionId = '{0}'", id);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Promotion", ref errorString);

            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }

            if (dataset.Tables["Promotion"].Rows.Count > 0)
            {
                var row = dataset.Tables["Promotion"].Rows[0];
                promotion = GetPromotionFromDataRow(row);
            }
            else
            {
                promotion = null;
            }
            return promotion;
        }

        private Promotion GetPromotionFromDataRow(DataRow dr)
        {
            Promotion promotion = new Promotion();
            if (dr["PromotionId"] != null)
            {
                promotion.PromotionId = dr["PromotionId"].ToString();
            }
            if (dr["PromotionName"] != null)
            {
                promotion.PromotionName = dr["PromotionName"].ToString();
            }
            if (dr["PromotionName2"] != null)
            {
                promotion.PromotionName2 = dr["PromotionName2"].ToString();
            }
            if (dr["PromotionName3"] != null)
            {
                promotion.PromotionName3 = dr["PromotionName3"].ToString();
            }
            if (dr["BeginDateTime"] != null)
            {
                promotion.BeginDateTime = DateTime.Parse(dr["BeginDateTime"].ToString());
            }
            if (dr["EndDateTime"] != null)
            {
                promotion.EndDateTime = DateTime.Parse(dr["EndDateTime"].ToString());
            }
            if (dr["BeginTime"] != null)
            {
                promotion.BeginTime = dr["BeginTime"].ToString();
            }
            if (dr["EndTime"] != null)
            {
                promotion.EndTime = dr["EndTime"].ToString();
            }
            if (dr["PercenDiscount"] != null)
            {
                promotion.PercentDiscount = dr["PercenDiscount"].ToString();
            }
            if (dr["Product"] != null)
            {
                promotion.Product = dr["Product"].ToString();
            }
            if (dr["PromotionTypeId"] != null)
            {
                promotion.PromotionType.PromotionTypeId = dr["PromotionTypeId"].ToString();
            }
            if (dr["CreatedDate"] != null)
            {
                promotion.CreateDate = DateTime.Parse(dr["CreatedDate"].ToString());
            }
            if (dr["UpdatedDate"] != null)
            {
                promotion.UpdateDate = DateTime.Parse(dr["UpdatedDate"].ToString());
            }
            if (dr["Creator"] != null)
            {
                promotion.Creator.EmployeeId = dr["Creator"].ToString();
            }
            if (dr["Type"] != null)
            {
                promotion.Type = dr["Type"].ToString();
            }
            return promotion;
        }

        ///
        /// Search Promotion
        /// 
        public DataTable SearchLists(string pPromotionName, string pPromotionTypeId, string pCreator, string pBeginDateTime, string pEndDateTime, string pFromPercenDiscount, string pToPercenDiscount)
        {
            string query = "SELECT A.PromotionId, A.PromotionName, A.PromotionName2, A.PromotionName3, date_format(A.BeginDateTime, '%Y-%m-%d') As BeginDateTime, date_format(A.EndDateTime, '%Y-%m-%d') As EndDateTime, A.BeginTime, A.EndTime, A.PercenDiscount, A.Product, A.PromotionTypeId, B.PromotionTypeName, B.PromotionTypeName2, B.PromotionTypeName3, date_format(A.CreatedDate, '%Y-%m-%d %h:%i %p') As CreatedDate, date_format(A.UpdatedDate, '%Y-%m-%d %h:%i %p') As UpdatedDate, A.Creator, C.EmployeeName FROM promotions as A Left join promotion_types B on A.PromotionTypeId = B.PromotionTypeId Left join Employees as C on A.Creator = C.EmployeeId ";

            if (!string.IsNullOrEmpty(pPromotionTypeId) && string.IsNullOrEmpty(pPromotionName) && string.IsNullOrEmpty(pCreator) && string.IsNullOrEmpty(pFromPercenDiscount) && string.IsNullOrEmpty(pToPercenDiscount))
            {
                query = query + string.Format(" WHERE A.PromotionTypeId='{0}' Or (date_format(A.BeginDateTime, '%Y-%m-%d') >='{1}' And date_format(A.BeginDateTime, '%Y-%m-%d') <='{2}')", pPromotionTypeId, pBeginDateTime, pEndDateTime);
            }
            else if (string.IsNullOrEmpty(pPromotionTypeId) && !string.IsNullOrEmpty(pPromotionName) && string.IsNullOrEmpty(pCreator) && string.IsNullOrEmpty(pFromPercenDiscount) && string.IsNullOrEmpty(pToPercenDiscount))
            {
                query = query + string.Format(" WHERE A.PromotionName like '%{0}%' Or A.PromotionName2 like '%{1}%' Or A.PromotionName3 like '%{2}%' Or (date_format(A.BeginDateTime, '%Y-%m-%d') >='{3}' And date_format(A.BeginDateTime, '%Y-%m-%d') <='{4}')", pPromotionName, pPromotionName, pPromotionName, pBeginDateTime, pEndDateTime);
            }
            else if (string.IsNullOrEmpty(pPromotionTypeId) && string.IsNullOrEmpty(pPromotionName) && !string.IsNullOrEmpty(pCreator) && string.IsNullOrEmpty(pFromPercenDiscount) && string.IsNullOrEmpty(pToPercenDiscount))
            {
                query = query + string.Format(" WHERE A.Creator='{0}' Or (date_format(A.BeginDateTime, '%Y-%m-%d') >='{1}' And date_format(A.BeginDateTime, '%Y-%m-%d')<='{2}')", pCreator, pBeginDateTime, pEndDateTime);
            }
            else if (string.IsNullOrEmpty(pPromotionTypeId) && string.IsNullOrEmpty(pPromotionName) && string.IsNullOrEmpty(pCreator) && !string.IsNullOrEmpty(pFromPercenDiscount) && !string.IsNullOrEmpty(pToPercenDiscount))
            {
                query = query + string.Format(" WHERE A.PercenDiscount Between '{0}' and '{1}'  Or (date_format(A.BeginDateTime, '%Y-%m-%d') >='{2}' And date_format(A.BeginDateTime, '%Y-%m-%d')<='{3}') ", pFromPercenDiscount, pToPercenDiscount, pBeginDateTime, pEndDateTime);
            }
            else if (!string.IsNullOrEmpty(pBeginDateTime) && !string.IsNullOrEmpty(pEndDateTime) && string.IsNullOrEmpty(pPromotionTypeId) && string.IsNullOrEmpty(pPromotionName) && string.IsNullOrEmpty(pCreator) && string.IsNullOrEmpty(pFromPercenDiscount) && string.IsNullOrEmpty(pToPercenDiscount))
            {
                query = query + string.Format(" WHERE date_format(A.BeginDateTime, '%Y-%m-%d')>='{0}' And date_format(A.BeginDateTime, '%Y-%m-%d')<='{1}'", pBeginDateTime, pEndDateTime);
            }
            else
            {
                query = query + string.Format(" WHERE A.PromotionName like '%{0}%' Or A.PromotionName2 like '%{1}%' Or A.PromotionName3 like '%{2}%' Or A.PromotionTypeId='{3}' Or A.Creator='{4}' Or (date_format(A.BeginDateTime, '%Y-%m-%d')>='{5}'  And date_format(A.BeginDateTime, '%Y-%m-%d')<='{6}') Or A.PercenDiscount Between '{7}' and '{8}'", pPromotionName, pPromotionName, pPromotionName, pPromotionTypeId, pCreator, pBeginDateTime, pEndDateTime, pFromPercenDiscount, pToPercenDiscount);
            }
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Promotion", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["Promotion"];
            else
                return null;
        }

        ///
        /// Read Name user login
        ///
        public DataTable GetId_NameByUserName(string pUserName)
        {
            string query = string.Format("SELECT * FROM promotions WHERE UserName='{0}'", pUserName);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Promotion", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["Promotion"];
            else
                return null;
        }

        /// <summary>
        /// Get Current promotion for receipt
        /// </summary>
        /// <param name="dateReceipt"></param>
        /// <returns></returns>
        public DataTable GetCurrentPromotionForReceipt(DateTime dateReceipt)
        {
            string query = String.Format("SELECT * FROM promotions WHERE Type = 1 AND DATE_FORMAT(BeginDateTime,'%Y-%m-%d') <= '{0}' AND DATE_FORMAT(EndDateTime,'%Y-%m-%d') >= '{0}'", dateReceipt.ToString("yyyy-MM-dd"));
            DataTable dt = new DataTable();
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Promotion", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                dt = dataset.Tables["Promotion"].Clone();
                for (int i = 0; i < dataset.Tables["Promotion"].Rows.Count; i++)
                {
                    var row = dataset.Tables["Promotion"].Rows[i];
                    if (!String.IsNullOrWhiteSpace(row["BeginTime"].ToString()))
                    {
                        decimal beginTime = Common.TotalHour.GetHourFromTime(row["BeginTime"].ToString());
                        decimal endTime = Common.TotalHour.GetHourFromTime(row["EndTime"].ToString());
                        decimal currentTime = Common.TotalHour.GetHourFromTime(dateReceipt.ToString("HH:mm:ss"));
                        if (currentTime >= beginTime && currentTime <= endTime)
                        {
                            DataRow dr = dt.NewRow();
                            dr = NewDataRow(dt, row);
                            dt.Rows.Add(dr);
                        }
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        dr = NewDataRow(dt, row);
                        dt.Rows.Add(dr);
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Create new data row
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private DataRow NewDataRow(DataTable dt, DataRow row)
        {
            DataRow dr = dt.NewRow();
            dr["PromotionId"] = row["PromotionId"];
            dr["PromotionName"] = row["PromotionName"];
            dr["PromotionName2"] = row["PromotionName2"];
            dr["PromotionName3"] = row["PromotionName3"];
            dr["BeginDateTime"] = row["BeginDateTime"];
            dr["EndDateTime"] = row["EndDateTime"];
            dr["BeginTime"] = row["BeginTime"];
            dr["EndTime"] = row["EndTime"];
            dr["PercenDiscount"] = row["PercenDiscount"];
            dr["Product"] = row["Product"];
            dr["PromotionTypeId"] = row["PromotionTypeId"];
            dr["CreatedDate"] = row["CreatedDate"];
            dr["UpdatedDate"] = row["UpdatedDate"];
            dr["Creator"] = row["Creator"];
            return dr;
        }

        /// <summary>
        /// Get promotion product 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable GetPromotionForProduct(DateTime date)
        {
            string query = String.Format(@"SELECT * FROM `promotions` WHERE `promotions`.`Type` = '3'
                                            AND BeginDateTime <= '{0}' AND EndDateTime >= '{0}'", date.ToString("yyyy-MM-dd HH:mm:ss"));
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Promotion", ref errorString);
            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }
            if (dataset.Tables["Promotion"].Rows.Count != 0)
            {
                return dataset.Tables["Promotion"];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get promotion service 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable GetPromotionForService(DateTime date)
        {
            string query = String.Format(@"SELECT * FROM `promotions` WHERE `promotions`.`Type` = '2'
                                            AND BeginDateTime <= '{0}' AND EndDateTime >= '{0}'", date.ToString("yyyy-MM-dd HH:mm:ss"));
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Promotion", ref errorString);
            if (!String.IsNullOrEmpty(errorString))
            {
                return null;
            }
            if (dataset.Tables["Promotion"].Rows.Count != 0)
            {
                return dataset.Tables["Promotion"];
            }
            else
            {
                return null;
            }
        }

        public void CreateObjectData(DataTable dt)
        {
            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("PromotionId", typeof(string));
            dt.Columns.Add("PromotionName", typeof(string));
            dt.Columns.Add("PromotionName2", typeof(string));
            dt.Columns.Add("PromotionName3", typeof(string));
            dt.Columns.Add("BeginDateTime", typeof(string));
            dt.Columns.Add("EndDateTime", typeof(string));
            dt.Columns.Add("BeginTime", typeof(string));
            dt.Columns.Add("EndTime", typeof(string));
            dt.Columns.Add("PercenDiscount", typeof(string));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("PromotionTypeId", typeof(string));
            dt.Columns.Add("CreatedDate", typeof(string));
            dt.Columns.Add("UpdatedDate", typeof(string));
            dt.Columns.Add("Creator", typeof(string));

        }
    }
}
