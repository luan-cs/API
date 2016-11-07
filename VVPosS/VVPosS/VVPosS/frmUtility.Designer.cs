namespace VVPosS
{
    partial class frmUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtility));
            this.pTop = new System.Windows.Forms.Panel();
            this.lbTittle1 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lbVat = new System.Windows.Forms.Label();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.lbServiceCharge = new System.Windows.Forms.Label();
            this.txtPhoneContact = new System.Windows.Forms.TextBox();
            this.lbPhoneContact = new System.Windows.Forms.Label();
            this.lbPrintTran = new System.Windows.Forms.Label();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pTop.Controls.Add(this.lbTittle1);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(456, 45);
            this.pTop.TabIndex = 8;
            // 
            // lbTittle1
            // 
            this.lbTittle1.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTittle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbTittle1.Location = new System.Drawing.Point(23, 0);
            this.lbTittle1.Name = "lbTittle1";
            this.lbTittle1.Size = new System.Drawing.Size(433, 45);
            this.lbTittle1.TabIndex = 0;
            this.lbTittle1.Text = "Config ";
            this.lbTittle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVat
            // 
            this.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.txtVat.Location = new System.Drawing.Point(155, 64);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(281, 29);
            this.txtVat.TabIndex = 15;
            this.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVat.TextChanged += new System.EventHandler(this.txtTenantName_TextChanged);
            this.txtVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceCharge_KeyPress);
            // 
            // lbVat
            // 
            this.lbVat.AutoSize = true;
            this.lbVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbVat.Location = new System.Drawing.Point(19, 64);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(40, 20);
            this.lbVat.TabIndex = 14;
            this.lbVat.Text = "VAT";
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtServiceCharge.Location = new System.Drawing.Point(155, 97);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(281, 29);
            this.txtServiceCharge.TabIndex = 17;
            this.txtServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtServiceCharge.TextChanged += new System.EventHandler(this.txtTenantCode_TextChanged);
            this.txtServiceCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceCharge_KeyPress);
            // 
            // lbServiceCharge
            // 
            this.lbServiceCharge.AutoSize = true;
            this.lbServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbServiceCharge.Location = new System.Drawing.Point(19, 97);
            this.lbServiceCharge.Name = "lbServiceCharge";
            this.lbServiceCharge.Size = new System.Drawing.Size(84, 20);
            this.lbServiceCharge.TabIndex = 16;
            this.lbServiceCharge.Text = "Phí dịch vụ";
            // 
            // txtPhoneContact
            // 
            this.txtPhoneContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtPhoneContact.Location = new System.Drawing.Point(155, 129);
            this.txtPhoneContact.Name = "txtPhoneContact";
            this.txtPhoneContact.Size = new System.Drawing.Size(281, 29);
            this.txtPhoneContact.TabIndex = 19;
            this.txtPhoneContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhoneContact.TextChanged += new System.EventHandler(this.txtPhoneContact_TextChanged);
            // 
            // lbPhoneContact
            // 
            this.lbPhoneContact.AutoSize = true;
            this.lbPhoneContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbPhoneContact.Location = new System.Drawing.Point(19, 129);
            this.lbPhoneContact.Name = "lbPhoneContact";
            this.lbPhoneContact.Size = new System.Drawing.Size(102, 20);
            this.lbPhoneContact.TabIndex = 18;
            this.lbPhoneContact.Text = "Số điện thoại";
            // 
            // lbPrintTran
            // 
            this.lbPrintTran.AutoSize = true;
            this.lbPrintTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrintTran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbPrintTran.Location = new System.Drawing.Point(19, 177);
            this.lbPrintTran.Name = "lbPrintTran";
            this.lbPrintTran.Size = new System.Drawing.Size(113, 20);
            this.lbPrintTran.TabIndex = 28;
            this.lbPrintTran.Text = "In order ra bếp";
            // 
            // rdYes
            // 
            this.rdYes.AutoSize = true;
            this.rdYes.Checked = true;
            this.rdYes.Enabled = false;
            this.rdYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdYes.Location = new System.Drawing.Point(241, 177);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(47, 24);
            this.rdYes.TabIndex = 29;
            this.rdYes.TabStop = true;
            this.rdYes.Text = "Có";
            this.rdYes.UseVisualStyleBackColor = true;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdNo.Location = new System.Drawing.Point(347, 177);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(73, 24);
            this.rdNo.TabIndex = 30;
            this.rdNo.Text = "Không";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnReset.Image = global::VVPosS.Properties.Resources.naplai_icon;
            this.btnReset.Location = new System.Drawing.Point(46, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 48);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCancel.Image = global::VVPosS.Properties.Resources.thoat_icon_black;
            this.btnCancel.Location = new System.Drawing.Point(308, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 48);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnConnect.Image = global::VVPosS.Properties.Resources.check_icon;
            this.btnConnect.Location = new System.Drawing.Point(177, 222);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 48);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "OK";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frmUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 289);
            this.ControlBox = false;
            this.Controls.Add(this.rdNo);
            this.Controls.Add(this.rdYes);
            this.Controls.Add(this.lbPrintTran);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPhoneContact);
            this.Controls.Add(this.lbPhoneContact);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.lbServiceCharge);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.lbVat);
            this.Controls.Add(this.pTop);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUtility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUtility_Load);
            this.pTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label lbTittle1;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lbVat;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.Label lbServiceCharge;
        private System.Windows.Forms.TextBox txtPhoneContact;
        private System.Windows.Forms.Label lbPhoneContact;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbPrintTran;
        private System.Windows.Forms.RadioButton rdYes;
        private System.Windows.Forms.RadioButton rdNo;
    }
}