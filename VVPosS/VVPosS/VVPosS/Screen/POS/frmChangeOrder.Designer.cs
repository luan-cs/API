namespace VVPosS.Screen.POS
{
    partial class frmChangeOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceiptId = new System.Windows.Forms.Label();
            this.txtReceiptId = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(75)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hủy/ Đổi món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReceiptId
            // 
            this.lblReceiptId.AutoSize = true;
            this.lblReceiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.lblReceiptId.Location = new System.Drawing.Point(12, 88);
            this.lblReceiptId.Name = "lblReceiptId";
            this.lblReceiptId.Size = new System.Drawing.Size(132, 25);
            this.lblReceiptId.TabIndex = 1;
            this.lblReceiptId.Text = "Mã hóa đơn:";
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptId.Location = new System.Drawing.Point(150, 85);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.Size = new System.Drawing.Size(232, 31);
            this.txtReceiptId.TabIndex = 2;
            this.txtReceiptId.Click += new System.EventHandler(this.txtReceiptId_Click);
            this.txtReceiptId.TextChanged += new System.EventHandler(this.txtReceiptId_TextChanged);
            this.txtReceiptId.Enter += new System.EventHandler(this.txtReceiptId_Enter);
            this.txtReceiptId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiptId_KeyDown);
            this.txtReceiptId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceiptId_KeyPress);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.lblNotes.Location = new System.Drawing.Point(12, 139);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(92, 25);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Ghi chú:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotes.Location = new System.Drawing.Point(150, 139);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(450, 147);
            this.rtxtNotes.TabIndex = 12;
            this.rtxtNotes.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.btnCancel.Location = new System.Drawing.Point(366, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 59);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.btnOK.Location = new System.Drawing.Point(183, 304);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(177, 59);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmChangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(630, 375);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtReceiptId);
            this.Controls.Add(this.lblReceiptId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangeOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeOrder";
            this.Load += new System.EventHandler(this.frmChangeOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReceiptId;
        private System.Windows.Forms.TextBox txtReceiptId;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
    }
}