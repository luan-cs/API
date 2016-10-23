using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VVPosM1.Entities;
using System.Data;
namespace VVPosM1.BusinessLayer.BLLCRM
{
    class MemberTypeBLL : IObjectBLL<MemberType>
    {
        MemberType memType = new MemberType();
        private string errorString = "";
        private DataTable lstMemberTypes = new DataTable();
        public MemberTypeBLL()
        {
            lstMemberTypes = GetListsNameNotNull();
        }

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        public bool Add(MemberType obj)
        {
            string queryStr = string.Format("Insert into member_types(MemberTypeCode, MemberTypeName, MemberTypeName2, MemberTypeName3) values('{0}','{1}','{2}','{3}')", DateTime.Now.ToString("yyyMddHmmss"), obj.MemberTypeName, obj.MemberTypeName2, obj.MemberTypeName3);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public bool Edit(MemberType obj)
        {
            string queryStr = "";
            if (string.IsNullOrEmpty(obj.MemberTypeName) && string.IsNullOrEmpty(obj.MemberTypeName2) && string.IsNullOrEmpty(obj.MemberTypeName3))
            {
                queryStr = "Update Member_Types set MemberTypeCode='" + obj.MemberTypeCode + "', MemberTypeName=null, MemberTypeName2=null, MemberTypeName3=null Where MemberTypeId ='" + obj.MemberTypeId + "'";
            }
            else
            {
                queryStr = "Update Member_Types set MemberTypeCode='" + obj.MemberTypeCode + "', MemberTypeName='" + obj.MemberTypeName + "', MemberTypeName2='" + obj.MemberTypeName2 + "', MemberTypeName3='" + obj.MemberTypeName3 + "' Where MemberTypeId ='" + obj.MemberTypeId + "'";
            }
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public bool Delete(string id)
        {
            string query = "SELECT count(*) as total FROM `member_membertype` WHERE `MemberTypeId` = " + id;
            DataSet dataset = new DataSet();

            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "count", ref errorString);
            if (!string.IsNullOrEmpty(errorString) || int.Parse(dataset.Tables["count"].Rows[0]["total"].ToString()) != 0)
            {
                return false;
            }

            errorString = "";

            string queryStr = string.Format("Delete From Member_Types Where MemberTypeId = {0}", id);
            Program.destopService.DataExecute(Program.Username, Program.Password, queryStr, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        public System.Data.DataTable GetLists()
        {
            
            string queryStr = "Select * From Member_Types";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "MemberType", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["MemberType"];
            else
                return null;
        }

        public MemberType GetById(string id)
        {
            string queryStr = String.Format("Select * From Member_Types Where MemberTypeId = '{0}'", id);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "MemberType", ref errorString);
            if (!string.IsNullOrEmpty(errorString))
            {
                return null;
            }
            if (dataset.Tables["MemberType"].Rows.Count > 0)
            {
                memType.MemberTypeId = int.Parse(dataset.Tables["MemberType"].Rows[0]["MemberTypeId"].ToString());
                memType.MemberTypeCode = dataset.Tables["MemberType"].Rows[0]["MemberTypeCode"].ToString();
                if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                {
                    memType.MemberTypeName = dataset.Tables["MemberType"].Rows[0]["MemberTypeName"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                {
                    memType.MemberTypeName = dataset.Tables["MemberType"].Rows[0]["MemberTypeName3"].ToString();
                }
                else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                {
                    memType.MemberTypeName = dataset.Tables["MemberType"].Rows[0]["MemberTypeName2"].ToString();
                }
            }
            else
                memType = null;

            return memType;
        }

        //Điệp 
        public MemberType GetByIdUpdate(string id)
        {
            string queryStr = String.Format("Select * From Member_Types Where MemberTypeId = '{0}'", id);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "MemberType", ref errorString);
            if (!string.IsNullOrEmpty(errorString))
            {
                return null;
            }
            if (dataset.Tables["MemberType"].Rows.Count > 0)
            {
                memType.MemberTypeId = int.Parse(dataset.Tables["MemberType"].Rows[0]["MemberTypeId"].ToString());
                memType.MemberTypeCode = dataset.Tables["MemberType"].Rows[0]["MemberTypeCode"].ToString();
                memType.MemberTypeName = dataset.Tables["MemberType"].Rows[0]["MemberTypeName"].ToString();
                memType.MemberTypeName2 = dataset.Tables["MemberType"].Rows[0]["MemberTypeName2"].ToString();
                memType.MemberTypeName3 = dataset.Tables["MemberType"].Rows[0]["MemberTypeName3"].ToString();

            }
            else
                memType = null;

            return memType;
        }


        /// <summary>
        /// Get list member with name not null
        /// </summary>
        /// <returns></returns>
        public DataTable GetListsNameNotNull()
        {
            string queryStr = "Select * From Member_Types WHERE Member_Types.MemberTypeName is not null AND Member_Types.MemberTypeName != ''";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "MemberType", ref errorString);

            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["MemberType"];
            else
                return null;
        }

        /// <summary>
        ///This function is Count (*), Dung add to support function get all member show when press search, if checklistbox is checked all. 
        /// </summary>
        /// <returns>int count</returns>
        public int CountAll()
        {
            string queryStr = "Select count(*) From Member_Types";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "MemberType", ref errorString);

            int _iC = 0;
            if (string.IsNullOrEmpty(errorString))
                _iC = int.Parse(dataset.Tables["MemberType"].Rows[0][0].ToString());
            else
                _iC = 0;
            return _iC;
        }

        public DataTable GetListsNameNotNull_And_Id(List<int> lst)
        {
            DataSet dataset = new DataSet();
            string queryStr = "Select * From Member_Types WHERE Member_Types.MemberTypeName is not null AND Member_Types.MemberTypeName != '' ";
            if (lst.Count > 0)
            {
                queryStr = queryStr + " and MemberTypeId in (";
                for (int i = 0; i < lst.Count; i++)
                {
                    queryStr = queryStr + lst[i].ToString();
                    if (i+1 != lst.Count)
                    {
                        queryStr = queryStr + ",";
                    }
                }
                queryStr = queryStr + ")";            
                
                Program.destopService.DataQuery(Program.Username, Program.Password, queryStr, ref dataset, "MemberType", ref errorString);
            }
            if (string.IsNullOrEmpty(errorString))
                return dataset.Tables["MemberType"];
            else
                return null;
        }

        /// <summary>
        /// Get member type name
        /// </summary>
        /// <param name="memberTypeId"></param>
        /// <returns></returns>
        /*public string[] GetMemberTypeName(int memberTypeId)
        {
            MemberType membertype = new MemberType();
            membertype = GetById(memberTypeId.ToString());
            string memberTypeName = membertype.MemberTypeName;
            string[] arrMemberTypeName = memberTypeName.Split('/');
            return arrMemberTypeName;
        }*/

        /// <summary>
        /// Get list member type name
        /// </summary>
        /// <param name="memberType"></param>
        /// <returns></returns>
        public List<string> GetListMemberTypeName(int memberType)
        {
            List<string> lst = new List<string>();
            //browse to get member type name 
            for (int i = 0; i < lstMemberTypes.Rows.Count; i++)
            {
                if (lstMemberTypes.Rows[i]["MemberTypeName"] != null)
                {
                    int memberTypeId = Int32.Parse(lstMemberTypes.Rows[i]["MemberTypeId"].ToString());
                    //MemberType objMemberType = GetById(lstMemberTypes.Rows[i]["MemberTypeId"].ToString());
                    //do and bit to know member type
                    if ((memberType & memberTypeId) == memberTypeId)
                    {
                        lst.Add(lstMemberTypes.Rows[i]["MemberTypeName"].ToString());
                    }
                }
            }
            return lst;
        }

        ///
        public List<string> GetListMemberTypeName_New(List<int> lst_mbt)
        {
            List<string> lst = new List<string>();
            DataTable dt = GetListsNameNotNull_And_Id(lst_mbt);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MemberTypeName"] != null)
                    {
                        int memberTypeId = Int32.Parse(dt.Rows[i]["MemberTypeId"].ToString());
                        lst.Add(dt.Rows[i]["MemberTypeName"].ToString());

                    }
                }
            }            
            return lst;
        }

