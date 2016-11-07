namespace VVPosM1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCommonCode = new System.Windows.Forms.ToolStripMenuItem();
            this.commonTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnObject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProductPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quảnLýĐịnhLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingreadientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPromotion = new System.Windows.Forms.ToolStripMenuItem();
            this.recieptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReciept = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RpHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RpMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RpABCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportCardBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTônKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChangepassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.objectToolStripMenuItem,
            this.productToolStripMenuItem,
            this.promotionToolStripMenuItem,
            this.recieptToolStripMenuItem,
            this.cRMToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.mnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCommonCode,
            this.commonTypeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 40);
            this.toolStripMenuItem1.Text = "Thông số chung";
            // 
            // mnCommonCode
            // 
            this.mnCommonCode.Name = "mnCommonCode";
            this.mnCommonCode.Size = new System.Drawing.Size(164, 22);
            this.mnCommonCode.Text = "Common Code";
            this.mnCommonCode.Click += new System.EventHandler(this.mnCommonCode_Click);
            // 
            // commonTypeToolStripMenuItem
            // 
            this.commonTypeToolStripMenuItem.Name = "commonTypeToolStripMenuItem";
            this.commonTypeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.commonTypeToolStripMenuItem.Text = "Common Type";
            this.commonTypeToolStripMenuItem.Click += new System.EventHandler(this.commonTypeToolStripMenuItem_Click);
            // 
            // objectToolStripMenuItem
            // 
            this.objectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnObject,
            this.mnUser,
            this.userToolStripMenuItem});
            this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            this.objectToolStripMenuItem.Size = new System.Drawing.Size(91, 40);
            this.objectToolStripMenuItem.Text = "Người dùng";
            // 
            // mnObject
            // 
            this.mnObject.Name = "mnObject";
            this.mnObject.Size = new System.Drawing.Size(136, 22);
            this.mnObject.Text = "Object";
            this.mnObject.Click += new System.EventHandler(this.mnObject_Click);
            // 
            // mnUser
            // 
            this.mnUser.Name = "mnUser";
            this.mnUser.Size = new System.Drawing.Size(136, 22);
            this.mnUser.Text = "Nhân Viên";
            this.mnUser.Visible = false;
            this.mnUser.Click += new System.EventHandler(this.mnUser_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProductPrice,
            this.mnProducts,
            this.toolStripSeparator1,
            this.quảnLýĐịnhLượngToolStripMenuItem,
            this.ingreadientToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(78, 40);
            this.productToolStripMenuItem.Text = "Sản phẩm";
            // 
            // mnProductPrice
            // 
            this.mnProductPrice.Name = "mnProductPrice";
            this.mnProductPrice.Size = new System.Drawing.Size(203, 22);
            this.mnProductPrice.Text = "Quản lý giá sản phẩm";
            this.mnProductPrice.Click += new System.EventHandler(this.mnProductPrice_Click);
            // 
            // mnProducts
            // 
            this.mnProducts.Name = "mnProducts";
            this.mnProducts.Size = new System.Drawing.Size(203, 22);
            this.mnProducts.Text = "Quản lý sản phẩm";
            this.mnProducts.Click += new System.EventHandler(this.mnProducts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // quảnLýĐịnhLượngToolStripMenuItem
            // 
            this.quảnLýĐịnhLượngToolStripMenuItem.Name = "quảnLýĐịnhLượngToolStripMenuItem";
            this.quảnLýĐịnhLượngToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.quảnLýĐịnhLượngToolStripMenuItem.Text = "Quản lý định lượng";
            this.quảnLýĐịnhLượngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐịnhLượngToolStripMenuItem_Click);
            // 
            // ingreadientToolStripMenuItem
            // 
            this.ingreadientToolStripMenuItem.Name = "ingreadientToolStripMenuItem";
            this.ingreadientToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ingreadientToolStripMenuItem.Text = "Quản lý nguyên liệu";
            this.ingreadientToolStripMenuItem.Click += new System.EventHandler(this.ingreadientToolStripMenuItem_Click);
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPromotion});
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(87, 40);
            this.promotionToolStripMenuItem.Text = "Khuyến mãi";
            this.promotionToolStripMenuItem.Visible = false;
            // 
            // mnPromotion
            // 
            this.mnPromotion.Name = "mnPromotion";
            this.mnPromotion.Size = new System.Drawing.Size(137, 22);
            this.mnPromotion.Text = "Promotion";
            // 
            // recieptToolStripMenuItem
            // 
            this.recieptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReciept,
            this.orderToolStripMenuItem});
            this.recieptToolStripMenuItem.Name = "recieptToolStripMenuItem";
            this.recieptToolStripMenuItem.Size = new System.Drawing.Size(85, 40);
            this.recieptToolStripMenuItem.Text = "Thanh toán";
            // 
            // mnReciept
            // 
            this.mnReciept.Name = "mnReciept";
            this.mnReciept.Size = new System.Drawing.Size(239, 22);
            this.mnReciept.Text = "Quản lý hóa đơn thanh toán";
            this.mnReciept.Click += new System.EventHandler(this.mnReciept_Click_1);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Enabled = false;
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.orderToolStripMenuItem.Text = "Quản lý hóa đơn đặt hàng";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // cRMToolStripMenuItem
            // 
            this.cRMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhoToolStripMenuItem,
            this.NccToolStripMenuItem});
            this.cRMToolStripMenuItem.Name = "cRMToolStripMenuItem";
            this.cRMToolStripMenuItem.Size = new System.Drawing.Size(114, 40);
            this.cRMToolStripMenuItem.Text = "Xuất/ Nhập Kho";
            this.cRMToolStripMenuItem.Click += new System.EventHandler(this.cRMToolStripMenuItem_Click_1);
            // 
            // nhậpKhoToolStripMenuItem
            // 
            this.nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
            this.nhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nhậpKhoToolStripMenuItem.Text = "Nhập Kho";
            this.nhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.nhậpKhoToolStripMenuItem_Click);
            // 
            // NccToolStripMenuItem
            // 
            this.NccToolStripMenuItem.Name = "NccToolStripMenuItem";
            this.NccToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.NccToolStripMenuItem.Text = "Nhà cung cấp";
            this.NccToolStripMenuItem.Visible = false;
            this.NccToolStripMenuItem.Click += new System.EventHandler(this.NccToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReport,
            this.BaoCaoDoanhThuToolStripMenuItem,
            this.ByProductToolStripMenuItem,
            this.RpHourToolStripMenuItem,
            this.RpMonthToolStripMenuItem,
            this.RpABCToolStripMenuItem,
            this.ReportCardBankToolStripMenuItem,
            this.baoCaoTônKhoToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(129, 40);
            this.reportToolStripMenuItem.Text = "Báo cáo & Thống kê";
            // 
            // mnReport
            // 
            this.mnReport.Name = "mnReport";
            this.mnReport.Size = new System.Drawing.Size(293, 22);
            this.mnReport.Text = "Báo cáo giá sản phẩm";
            this.mnReport.Click += new System.EventHandler(this.mnReport_Click);
            // 
            // BaoCaoDoanhThuToolStripMenuItem
            // 
            this.BaoCaoDoanhThuToolStripMenuItem.Name = "BaoCaoDoanhThuToolStripMenuItem";
            this.BaoCaoDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.BaoCaoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu của nhân viên";
            this.BaoCaoDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuToolStripMenuItem_Click);
            // 
            // ByProductToolStripMenuItem
            // 
            this.ByProductToolStripMenuItem.Name = "ByProductToolStripMenuItem";
            this.ByProductToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ByProductToolStripMenuItem.Text = "Báo cáo theo sản phẩm";
            this.ByProductToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhSốTheoSảnPhẩmToolStripMenuItem_Click);
            // 
            // RpHourToolStripMenuItem
            // 
            this.RpHourToolStripMenuItem.Name = "RpHourToolStripMenuItem";
            this.RpHourToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.RpHourToolStripMenuItem.Text = "Báo cáo doanh thu theo múi giờ";
            this.RpHourToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDToolStripMenuItem_Click);
            // 
            // RpMonthToolStripMenuItem
            // 
            this.RpMonthToolStripMenuItem.Name = "RpMonthToolStripMenuItem";
            this.RpMonthToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.RpMonthToolStripMenuItem.Text = "Báo cáo số lượng khách trong tháng ";
            this.RpMonthToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuTheoToolStripMenuItem_Click);
            // 
            // RpABCToolStripMenuItem
            // 
            this.RpABCToolStripMenuItem.Enabled = false;
            this.RpABCToolStripMenuItem.Name = "RpABCToolStripMenuItem";
            this.RpABCToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.RpABCToolStripMenuItem.Text = "Báo cáo ABC";
            this.RpABCToolStripMenuItem.Click += new System.EventHandler(this.báoCáoABCToolStripMenuItem_Click);
            // 
            // ReportCardBankToolStripMenuItem
            // 
            this.ReportCardBankToolStripMenuItem.Name = "ReportCardBankToolStripMenuItem";
            this.ReportCardBankToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ReportCardBankToolStripMenuItem.Text = "Báo cáo thẻ ngân hàng";
            this.ReportCardBankToolStripMenuItem.Visible = false;
            this.ReportCardBankToolStripMenuItem.Click += new System.EventHandler(this.ReportCardBankToolStripMenuItem_Click);
            // 
            // baoCaoTônKhoToolStripMenuItem
            // 
            this.baoCaoTônKhoToolStripMenuItem.Enabled = false;
            this.baoCaoTônKhoToolStripMenuItem.Name = "baoCaoTônKhoToolStripMenuItem";
            this.baoCaoTônKhoToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.baoCaoTônKhoToolStripMenuItem.Text = "Báo cáo tồn kho";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChangepassword,
            this.mnLanguages,
            this.mnLogout});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(64, 40);
            this.utilityToolStripMenuItem.Text = "Tiện ích";
            // 
            // mnChangepassword
            // 
            this.mnChangepassword.Name = "mnChangepassword";
            this.mnChangepassword.Size = new System.Drawing.Size(180, 22);
            this.mnChangepassword.Text = "Change Password";
            this.mnChangepassword.Click += new System.EventHandler(this.mnChangepassword_Click);
            // 
            // mnLanguages
            // 
            this.mnLanguages.Name = "mnLanguages";
            this.mnLanguages.Size = new System.Drawing.Size(180, 22);
            this.mnLanguages.Text = "Set Languages";
            this.mnLanguages.Visible = false;
            this.mnLanguages.Click += new System.EventHandler(this.mnLanguages_Click);
            // 
            // mnLogout
            // 
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(180, 22);
            this.mnLogout.Text = "Log out";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(40, 40);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // pMain
            // 
            this.pMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pMain.BackColor = System.Drawing.Color.Transparent;
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 44);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1022, 689);
            this.pMain.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.ControlBox = false;
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tính tiền POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Form frmLanguage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnCommonCode;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnObject;
        private System.Windows.Forms.ToolStripMenuItem mnUser;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnProducts;
        private System.Windows.Forms.ToolStripMenuItem mnProductPrice;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnPromotion;
        private System.Windows.Forms.ToolStripMenuItem recieptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnReciept;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnReport;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnChangepassword;
        private System.Windows.Forms.ToolStripMenuItem mnLanguages;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commonTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RpHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RpMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RpABCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportCardBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐịnhLượngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoTônKhoToolStripMenuItem;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ingreadientToolStripMenuItem;
    }
}

