namespace VVPosM1.Screen
{
    partial class frmRpt_Inventory
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gb_SelectInformation = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.lb_SPorNSP = new System.Windows.Forms.Label();
            this.cbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.gb_ReportDetail = new System.Windows.Forms.GroupBox();
            this.rptViewInventory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_SelectInformation.SuspendLayout();
            this.gb_ReportDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_SelectInformation
            // 
            this.gb_SelectInformation.Controls.Add(this.btnThoat);
            this.gb_SelectInformation.Controls.Add(this.btn_ViewReport);
            this.gb_SelectInformation.Controls.Add(this.lb_SPorNSP);
            this.gb_SelectInformation.Controls.Add(this.cbNguyenLieu);
            this.gb_SelectInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_SelectInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SelectInformation.Location = new System.Drawing.Point(0, 0);
            this.gb_SelectInformation.Name = "gb_SelectInformation";
            this.gb_SelectInformation.Size = new System.Drawing.Size(1206, 93);
            this.gb_SelectInformation.TabIndex = 2;
            this.gb_SelectInformation.TabStop = false;
            this.gb_SelectInformation.Text = "Chọn thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Location = new System.Drawing.Point(985, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 56);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ViewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ViewReport.Location = new System.Drawing.Point(780, 21);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(114, 56);
            this.btn_ViewReport.TabIndex = 8;
            this.btn_ViewReport.Text = "Xem báo cáo";
            this.btn_ViewReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ViewReport.UseVisualStyleBackColor = false;
            this.btn_ViewReport.Click += new System.EventHandler(this.btn_ViewReport_Click);
            // 
            // lb_SPorNSP
            // 
            this.lb_SPorNSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SPorNSP.Location = new System.Drawing.Point(73, 34);
            this.lb_SPorNSP.Name = "lb_SPorNSP";
            this.lb_SPorNSP.Size = new System.Drawing.Size(113, 29);
            this.lb_SPorNSP.TabIndex = 7;
            this.lb_SPorNSP.Text = "Nguyên liệu";
            this.lb_SPorNSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNguyenLieu
            // 
            this.cbNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNguyenLieu.FormattingEnabled = true;
            this.cbNguyenLieu.Location = new System.Drawing.Point(213, 38);
            this.cbNguyenLieu.Name = "cbNguyenLieu";
            this.cbNguyenLieu.Size = new System.Drawing.Size(287, 25);
            this.cbNguyenLieu.TabIndex = 6;
            // 
            // gb_ReportDetail
            // 
            this.gb_ReportDetail.Controls.Add(this.rptViewInventory);
            this.gb_ReportDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_ReportDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ReportDetail.Location = new System.Drawing.Point(0, 99);
            this.gb_ReportDetail.Name = "gb_ReportDetail";
            this.gb_ReportDetail.Size = new System.Drawing.Size(1206, 562);
            this.gb_ReportDetail.TabIndex = 3;
            this.gb_ReportDetail.TabStop = false;
            this.gb_ReportDetail.Text = "Báo cáo chi tiết";
            // 
            // rptViewInventory
            // 
            this.rptViewInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportInventoryBindingSource;
            this.rptViewInventory.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewInventory.LocalReport.ReportEmbeddedResource = "VVPosM1.ReportView.rptInventory.rdlc";
            this.rptViewInventory.Location = new System.Drawing.Point(3, 21);
            this.rptViewInventory.Name = "rptViewInventory";
            this.rptViewInventory.Size = new System.Drawing.Size(1200, 538);
            this.rptViewInventory.TabIndex = 0;
            // 
            // ReportInventoryBindingSource
            // 
            this.ReportInventoryBindingSource.DataSource = typeof(VVPosM1.Entities.ReportInventory);
            // 
            // frmRpt_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gb_SelectInformation);
            this.Controls.Add(this.gb_ReportDetail);
            this.Name = "frmRpt_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tồn kho";
            this.Load += new System.EventHandler(this.frmRpt_Inventory_Load);
            this.gb_SelectInformation.ResumeLayout(false);
            this.gb_ReportDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SelectInformation;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Label lb_SPorNSP;
        private System.Windows.Forms.ComboBox cbNguyenLieu;
        private System.Windows.Forms.GroupBox gb_ReportDetail;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewInventory;
        private System.Windows.Forms.BindingSource ReportInventoryBindingSource;
    }
}