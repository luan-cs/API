namespace VVPosS.Screen.POS
{
    partial class frmDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesk));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEmpty = new System.Windows.Forms.Label();
            this.lbFull = new System.Windows.Forms.Label();
            this.pxEmpty = new System.Windows.Forms.PictureBox();
            this.tabFromTable = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pxFull = new System.Windows.Forms.PictureBox();
            this.lbTilte = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxEmpty)).BeginInit();
            this.tabFromTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxFull)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbEmpty);
            this.panel1.Controls.Add(this.lbFull);
            this.panel1.Controls.Add(this.pxEmpty);
            this.panel1.Controls.Add(this.tabFromTable);
            this.panel1.Controls.Add(this.pxFull);
            this.panel1.Controls.Add(this.lbTilte);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 686);
            this.panel1.TabIndex = 6;
            // 
            // lbEmpty
            // 
            this.lbEmpty.AutoSize = true;
            this.lbEmpty.Location = new System.Drawing.Point(91, 622);
            this.lbEmpty.Name = "lbEmpty";
            this.lbEmpty.Size = new System.Drawing.Size(51, 20);
            this.lbEmpty.TabIndex = 2;
            this.lbEmpty.Text = "label1";
            // 
            // lbFull
            // 
            this.lbFull.AutoSize = true;
            this.lbFull.Location = new System.Drawing.Point(374, 622);
            this.lbFull.Name = "lbFull";
            this.lbFull.Size = new System.Drawing.Size(51, 20);
            this.lbFull.TabIndex = 37;
            this.lbFull.Text = "label1";
            // 
            // pxEmpty
            // 
            this.pxEmpty.Image = global::VVPosS.Properties.Resources.table_empty;
            this.pxEmpty.Location = new System.Drawing.Point(25, 608);
            this.pxEmpty.Name = "pxEmpty";
            this.pxEmpty.Size = new System.Drawing.Size(51, 48);
            this.pxEmpty.TabIndex = 0;
            this.pxEmpty.TabStop = false;
            // 
            // tabFromTable
            // 
            this.tabFromTable.AllowDrop = true;
            this.tabFromTable.Controls.Add(this.tabPage1);
            this.tabFromTable.Controls.Add(this.tabPage2);
            this.tabFromTable.Location = new System.Drawing.Point(0, 33);
            this.tabFromTable.Margin = new System.Windows.Forms.Padding(0);
            this.tabFromTable.Multiline = true;
            this.tabFromTable.Name = "tabFromTable";
            this.tabFromTable.Padding = new System.Drawing.Point(0, 0);
            this.tabFromTable.SelectedIndex = 0;
            this.tabFromTable.Size = new System.Drawing.Size(841, 544);
            this.tabFromTable.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(833, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pxFull
            // 
            this.pxFull.Image = global::VVPosS.Properties.Resources.table_empty;
            this.pxFull.Location = new System.Drawing.Point(305, 607);
            this.pxFull.Name = "pxFull";
            this.pxFull.Size = new System.Drawing.Size(51, 48);
            this.pxFull.TabIndex = 1;
            this.pxFull.TabStop = false;
            // 
            // lbTilte
            // 
            this.lbTilte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbTilte.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTilte.Location = new System.Drawing.Point(0, 0);
            this.lbTilte.Name = "lbTilte";
            this.lbTilte.Size = new System.Drawing.Size(841, 34);
            this.lbTilte.TabIndex = 30;
            this.lbTilte.Text = "Danh sách bàn";
            this.lbTilte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::VVPosS.Properties.Resources.thoat_button2;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(666, 597);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 61);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(839, 684);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDesk";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDesk_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxEmpty)).EndInit();
            this.tabFromTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxFull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTilte;
        private System.Windows.Forms.PictureBox pxEmpty;
        private System.Windows.Forms.PictureBox pxFull;
        private System.Windows.Forms.Label lbEmpty;
        private System.Windows.Forms.TabControl tabFromTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbFull;
        //private System.Windows.Forms.CheckedListBox lstMemberType;
    }
}