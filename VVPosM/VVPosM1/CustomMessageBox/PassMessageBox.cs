using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VVPosM1.CustomMessageBox
{
    public partial class PassMessageBox : Form
    {
        static PassMessageBox messageBox;
        static DialogResult dialogResult;

        public PassMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show custom MessageBox with title
        /// </summary>
        /// <param name="title">Title of message box</param>
        /// <returns></returns>
        public static DialogResult ShowCustomMessageBox(string title)
        {
            messageBox = new PassMessageBox();
            messageBox.lblTitle.Text = title;
            messageBox.ShowDialog();
            messageBox.btnOK.Visible = false;
            return dialogResult;
        }

        /// <summary>
        /// Show custom MessageBox with title, messageButton
        /// </summary>
        /// <param name="title"></param>
        /// <param name="messageButton"></param>
        /// <returns></returns>
        public static DialogResult ShowCustomMessageBox(string title, Common.Config.CUSTOM_MESSAGEBOX_BUTTON messageButton)
        {
            messageBox = new PassMessageBox();
            messageBox.lblTitle.Text = title;
            if (messageButton.Equals(Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK))
            {
                messageBox.btnAccept.Visible = false;
                messageBox.btnCancel.Visible = false;
                messageBox.btnOK.Location = messageBox.btnCancel.Location;
            }
            if (messageButton.Equals(Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO))
            {
                messageBox.btnOK.Visible = false;
            }
            messageBox.ShowDialog();
            return dialogResult;
        }

        /// <summary>
        /// Show custom MessageBox with message and title
        /// </summary>
        /// <param name="message">Message of message box</param>
        /// <param name="title">Title of message box</param>
        /// <returns></returns>
        public static DialogResult ShowCustomMessageBox(string message, string title)
        {
            messageBox = new PassMessageBox();
            messageBox.lblMessage.Text = message;
            messageBox.lblTitle.Text = title;
            messageBox.btnOK.Visible = false;
            messageBox.ShowDialog();
            return dialogResult;
        }

        /// <summary>
        /// Show custom MessageBox with message, title and icon
        /// </summary>
        /// <param name="message">Message of message box</param>
        /// <param name="title">Title of message box</param>
        /// <param name="icon">Icon of message box</param>
        /// <returns></returns>
        public static DialogResult ShowCustomMessageBox(string message, string title, Common.Config.CUSTOM_MESSAGEBOX_ICON icon)
        {
            messageBox = new PassMessageBox();
            messageBox.lblMessage.Text = message;
            messageBox.lblTitle.Text = title;
            if (icon == Common.Config.CUSTOM_MESSAGEBOX_ICON.Information)
            {
                messageBox.pbIcon.BackgroundImage = Properties.Resources.information;
            }
            if (icon == Common.Config.CUSTOM_MESSAGEBOX_ICON.Error)
            {
                messageBox.pbIcon.BackgroundImage = Properties.Resources.thoat;
            }
            messageBox.btnOK.Visible = false;
            messageBox.ShowDialog();
            return dialogResult;
        }

        /// <summary>
        /// Show custom MessageBox with message, title, icon, button
        /// </summary>
        /// <param name="message">Message of message box</param>
        /// <param name="title">Title of message box</param>
        /// <param name="icon">Icon of message box</param>
        /// <param name="messageBoxButton">Button that show in message box</param>
        /// <returns></returns>
        public static DialogResult ShowCustomMessageBox(string message, string title, Common.Config.CUSTOM_MESSAGEBOX_ICON icon, Common.Config.CUSTOM_MESSAGEBOX_BUTTON messageBoxButton)
        {
            messageBox = new PassMessageBox();
            messageBox.lblMessage.Text = message;
            messageBox.lblTitle.Text = title;
            if (icon == Common.Config.CUSTOM_MESSAGEBOX_ICON.Information)
            {
                messageBox.pbIcon.BackgroundImage = Properties.Resources.information;
            }
            if (icon == Common.Config.CUSTOM_MESSAGEBOX_ICON.Error)
            {
                messageBox.pbIcon.BackgroundImage = Properties.Resources.thoat;
            }
            if (messageBoxButton.Equals(Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK))
            {
                messageBox.btnCancel.Visible = false;
                messageBox.btnAccept.Visible = false;
                messageBox.btnOK.Location = messageBox.btnCancel.Location;
            }
            if (messageBoxButton.Equals(Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO))
            {
                messageBox.btnOK.Visible = false;
            }
            messageBox.ShowDialog();
            return dialogResult;
        }

        /// <summary>
        /// Show custom MessageBox with message , title, button
        /// </summary>
        /// <param name="message">Message of message box</param>
        /// <param name="title">Title of message box</param>
        /// <param name="messageBoxButton">Button of message box</param>
        /// <returns></returns>
        public static DialogResult ShowCustomMessageBox(string message, string title, Common.Config.CUSTOM_MESSAGEBOX_BUTTON messageBoxButton)
        {
            messageBox = new PassMessageBox();
            messageBox.lblMessage.Text = message;
            messageBox.lblTitle.Text = title;
            if (messageBoxButton.Equals(Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK))
            {
                messageBox.btnCancel.Visible = false;
                messageBox.btnAccept.Visible = false;
                messageBox.btnOK.Location = messageBox.btnCancel.Location;
            }
            if (messageBoxButton.Equals(Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO))
            {
                messageBox.btnOK.Visible = false;
            }
            messageBox.ShowDialog();
            return dialogResult;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // check pass
            if (CheckCurrentPass() == true)
            {
                dialogResult = DialogResult.Yes;
                messageBox.Dispose();
            }
            else
            {
                lblMessage.Text = Common.clsLanguages.GetResource("CRM591");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // check pass
            if (CheckCurrentPass() == true)
            {
                dialogResult = DialogResult.OK;
                messageBox.Dispose();
            }
            else
            {
                lblMessage.Text = Common.clsLanguages.GetResource("CRM591");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            messageBox.Dispose();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            btnOK.Text = Common.clsLanguages.GetResource("CRM8");
            btnAccept.Text = Common.clsLanguages.GetResource("CRM8");
            btnCancel.Text = Common.clsLanguages.GetResource("CRM9");
        }

        private bool CheckCurrentPass()
        {
            bool res = false;
            string pas = txtPass.Text;
            string passMD5 = Program.ConvertStringToMD5(pas);
            if (passMD5 == Program.employee1.Password)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
