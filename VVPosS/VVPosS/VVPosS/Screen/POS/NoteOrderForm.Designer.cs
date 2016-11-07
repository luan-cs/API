namespace VVPosS.Screen.POS
{
    partial class NoteOrderForm
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
            this.rtbCustomInfo = new System.Windows.Forms.RichTextBox();
            this.bntFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbCustomInfo
            // 
            this.rtbCustomInfo.Location = new System.Drawing.Point(20, 77);
            this.rtbCustomInfo.Name = "rtbCustomInfo";
            this.rtbCustomInfo.Size = new System.Drawing.Size(250, 96);
            this.rtbCustomInfo.TabIndex = 0;
            this.rtbCustomInfo.Text = "";
            // 
            // bntFinish
            // 
            this.bntFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFinish.BackColor = System.Drawing.Color.Transparent;
            this.bntFinish.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.bntFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntFinish.FlatAppearance.BorderSize = 0;
            this.bntFinish.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntFinish.ForeColor = System.Drawing.Color.Black;
            this.bntFinish.Image = global::VVPosS.Properties.Resources.save_icon;
            this.bntFinish.Location = new System.Drawing.Point(95, 188);
            this.bntFinish.Name = "bntFinish";
            this.bntFinish.Size = new System.Drawing.Size(100, 61);
            this.bntFinish.TabIndex = 50;
            this.bntFinish.Text = "OK";
            this.bntFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntFinish.UseVisualStyleBackColor = false;
            this.bntFinish.Click += new System.EventHandler(this.bntFinish_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 70);
            this.label1.TabIndex = 51;
            this.label1.Text = "Thông tin khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VVPosS.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntFinish);
            this.Controls.Add(this.rtbCustomInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NoteOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCustomInfo;
        private System.Windows.Forms.Button bntFinish;
        private System.Windows.Forms.Label label1;
    }
}