//Create by: Điệp
//Modified : Điệp
//Create date: 20131029
//Update : 20131029
using System;
using System.Collections.Generic;
using System.Linq;
using VVPosM1.Entities;
using System.Data;
using VVPosM1.Common;

namespace VVPosM1.BusinessLayer.BLLCRM
{
    class EmployeeTypeBLL:IObjectBLL<EmployeeType>
    {
        EmployeeType empType = new EmployeeType();
        private string errorString = "";
        private const string TABLE_NAME = "employee_types";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        } 

        public bool Add(EmployeeType obj)
        {
            string queryStr = string.Format("Insert into {2}(EmployeeTypeId,  EmployeeTypeName, EmployeeTypeName2, EmployeeTypeName3) values('{0}','{1}','{3}', '{4}')", DateTime.Now.ToString("yyyMddHmmss"), obj.EmployeeTypeName, TABLE_NAME, obj.EmployeeTypeName2, obj.EmployeeTypeName3);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public bool Edit(EmployeeType obj)
        {
            string queryStr = string.Format("Update {2} set EmployeeTypeName='{0}', EmployeeTypeName2='{3}', EmployeeTypeName3='{4}'  Where EmployeeTypeId ='{1}'", obj.EmployeeTypeName, obj.EmployeeTypeId, TABLE_NAME, obj.EmployeeTypeName2, obj.EmployeeTypeName3);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public bool Delete(string id)
        {
            string query = "SELECT count(*) as total FROM `employees` WHERE `EmployeeTypeId` = '" + id + "'";
            DataSet dataset = new DataSet();

            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "count", ref errorString);
            if (!string.IsNullOrEmpty(errorString) || int.Parse(dataset.Tables["count"].Rows[0]["total"].ToString()) != 0)
            {
                return false;
            }

            errorString = "";

            string queryStr = string.Format("Delete From {1} Where EmployeeTypeId ='{0}'", id, TABLE_NAME);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public DataTable GetLists()
        {
            DataSet dataset = new DataSet();

            string condition = "";
            if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
            {
                condition = "where EmployeeTypeName is not null and EmployeeTypeName != ''";
            }
            if (Common.clsLanguages.StrCulture.Equals("en-US"))
            {
                condition = "where EmployeeTypeName is not null and EmployeeTypeName2 != ''";
            }
            if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
            {
                condition = "where EmployeeTypeName is not null and EmployeeTypeName3 != ''";
            }

            Program.destopService.DataQuery(Program.Username, Program.Password, "SELECT * FROM employee_types " + condition, ref dataset, "x", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["x"];
            else
                return null;
        }

        public EmployeeType GetById(string id)
        {
            string queryStr = String.Format("Select * From {1} Where EmployeeTypeId = '{0}'", id, TABLE_NAME);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "EmployeeType", ref errorString);
            if (!string.IsNullOrEmpty(errorString))
            {
                return null;
            }
            if (dataset.Tables["EmployeeType"].Rows.Count > 0)
            {
                empType.EmployeeTypeId = dataset.Tables["EmployeeType"].Rows[0]["EmployeeTypeId"].ToString();
                empType.EmployeeTypeName = dataset.Tables["EmployeeType"].Rows[0]["EmployeeTypeName"].ToString();
                empType.EmployeeTypeName2 = dataset.Tables["EmployeeType"].Rows[0]["EmployeeTypeName2"].ToString();
                empType.EmployeeTypeName3 = dataset.Tables["EmployeeType"].Rows[0]["EmployeeTypeName3"].ToString();
            }
            else
                empType = null;

            return empType;
        }
    }
}
