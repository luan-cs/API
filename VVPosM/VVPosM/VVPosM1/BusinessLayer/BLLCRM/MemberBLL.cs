#region (c) 2012 Viet Vang - All rights reserved
/*             			COPYRIGHT NOTICE
 *-----------------------------------------------------------------------
 * All materials (including but not limited to source code, compiled
 * assemblies, images, resources, etc.) are copyrighted to Viet Vang.
 * No usage is allowed unless permitted by written consent.
 * You may not use, reverse-engineer these materials under any 
 * circumstances.
 * 
 *
 *				PROJECT DESCRIPTION
 *-----------------------------------------------------------------------
 * Project		: V2SoftMEMDIWINF1308
 * Class		: frmMain
 * Developer    : Tran Thanh Luan
 */
#endregion

#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VVPosM1.Entities;
using System.Data; 
#endregion

namespace VVPosM1.BusinessLayer.BLLCRM
{
    class MemberBLL:IObjectBLL<Member>
    {
        #region Variable
        /// <summary>
        /// string containts error
        /// </summary>
        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        } 
        #endregion

        #region Function
        /// <summary>
        /// Add member
        /// </summary>
        /// <param name="obj"></param>
        public bool Add(Member obj)
        {
            string query = @"INSERT INTO members 
                                ( members.memberCode
                                 ,members.MemberName
                                 ,members.BirthDate
                                 ,members.PhoneNumber
                                 ,members.Email
                                 ,members.Address
                                 ,members.TotalScore
                                 ,members.NumberOfVissits
                                 ,members.LastestDate
                                 
                                 ,members.CountryId
                                 ,members.IsLock
                                 ,members.IsDelete
                                 ,members.CreatedDate
                                 ,members.UpdatedDate
                                 ,members.Creator
                                 ,members.CurrentScore
                                ,members.MobilePhone
                                ,members.Website
                                ,members.TaxCode
                                ,members.CompanyName
                                ,members.Description
                                ,members.CallName
                                ,members.Regency
                                ,members.CompanyEmail
                                ,members.Curator
                                ,members.CategoryID
                            )
                            VALUES (";
            query += string.Format("'{0}',", obj.MemberCode);
            query += string.Format("'{0}',", obj.MemberName);
            if (obj.birthDay == true)
            {
                query += string.Format("'{0}',", obj.BirthDate.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else
            {
                query += string.Format("{0},", "NULL");
            }
            query += string.Format("'{0}',", obj.PhoneNumber);
            query += string.Format("'{0}',", obj.Email);
            query += string.Format("'{0}',", obj.Address);
            query += string.Format("'{0}',", obj.TotalScore);
            query += string.Format("'{0}',", obj.NumberOfVissits);
            query += string.Format("'{0}',", obj.LastestDate.ToString("yyyy-MM-dd HH:mm:ss"));
            
            query += string.Format("'{0}',", obj.Country.CountryId);
            query += string.Format("'{0}',", 0);
            query += string.Format("'{0}',", 0);
            query += string.Format("'{0}',", obj.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss"));
            query += string.Format("'{0}',", obj.UpdatedDate.ToString("yyyy-MM-dd HH:mm:ss"));
            query += string.Format("'{0}',", obj.Creator.EmployeeId);
            query += string.Format("'{0}',", obj.CurrentScore);
            //Linh Add 20140417
            query += string.Format("'{0}',", obj.MobilePhone);
            query += string.Format("'{0}',", obj.Website);
            query += string.Format("'{0}',", obj.TaxCode);
            query += string.Format("'{0}',", obj.CompanyName);
            //query += string.Format("'{0}',", obj.Description);
            query += "'"+obj.Description+"',";
            query += string.Format("'{0}',", obj.CallName.CallNameID);
            query += string.Format("'{0}',", obj.Regency);
            query += string.Format("'{0}',", obj.CompanyEmail);

            //Linh 24-12-2014
            query += string.Format("'{0}',", obj.Curator.EmployeeId);
            query += string.Format("'{0}')", obj.CategoryID.CategoryActionID);
            Int64 pId = 0;
            Program.destopService.DataExecuteId(Program.Username, Program.Password, query, ref pId, ref errorString);
            // public void DataExecuteId(string pUsernameOrId, string password, string pQueryString, ref Int64 pId, ref string pError)

            // add vào member_membertype
            if (string.IsNullOrEmpty(errorString) && pId>0)
            {
                if (obj.List_MemberType != null)
                {
                    if (obj.List_MemberType.Count > 0)
                    {
                        string query1 = @"INSERT INTO member_membertype ( member_membertype.MemberId, member_membertype.MemberTypeId) VALUE ";
                        string isComma = "";
                        foreach (Entities.MemberType mt in obj.List_MemberType)
                        {
                            query1 += isComma + string.Format("('{0}', '{1}')", pId.ToString(), mt.MemberTypeId.ToString());

                            isComma = ",";
                        }
                        Program.destopService.DataExecute(Program.Username, Program.Password, query1, ref errorString);
                        //return (string.IsNullOrEmpty(errorString)) ? true : false;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Edit member
        /// </summary>
        /// <param name="obj"></param>
        public bool Edit(Member obj)
        {
            string query = @"UPDATE members SET ";
            query += string.Format("members.MemberCode = '{0}' ", obj.MemberCode);
            query += string.Format(",members.MemberName = '{0}' ", obj.MemberName);
            if(obj.birthDay == true)
            {
                query += string.Format(",members.BirthDate = '{0}' ", obj.BirthDate.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            query += string.Format(",members.PhoneNumber = '{0}' ", obj.PhoneNumber);
            query += string.Format(",members.Email = '{0}' ", obj.Email);
            query += string.Format(",members.Address = '{0}' ", obj.Address);
            query += string.Format(",members.TotalScore = '{0}' ", obj.TotalScore);

            query += string.Format(",members.CurrentScore = '{0}' ", obj.CurrentScore);
            query += string.Format(",members.NumberOfVissits = '{0}' ", obj.NumberOfVissits);
            query += string.Format(",members.LastestDate = '{0}' ", obj.LastestDate.ToString("yyyy-MM-dd HH:mm:ss"));
            query += string.Format(",members.MemberType = '{0}' ", obj.MemberType.MemberTypeId);
            query += string.Format(",members.CountryId = '{0}' ", obj.Country.CountryId);
            query += string.Format(",members.IsLock = '{0}' ", obj.IsLock);
            query += string.Format(",members.LockDate = '{0}' ", obj.LockDate.ToString("yyyy-MM-dd HH:mm:ss"));
            query += string.Format(",members.IsDelete = '{0}' ", obj.IsDelete);
           //query += string.Format(",members.CreatedDate = '{0}' ", obj.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss"));

            query += string.Format(",members.UpdatedDate = '{0}' ", obj.UpdatedDate.ToString("yyyy-MM-dd HH:mm:ss"));
            query += string.Format(",members.Creator = '{0}' ", obj.Creator.EmployeeId);
                    
            //Diep add new 20140418
            query += string.Format(",members.MobilePhone = '{0}' ", obj.MobilePhone);
            query += string.Format(",members.Website = '{0}' ", obj.Website);
            query += string.Format(",members.TaxCode = '{0}' ", obj.TaxCode);
            query += string.Format(",members.CompanyName = '{0}' ", obj.CompanyName);
            query += string.Format(",members.Description = '{0}' ", obj.Description);
            query += string.Format(",members.CallName = '{0}' ", obj.CallName.CallNameID);
            query += string.Format(",members.Regency = '{0}' ", obj.Regency);
            query += string.Format(",members.CompanyEmail = '{0}' ", obj.CompanyEmail);

            //Linh 24-12-2014
            query += string.Format(",members.Curator = '{0}' ", obj.Curator.EmployeeId);
            query += string.Format(",members.CategoryID = '{0}' ", obj.CategoryID.CategoryActionID);

            query += string.Format(" WHERE members.MemberId = '{0}'", obj.MemberId);
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);


            // Update vào member_membertype
            if (string.IsNullOrEmpty(errorString) )
            {
                // delete member_membertype

                string query2 = @"DELETE FROM member_membertype";
                query2 += string.Format(" WHERE MemberId = '{0}'", obj.MemberId);
                Program.destopService.DataExecute(Program.Username, Program.Password, query2, ref errorString);

                if (obj.List_MemberType != null && string.IsNullOrEmpty(errorString))
                {
                    if (obj.List_MemberType.Count > 0)
                    {
                        foreach (Entities.MemberType mt in obj.List_MemberType)
                        {
                            string query1 = @"INSERT INTO member_membertype";
                            query1 += "( member_membertype.MemberId, member_membertype.MemberTypeId) ";
                            query1 += " VALUES(" + string.Format("'{0}',", obj.MemberId);
                            query1 += string.Format("'{0}')", mt.MemberTypeId.ToString());

                            Program.destopService.DataExecute(Program.Username, Program.Password, query1, ref errorString);
                            //return (string.IsNullOrEmpty(errorString)) ? true : false;
                        }
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Delete member
        /// </summary>
        /// <param name="id"></param>
        public bool Delete(string id)
        {
            string query = string.Format("UPDATE members SET members.IsDelete = '1' WHERE members.MemberId = '{0}'", id);

            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
            return (string.IsNullOrEmpty(errorString)) ? true : false;
        }

        /// <summary>
        /// Get list members
        /// </summary>
        /// <returns></returns>
        public DataTable GetLists()
        {
            string query = @"SELECT members.MemberId,
                                    members.MemberCode,
                                    members.MemberName,
                                    members.BirthDate,
                                    members.PhoneNumber,
                                    members.Email,
                                    members.Address,
                                    members.TotalScore,
                                    members.CurrentScore,
                                    members.NumberOfVissits,
                                    members.LastestDate,
                                    members.Membertype,
                                    countries.CountryName,
                                    members.IsLock,
                                    members.CreatedDate,
                                    members.UpdatedDate,
                                    employees.EmployeeName,
                                    members.CompanyName,
                                    members.MobilePhone,
                                    members.CompanyEmail     

                            FROM members LEFT JOIN countries ON members.CountryId = countries.CountryId 
                                         LEFT JOIN employees ON members.Creator = employees.EmployeeId
                            WHERE members.IsDelete = '0'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["Member"];
            }
            else
                return null;
        }

        public DataTable GetListNameOrCompany()
        {
            string query = "SELECT `MemberId`, CASE WHEN `MemberName` = '' or `MemberName` is null THEN concat('[', `CompanyName`, ']') ELSE `MemberName` END AS MemberName FROM `members` WHERE `members`.`IsDelete` = '0' ORDER BY MemberName ASC";

            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["Member"];
            }
            else
                return null;
        }

        /// <summary>
        /// Get list display on data gridview
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataTable GetListDisplay(DataTable dt)
        {
            if (dt != null)
            {
                MemberTypeBLL memberTypeBLL = new MemberTypeBLL();
                DataTable newDataTable = new DataTable();
                newDataTable.Columns.Add("STT");
                newDataTable.Columns.Add("MemberId");
                newDataTable.Columns.Add("MemberName");
                newDataTable.Columns.Add("MemberCode");
                newDataTable.Columns.Add("PhoneNumber");
                newDataTable.Columns.Add("Email");
                newDataTable.Columns.Add("Address");
                newDataTable.Columns.Add("CountryName");
                newDataTable.Columns.Add("BirthDate");
                newDataTable.Columns.Add("CompanyName");
                newDataTable.Columns.Add("MobilePhone");
                newDataTable.Columns.Add("Curator");
                newDataTable.Columns.Add("EmployeeName");
                newDataTable.Columns.Add("CategoryID");
                newDataTable.Columns.Add("Description");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    string coundtry = "";
                    if (Common.clsLanguages.StrCulture.Equals("vi-VN"))
                    {
                        coundtry = "CountryName";
                    }
                    else if (Common.clsLanguages.StrCulture.Equals("en-US"))
                    {
                        coundtry = "CountryName3";
                    }
                    else if (Common.clsLanguages.StrCulture.Equals("ja-JP"))
                    {
                        coundtry = "CountryName2";
                    }

                    DataRow dtRow = newDataTable.NewRow();
                    dtRow["STT"] = (i+1).ToString();
                    dtRow["MemberId"] = row["MemberId"];
                    dtRow["MemberName"] = row["MemberName"];
                    dtRow["MemberCode"] = row["MemberCode"];
                    dtRow["PhoneNumber"] = row["PhoneNumber"];
                    dtRow["Email"] = row["Email"];
                    dtRow["BirthDate"] = row["BirthDate"];
                    dtRow["CountryName"] = row[coundtry];
                    dtRow["CompanyName"] = row["CompanyName"];
                    dtRow["MobilePhone"] = row["MobilePhone"];
                    dtRow["Curator"] = row["Curator"];
                    dtRow["Address"] = row["Address"];
                    dtRow["EmployeeName"] = row["EmployeeName"];
                    dtRow["CategoryID"] = row["CategoryID"];
                    dtRow["Description"] = row["Description"];
              
                    newDataTable.Rows.Add(dtRow);
                }
                return newDataTable;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get member by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Member GetById(string id)
        {
            Member member = new Member();
            string query = "";
            try
            {
                query = string.Format("SELECT * FROM members WHERE members.MemberId = '{0}'", id);
                DataSet dataset = new DataSet();
                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

                if (!string.IsNullOrEmpty(errorString))
                    return null;
                if (dataset.Tables["Member"].Rows.Count > 0)
                {
                    var row = dataset.Tables["Member"].Rows[0];
                    member = GetMemberByDataRow(row); 
                    /// danh sách member_types
                    string query1 = string.Format("SELECT * FROM member_types INNER JOIN  member_membertype ON member_types.`MemberTypeId`=member_membertype.`MemberTypeId` WHERE member_membertype.MemberId = '{0}'", id);
                    DataSet dataset1 = new DataSet();
                    Program.destopService.DataQuery(Program.Username, Program.Password, query1, ref dataset1, "member_types", ref errorString);
                    DataTable dt = dataset1.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        List<MemberType> lst_mbt = new List<MemberType>();
                        foreach (DataRow dr in dt.Rows)
                        {
                            MemberType mbt = new MemberType();
                            mbt.MemberTypeId = int.Parse(dr["MemberTypeId"].ToString());
                            mbt.MemberTypeCode = dr["MemberTypeCode"].ToString();
                            mbt.MemberTypeName = dr["MemberTypeName"].ToString();
                            mbt.MemberTypeName2 = dr["MemberTypeName2"].ToString();
                            mbt.MemberTypeName3 = dr["MemberTypeName3"].ToString();
                            lst_mbt.Add(mbt);
                        }
                        member.List_MemberType = lst_mbt;
                    }
                    else
                    {
                        member.List_MemberType = null;
                    }
                }
                else
                {
                    member = null;
                }
            }
            catch (Exception ex)
            {
                VVPosM1.CustomMessageBox.MessageBox.ShowCustomMessageBox(ex.Message, Common.Messages.msgTitleError, Common.Config.CUSTOM_MESSAGEBOX_ICON.Error, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
            return member;
        }

        public int GetMemberTypeByMemberId(int memberId)
        {
            string query = "";
            int memberType = 0;
            try
            {
                query = string.Format("SELECT * FROM members WHERE members.MemberId = '{0}'", memberId);
                DataSet dataset = new DataSet();
                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

                if (dataset.Tables["Member"].Rows.Count > 0)
                {
                    var row = dataset.Tables["Member"].Rows[0];
                    memberType = (row["MemberType"].ToString() == "") ? 0 : Int32.Parse(row["MemberType"].ToString());
                }
            }
            catch (Exception ex)
            {
                VVPosM1.CustomMessageBox.MessageBox.ShowCustomMessageBox(ex.Message, Common.Messages.msgTitleError, Common.Config.CUSTOM_MESSAGEBOX_ICON.Error, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
            return memberType;
        }

        /// <summary>
        /// Check islock of member 
        /// if true is ok
        /// if false , member is locked
        /// </summary>
        /// <param name="memberCode"></param>
        /// <returns></returns>
        public bool CheckMemberIsLock(string memberCode)
        {
            string query = string.Format("SELECT * FROM members WHERE members.MemberCode = '{0}' AND members.IsLock = '0' AND members.IsDelete = '0'", memberCode);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
            {
                return false;
            }

            if (dataset.Tables["Member"].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check isDelete field of member
        /// if true is having deleted
        /// else not
        /// </summary>
        /// <param name="memberCode"></param>
        /// <returns></returns>
        public bool CheckMemberIsDelete(string memberCode)
        {
            string query = string.Format("SELECT * FROM members WHERE members.MemberCode = '{0}' AND members.IsDelete = '1'", memberCode);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
            {
                return false;
            }

            if (dataset.Tables["Member"].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check membercode exist in system or not
        /// </summary>
        /// <param name="memberCode"></param>
        /// <returns></returns>
        public bool CheckMemberCodeExist(string memberCode)
        {
            string query = string.Format("SELECT * FROM members WHERE members.MemberCode = '{0}'  AND members.IsDelete = '0'", memberCode);
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (!string.IsNullOrEmpty(errorString))
            {
                return false;
            }

            if (dataset.Tables["Member"].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get member by membercode
        /// </summary>
        /// <param name="memberCode"></param>
        /// <returns></returns>
        public Member GetByMemberCode(string memberCode)
        {
            Member member = new Member();
            string query = "";
            try
            {
                query = string.Format("SELECT * FROM members WHERE members.MemberCode = '{0}'  AND members.IsDelete = '0'", memberCode);
                DataSet dataset = new DataSet();
                Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

                if (!string.IsNullOrEmpty(errorString))
                    return null;
                if (dataset.Tables["Member"].Rows.Count > 0)
                {
                    var row = dataset.Tables["Member"].Rows[0];
                    member = GetMemberByDataRow(row);
                }
                else
                {
                    member = null;
                }

            }
            catch (Exception ex)
            {
                VVPosM1.CustomMessageBox.MessageBox.ShowCustomMessageBox(ex.Message, Common.Messages.msgTitleError, Common.Config.CUSTOM_MESSAGEBOX_ICON.Error, Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
            return member;
        }

        /// <summary>
        /// Get member by datarow
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Member GetMemberByDataRow(DataRow row)
        {
            Member member = new Member();
            if (!String.IsNullOrEmpty(row["MemberId"].ToString()))
            {
                member.MemberId = row["MemberId"].ToString();
            }
            if (!String.IsNullOrEmpty(row["MemberCode"].ToString()))
            {
                member.MemberCode = row["MemberCode"].ToString();
            }
            if (!String.IsNullOrEmpty(row["MemberName"].ToString()))
            {
                member.MemberName = row["MemberName"].ToString();
            }
            if (!String.IsNullOrEmpty(row["BirthDate"].ToString()))
            {
                member.birthDay = true;
                member.BirthDate = DateTime.Parse(row["BirthDate"].ToString());
            }
            else
            {
                member.birthDay = false;
                member.BirthDate = DateTime.Now;
            }
            if (!String.IsNullOrEmpty(row["PhoneNumber"].ToString()))
            {
                member.PhoneNumber = row["PhoneNumber"].ToString();
            }
            if (!String.IsNullOrEmpty(row["Email"].ToString()))
            {
                member.Email = row["Email"].ToString();
            }
            if (!String.IsNullOrEmpty(row["Address"].ToString()))
            {
                member.Address = row["Address"].ToString();
            }
            if (!String.IsNullOrEmpty(row["TotalScore"].ToString()))
            {
                member.TotalScore = Double.Parse(row["TotalScore"].ToString());
            }
            if (!String.IsNullOrEmpty(row["NumberOfVissits"].ToString()))
            {
                member.NumberOfVissits = Int32.Parse(row["NumberOfVissits"].ToString());
            }
            if (!String.IsNullOrEmpty(row["LastestDate"].ToString()))
            {
                member.LastestDate = DateTime.Parse(row["LastestDate"].ToString());
            }
            if (!String.IsNullOrEmpty(row["MemberType"].ToString()))
            {
                member.MemberType.MemberTypeId = Int32.Parse(row["MemberType"].ToString());
            }
            if (!String.IsNullOrEmpty(row["CountryId"].ToString()))
            {
                member.Country.CountryId = row["CountryId"].ToString();
            }
            if (!String.IsNullOrEmpty(row["IsLock"].ToString()))
            {
                member.IsLock = Int32.Parse(row["IsLock"].ToString());
            }
            if (!String.IsNullOrEmpty(row["LockDate"].ToString()))
            {
                member.LockDate = DateTime.Parse(row["LockDate"].ToString());
            }
            if (!String.IsNullOrEmpty(row["IsDelete"].ToString()))
            {
                member.IsDelete = Int32.Parse(row["IsDelete"].ToString());
            }
            if (!String.IsNullOrEmpty(row["CreatedDate"].ToString()))
            {
                member.CreatedDate = DateTime.Parse(row["CreatedDate"].ToString());
            }
            if (!String.IsNullOrEmpty(row["UpdatedDate"].ToString()))
            {
                member.UpdatedDate = DateTime.Parse(row["UpdatedDate"].ToString());
            }
            if (!String.IsNullOrEmpty(row["Creator"].ToString()))
            {
                member.Creator.EmployeeId = row["Creator"].ToString();
            }
            if (!String.IsNullOrEmpty(row["CurrentScore"].ToString()))
            {
                member.CurrentScore = Int32.Parse(row["CurrentScore"].ToString());
            }
            //Diep Add new 20140418
            if (!String.IsNullOrEmpty(row["MobilePhone"].ToString()))
            {
                member.MobilePhone = row["MobilePhone"].ToString();
            }
            if (!String.IsNullOrEmpty(row["Website"].ToString()))
            {
                member.Website = row["Website"].ToString();
            }
            if (!String.IsNullOrEmpty(row["TaxCode"].ToString()))
            {
                member.TaxCode = row["TaxCode"].ToString();
            }
            if (!String.IsNullOrEmpty(row["CompanyName"].ToString()))
            {
                member.CompanyName = row["CompanyName"].ToString();
            }
            if (!String.IsNullOrEmpty(row["Description"].ToString()))
            {
                member.Description = row["Description"].ToString();
            }
            if (!String.IsNullOrEmpty(row["CallName"].ToString()))
            {
                member.CallName.CallNameID = int.Parse(row["CallName"].ToString());
            }
            if (!String.IsNullOrEmpty(row["Regency"].ToString()))
            {
                member.Regency =row["Regency"].ToString();
            }
            if (!String.IsNullOrEmpty(row["CompanyEmail"].ToString()))
            {
                member.CompanyEmail = row["CompanyEmail"].ToString();
            }          
  
            //Linh 25-12-2014
            if (!String.IsNullOrEmpty(row["Curator"].ToString()))
            {
                member.Curator.EmployeeId = row["Curator"].ToString();
            }
            if(!String.IsNullOrEmpty(row["CategoryID"].ToString()))
            {
                member.CategoryID.CategoryActionID = row["CategoryID"].ToString();
            }

            return member;
        }

        /// <summary>
        /// Update history for member
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="totalScore"></param>
        /// <param name="numberOfVissit"></param>
        /// <param name="lastestDate"></param>
        public void UpdateHistory(string memberId,int totalScore, int numberOfVissit,DateTime lastestDate)
        {
            string query = "UPDATE members SET ";
            query += String.Format("TotalScore = '{0}', ", totalScore);
            query += String.Format("NumberOfVissits = '{0}', ", numberOfVissit);
            query += String.Format("LastestDate = '{0}' WHERE ", lastestDate.ToString("yyyy-MM-dd HH:mm:ss"));
            query += String.Format("MemberId = '{0}'", memberId);
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
        }

        public DataSet GetInfoForFrmManageMembers()
        {
            DataSet dataset = new DataSet();
            Program.destopService.DataStoreProcQuery(Program.Username, Program.Password, "GetInfoForFrmManageMembers", ref dataset, ref errorString);
            if (string.IsNullOrEmpty(errorString))
            {
                return dataset;
            }
            else
            {
                return null;
            }
        }

        #endregion
        
        #region Điệp add in form frmMemberMail
        public DataTable SearchGetListsByMemberName(string pMemberName)
        {
            string query = @"SELECT members.MemberId,
                                    members.MemberCode,
                                    members.MemberName,
                                    members.BirthDate,
                                    members.PhoneNumber,
                                    members.Email,
                                    members.Address,
                                    members.TotalScore,
                                    members.NumberOfVissits,
                                    members.LastestDate,
                                    members.Membertype,
                                    countries.CountryName,
                                    members.IsLock,
                                    members.CreatedDate,
                                    members.UpdatedDate,
                                    employees.EmployeeName        
                            FROM members LEFT JOIN countries ON members.CountryId = countries.CountryId 
                                         LEFT JOIN employees ON members.Creator = employees.EmployeeId
                            WHERE members.IsDelete = '0'";
            query += " and memberName LIKE '%" + pMemberName +"%'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["Member"];
            }
            else
                return null;
        }


        /// <summary>
        /// Update Score for frm MemberScore
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="totalScore"></param>
        /// <param name="numberOfVissit"></param>
        /// <param name="lastestDate"></param>
        public void UpdateScore(string pMemberId, int pCurrentScore)
        {
            string query = "UPDATE members SET ";
            query += String.Format("CurrentScore = '{0}' Where ", pCurrentScore);           
            query += String.Format("MemberId = '{0}'", pMemberId);
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
        }
        #endregion

        //Điệp Add 20140418   
        public string GetMemberCode()
        {
            string query = String.Format("SELECT  RIGHT(membercode,5) AS SoCuoi	FROM members WHERE memberId = (SELECT MAX(memberID) FROM members) ");
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);
            if (String.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["x"].Rows[0]["SoCuoi"].ToString();
            }
            else
            {
                return null;
            }
        }

        //End Điệp add 20140418

        #region Dung add 2014-08-07
        /// <summary>
        /// Search information member
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public DataTable SearchInformation(Dictionary<string, string> param, List<string> lstMBT)
        {
            DataSet dataset = new DataSet();
            string query = @"SELECT members.*, countries.CountryName,countries.CountryName2,countries.CountryName3, employees.EmployeeName FROM members LEFT JOIN countries ON members.CountryId = countries.CountryId LEFT JOIN employees ON members.Creator = employees.EmployeeId WHERE ";
            
            string connectOp = "";
            if((param != null && param.Count > 0) || (lstMBT != null && lstMBT.Count > 0))
            {

                if (param.ContainsKey("SearchKeyWord"))
                {
                    query += String.Format("(members.MemberCode {0} OR members.MemberName {0} OR members.PhoneNumber {0} OR members.CompanyEmail {0} OR members.Address {0} OR members.TaxCode {0} OR members.CompanyName {0} OR members.CallName {0} OR members.Website {0} OR members.MobilePhone {0} OR members.Description {0})", "LIKE \"%" + param["SearchKeyWord"] + "%\"");
                    connectOp = " AND ";
                }

                if (param.ContainsKey("BirthDate"))
                {
                    string[] arr = param["BirthDate"].Split('@');
                    query += string.Format("{0}(members.BirthDate BETWEEN '{1}' AND '{2}')", connectOp, arr[0], arr[1]);
                    connectOp = " AND ";
                }

                if (param.ContainsKey("CountryId"))
                {
                    query += connectOp + "members.CountryId = '" + param["CountryId"] + "'";
                    connectOp = " AND ";
                }

                if (param.ContainsKey("Creator") && int.Parse(param["Creator"]) > 0)
                {
                    query += connectOp + "members.Creator = " + param["Creator"];
                    connectOp = " AND ";
                }

                //Linh 25-12-2014
                if (param.ContainsKey("Curator") && int.Parse(param["Curator"]) > 0)
                {
                    query += connectOp + "members.Curator = " + param["Curator"];
                    connectOp = " AND ";
                }

                if (param.ContainsKey("CategoryID") && int.Parse(param["CategoryID"]) > 0)
                {
                    query += connectOp + "members.CategoryID = " + param["CategoryID"];
                    connectOp = " AND ";
                }

                


                if (lstMBT != null && lstMBT.Count > 0)  //if (lstMBT.Count > 0) // Dung change on 2014-08-07
                {                   
                    query += connectOp + "members.MemberId IN (SELECT DISTINCT MemberId FROM member_membertype WHERE MemberTypeId IN (";
                    for (int i = 0; i < lstMBT.Count; i++)
                    {
                        query += lstMBT[i].ToString();
                        if (i < lstMBT.Count - 1)
                        {
                            query += ",";
                        }
                    }
                    query += "))";
                    connectOp = " AND ";
                }
            }
            query += connectOp + "members.IsDelete = 0";
            query += " ORDER BY members.MemberID DESC";
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "Member", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                return dataset.Tables[0];
            }
            else
                return null;
        }

        #endregion

        //Linh 16-12-2014
        public string getMemberId(string memberCode)
        {
            string query = "SELECT memberId FROM members WHERE membercode = '" + memberCode + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);
            if (String.IsNullOrEmpty(errorString))
            {
                return dataset.Tables["x"].Rows[0]["memberId"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        #region Nghi 25-12-2014
        public bool countCurator(string listMember, string curator)
        {
            string query = "SELECT distinct `members`.`Curator` FROM `members` WHERE `members`.`MemberId` IN " + listMember;
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "x", ref errorString);
            if (String.IsNullOrEmpty(errorString))
            {
                if (dataset.Tables["x"].Rows.Count != 1) return false;
                else
                    if (dataset.Tables["x"].Rows[0]["Curator"].ToString().Equals(curator)) return true;
                    else return false;
            }
            else
            {
                return false;
            }
        }

        public void Delete(string id, string DelList = null)
        {
            string query = "";
            if (string.IsNullOrEmpty(DelList))
            {
                query = string.Format("UPDATE members SET members.IsDelete = '1' WHERE members.MemberId = '{0}'", id);
            }
            else if (Program.lstRole.Contains("admin"))
            {
                query = string.Format("UPDATE members SET members.IsDelete = '1' WHERE members.MemberId IN {0}", DelList);
            }
            else
            {
                query = string.Format("UPDATE members SET members.IsDelete = '1' WHERE members.MemberId IN {0} AND members.Curator = {1}", DelList, id);
            }
            Program.destopService.DataExecute(Program.Username, Program.Password, query, ref errorString);
        }

        public string getCurator(string MemberID)
        {
            string query = "SELECT `Curator` FROM `members` WHERE `members`.`MemberID` = '" + MemberID + "'";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "tb", ref errorString);
            if (!string.IsNullOrEmpty(errorString) || dataset.Tables["tb"].Rows.Count != 1)
                return null;
            else
            {
                return dataset.Tables["tb"].Rows[0]["Curator"].ToString();
            }
        }
        #endregion
    }
}
