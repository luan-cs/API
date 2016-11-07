using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VVPosM1.Common
{
    class Validation
    {
        /// <summary>
        /// Validate phone number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber,@"^(\+)?[0-9\(\)\{\}\-\.| ]{1,31}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///<sumary>
        ///Validate website
        ///</sumary>
        public static bool ValidateWebsite(string url)
        {
            return Regex.IsMatch(url, @"(\S)+\.(\S)+$");
        }
        /// <summary>
        /// Validate email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate birth date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool ValidateBirthDate(DateTime date)
        {
            string year = date.ToString("yyyy");
            int intYear = Int32.Parse(year);
            if (Int32.Parse(DateTime.Now.ToString("yyyy")) - intYear >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// validate member number
        /// </summary>
        /// <param name="memberNumber"></param>
        /// <returns></returns>
        public static bool ValidateMemberNumber(string memberNumber)
        {
            if (Regex.IsMatch(memberNumber, @"^[0-9]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// validate bracelet number
        /// </summary>
        /// <param name="braceletNumber"></param>
        /// <returns></returns>
        public static bool ValidateBraceletNumber(string braceletNumber)
        {
            if (Regex.IsMatch(braceletNumber, @"^[0-9]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool ValidateNumber(string number)
        {
            if (Regex.IsMatch(number,@"^[0-9]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// for CustomType
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static bool ValidateCustomerType(string pID, string pValue)
        {
            if (pID.Contains(pValue) && pID.IndexOf(pValue) != 0 && pID.LastIndexOf(pValue) != pID.Length - 1)
            {
                return true;
            }
            else
            { return false; }
        }

        /// <summary>
        /// for frmUpdateWorking
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static bool ValidateHour_UpdateWorking(string pValue)
        {
            bool kq = false;
            string[] pArr = new string[2];
            pArr = pValue.Split(':');
            if (pArr[0] != "" || !string.IsNullOrEmpty(pArr[0]))
            {
                int pHour1 = int.Parse(string.IsNullOrEmpty(pArr[0])? "0": pArr[0].ToString());
                int pHour2 = int.Parse(string.IsNullOrEmpty(pArr[1])? "0": pArr[1].ToString());
                if (pHour1 < 24 && pHour2 < 60)
                {
                   kq= true;
                }               
            }
            return kq;
           
        }
        /// <summary>
        /// for 2Hour frmUpdateWorking
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static bool ValidateHour2Then_UpdateWorking(string pValue, string pValue2)
        {
            bool kq = false;
            string[] pArr = new string[2];
            string[] pArr2 = new string[2];
            pArr = pValue.Split(':');
            pArr2 = pValue2.Split(':');
            int pHour1 = int.Parse(string.IsNullOrEmpty(pArr[0]) ? "0" : pArr[0].ToString());
            int pHour2 = int.Parse(string.IsNullOrEmpty(pArr[1]) ? "0" : pArr[1].ToString());
            int pHour3 = int.Parse(string.IsNullOrEmpty(pArr2[0]) ? "0" : pArr2[0].ToString());
            int pHour4 = int.Parse(string.IsNullOrEmpty(pArr2[1]) ? "0" : pArr2[1].ToString());
            
            if (pHour1 > 0 && (pHour3 == 0 && pHour4 == 0))
            {
                //pHour3 = 24;
                //pHour4 = 59;
                kq = false;
            }
            if ((pHour1 < pHour3) || (pHour1 == pHour3 && pHour2 <= pHour4))
            {
                kq = true;
            }
            return kq;
        }
    }
}
