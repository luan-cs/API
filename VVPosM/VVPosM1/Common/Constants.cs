using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Common
{
    internal static class Constants
    {
        public const string EMPLOYEE_TYPE_GET_LIST = "SELECT * FROM employee_types";
        internal static readonly byte[] CRYPTO_ENTROPY = System.Text.Encoding.Unicode.GetBytes("Welcome Nghi Ho");
    }
}
