namespace VVPosM1.Screen
{
    partial class frmRpt_ProductPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpt_ProductPrice));
            this.lb_ReportPrice = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_ReportView = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ReportPrice
            // 
            this.lb_ReportPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ReportPrice.Location = new System.Drawing.Point(80, 19);
            this.lb_ReportPrice.Name = "lb_ReportPrice";
            this.lb_ReportPrice.Size = new System.Drawing.Size(206, 25);
            this.lb_ReportPrice.TabIndex = 0;
            this.lb_ReportPrice.Text = "Báo cáo giá sản phẩm";
            this.lb_ReportPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(310, 19);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(540, 25);
            this.cboProduct.TabIndex = 1;
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptViewer.Location = new System.Drawing.Point(0, 64);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(1206, 597);
            this.rptViewer.TabIndex = 2;
            // 
            // btn_ReportView
            // 
            this.btn_ReportView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ReportView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReportView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ReportView.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btn_ReportView.Location = new System.Drawing.Point(904, 2);
            this.btn_ReportView.Name = "btn_ReportView";
            this.btn_ReportView.Size = new System.Drawing.Size(111, 56);
            this.btn_ReportView.TabIndex = 3;
            this.btn_ReportView.Text = "Xem báo cáo";
            this.btn_ReportView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ReportView.UseVisualStyleBackColor = false;
            this.btn_ReportView.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnThoat.Location = new System.Drawing.Point(1021, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 56);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRpt_ProductPrice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_ReportView);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.lb_ReportPrice);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRpt_ProductPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo giá của sản phẩm";
            this.Load += new System.EventHandler(this.frmRpt_ProductPrice_Load);
            this.Resize += new System.EventHandler(this.frmRpt_ProductPrice_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_ReportPrice;
        private System.Windows.Forms.ComboBox cboProduct;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.Button btn_ReportView;
        private System.Windows.Forms.Button btnThoat;
    }
}