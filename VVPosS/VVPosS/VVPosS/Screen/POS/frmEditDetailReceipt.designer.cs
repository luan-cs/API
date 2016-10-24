namespace VVPosS.Screen.POS
{
    partial class frmEditDetailReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditDetailReceipt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gDesk = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSL = new VVPosS.Controls.NumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThue = new VVPosS.Controls.NumericTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTTT = new System.Windows.Forms.TextBox();
            this.txtTTS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDG = new VVPosS.Controls.NumericTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gDesk.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            //this.panel1.BackgroundImage = global::VVPosS.Properties.Resources.BG05;
            this.panel1.Controls.Add(this.gDesk);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 476);
            this.panel1.TabIndex = 6;
            // 
            // gDesk
            // 
            this.gDesk.Controls.Add(this.panel2);
            this.gDesk.Controls.Add(this.lblProductName);
            this.gDesk.Controls.Add(this.lblTenSP);
            this.gDesk.Controls.Add(this.lblProductId);
            this.gDesk.Controls.Add(this.btnExit);
            this.gDesk.Controls.Add(this.lblMaSP);
            this.gDesk.Controls.Add(this.btnThem);
            this.gDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gDesk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gDesk.Location = new System.Drawing.Point(3, 12);
            this.gDesk.Margin = new System.Windows.Forms.Padding(0);
            this.gDesk.Name = "gDesk";
            this.gDesk.Padding = new System.Windows.Forms.Padding(0);
            this.gDesk.Size = new System.Drawing.Size(542, 445);
            this.gDesk.TabIndex = 28;
            this.gDesk.TabStop = false;
            this.gDesk.Text = "Sửa chi tiết hóa đơn";
            this.gDesk.Enter += new System.EventHandler(this.gDesk_Enter);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::VVPosS.Properties.Resources.bg00;
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtThue);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTTT);
            this.panel2.Controls.Add(this.txtTTS);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDG);
            this.panel2.Controls.Add(this.label15);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(30, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 198);
            this.panel2.TabIndex = 57;
            // 
            // txtSL
            // 
            this.txtSL.AllowNegative = true;
            this.txtSL.Location = new System.Drawing.Point(175, 19);
            this.txtSL.Name = "txtSL";
            this.txtSL.NumericPrecision = 1;
            this.txtSL.NumericScaleOnFocus = 0;
            this.txtSL.NumericScaleOnLostFocus = 0;
            this.txtSL.NumericValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSL.Size = new System.Drawing.Size(260, 26);
            this.txtSL.TabIndex = 49;
            this.txtSL.Text = "1";
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSL.ZeroIsValid = false;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(94, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tiền thuế";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtThue
            // 
            this.txtThue.AllowNegative = true;
            this.txtThue.Location = new System.Drawing.Point(175, 117);
            this.txtThue.Name = "txtThue";
            this.txtThue.NumericPrecision = 1;
            this.txtThue.NumericScaleOnFocus = 0;
            this.txtThue.NumericScaleOnLostFocus = 0;
            this.txtThue.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtThue.Size = new System.Drawing.Size(260, 26);
            this.txtThue.TabIndex = 33;
            this.txtThue.Text = "0";
            this.txtThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThue.ZeroIsValid = false;
            this.txtThue.TextChanged += new System.EventHandler(this.txtThue_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(19, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tổng cộng sau thuế";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTTT
            // 
            this.txtTTT.Location = new System.Drawing.Point(175, 83);
            this.txtTTT.Name = "txtTTT";
            this.txtTTT.ReadOnly = true;
            this.txtTTT.Size = new System.Drawing.Size(260, 26);
            this.txtTTT.TabIndex = 53;
            this.txtTTT.Text = "0";
            this.txtTTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTTS
            // 
            this.txtTTS.Location = new System.Drawing.Point(175, 149);
            this.txtTTS.Name = "txtTTS";
            this.txtTTS.ReadOnly = true;
            this.txtTTS.Size = new System.Drawing.Size(260, 26);
            this.txtTTS.TabIndex = 35;
            this.txtTTS.Text = "0";
            this.txtTTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(9, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "Tổng cộng trước thuế";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(140, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "SL";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDG
            // 
            this.txtDG.AllowNegative = true;
            this.txtDG.Location = new System.Drawing.Point(175, 51);
            this.txtDG.Name = "txtDG";
            this.txtDG.NumericPrecision = 1;
            this.txtDG.NumericScaleOnFocus = 0;
            this.txtDG.NumericScaleOnLostFocus = 0;
            this.txtDG.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDG.Size = new System.Drawing.Size(260, 26);
            this.txtDG.TabIndex = 51;
            this.txtDG.Text = "0";
            this.txtDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDG.ZeroIsValid = false;
            this.txtDG.TextChanged += new System.EventHandler(this.txtDG_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(105, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "Đơn giá";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductName.Location = new System.Drawing.Point(173, 82);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(344, 63);
            this.lblProductName.TabIndex = 56;
            this.lblProductName.Text = ".........";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTenSP.Location = new System.Drawing.Point(26, 81);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(130, 52);
            this.lblTenSP.TabIndex = 55;
            this.lblTenSP.Text = "Tên Sản phẩm";
            // 
            // lblProductId
            // 
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductId.Location = new System.Drawing.Point(173, 23);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(329, 52);
            this.lblProductId.TabIndex = 54;
            this.lblProductId.Text = ".........";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::VVPosS.Properties.Resources.delete_icon;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(30, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 76);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Hủy";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMaSP
            // 
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaSP.Location = new System.Drawing.Point(26, 24);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(130, 52);
            this.lblMaSP.TabIndex = 41;
            this.lblMaSP.Text = "Mã Sản phẩm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(385, 353);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 76);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmEditDetailReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(180)))), ((int)(((byte)(154)))));
            //this.BackgroundImage = global::VVPosS.Properties.Resources.bground;
            this.ClientSize = new System.Drawing.Size(548, 466);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditDetailReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.gDesk.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gDesk;
        //private System.Windows.Forms.CheckedListBox lstMemberType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTTT;
        private System.Windows.Forms.Label label14;
        //private System.Windows.Forms.TextBox txtDG;
        private VVPosS.Controls.NumericTextBox txtDG;
        private System.Windows.Forms.Label label15;
//        private System.Windows.Forms.TextBox txtSL;
        private VVPosS.Controls.NumericTextBox txtSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTTS;
        private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.TextBox txtThue;
        private VVPosS.Controls.NumericTextBox txtThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Panel panel2;
    }
}