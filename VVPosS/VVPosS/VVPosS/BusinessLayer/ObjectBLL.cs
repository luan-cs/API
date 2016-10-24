using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosS.Entities;
using System.Data;

namespace VVPosS.BusinessLayer
{
    public class ObjectBLL:IObjectBLL<Objects>
    {
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public void Add(Objects obj)
        {
            long id = 0;
            string queryStr = "INSERT INTO";
            queryStr += " objects(Objectid, ObjectGroup, ObjectType, FullName, PID, PIDState, PIDIssue, DoB, PoB, PerAdd, TemAdd,";
            queryStr += " Gender, ProvinceId, Tel, Fax, Email, Website, TaxCode, Note, Status, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)";
            queryStr += " VALUES(";
            queryStr += string.Format("'{0}'", obj.ObjectId);
            queryStr += string.Format(", '{0}'", obj.ObjectGroup);
            queryStr += string.Format(", '{0}'", obj.ObjectType);
            queryStr += string.Format(", '{0}'", obj.FullName);
            queryStr += string.Format(", '{0}'", obj.PID);
            queryStr += string.Format(", '{0}'", obj.PIDState);
            queryStr += string.Format(", '{0}'", obj.PIDIssue);
            queryStr += string.Format(", '{0}'", obj.DoB);
            queryStr += string.Format(", {0}", obj.PoB);
            queryStr += string.Format(", '{0}'", obj.PerAdd);
            queryStr += string.Format(", '{0}'", obj.TemAdd);
            queryStr += string.Format(", '{0}'", obj.Gender);
            queryStr += string.Format(", '{0}'", obj.ProvinceId);
            queryStr += string.Format(", {0}", obj.Tel);
            queryStr += string.Format(", {0}", obj.Fax);
            queryStr += string.Format(", {0}", obj.Email);
            queryStr += string.Format(", {0}", obj.Website);
            queryStr += string.Format(", {0}", obj.TaxCode);
            queryStr += string.Format(", {0}", obj.Note);
            queryStr += string.Format(", {0}", obj.Status);
            queryStr += string.Format(", {0}", obj.CreatedBy);
            queryStr += ", NOW()";
            queryStr += string.Format(", {0}", obj.ModifiedBy);
            queryStr += ", NOW() )";
            //Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            Program.destopService.DataExecuteId(Program.Username, Program.Password, queryStr, ref id, ref errorString);
            //MessageBox.Show(id + "");
        }

        public void Edit(Objects obj)
        {
            string queryStr = "UPDATE objects SET";
            queryStr += string.Format(" ObjectGroup = '{0}'", obj.ObjectGroup);
            queryStr += string.Format(" ,ObjectType = '{0}'", obj.ObjectType);
            queryStr += string.Format(" ,FullName = '{0}'", obj.FullName);
            queryStr += string.Format(" ,PID = '{0}'", obj.PID);
            queryStr += string.Format(" ,PIDState = '{0}'", obj.PIDState);
            queryStr += string.Format(" ,PIDIssue = '{0}'", obj.PIDIssue);
            queryStr += string.Format(" ,DoB = '{0}'", obj.DoB);
            queryStr += string.Format(" ,PoB = {0}", obj.PoB);
            queryStr += string.Format(" ,PerAdd = '{0}'", obj.PerAdd);
            queryStr += string.Format(" ,Gender = '{0}'", obj.Gender);
            queryStr += string.Format(" ,TemAdd = '{0}'", obj.TemAdd);
            queryStr += string.Format(" ,ProvinceId = '{0}'", obj.ProvinceId);
            queryStr += string.Format(" ,Tel = {0}", obj.Tel);
            queryStr += string.Format(" ,Fax = '{0}'", obj.Fax);
            queryStr += string.Format(" ,Email = {0}", obj.Email);
            queryStr += string.Format(" ,Website = '{0}'", obj.Website);
            queryStr += string.Format(" ,TaxCode = {0}", obj.TaxCode);
            queryStr += string.Format(" ,Note = '{0}'", obj.Note);
            queryStr += string.Format(" ,ModifiedBy = {0}", obj.ModifiedBy);
            queryStr += " ,UpdatedDate = NOW()";
            queryStr += string.Format(" WHERE Objectid = '{0}'", obj.ObjectId);

            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        }

        public void Delete(string id)
        {
            string queryStr = string.Format("UPDATE objects SET IsDelete = 1 WHERE  Objectid = '{0}'", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
        }

        public DataTable GetObjectByObjectId(string objectid)
        {
            DataTable res = new DataTable();
            DataSet ds = new DataSet();
            string[][] param ={
                new string[] {"p_ObjectId",objectid},
            };
            Program.destopService.DataStoreProcQuery_Param(Program.Username, Program.Password, "spSelect_Object_By_ObjectId", ref ds, param, ref errorString);

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
    }
}
