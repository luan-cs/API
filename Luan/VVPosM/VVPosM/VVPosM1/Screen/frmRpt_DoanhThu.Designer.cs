namespace VVPosM1.Screen
{
    partial class frmRpt_DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpt_DoanhThu));
            this.lb_FromDate = new System.Windows.Forms.Label();
            this.lb_ToDate = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.rptViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbTatCa = new System.Windows.Forms.CheckBox();
            this.checkThoiGian = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gb_SelectInformation = new System.Windows.Forms.GroupBox();
            this.clbUser = new VVPosM1.Controls.MyListBox();
            this.gb_ReportDetail = new System.Windows.Forms.GroupBox();
            this.gb_SelectInformation.SuspendLayout();
            this.gb_ReportDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_FromDate
            // 
            this.lb_FromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FromDate.Location = new System.Drawing.Point(531, 52);
            this.lb_FromDate.Name = "lb_FromDate";
            this.lb_FromDate.Size = new System.Drawing.Size(96, 21);
            this.lb_FromDate.TabIndex = 2;
            this.lb_FromDate.Text = "Từ ngày";
            this.lb_FromDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_ToDate
            // 
            this.lb_ToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ToDate.Location = new System.Drawing.Point(531, 94);
            this.lb_ToDate.Name = "lb_ToDate";
            this.lb_ToDate.Size = new System.Drawing.Size(96, 21);
            this.lb_ToDate.TabIndex = 99;
            this.lb_ToDate.Text = "Tới ngày";
            this.lb_ToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(633, 49);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(155, 29);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpToiNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToiNgay.Location = new System.Drawing.Point(633, 92);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(155, 29);
            this.dtpToiNgay.TabIndex = 3;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBaoCao.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btnBaoCao.Location = new System.Drawing.Point(839, 55);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(115, 61);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Xem báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // rptViewer1
            // 
            this.rptViewer1.Location = new System.Drawing.Point(6, 19);
            this.rptViewer1.Name = "rptViewer1";
            this.rptViewer1.Size = new System.Drawing.Size(1194, 428);
            this.rptViewer1.TabIndex = 103;
            // 
            // cbTatCa
            // 
            this.cbTatCa.AutoSize = true;
            this.cbTatCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTatCa.Location = new System.Drawing.Point(133, 16);
            this.cbTatCa.Name = "cbTatCa";
            this.cbTatCa.Size = new System.Drawing.Size(69, 25);
            this.cbTatCa.TabIndex = 0;
            this.cbTatCa.Text = "Tất cả";
            this.cbTatCa.UseVisualStyleBackColor = true;
            this.cbTatCa.CheckedChanged += new System.EventHandler(this.cbTatCa_CheckedChanged);
            this.cbTatCa.Click += new System.EventHandler(this.cbTatCa_Click);
            // 
            // checkThoiGian
            // 
            this.checkThoiGian.AutoSize = true;
            this.checkThoiGian.Checked = true;
            this.checkThoiGian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkThoiGian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkThoiGian.Location = new System.Drawing.Point(527, 16);
            this.checkThoiGian.Name = "checkThoiGian";
            this.checkThoiGian.Size = new System.Drawing.Size(94, 25);
            this.checkThoiGian.TabIndex = 104;
            this.checkThoiGian.Text = "Thời gian";
            this.checkThoiGian.UseVisualStyleBackColor = true;
            this.checkThoiGian.CheckedChanged += new System.EventHandler(this.check_change);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnThoat.Location = new System.Drawing.Point(960, 55);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 61);
            this.btnThoat.TabIndex = 105;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gb_SelectInformation
            // 
            this.gb_SelectInformation.Controls.Add(this.clbUser);
            this.gb_SelectInformation.Controls.Add(this.btnThoat);
            this.gb_SelectInformation.Controls.Add(this.lb_FromDate);
            this.gb_SelectInformation.Controls.Add(this.checkThoiGian);
            this.gb_SelectInformation.Controls.Add(this.lb_ToDate);
            this.gb_SelectInformation.Controls.Add(this.cbTatCa);
            this.gb_SelectInformation.Controls.Add(this.dtpTuNgay);
            this.gb_SelectInformation.Controls.Add(this.dtpToiNgay);
            this.gb_SelectInformation.Controls.Add(this.btnBaoCao);
            this.gb_SelectInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_SelectInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SelectInformation.Location = new System.Drawing.Point(0, 0);
            this.gb_SelectInformation.Name = "gb_SelectInformation";
            this.gb_SelectInformation.Size = new System.Drawing.Size(1206, 171);
            this.gb_SelectInformation.TabIndex = 106;
            this.gb_SelectInformation.TabStop = false;
            this.gb_SelectInformation.Text = "Chọn thông tin";
            // 
            // clbUser
            // 
            this.clbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbUser.CheckOnClick = true;
            this.clbUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUser.FormattingEnabled = true;
            this.clbUser.Location = new System.Drawing.Point(224, 15);
            this.clbUser.Name = "clbUser";
            this.clbUser.Size = new System.Drawing.Size(276, 140);
            this.clbUser.TabIndex = 1;
            this.clbUser.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbUser_ItemCheck);
            this.clbUser.SelectedIndexChanged += new System.EventHandler(this.clbUser_SelectedIndexChanged);
            this.clbUser.SelectedValueChanged += new System.EventHandler(this.clbUser_SelectedValueChanged);
            // 
            // gb_ReportDetail
            // 
            this.gb_ReportDetail.Controls.Add(this.rptViewer1);
            this.gb_ReportDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_ReportDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ReportDetail.Location = new System.Drawing.Point(0, 177);
            this.gb_ReportDetail.Name = "gb_ReportDetail";
            this.gb_ReportDetail.Size = new System.Drawing.Size(1206, 484);
            this.gb_ReportDetail.TabIndex = 107;
            this.gb_ReportDetail.TabStop = false;
            this.gb_ReportDetail.Text = "Báo cáo chi tiết";
            // 
            // frmRpt_DoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gb_ReportDetail);
            this.Controls.Add(this.gb_SelectInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRpt_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu của nhân viên";
            this.Load += new System.EventHandler(this.frmRpt_DoanhThu_Load);
            this.gb_SelectInformation.ResumeLayout(false);
            this.gb_SelectInformation.PerformLayout();
            this.gb_ReportDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_FromDate;
        private System.Windows.Forms.Label lb_ToDate;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private System.Windows.Forms.Button btnBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer1;
        //private System.Windows.Forms.CheckedListBox clbUser;
        private VVPosM1.Controls.MyListBox clbUser;
        private System.Windows.Forms.CheckBox cbTatCa;
        private System.Windows.Forms.CheckBox checkThoiGian;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gb_SelectInformation;
        private System.Windows.Forms.GroupBox gb_ReportDetail;
    }
}