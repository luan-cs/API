using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Common
{
    class TotalHour
    {
        /// <summary>
        /// Điệp for frmUpdateWorking
        /// </summary>
        /// <param name="pBegin"></param>
        /// <param name="pEnd"></param>
        /// <returns></returns>
        public static decimal TotalHourWork(string pBegin, string pEnd)
        {
            decimal kq = 0;
            if (string.IsNullOrEmpty(pEnd))
            {
                return kq;
            }
            else
            {
                string[] array1, array2 = new string[2];
                array1 = pBegin.Split(new char[] { ':' });
                array2 = pEnd.Split(new char[] { ':' });
                
                int pHour1 = int.Parse(array1[0].ToString());
                           
                int pHour2 = int.Parse(array2[0]);
                int pMin1 = int.Parse(array1[1]);
                int pMin2 = int.Parse(array2[1]);
               
                //if (pHour1 > 0 && (pHour2==0 && pMin2 == 0))
                //{
                //    pHour2 = 24;
                //    pMin2 = 59;
                //}
                decimal pTotalMin = (pHour2 * 60 + pMin2) - (pHour1 * 60 + pMin1);
                kq = Math.Round(pTotalMin / 60, 2);

            }
            return kq;

        }

        public static decimal GetHourFromTime(string strTime)
        {
            decimal kq = 0;
            string[] arr;
            arr = strTime.Split(':');
            kq = Math.Round((decimal)(Int32.Parse(arr[0]) * 60 + Int32.Parse(arr[1])) / 60, 2);
            return kq;
        }

        // <summary>
        /// Lấy ra ngày đầu tiên trong tháng có chứa 
        /// 1 ngày bất kỳ được truyền vào
        /// </summary>
        /// <param name="dtDate">Ngày nhập vào</param>
        /// <returns>Ngày đầu tiên trong tháng</returns>
        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        /// <summary>
        /// Lấy ra ngày cuối cùng trong tháng có chứa 
        /// 1 ngày bất kỳ được truyền vào
        /// </summary>
        /// <param name="dtInput">Ngày nhập vào</param>
        /// <returns>Ngày cuối cùng trong tháng</returns>
        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }

    }

}
