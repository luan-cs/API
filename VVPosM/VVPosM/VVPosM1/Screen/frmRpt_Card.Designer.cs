namespace VVPosM1.Screen
{
    partial class frmRpt_Card
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
            this.txtNam = new System.Windows.Forms.NumericUpDown();
            this.txtThang = new System.Windows.Forms.NumericUpDown();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.txtDenngay = new System.Windows.Forms.DateTimePicker();
            this.txtTungay = new System.Windows.Forms.DateTimePicker();
            this.rdNgay = new System.Windows.Forms.RadioButton();
            this.rpt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.lbSoHoaDon = new System.Windows.Forms.Label();
            this.lbTodate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNam
            // 
            this.txtNam.AutoSize = true;
            this.txtNam.BackColor = System.Drawing.Color.White;
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.txtNam.Location = new System.Drawing.Point(252, 68);
            this.txtNam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txtNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(120, 29);
            this.txtNam.TabIndex = 27;
            this.txtNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNam.Value = new decimal(new int[] {
            2006,
            0,
            0,
            0});
            // 
            // txtThang
            // 
            this.txtThang.BackColor = System.Drawing.Color.White;
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.txtThang.Location = new System.Drawing.Point(191, 68);
            this.txtThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(52, 29);
            this.txtThang.TabIndex = 26;
            this.txtThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdThang
            // 
            this.rdThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThang.ForeColor = System.Drawing.Color.Black;
            this.rdThang.Location = new System.Drawing.Point(78, 68);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(94, 29);
            this.rdThang.TabIndex = 25;
            this.rdThang.Text = "Tháng :";
            this.rdThang.UseVisualStyleBackColor = true;
            // 
            // txtDenngay
            // 
            this.txtDenngay.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.txtDenngay.CustomFormat = "dd/MM/yyyy";
            this.txtDenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDenngay.Location = new System.Drawing.Point(579, 10);
            this.txtDenngay.Name = "txtDenngay";
            this.txtDenngay.Size = new System.Drawing.Size(215, 29);
            this.txtDenngay.TabIndex = 30;
            // 
            // txtTungay
            // 
            this.txtTungay.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.txtTungay.CustomFormat = "dd/MM/yyyy";
            this.txtTungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTungay.Location = new System.Drawing.Point(191, 11);
            this.txtTungay.Name = "txtTungay";
            this.txtTungay.Size = new System.Drawing.Size(181, 29);
            this.txtTungay.TabIndex = 29;
            // 
            // rdNgay
            // 
            this.rdNgay.Checked = true;
            this.rdNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNgay.ForeColor = System.Drawing.Color.Black;
            this.rdNgay.Location = new System.Drawing.Point(77, 13);
            this.rdNgay.Name = "rdNgay";
            this.rdNgay.Size = new System.Drawing.Size(98, 27);
            this.rdNgay.TabIndex = 28;
            this.rdNgay.TabStop = true;
            this.rdNgay.Text = "Từ ngày :";
            this.rdNgay.UseVisualStyleBackColor = true;
            // 
            // rpt
            // 
            this.rpt.Location = new System.Drawing.Point(1, 132);
            this.rpt.Name = "rpt";
            this.rpt.Size = new System.Drawing.Size(1204, 528);
            this.rpt.TabIndex = 31;
            this.rpt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.btnThoat.Location = new System.Drawing.Point(1003, 31);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 61);
            this.btnThoat.TabIndex = 107;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBaoCao.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.btnBaoCao.Location = new System.Drawing.Point(882, 31);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(115, 61);
            this.btnBaoCao.TabIndex = 106;
            this.btnBaoCao.Text = "Xem báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoHoaDon.Enabled = false;
            this.txtSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoaDon.Location = new System.Drawing.Point(579, 73);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(215, 22);
            this.txtSoHoaDon.TabIndex = 108;
            // 
            // lbSoHoaDon
            // 
            this.lbSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoHoaDon.Location = new System.Drawing.Point(390, 68);
            this.lbSoHoaDon.Name = "lbSoHoaDon";
            this.lbSoHoaDon.Size = new System.Drawing.Size(183, 29);
            this.lbSoHoaDon.TabIndex = 109;
            this.lbSoHoaDon.Text = "Mã thẻ ngân hàng";
            this.lbSoHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTodate
            // 
            this.lbTodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodate.ForeColor = System.Drawing.Color.Black;
            this.lbTodate.Location = new System.Drawing.Point(409, 12);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(164, 29);
            this.lbTodate.TabIndex = 110;
            this.lbTodate.Text = "đến ngày :";
            this.lbTodate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmRpt_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.lbTodate);
            this.Controls.Add(this.lbSoHoaDon);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.rpt);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.rdThang);
            this.Controls.Add(this.txtDenngay);
            this.Controls.Add(this.txtTungay);
            this.Controls.Add(this.rdNgay);
            this.Name = "frmRpt_Card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thông tin thẻ ngân hàng";
            this.Load += new System.EventHandler(this.frmRpt_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtNam;
        private System.Windows.Forms.NumericUpDown txtThang;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.DateTimePicker txtDenngay;
        private System.Windows.Forms.DateTimePicker txtTungay;
        private System.Windows.Forms.RadioButton rdNgay;
        private Microsoft.Reporting.WinForms.ReportViewer rpt;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Label lbSoHoaDon;
        private System.Windows.Forms.Label lbTodate;
    }
}