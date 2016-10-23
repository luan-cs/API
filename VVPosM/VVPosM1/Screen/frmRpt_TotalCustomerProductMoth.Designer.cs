namespace VVPosM1.Screen
{
    partial class frmRpt_TotalCustomerProductMoth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpt_TotalCustomerProductMoth));
            this.gb_SelectInformation = new System.Windows.Forms.GroupBox();
            this.cboLoad = new System.Windows.Forms.ComboBox();
            this.chkNhomSanPham = new System.Windows.Forms.CheckBox();
            this.chkSanPham = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemBC = new System.Windows.Forms.Button();
            this.lb_MonthYear = new System.Windows.Forms.Label();
            this.dptThangNam = new System.Windows.Forms.DateTimePicker();
            this.gb_ReportDetail = new System.Windows.Forms.GroupBox();
            this.rptViewTotalCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gb_SelectInformation.SuspendLayout();
            this.gb_ReportDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SelectInformation
            // 
            this.gb_SelectInformation.Controls.Add(this.cboLoad);
            this.gb_SelectInformation.Controls.Add(this.chkNhomSanPham);
            this.gb_SelectInformation.Controls.Add(this.chkSanPham);
            this.gb_SelectInformation.Controls.Add(this.btnThoat);
            this.gb_SelectInformation.Controls.Add(this.btnXemBC);
            this.gb_SelectInformation.Controls.Add(this.lb_MonthYear);
            this.gb_SelectInformation.Controls.Add(this.dptThangNam);
            this.gb_SelectInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_SelectInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SelectInformation.Location = new System.Drawing.Point(0, 0);
            this.gb_SelectInformation.Name = "gb_SelectInformation";
            this.gb_SelectInformation.Size = new System.Drawing.Size(1206, 105);
            this.gb_SelectInformation.TabIndex = 0;
            this.gb_SelectInformation.TabStop = false;
            this.gb_SelectInformation.Text = "Chọn thời gian";
            // 
            // cboLoad
            // 
            this.cboLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoad.FormattingEnabled = true;
            this.cboLoad.Location = new System.Drawing.Point(422, 56);
            this.cboLoad.Name = "cboLoad";
            this.cboLoad.Size = new System.Drawing.Size(311, 25);
            this.cboLoad.TabIndex = 12;
            // 
            // chkNhomSanPham
            // 
            this.chkNhomSanPham.AutoSize = true;
            this.chkNhomSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNhomSanPham.Location = new System.Drawing.Point(596, 23);
            this.chkNhomSanPham.Name = "chkNhomSanPham";
            this.chkNhomSanPham.Size = new System.Drawing.Size(145, 25);
            this.chkNhomSanPham.TabIndex = 11;
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
            this.chkSanPham.Location = new System.Drawing.Point(424, 23);
            this.chkSanPham.Name = "chkSanPham";
            this.chkSanPham.Size = new System.Drawing.Size(99, 25);
            this.chkSanPham.TabIndex = 10;
            this.chkSanPham.Text = "Sản phẩm";
            this.chkSanPham.UseVisualStyleBackColor = true;
            this.chkSanPham.CheckedChanged += new System.EventHandler(this.chk_change);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnThoat.Location = new System.Drawing.Point(919, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemBC
            // 
            this.btnXemBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXemBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnXemBC.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btnXemBC.Location = new System.Drawing.Point(815, 26);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(98, 52);
            this.btnXemBC.TabIndex = 2;
            this.btnXemBC.Text = "Xem báo cáo";
            this.btnXemBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemBC.UseVisualStyleBackColor = false;
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // lb_MonthYear
            // 
            this.lb_MonthYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MonthYear.Location = new System.Drawing.Point(99, 23);
            this.lb_MonthYear.Name = "lb_MonthYear";
            this.lb_MonthYear.Size = new System.Drawing.Size(91, 21);
            this.lb_MonthYear.TabIndex = 1;
            this.lb_MonthYear.Text = "Tháng năm";
            this.lb_MonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dptThangNam
            // 
            this.dptThangNam.CustomFormat = "dd/MM/yyyy";
            this.dptThangNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptThangNam.Location = new System.Drawing.Point(211, 23);
            this.dptThangNam.Name = "dptThangNam";
            this.dptThangNam.Size = new System.Drawing.Size(164, 29);
            this.dptThangNam.TabIndex = 0;
            // 
            // gb_ReportDetail
            // 
            this.gb_ReportDetail.Controls.Add(this.rptViewTotalCustomer);
            this.gb_ReportDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_ReportDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ReportDetail.Location = new System.Drawing.Point(0, 111);
            this.gb_ReportDetail.Name = "gb_ReportDetail";
            this.gb_ReportDetail.Size = new System.Drawing.Size(1206, 550);
            this.gb_ReportDetail.TabIndex = 1;
            this.gb_ReportDetail.TabStop = false;
            this.gb_ReportDetail.Text = "Báo cáo số lượng khách trong tháng";
            this.gb_ReportDetail.Resize += new System.EventHandler(this.groupBox2_Resize);
            // 
            // rptViewTotalCustomer
            // 
            this.rptViewTotalCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewTotalCustomer.Location = new System.Drawing.Point(3, 21);
            this.rptViewTotalCustomer.Name = "rptViewTotalCustomer";
            this.rptViewTotalCustomer.Size = new System.Drawing.Size(1200, 526);
            this.rptViewTotalCustomer.TabIndex = 0;
            // 
            // frmRpt_TotalCustomerProductMoth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gb_ReportDetail);
            this.Controls.Add(this.gb_SelectInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRpt_TotalCustomerProductMoth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo số lượng khách và doanh thu theo tháng";
            this.Load += new System.EventHandler(this.frmRpt_TotalCustomerProductMoth_Load);
            this.gb_SelectInformation.ResumeLayout(false);
            this.gb_SelectInformation.PerformLayout();
            this.gb_ReportDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SelectInformation;
        private System.Windows.Forms.Button btnXemBC;
        private System.Windows.Forms.Label lb_MonthYear;
        private System.Windows.Forms.DateTimePicker dptThangNam;
        private System.Windows.Forms.GroupBox gb_ReportDetail;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewTotalCustomer;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboLoad;
        private System.Windows.Forms.CheckBox chkNhomSanPham;
        private System.Windows.Forms.CheckBox chkSanPham;
    }
}