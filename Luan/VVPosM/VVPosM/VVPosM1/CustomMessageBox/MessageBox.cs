﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VVPosM1.CustomMessageBox
{
    public partial class MessageBox : Form
    {
        static MessageBox messageBox;
        static DialogResult dialogResult;

        public MessageBox()
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
            messageBox = new MessageBox();
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
            messageBox = new MessageBox();
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
            messageBox = new MessageBox();
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
            messageBox = new MessageBox();
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
            messageBox = new MessageBox();
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
            messageBox = new MessageBox();
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
            dialogResult = DialogResult.Yes;
            messageBox.Dispose();
            messageBox.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.OK;
            messageBox.Dispose();
            messageBox.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            messageBox.Dispose();
            messageBox.Close();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            //btnOK.Text = Common.clsLanguages.RM.GetString("00008");
            //btnAccept.Text = Common.clsLanguages.RM.GetString("00008");
            //btnCancel.Text = Common.clsLanguages.RM.GetString("00009");

            btnOK.Text = Common.clsLanguages.GetResource("Agree");
            btnAccept.Text = Common.clsLanguages.GetResource("Agree");
            btnCancel.Text = Common.clsLanguages.GetResource("Cancel");
        }
    }
}
