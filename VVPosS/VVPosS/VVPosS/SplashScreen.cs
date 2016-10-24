using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VVPosS
{
    public partial class SplashScreen : Form
    {
        delegate void StringParameterDelegate(string Text);
        delegate void StringParameterWithStatusDelegate(string Text, Entities.TypeOfMessage tom);
        delegate void SplashShowCloseDelegate();
        /// <summary>
        /// To ensure splash screen is closed using the API and not by keyboard or any other things
        /// </summary>
        bool CloseSplashScreenFlag = false;

        public SplashScreen()
        {
            InitializeComponent();
            progressBar1.Show();
        }

        /// <summary>
        /// Displays the splashscreen
        /// </summary>
        public void ShowSplashScreen()
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new SplashShowCloseDelegate(ShowSplashScreen));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        /// <summary>
        /// Closes the SplashScreen
        /// </summary>
        public void CloseSplashScreen()
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new SplashShowCloseDelegate(CloseSplashScreen));
                return;
            }
            CloseSplashScreenFlag = true;
            this.Close();
        }

        /// <summary>
        /// Update text in default green color of success message
        /// </summary>
        /// <param name="Text">Message</param>
        public void UdpateStatusText(string Text)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterDelegate(UdpateStatusText), new object[] { Text });
                return;
            }
            // Must be on the UI thread if we've got this far
            lblInfor.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C2B49A");
            lblInfor.Text = Text;
        }


        /// <summary>
        /// Update text with message color defined as green/yellow/red/ for success/warning/failure
        /// </summary>
        /// <param name="Text">Message</param>
        /// <param name="tom">Type of Message</param>
        public void UdpateStatusTextWithStatus(string Text, Entities.TypeOfMessage tom)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterWithStatusDelegate(UdpateStatusTextWithStatus), new object[] { Text, tom });
                return;
            }
            // Must be on the UI thread if we've got this far
            switch (tom)
            {
                case Entities.TypeOfMessage.Error:
                    lblInfor.ForeColor = Color.Red;
                    break;
                case Entities.TypeOfMessage.Warning:
                    lblInfor.ForeColor = Color.Yellow;
                    break;
                case Entities.TypeOfMessage.Success:
                    lblInfor.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C2B49A");
                    break;
            }
            lblInfor.Text = Text;

        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseSplashScreenFlag == false)
                e.Cancel = true;
        }

        private void SplashScreen_Paint(object sender, PaintEventArgs e)
        {
            //Form frm = (Form)sender;
            ////float conner = 30;
            //System.Drawing.Drawing2D.GraphicsPath frmPath = new System.Drawing.Drawing2D.GraphicsPath();
            //// Set a new rectangle to the same size as the button's 
            //// ClientRectangle property.
            //System.Drawing.Rectangle newRectangle = frm.ClientRectangle;
            //ControlPaint.DrawBorder(e.Graphics, newRectangle,
            //    System.Drawing.ColorTranslator.FromHtml("#916F5D"), 10, ButtonBorderStyle.Outset,
            //    System.Drawing.ColorTranslator.FromHtml("#916F5D"), 10, ButtonBorderStyle.Outset,
            //    System.Drawing.ColorTranslator.FromHtml("#916F5D"), 10, ButtonBorderStyle.Inset,
            //    System.Drawing.ColorTranslator.FromHtml("#916F5D"), 10, ButtonBorderStyle.Inset);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
