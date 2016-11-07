namespace VVPosM1.Screen
{
    partial class frmRpt_ABC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpt_ABC));
            this.txtA = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.Label();
            this.dptTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dptDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lb_fromDate = new System.Windows.Forms.Label();
            this.lb_toDate = new System.Windows.Forms.Label();
            this.rptABC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_tylechidinh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gb_infomation = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.gb_ReportDetail = new System.Windows.Forms.GroupBox();
            this.gb_infomation.SuspendLayout();
            this.gb_ReportDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(267, 23);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(16, 17);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "A";
            // 
            // txtB
            // 
            this.txtB.AutoSize = true;
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(267, 50);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(15, 17);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "B";
            // 
            // dptTuNgay
            // 
            this.dptTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dptTuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptTuNgay.Location = new System.Drawing.Point(569, 23);
            this.dptTuNgay.Name = "dptTuNgay";
            this.dptTuNgay.Size = new System.Drawing.Size(109, 29);
            this.dptTuNgay.TabIndex = 2;
            // 
            // dptDenNgay
            // 
            this.dptDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dptDenNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDenNgay.Location = new System.Drawing.Point(569, 73);
            this.dptDenNgay.Name = "dptDenNgay";
            this.dptDenNgay.Size = new System.Drawing.Size(109, 29);
            this.dptDenNgay.TabIndex = 3;
            // 
            // lb_fromDate
            // 
            this.lb_fromDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fromDate.Location = new System.Drawing.Point(490, 29);
            this.lb_fromDate.Name = "lb_fromDate";
            this.lb_fromDate.Size = new System.Drawing.Size(63, 23);
            this.lb_fromDate.TabIndex = 4;
            this.lb_fromDate.Text = "Từ ngày";
            // 
            // lb_toDate
            // 
            this.lb_toDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_toDate.Location = new System.Drawing.Point(488, 74);
            this.lb_toDate.Name = "lb_toDate";
            this.lb_toDate.Size = new System.Drawing.Size(65, 23);
            this.lb_toDate.TabIndex = 5;
            this.lb_toDate.Text = "Tới ngày";
            // 
            // rptABC
            // 
            this.rptABC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptABC.Location = new System.Drawing.Point(3, 21);
            this.rptABC.Name = "rptABC";
            this.rptABC.Size = new System.Drawing.Size(1200, 515);
            this.rptABC.TabIndex = 8;
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ViewReport.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btn_ViewReport.Location = new System.Drawing.Point(724, 35);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(103, 57);
            this.btn_ViewReport.TabIndex = 9;
            this.btn_ViewReport.Text = "Xem báo cáo";
            this.btn_ViewReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ViewReport.UseVisualStyleBackColor = false;
            this.btn_ViewReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtC1
            // 
            this.txtC1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtC1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1.Location = new System.Drawing.Point(287, 77);
            this.txtC1.Name = "txtC1";
            this.txtC1.ReadOnly = true;
            this.txtC1.Size = new System.Drawing.Size(77, 25);
            this.txtC1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "%";
            // 
            // lb_tylechidinh
            // 
            this.lb_tylechidinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tylechidinh.Location = new System.Drawing.Point(157, 23);
            this.lb_tylechidinh.Name = "lb_tylechidinh";
            this.lb_tylechidinh.Size = new System.Drawing.Size(88, 23);
            this.lb_tylechidinh.TabIndex = 15;
            this.lb_tylechidinh.Text = "Tỷ lệ chỉ định";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnThoat.Location = new System.Drawing.Point(945, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 57);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gb_infomation
            // 
            this.gb_infomation.Controls.Add(this.btnReset);
            this.gb_infomation.Controls.Add(this.txtB1);
            this.gb_infomation.Controls.Add(this.txtA1);
            this.gb_infomation.Controls.Add(this.btnThoat);
            this.gb_infomation.Controls.Add(this.txtA);
            this.gb_infomation.Controls.Add(this.txtB);
            this.gb_infomation.Controls.Add(this.dptTuNgay);
            this.gb_infomation.Controls.Add(this.lb_tylechidinh);
            this.gb_infomation.Controls.Add(this.dptDenNgay);
            this.gb_infomation.Controls.Add(this.label6);
            this.gb_infomation.Controls.Add(this.lb_fromDate);
            this.gb_infomation.Controls.Add(this.label5);
            this.gb_infomation.Controls.Add(this.lb_toDate);
            this.gb_infomation.Controls.Add(this.label2);
            this.gb_infomation.Controls.Add(this.btn_ViewReport);
            this.gb_infomation.Controls.Add(this.txtC1);
            this.gb_infomation.Controls.Add(this.label1);
            this.gb_infomation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_infomation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_infomation.Location = new System.Drawing.Point(0, 0);
            this.gb_infomation.Name = "gb_infomation";
            this.gb_infomation.Size = new System.Drawing.Size(1206, 125);
            this.gb_infomation.TabIndex = 19;
            this.gb_infomation.TabStop = false;
            this.gb_infomation.Text = "Chọn thông tin";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.btnReset.Location = new System.Drawing.Point(834, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 57);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtB1
            // 
            this.txtB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(287, 50);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(77, 25);
            this.txtB1.TabIndex = 20;
            this.txtB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB1_KeyPress);
            this.txtB1.Validated += new System.EventHandler(this.txtB1_Validated);
            // 
            // txtA1
            // 
            this.txtA1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1.Location = new System.Drawing.Point(287, 23);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(77, 25);
            this.txtA1.TabIndex = 19;
            this.txtA1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtA1_KeyDown);
            this.txtA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA1_KeyPress);
            this.txtA1.Validated += new System.EventHandler(this.txtA1_Validated);
            // 
            // gb_ReportDetail
            // 
            this.gb_ReportDetail.Controls.Add(this.rptABC);
            this.gb_ReportDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_ReportDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ReportDetail.Location = new System.Drawing.Point(0, 122);
            this.gb_ReportDetail.Name = "gb_ReportDetail";
            this.gb_ReportDetail.Size = new System.Drawing.Size(1206, 539);
            this.gb_ReportDetail.TabIndex = 20;
            this.gb_ReportDetail.TabStop = false;
            this.gb_ReportDetail.Text = "Báo cáo chi tiết";
            // 
            // frmRpt_ABC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gb_ReportDetail);
            this.Controls.Add(this.gb_infomation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRpt_ABC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo phân tích ABC";
            this.Load += new System.EventHandler(this.frmRpt_ABC_Load);
            this.gb_infomation.ResumeLayout(false);
            this.gb_infomation.PerformLayout();
            this.gb_ReportDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.Label txtB;
        private System.Windows.Forms.DateTimePicker dptTuNgay;
        private System.Windows.Forms.DateTimePicker dptDenNgay;
        private System.Windows.Forms.Label lb_fromDate;
        private System.Windows.Forms.Label lb_toDate;
        private Microsoft.Reporting.WinForms.ReportViewer rptABC;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_tylechidinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gb_infomation;
        private System.Windows.Forms.GroupBox gb_ReportDetail;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Button btnReset;
       // private VVPosM1.
 
    }
}