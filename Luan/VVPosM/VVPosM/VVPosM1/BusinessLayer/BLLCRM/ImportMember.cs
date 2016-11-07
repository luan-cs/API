using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace VVPosM1.BusinessLayer.BLLCRM
{
    class ImportMember
    {
        public static DataTable ReadExcelFile(string filepath)
        {
            DataTable dt = new DataTable();
            string connString = string.Empty;
            //Excel 2007 - 2013
            if (filepath.EndsWith(".xlsx"))
            {
                //2007 Format
                connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=No;IMEX=1;\"", filepath);
            }
            else
            {
                //2003 Format
                connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=No;IMEX=1;\"", filepath);
            }

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    try
                    {
                        //Read the First Sheet
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        con.Close();
                        string firstSheet = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

                        //Read the Header Row
                        cmd.CommandText = "SELECT * From [" + firstSheet + "]";
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            DataTable ExcelTable = new DataTable();
                            
                            da.SelectCommand = cmd;
                            da.Fill(ExcelTable);
                            dt = ExcelTable;
                        }
                    }
                    catch (Exception)
                    {
                        return dt;                     
                    }
                   
                }
            }
            return dt;
        }

       public static int returnCellName(string scompare)
       {
           //string colLabel = "F";
           string[] alphabetArray = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

           //string sTemp = colLabel + "0";
           int sTemp = -1;
           for (int iCount = 0; iCount < alphabetArray.Length; iCount++)
           {
               if (alphabetArray[iCount].Equals(scompare.ToUpper()))
               {
                   //sTemp = colLabel + iCount.ToString();
                   sTemp = iCount;
                   break;
               }
           }

           return sTemp;
       }

       public static string GetAutoMemberCode()
       {
           BusinessLayer.BLLCRM.MemberBLL memberBLL = new BusinessLayer.BLLCRM.MemberBLL();
           string pQG = "";
           string pNamThangNgay = "";
           int pAutoID = 1;
           pQG = "OT";
           pNamThangNgay = DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
           string pkq = "0";
           try
           {
               pkq = memberBLL.GetMemberCode();               
           }
           catch(Exception)
           {
               pkq = (pkq == "") ? "0" : pkq;
           }
           
           pAutoID = int.Parse(pkq.ToString()) + 1;

           string pKqAuto = "";
           if (pAutoID < 10)
           {
               pKqAuto = "0000" + pAutoID;
           }
           else if (pAutoID >= 10 && pAutoID < 100)
           {
               pKqAuto = "000" + pAutoID;
           }
           else if (pAutoID >= 100 && pAutoID < 1000)
           {
               pKqAuto = "00" + pAutoID;
           }
           else if (pAutoID >= 1000 && pAutoID < 10000)
           {
               pKqAuto = "0" + pAutoID;
           }
           else
           {
               pKqAuto = pAutoID.ToString();
           }
           return pQG + pNamThangNgay + pKqAuto;
       }
    }
}
