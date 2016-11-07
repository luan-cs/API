using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using VVPosM1.Entities;
using System.Threading;
using VVPosM1.Screen;
using System.Security.Cryptography;
using System.Text;

namespace VVPosM1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static VVPosM1.VVPosService.VVPosService destopService = new VVPosM1.VVPosService.VVPosService();
        public static DataTableCollection LangRes = VVPosM1.Common.clsLanguages.ReadExcelFromURL(@"LangResource.xls");
        public static string urlImage = "";
        //  public static Users users = new Users();
        public static Employees1 employee1 = new Employees1();

        public static User user = new User();
        public static Roles roles = new Roles();
        public static string Username = "";
        public static string Password = "";
        public static string RoleId = "";
        public static string ImageUser = "";
        public static string FullName = "";

        public static List<string> lstRole = new List<string>();

        public static string ConvertStringToMD5(string pString)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(pString);

            Byte[] hashedBytes = new MD5CryptoServiceProvider().ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLowerInvariant();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmManageProduct());

        }
    }
}
