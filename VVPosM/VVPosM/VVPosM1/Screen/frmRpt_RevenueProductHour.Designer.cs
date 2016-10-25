namespace VVPosM1.Screen
{
    partial class frmRpt_RevenueProductHour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpt_RevenueProductHour));
            this.gb_SelectInformation = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboLoad = new System.Windows.Forms.ComboBox();
            this.chkNhomSanPham = new System.Windows.Forms.CheckBox();
            this.chkSanPham = new System.Windows.Forms.CheckBox();
            this.btn_ReportView = new System.Windows.Forms.Button();
            this.lb_ToDate = new System.Windows.Forms.Label();
            this.lb_FromDate = new System.Windows.Forms.Label();
            this.dptToiNgay = new System.Windows.Forms.DateTimePicker();
            this.dptTuNgay = new System.Windows.Forms.DateTimePicker();
            this.gb_ReportDetail = new System.Windows.Forms.GroupBox();
            this.rptViewHour = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gb_SelectInformation.SuspendLayout();
            this.gb_ReportDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SelectInformation
            // 
            this.gb_SelectInformation.Controls.Add(this.btnThoat);
            this.gb_SelectInformation.Controls.Add(this.cboLoad);
            this.gb_SelectInformation.Controls.Add(this.chkNhomSanPham);
            this.gb_SelectInformation.Controls.Add(this.chkSanPham);
            this.gb_SelectInformation.Controls.Add(this.btn_ReportView);
            this.gb_SelectInformation.Controls.Add(this.lb_ToDate);
            this.gb_SelectInformation.Controls.Add(this.lb_FromDate);
            this.gb_SelectInformation.Controls.Add(this.dptToiNgay);
            this.gb_SelectInformation.Controls.Add(this.dptTuNgay);
            this.gb_SelectInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_SelectInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SelectInformation.Location = new System.Drawing.Point(0, 0);
            this.gb_SelectInformation.Name = "gb_SelectInformation";
            this.gb_SelectInformation.Size = new System.Drawing.Size(1205, 97);
            this.gb_SelectInformation.TabIndex = 0;
            this.gb_SelectInformation.TabStop = false;
            this.gb_SelectInformation.Text = "Chọn thời gian";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnThoat.Location = new System.Drawing.Point(939, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 50);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboLoad
            // 
            this.cboLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoad.FormattingEnabled = true;
            this.cboLoad.Location = new System.Drawing.Point(426, 52);
            this.cboLoad.Name = "cboLoad";
            this.cboLoad.Size = new System.Drawing.Size(350, 25);
            this.cboLoad.TabIndex = 9;
            // 
            // chkNhomSanPham
            // 
            this.chkNhomSanPham.AutoSize = true;
            this.chkNhomSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNhomSanPham.Location = new System.Drawing.Point(631, 19);
            this.chkNhomSanPham.Name = "chkNhomSanPham";
            this.chkNhomSanPham.Size = new System.Drawing.Size(145, 25);
            this.chkNhomSanPham.TabIndex = 8;
            this.chkNhomSanPham.Text = "Nhóm sản phẩm";
            this.chkNhomSanPham.UseVisualStyleBackColor = true;
            this.chkNhomSanPham.CheckedChanged += new System.EventHandler(this.chk_changeGroup);
            // 
            // chkSanPham
            // 
            this.chkSanPham.AutoSize = true;
            this.chkSanPham.Checked = true;
            this.chkSanPham.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSanPham.Location = new System.Drawing.Point(428, 19);
            this.chkSanPham.Name = "chkSanPham";
            this.chkSanPham.Size = new System.Drawing.Size(99, 25);
            this.chkSanPham.TabIndex = 7;
            this.chkSanPham.Text = "Sản phẩm";
            this.chkSanPham.UseVisualStyleBackColor = true;
            this.chkSanPham.CheckedChanged += new System.EventHandler(this.chk_change);
            // 
            // btn_ReportView
            // 
            this.btn_ReportView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ReportView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReportView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ReportView.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btn_ReportView.Location = new System.Drawing.Point(831, 23);
            this.btn_ReportView.Name = "btn_ReportView";
            this.btn_ReportView.Size = new System.Drawing.Size(105, 50);
            this.btn_ReportView.TabIndex = 6;
            this.btn_ReportView.Text = "Xem báo cáo";
            this.btn_ReportView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ReportView.UseVisualStyleBackColor = false;
            this.btn_ReportView.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lb_ToDate
            // 
            this.lb_ToDate.AutoSize = true;
            this.lb_ToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ToDate.Location = new System.Drawing.Point(155, 56);
            this.lb_ToDate.Name = "lb_ToDate";
            this.lb_ToDate.Size = new System.Drawing.Size(70, 21);
            this.lb_ToDate.TabIndex = 3;
            this.lb_ToDate.Text = "Tới ngày";
            this.lb_ToDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_FromDate
            // 
            this.lb_FromDate.AutoSize = true;
            this.lb_FromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FromDate.Location = new System.Drawing.Point(156, 17);
            this.lb_FromDate.Name = "lb_FromDate";
            this.lb_FromDate.Size = new System.Drawing.Size(65, 21);
            this.lb_FromDate.TabIndex = 2;
            this.lb_FromDate.Text = "Từ ngày";
            // 
            // dptToiNgay
            // 
            this.dptToiNgay.CustomFormat = "dd/MM/yyyy";
            this.dptToiNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptToiNgay.Location = new System.Drawing.Point(239, 53);
            this.dptToiNgay.Name = "dptToiNgay";
            this.dptToiNgay.Size = new System.Drawing.Size(136, 29);
            this.dptToiNgay.TabIndex = 1;
            // 
            // dptTuNgay
            // 
            this.dptTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dptTuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptTuNgay.Location = new System.Drawing.Point(239, 14);
            this.dptTuNgay.Name = "dptTuNgay";
            this.dptTuNgay.Size = new System.Drawing.Size(136, 29);
            this.dptTuNgay.TabIndex = 0;
            // 
            // gb_ReportDetail
            // 
            this.gb_ReportDetail.Controls.Add(this.rptViewHour);
            this.gb_ReportDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_ReportDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ReportDetail.Location = new System.Drawing.Point(0, 97);
            this.gb_ReportDetail.Name = "gb_ReportDetail";
            this.gb_ReportDetail.Size = new System.Drawing.Size(1205, 552);
            this.gb_ReportDetail.TabIndex = 1;
            this.gb_ReportDetail.TabStop = false;
            this.gb_ReportDetail.Text = "Chi tiết báo cáo doanh thu";
            // 
            // rptViewHour
            // 
            this.rptViewHour.AutoScroll = true;
            this.rptViewHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewHour.Location = new System.Drawing.Point(3, 21);
            this.rptViewHour.Name = "rptViewHour";
            this.rptViewHour.Size = new System.Drawing.Size(1199, 528);
            this.rptViewHour.TabIndex = 0;
            this.rptViewHour.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmRpt_RevenueProductHour
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1205, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gb_ReportDetail);
            this.Controls.Add(this.gb_SelectInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRpt_RevenueProductHour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu theo múi giờ";
            this.Load += new System.EventHandler(this.frmRpt_RevenueSevicesHour_Load);
            this.gb_SelectInformation.ResumeLayout(false);
            this.gb_SelectInformation.PerformLayout();
            this.gb_ReportDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SelectInformation;
        private System.Windows.Forms.Label lb_ToDate;
        private System.Windows.Forms.Label lb_FromDate;
        private System.Windows.Forms.DateTimePicker dptToiNgay;
        private System.Windows.Forms.DateTimePicker dptTuNgay;
        private System.Windows.Forms.GroupBox gb_ReportDetail;
        private System.Windows.Forms.Button btn_ReportView;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewHour;
        private System.Windows.Forms.CheckBox chkNhomSanPham;
        private System.Windows.Forms.CheckBox chkSanPham;
        private System.Windows.Forms.ComboBox cboLoad;
        private System.Windows.Forms.Button btnThoat;
    }
}