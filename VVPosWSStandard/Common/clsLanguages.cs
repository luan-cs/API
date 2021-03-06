﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.Data;
using System.Collections;
using System.IO;
using System.Web;
using Excel;


namespace VVPosWS.Common
{
    class clsLanguages
    {
        private static string strCulture;
        public static string StrCulture
        {
            get;
            set;
        }
        /// <summary>
        /// Resource Manager
        /// </summary>
        private static ResourceManager rm;
        public static ResourceManager RM
        {
            get
            {
                return rm;
            }
        }

        /// <summary>
        /// Set culture
        /// </summary>
        public static void SetCulture(string strCulture)
        {
            CultureInfo objCI = new CultureInfo(strCulture);
            Thread.CurrentThread.CurrentCulture = objCI;
            Thread.CurrentThread.CurrentUICulture = objCI;

        }

        public static string GetCulture()
        {
            return StrCulture;
        }
        /// <summary>
        /// Set resource
        /// </summary>
        public static void SetResource()
        {
            //rm = ResourceManager.CreateFileBasedResourceManager
            //  ("GrandSpaResource", strResourcesPath, null);
            rm = new ResourceManager("DesktopPOS.Languages.GrandSpaResource", Assembly.GetExecutingAssembly());

        }

        #region convertDataTableToHashTable
        public static Hashtable convertDataTableToHashTable(DataTable dtIn, string keyField, string valueField)
        {
            Hashtable htOut = new Hashtable();
            try
            {
                foreach (DataRow drIn in dtIn.Rows)
                {
                    if (!drIn[keyField].ToString().Equals(""))
                        htOut.Add(drIn[keyField].ToString(), drIn[valueField].ToString());
                }
            }
            catch (Exception ex)
            {
                htOut = null;
            }
            return htOut;
        }
        #endregion

        #region Get Resource
        public static string GetResource(string skey, string Language)
        {
            string sResult = string.Empty;
            //string FileName = "~/Resource/LangResource.xls";
            DataTableCollection dtc = ReadExcelFromURL(@"LangResource.xls");
            Hashtable HasTableLang = new Hashtable();
            try
            {
                int LangId = GetLangIdBySession(Language);
                
                DataTable dtLang = dtc[LangId];
                HasTableLang = convertDataTableToHashTable(dtLang, "Column1", "Column2");
                sResult = (string)HasTableLang[skey];
            }
            catch (Exception ex)
            {
                sResult = null;
            }
            return sResult;
        }
        #endregion

        #region GetLangIdBySession
        public static int GetLangIdBySession(string SessionLang)
        {
            int iResult = 0;
            switch (SessionLang)
            {
                case "vi-VN":
                    iResult = 0;
                    break;

                case "en-US":
                    iResult = 1;
                    break;
                case "ja-JP":
                    iResult = 2;
                    break;
                default:
                    iResult = 0;
                    break;
            }
            return iResult;
        }
        #endregion

        #region ReadExcelFromURL
        public static DataTableCollection ReadExcelFromURL(string FullFileName)
        {
            try
            {

                string path = HttpContext.Current.Server.MapPath("~") + "\\bin\\" + FullFileName;
                string filePath = path;
                Stream data = GetData(filePath);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(data);
                DataSet ds = excelReader.AsDataSet();
                return ds.Tables;
                #region Old Code

                #endregion
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Get Data
        public static Stream GetData(string filePath)
        {
            MemoryStream ms = new MemoryStream();
            //FileStream client = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                using (FileStream fsSource = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int count = 0;
                    do
                    {
                        byte[] buf = new byte[1024];
                        count = fsSource.Read(buf, 0, 1024);
                        ms.Write(buf, 0, count);
                    } while (fsSource.CanRead && count > 0);
                }

            }
            catch
            {

            }
            return ms;
        }
        #endregion


    }
}