using VVPosM1.CRM;
namespace VVPosM1.Screen.CRM.Promotions
{
    partial class frmSendMailPromotion1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMailPromotion1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbfailList = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.txtFailList = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbInformationSearch = new System.Windows.Forms.GroupBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtToCC = new System.Windows.Forms.TextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblToCC = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.htmlEditorControl1 = new VVPosM1.Screen.CRM.HtmlEditorControl();
            this.panel2.SuspendLayout();
            this.gbInformationSearch.SuspendLayout();
            this.gbInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbfailList);
            this.panel2.Controls.Add(this.lblTB);
            this.panel2.Controls.Add(this.txtFailList);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.gbInformationSearch);
            this.panel2.Controls.Add(this.gbInformation);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 728);
            this.panel2.TabIndex = 27;
            // 
            // lbfailList
            // 
            this.lbfailList.AutoSize = true;
            this.lbfailList.Location = new System.Drawing.Point(32, 647);
            this.lbfailList.Name = "lbfailList";
            this.lbfailList.Size = new System.Drawing.Size(137, 20);
            this.lbfailList.TabIndex = 33;
            this.lbfailList.Text = "Danh sách mail lỗi";
            // 
            // lblTB
            // 
            this.lblTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTB.Location = new System.Drawing.Point(29, 623);
            this.lblTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(283, 22);
            this.lblTB.TabIndex = 31;
            this.lblTB.Text = "--";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFailList
            // 
            this.txtFailList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFailList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFailList.Location = new System.Drawing.Point(202, 648);
            this.txtFailList.Multiline = true;
            this.txtFailList.Name = "txtFailList";
            this.txtFailList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFailList.Size = new System.Drawing.Size(756, 76);
            this.txtFailList.TabIndex = 32;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 601);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(933, 22);
            this.progressBar1.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblTitle.Location = new System.Drawing.Point(31, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 47);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Gửi Mail";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbInformationSearch
            // 
            this.gbInformationSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInformationSearch.Controls.Add(this.btnSendMail);
            this.gbInformationSearch.Controls.Add(this.btnAttach);
            this.gbInformationSearch.Controls.Add(this.txtAttachment);
            this.gbInformationSearch.Controls.Add(this.txtSubject);
            this.gbInformationSearch.Controls.Add(this.txtToCC);
            this.gbInformationSearch.Controls.Add(this.lblAttachment);
            this.gbInformationSearch.Controls.Add(this.txtTo);
            this.gbInformationSearch.Controls.Add(this.lblSubject);
            this.gbInformationSearch.Controls.Add(this.lblToCC);
            this.gbInformationSearch.Controls.Add(this.lblTo);
            this.gbInformationSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationSearch.Location = new System.Drawing.Point(25, 71);
            this.gbInformationSearch.Name = "gbInformationSearch";
            this.gbInformationSearch.Size = new System.Drawing.Size(936, 215);
            this.gbInformationSearch.TabIndex = 30;
            this.gbInformationSearch.TabStop = false;
            this.gbInformationSearch.Text = "Thông tin người nhận mail";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Image = global::VVPosM1.Properties.Resources.mail59;
            this.btnSendMail.Location = new System.Drawing.Point(13, 37);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(83, 94);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Gửi";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Image = global::VVPosM1.Properties.Resources.attachment7;
            this.btnAttach.Location = new System.Drawing.Point(896, 169);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(33, 28);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // txtAttachment
            // 
            this.txtAttachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAttachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttachment.Location = new System.Drawing.Point(202, 170);
            this.txtAttachment.Multiline = true;
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAttachment.Size = new System.Drawing.Size(689, 26);
            this.txtAttachment.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Location = new System.Drawing.Point(202, 138);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubject.Size = new System.Drawing.Size(689, 26);
            this.txtSubject.TabIndex = 4;
            // 
            // txtToCC
            // 
            this.txtToCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtToCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToCC.Location = new System.Drawing.Point(202, 105);
            this.txtToCC.Multiline = true;
            this.txtToCC.Name = "txtToCC";
            this.txtToCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToCC.Size = new System.Drawing.Size(689, 26);
            this.txtToCC.TabIndex = 3;
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(102, 178);
            this.lblAttachment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(77, 21);
            this.lblAttachment.TabIndex = 6;
            this.lblAttachment.Text = "Đính kèm";
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTo.Location = new System.Drawing.Point(202, 33);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTo.Size = new System.Drawing.Size(689, 64);
            this.txtTo.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(102, 143);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(62, 21);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Chủ đề:";
            // 
            // lblToCC
            // 
            this.lblToCC.AutoSize = true;
            this.lblToCC.Location = new System.Drawing.Point(102, 108);
            this.lblToCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToCC.Name = "lblToCC";
            this.lblToCC.Size = new System.Drawing.Size(36, 21);
            this.lblToCC.TabIndex = 6;
            this.lblToCC.Text = "Bcc:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(102, 34);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(89, 21);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "Thành viên:";
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.htmlEditorControl1);
            this.gbInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformation.Location = new System.Drawing.Point(25, 303);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(936, 294);
            this.gbInformation.TabIndex = 0;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Nội dung chi tiết";
            // 
            // htmlEditorControl1
            // 
            this.htmlEditorControl1.BodyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.htmlEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditorControl1.InnerText = null;
            this.htmlEditorControl1.Location = new System.Drawing.Point(3, 25);
            this.htmlEditorControl1.Name = "htmlEditorControl1";
            this.htmlEditorControl1.Size = new System.Drawing.Size(930, 266);
            this.htmlEditorControl1.TabIndex = 6;
            // 
            // frmSendMailPromotion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 732);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendMailPromotion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSendMailPromotion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbInformationSearch.ResumeLayout(false);
            this.gbInformationSearch.PerformLayout();
            this.gbInformation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbInformation;
        private HtmlEditorControl htmlEditorControl1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbInformationSearch;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtToCC;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblToCC;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.TextBox txtFailList;
        private System.Windows.Forms.Label lbfailList;

    }
}