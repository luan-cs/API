namespace VVPosS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.bntShowTemp = new System.Windows.Forms.Button();
            this.btnRegisterService = new System.Windows.Forms.Button();
            this.btnCancelReceipt = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lbCompayInfor = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.tblUtil = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bntLogout = new System.Windows.Forms.Button();
            this.bntChangePass = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tblUtil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.tblMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImage = global::VVPosS.Properties.Resources.backgroud;
            this.splitContainer1.Panel2.Controls.Add(this.pbImage);
            this.splitContainer1.Panel2.Controls.Add(this.lbCompayInfor);
            this.splitContainer1.Panel2.Controls.Add(this.lbFullname);
            this.splitContainer1.Panel2.Controls.Add(this.tblUtil);
            this.splitContainer1.Size = new System.Drawing.Size(919, 573);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 0;
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.bntShowTemp, 0, 1);
            this.tblMain.Controls.Add(this.btnRegisterService, 0, 0);
            this.tblMain.Controls.Add(this.btnCancelReceipt, 1, 0);
            this.tblMain.Controls.Add(this.btnReport, 1, 1);
            this.tblMain.Location = new System.Drawing.Point(280, 9);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(317, 239);
            this.tblMain.TabIndex = 7;
            // 
            // bntShowTemp
            // 
            this.bntShowTemp.BackColor = System.Drawing.Color.Transparent;
            this.bntShowTemp.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.bntShowTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntShowTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntShowTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntShowTemp.FlatAppearance.BorderSize = 0;
            this.bntShowTemp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntShowTemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntShowTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntShowTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntShowTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntShowTemp.ForeColor = System.Drawing.Color.Black;
            this.bntShowTemp.Image = global::VVPosS.Properties.Resources.ds_order_icon;
            this.bntShowTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntShowTemp.Location = new System.Drawing.Point(3, 122);
            this.bntShowTemp.Name = "bntShowTemp";
            this.bntShowTemp.Size = new System.Drawing.Size(152, 114);
            this.bntShowTemp.TabIndex = 43;
            this.bntShowTemp.Text = "DS Order";
            this.bntShowTemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntShowTemp.UseVisualStyleBackColor = false;
            this.bntShowTemp.Click += new System.EventHandler(this.bntShowTemp_Click);
            // 
            // btnRegisterService
            // 
            this.btnRegisterService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterService.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterService.BackgroundImage = global::VVPosS.Properties.Resources.save_button;
            this.btnRegisterService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegisterService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterService.FlatAppearance.BorderSize = 0;
            this.btnRegisterService.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRegisterService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegisterService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegisterService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterService.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterService.Image = global::VVPosS.Properties.Resources.dangky_icon;
            this.btnRegisterService.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegisterService.Location = new System.Drawing.Point(4, 5);
            this.btnRegisterService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegisterService.Name = "btnRegisterService";
            this.btnRegisterService.Size = new System.Drawing.Size(150, 109);
            this.btnRegisterService.TabIndex = 2;
            this.btnRegisterService.Text = "Đăng ký dịch vụ";
            this.btnRegisterService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegisterService.UseVisualStyleBackColor = false;
            this.btnRegisterService.Click += new System.EventHandler(this.btnRegisterService_Click);
            // 
            // btnCancelReceipt
            // 
            this.btnCancelReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelReceipt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelReceipt.BackgroundImage")));
            this.btnCancelReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReceipt.FlatAppearance.BorderSize = 0;
            this.btnCancelReceipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancelReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReceipt.ForeColor = System.Drawing.Color.Black;
            this.btnCancelReceipt.Image = global::VVPosS.Properties.Resources.thanhtoan_icon;
            this.btnCancelReceipt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelReceipt.Location = new System.Drawing.Point(162, 5);
            this.btnCancelReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelReceipt.Name = "btnCancelReceipt";
            this.btnCancelReceipt.Size = new System.Drawing.Size(151, 109);
            this.btnCancelReceipt.TabIndex = 6;
            this.btnCancelReceipt.Text = "Hủy hóa đơn";
            this.btnCancelReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelReceipt.UseVisualStyleBackColor = false;
            this.btnCancelReceipt.Click += new System.EventHandler(this.btnCancelReceipt_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReport.Image = global::VVPosS.Properties.Resources.ds_tamtinh_icon;
            this.btnReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReport.Location = new System.Drawing.Point(161, 122);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(153, 114);
            this.btnReport.TabIndex = 44;
            this.btnReport.Text = "Doanh thu";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lbCompayInfor
            // 
            this.lbCompayInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCompayInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCompayInfor.ForeColor = System.Drawing.Color.White;
            this.lbCompayInfor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCompayInfor.Location = new System.Drawing.Point(12, 5);
            this.lbCompayInfor.Name = "lbCompayInfor";
            this.lbCompayInfor.Size = new System.Drawing.Size(332, 223);
            this.lbCompayInfor.TabIndex = 26;
            this.lbCompayInfor.Text = "ABC Company \\n Poe";
            // 
            // lbFullname
            // 
            this.lbFullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFullname.ForeColor = System.Drawing.Color.White;
            this.lbFullname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFullname.Location = new System.Drawing.Point(463, 73);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(306, 161);
            this.lbFullname.TabIndex = 24;
            this.lbFullname.Text = "label1";
            this.lbFullname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tblUtil
            // 
            this.tblUtil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblUtil.ColumnCount = 4;
            this.tblUtil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblUtil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblUtil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblUtil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblUtil.Controls.Add(this.btnConfig, 0, 0);
            this.tblUtil.Controls.Add(this.btnExit, 3, 0);
            this.tblUtil.Controls.Add(this.bntLogout, 2, 0);
            this.tblUtil.Controls.Add(this.bntChangePass, 1, 0);
            this.tblUtil.Location = new System.Drawing.Point(350, 0);
            this.tblUtil.Name = "tblUtil";
            this.tblUtil.RowCount = 1;
            this.tblUtil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUtil.Size = new System.Drawing.Size(567, 67);
            this.tblUtil.TabIndex = 25;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.Black;
            this.btnConfig.Image = global::VVPosS.Properties.Resources.icon_cauhinh;
            this.btnConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfig.Location = new System.Drawing.Point(4, 5);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(133, 57);
            this.btnConfig.TabIndex = 35;
            this.btnConfig.Text = "Cấu hình";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::VVPosS.Properties.Resources.thoat_icon;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(427, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 57);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bntLogout
            // 
            this.bntLogout.BackColor = System.Drawing.Color.Transparent;
            this.bntLogout.BackgroundImage = global::VVPosS.Properties.Resources.thoat_button2;
            this.bntLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLogout.FlatAppearance.BorderSize = 0;
            this.bntLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntLogout.Location = new System.Drawing.Point(285, 3);
            this.bntLogout.Name = "bntLogout";
            this.bntLogout.Size = new System.Drawing.Size(134, 60);
            this.bntLogout.TabIndex = 36;
            this.bntLogout.Text = "Đăng xuất";
            this.bntLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntLogout.UseVisualStyleBackColor = false;
            this.bntLogout.Click += new System.EventHandler(this.bntLogout_Click);
            // 
            // bntChangePass
            // 
            this.bntChangePass.BackColor = System.Drawing.Color.Transparent;
            this.bntChangePass.BackgroundImage = global::VVPosS.Properties.Resources.ds_order_button;
            this.bntChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntChangePass.FlatAppearance.BorderSize = 0;
            this.bntChangePass.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntChangePass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntChangePass.Location = new System.Drawing.Point(144, 3);
            this.bntChangePass.Name = "bntChangePass";
            this.bntChangePass.Size = new System.Drawing.Size(134, 61);
            this.bntChangePass.TabIndex = 34;
            this.bntChangePass.Text = "Change password";
            this.bntChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntChangePass.UseVisualStyleBackColor = false;
            this.bntChangePass.Click += new System.EventHandler(this.bntChangePass_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Image = global::VVPosS.Properties.Resources.user_image;
            this.pbImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(780, 70);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(134, 149);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 23;
            this.pbImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VVPosS.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 573);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of View - Prodcut of HD Tech - Phone: 0989870091";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.tblUtil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRegisterService;
        private System.Windows.Forms.Button btnCancelReceipt;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button bntShowTemp;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TableLayoutPanel tblUtil;
        private System.Windows.Forms.Button bntChangePass;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button bntLogout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lbCompayInfor;
    }
}