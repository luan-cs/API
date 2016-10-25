namespace VVPosM1.Screen
{
    partial class frmRpt_ByProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpt_ByProduct));
            this.gb_SelectInformation = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.lb_SPorNSP = new System.Windows.Forms.Label();
            this.cboLoad = new System.Windows.Forms.ComboBox();
            this.chkGroupProduct = new System.Windows.Forms.CheckBox();
            this.chkProduct = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lb_ToDate = new System.Windows.Forms.Label();
            this.lb_FromDate = new System.Windows.Forms.Label();
            this.gb_ReportDetail = new System.Windows.Forms.GroupBox();
            this.rptViewByProduct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gb_SelectInformation.SuspendLayout();
            this.gb_ReportDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SelectInformation
            // 
            this.gb_SelectInformation.Controls.Add(this.btnThoat);
            this.gb_SelectInformation.Controls.Add(this.btn_ViewReport);
            this.gb_SelectInformation.Controls.Add(this.lb_SPorNSP);
            this.gb_SelectInformation.Controls.Add(this.cboLoad);
            this.gb_SelectInformation.Controls.Add(this.chkGroupProduct);
            this.gb_SelectInformation.Controls.Add(this.chkProduct);
            this.gb_SelectInformation.Controls.Add(this.dtpDenNgay);
            this.gb_SelectInformation.Controls.Add(this.dtpTuNgay);
            this.gb_SelectInformation.Controls.Add(this.lb_ToDate);
            this.gb_SelectInformation.Controls.Add(this.lb_FromDate);
            this.gb_SelectInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_SelectInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SelectInformation.Location = new System.Drawing.Point(0, 0);
            this.gb_SelectInformation.Name = "gb_SelectInformation";
            this.gb_SelectInformation.Size = new System.Drawing.Size(1206, 128);
            this.gb_SelectInformation.TabIndex = 0;
            this.gb_SelectInformation.TabStop = false;
            this.gb_SelectInformation.Text = "Chọn thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnThoat.Location = new System.Drawing.Point(983, 39);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 56);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ViewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ViewReport.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btn_ViewReport.Location = new System.Drawing.Point(866, 39);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(114, 56);
            this.btn_ViewReport.TabIndex = 8;
            this.btn_ViewReport.Text = "Xem báo cáo";
            this.btn_ViewReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ViewReport.UseVisualStyleBackColor = false;
            this.btn_ViewReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_SPorNSP
            // 
            this.lb_SPorNSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SPorNSP.Location = new System.Drawing.Point(553, 33);
            this.lb_SPorNSP.Name = "lb_SPorNSP";
            this.lb_SPorNSP.Size = new System.Drawing.Size(282, 29);
            this.lb_SPorNSP.TabIndex = 7;
            this.lb_SPorNSP.Text = "Sản phẩm/Nhóm sản phẩm";
            this.lb_SPorNSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLoad
            // 
            this.cboLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoad.FormattingEnabled = true;
            this.cboLoad.Location = new System.Drawing.Point(548, 65);
            this.cboLoad.Name = "cboLoad";
            this.cboLoad.Size = new System.Drawing.Size(287, 25);
            this.cboLoad.TabIndex = 6;
            // 
            // chkGroupProduct
            // 
            this.chkGroupProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGroupProduct.Location = new System.Drawing.Point(400, 33);
            this.chkGroupProduct.Name = "chkGroupProduct";
            this.chkGroupProduct.Size = new System.Drawing.Size(138, 29);
            this.chkGroupProduct.TabIndex = 5;
            this.chkGroupProduct.Text = "Nhóm sản phẩm";
            this.chkGroupProduct.UseVisualStyleBackColor = true;
            this.chkGroupProduct.CheckedChanged += new System.EventHandler(this.chk_changeGroup);
            // 
            // chkProduct
            // 
            this.chkProduct.Checked = true;
            this.chkProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProduct.Location = new System.Drawing.Point(401, 67);
            this.chkProduct.Name = "chkProduct";
            this.chkProduct.Size = new System.Drawing.Size(116, 29);
            this.chkProduct.TabIndex = 4;
            this.chkProduct.Text = "Sản phẩm";
            this.chkProduct.UseVisualStyleBackColor = true;
            this.chkProduct.CheckedChanged += new System.EventHandler(this.chk_change);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(241, 67);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(137, 29);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(241, 33);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(137, 29);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // lb_ToDate
            // 
            this.lb_ToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ToDate.Location = new System.Drawing.Point(120, 67);
            this.lb_ToDate.Name = "lb_ToDate";
            this.lb_ToDate.Size = new System.Drawing.Size(108, 29);
            this.lb_ToDate.TabIndex = 1;
            this.lb_ToDate.Text = "Đến ngày";
            this.lb_ToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_FromDate
            // 
            this.lb_FromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FromDate.Location = new System.Drawing.Point(126, 33);
            this.lb_FromDate.Name = "lb_FromDate";
            this.lb_FromDate.Size = new System.Drawing.Size(100, 29);
            this.lb_FromDate.TabIndex = 0;
            this.lb_FromDate.Text = "Từ ngày";
            this.lb_FromDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_ReportDetail
            // 
            this.gb_ReportDetail.Controls.Add(this.rptViewByProduct);
            this.gb_ReportDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_ReportDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ReportDetail.Location = new System.Drawing.Point(0, 134);
            this.gb_ReportDetail.Name = "gb_ReportDetail";
            this.gb_ReportDetail.Size = new System.Drawing.Size(1206, 527);
            this.gb_ReportDetail.TabIndex = 1;
            this.gb_ReportDetail.TabStop = false;
            this.gb_ReportDetail.Text = "Báo cáo chi tiết";
            // 
            // rptViewByProduct
            // 
            this.rptViewByProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewByProduct.Location = new System.Drawing.Point(3, 21);
            this.rptViewByProduct.Name = "rptViewByProduct";
            this.rptViewByProduct.Size = new System.Drawing.Size(1200, 503);
            this.rptViewByProduct.TabIndex = 0;
            // 
            // frmRpt_ByProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gb_ReportDetail);
            this.Controls.Add(this.gb_SelectInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRpt_ByProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo số lượng và doanh thu theo sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_SelectInformation.ResumeLayout(false);
            this.gb_ReportDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SelectInformation;
        private System.Windows.Forms.Label lb_SPorNSP;
        private System.Windows.Forms.ComboBox cboLoad;
        private System.Windows.Forms.CheckBox chkGroupProduct;
        private System.Windows.Forms.CheckBox chkProduct;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lb_ToDate;
        private System.Windows.Forms.Label lb_FromDate;
        private System.Windows.Forms.GroupBox gb_ReportDetail;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewByProduct;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Button btnThoat;
    }
}