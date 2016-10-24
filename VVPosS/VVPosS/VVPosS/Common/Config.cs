using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Configuration;
using System.IO;
using System.Windows.Forms;


namespace VVPosS.Common
{
    public static class Config
    {
        public static string LANGUAGE_PRINT_ORDER = ConfigurationManager.AppSettings["LANGUAGE_PRINT_ORDER"].ToString();
        public const string LANGUAGE_VI = "vi-VN";
        public const string LANGUAGE_EN = "en-US";
        public const string LANGUAGE_JA = "ja-JP";
        /// <summary>
        /// Max score to VIP Member
        /// </summary>
        public const int MAX_VIP = 1500;
        /// <summary>
        /// Separator product coupon in promotion
        /// </summary>
        public static char SEPARATOR = ',';
        /// <summary>
        /// Unit marks of members
        /// </summary>
        public static int unitScore = 10000;

        /// <summary>
        ///size of picture that resize before save into database
        /// </summary>
        public static int pWidth = 200;
        public static int pHeight = 133;

        /// <summary>
        /// Number copies of receipt print
        /// </summary>
        public static int NUMBER_PRINT_PAGE_COPY = Int32.Parse(ConfigurationManager.AppSettings["NUMBER_PRINT_PAGE_COPY"].ToString());

        /// <summary>
        /// Default vi-VN
        /// </summary>
        public static string CULTURE_NAME = "vi-VN";

        /// <summary>
        /// Status of bracelet
        /// </summary>
        public enum STATUSBRACELET
        {
            UnusedStatus = 1,
            UsedStatus,
            LossStaus
        }

        /// <summary>
        /// Custom MessageBox Button
        /// </summary>
        public enum CUSTOM_MESSAGEBOX_BUTTON
        {
            OK,
            YESNO,
            YESNOCANCEL
        }

        /// <summary>
        /// Custom MessageBox Icon
        /// </summary>
        public enum CUSTOM_MESSAGEBOX_ICON
        {
            Information,
            Error,
            Warning
        }

        /// <summary>
        /// Define background color
        /// </summary>
        public static string BACKGROUNDCOLOR = "#916F5D";

        /// <summary>
        /// Define FORECOLOR
        /// </summary>
        public static string FORECOLOR = ConfigurationManager.AppSettings["FORECOLOR"];

        /// <summary>
        /// Define title color
        /// </summary>
        public static string TITLECOLORWHILE = "#ffffff";

        /// <summary>
        /// Define title color
        /// </summary>
        public static string TITLECOLOR = "#C2B49A";

        /// <summary>
        /// Define color of text
        /// </summary>
        public static string TEXTCOLOR = "#000000";

        /// <summary>
        /// Define color of label
        /// </summary>
        public static string LABELCOLOR = ConfigurationManager.AppSettings["LABEL_TITLE_COLOR"];

        /// <summary>
        /// Define color of text button
        /// </summary>
        public static string TEXTBUTTONCOLOR = "#000000";

        /// <summary>
        /// Define background image 
        /// </summary>
        public static Image BACKGROUNDIMAGE = Properties.Resources.backgroud;

        //static string a = Path.GetDirectoryName(Application.ExecutablePath) + "";
        //static Image i = (Image)new Bitmap("a");
        /// <summary>
        /// Logo application
        /// </summary>
        //public static Image LOGO = Properties.Resources.logoVVNeew;
        /// <summary>
        /// Define font style for group box
        /// </summary>
        public static FontStyle FONTSTYLEGROUPBOX = FontStyle.Bold;

        /// <summary>
        /// Define color for title group box
        /// </summary>
        public static string TITLEGROUPBOXCOLOR = ConfigurationManager.AppSettings["TITLE_GROUPBOX_COLOR"];

        /// <summary>
        /// Define font size for title group box
        /// </summary>
        public static float FONTSIZEGROUPBOX = 14.0F;

        /// <summary>
        /// Define color for result check to cancel order
        /// </summary>
        public static string RESULTCHECKCOLOR = "#FF0000";

        /// <summary>
        /// Define background color for listcheckbox
        /// </summary>
        public static string LISTCHECKBOXBACKGROUNDCOLOR = "#916F5D";

        /// <summary>
        /// Define color for listcheckbox
        /// </summary>
        public static string LISTCHECKBOXCOLOR = "#000000";

        /// <summary>
        /// Define color for require fields
        /// </summary>
        public static string REQUIRECOLOR = "#FF0000";

        //Define score change money
        public static string pSOCRE = ConfigurationManager.AppSettings["pSCORE"].ToString();
        public static string pMONEY = ConfigurationManager.AppSettings["pMONEY"].ToString();
    }
}