        /// <summary>
        /// Get list member type
        /// </summary>
        /// <param name="memberType"></param>
        /// <returns></returns>
        public List<int> GetListMemberType(int memberType)
        {
            List<int> lst = new List<int>();
            //browse to get member type name 
            for (int i = 0; i < lstMemberTypes.Rows.Count; i++)
            {
                if (lstMemberTypes.Rows[i]["MemberTypeName"] != null)
                {
                    int memberTypeId = Int32.Parse(lstMemberTypes.Rows[i]["MemberTypeId"].ToString());
                    //do and bit to know member type
                    if ((memberType & memberTypeId) == memberTypeId)
                    {
                        lst.Add(memberTypeId);
                    }
                }
            }
            return lst;
        }

        /// <summary>
        /// Check member type
        /// </summary>
        /// <param name="memberType"></param>
        /// <returns></returns>
        public bool CheckMemberHasMemberType(int memberType, int memberTypeSearch)
        {
            bool blag = false;
            List<int> lstSearch = GetListMemberType(memberTypeSearch);
            List<int> lstMemberType = GetListMemberType(memberType);
            for (int i = 0; i < lstSearch.Count; i++)
            {
                if (lstMemberType.Contains(lstSearch[i]))
                {
                    blag = true;
                    break;
                }
                //for (int j = 0; j < lstMemberType.Count; j++)
                //{
                //    if (lstSearch[i] == lstMemberType[j])
                //    {
                //        blag = true;
                //        break;
                //    }
                //}
            }
            return blag;
        }
        /// <summary>
        /// get member type number of member by a list of membername
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int GetMemberTypeByMemberTypeNameLists(List<string> lst)
        {
            int memberType = 0;
            DataTable lstMemberType = GetListsNameNotNull();
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < lstMemberType.Rows.Count; j++)
                {
                    if (lst[i].Equals(lstMemberType.Rows[j]["MemberTypeName"]))
                    {
                        memberType += Int32.Parse(lstMemberType.Rows[j]["MemberTypeId"].ToString());
                        break;
                    }
                }
            }
            return memberType;
        }

        public DataTable GetListMember_MemberType()
        {
            string query = "SELECT `MemberId`, `MemberTypeName`, `MemberTypeName2`, `MemberTypeName3` FROM `member_membertype` LEFT JOIN `member_types` ON `member_membertype`.`MemberTypeId` = `member_types`.`MemberTypeId`";
            DataSet dataset = new DataSet();
            try
            {
                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "a", ref errorString);
                if (string.IsNullOrEmpty(errorString))
                {
                    return dataset.Tables["a"];
                }
                else return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
