using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosS.Entities;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Data;
using System.Net;
using System.Threading;
using System.Configuration;

namespace VVPosS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        public static VVPosS.VVPosService.VVPosService destopService = new VVPosS.VVPosService.VVPosService();
        //public static DataTableCollection LangRes = VVPosS.Common.clsLanguages.ReadExcelFromURL(@"../../Res/LangResource.xls");
        public static DataTableCollection LangRes = VVPosS.Common.clsLanguages.ReadExcelFromURL(@"LangResource.xls");
        public static string urlImage = "";
        public static Users users = new Users();
        public static Roles roles = new Roles();
        public static string Username = "";
        public static string Password = "";
        public static string RoleId = "";
        public static string ImageUser = "";
        public static string FullName = "";
        public static string LastLogin = "";
        public static string LastModified = "";
        public static string PaperSizeName = ConfigurationManager.AppSettings["PaperSizeName"];
        public static List<string> lstRole = new List<string>();
        public static List<OrderObject> lstTemp=new List<OrderObject>();
        public static OrderObject lstTempOrder = new OrderObject();
        public static List<OrderDetails> lstOrderDetail = new List<OrderDetails>();

        //Receipt
        public static List<ReceiptsCard> lstCard = null;
        public static ReceiptMember rep_mb = null;
        public static ReceiptInfo rep_info = null;
        public static OrderDetails od_sua = null;

        //Variables App Config
        public static int Vat = int.Parse(ConfigurationManager.AppSettings["VAT"]);
        public static int IsRestaurant = int.Parse(ConfigurationManager.AppSettings["IsRestaurant"]);

        public static string ConvertStringToMD5(string pString)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(pString);

            Byte[] hashedBytes = new MD5CryptoServiceProvider().ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLowerInvariant();
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
