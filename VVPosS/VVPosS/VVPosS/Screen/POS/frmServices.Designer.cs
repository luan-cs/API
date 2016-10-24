namespace VVPosS.Screen.POS
{
    partial class frmServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServices));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pMTop = new System.Windows.Forms.Panel();
            this.pSubmenu = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnFrmPay = new System.Windows.Forms.Button();
            this.bntAll = new System.Windows.Forms.Button();
            this.pLstsub = new System.Windows.Forms.Panel();
            this.btnGoNextMenu = new System.Windows.Forms.Button();
            this.btnGoPreMenu = new System.Windows.Forms.Button();
            this.pMBottom = new System.Windows.Forms.Panel();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.btnGoNextPro = new System.Windows.Forms.Button();
            this.btnGoPrePro = new System.Windows.Forms.Button();
            this.bntTamtinh = new System.Windows.Forms.Button();
            this.bntShowTamTinh = new System.Windows.Forms.Button();
            this.bntDesk = new System.Windows.Forms.Button();
            this.pMCenter = new System.Windows.Forms.Panel();
            this.pTotal = new System.Windows.Forms.Panel();
            this.ckbIsPrint = new System.Windows.Forms.CheckBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.lbTotalLang = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountBeforeTax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colSub = new System.Windows.Forms.DataGridViewImageColumn();
            this.colIsBuffet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstSp = new System.Windows.Forms.ListView();
            this.bntFrmMain = new System.Windows.Forms.Button();
            this.bntFinish = new System.Windows.Forms.Button();
            this.pMTop.SuspendLayout();
            this.pSubmenu.SuspendLayout();
            this.pMBottom.SuspendLayout();
            this.pMCenter.SuspendLayout();
            this.pTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pMTop
            // 
            this.pMTop.BackColor = System.Drawing.Color.Transparent;
            this.pMTop.Controls.Add(this.pSubmenu);
            this.pMTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMTop.Location = new System.Drawing.Point(0, 0);
            this.pMTop.Name = "pMTop";
            this.pMTop.Size = new System.Drawing.Size(1022, 82);
            this.pMTop.TabIndex = 0;
            // 
            // pSubmenu
            // 
            this.pSubmenu.BackColor = System.Drawing.Color.Transparent;
            this.pSubmenu.Controls.Add(this.bntFinish);
            this.pSubmenu.Controls.Add(this.btnOrder);
            this.pSubmenu.Controls.Add(this.btnFrmPay);
            this.pSubmenu.Controls.Add(this.bntAll);
            this.pSubmenu.Controls.Add(this.pLstsub);
            this.pSubmenu.Controls.Add(this.btnGoNextMenu);
            this.pSubmenu.Controls.Add(this.btnGoPreMenu);
            this.pSubmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSubmenu.Location = new System.Drawing.Point(0, 0);
            this.pSubmenu.Name = "pSubmenu";
            this.pSubmenu.Size = new System.Drawing.Size(1022, 82);
            this.pSubmenu.TabIndex = 20;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackgroundImage = global::VVPosS.Properties.Resources.ds_order_button;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Image = global::VVPosS.Properties.Resources.ds_order_icon;
            this.btnOrder.Location = new System.Drawing.Point(920, 11);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(101, 61);
            this.btnOrder.TabIndex = 48;
            this.btnOrder.Text = "DS Order";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.bntShowTamTinh_Click);
            // 
            // btnFrmPay
            // 
            this.btnFrmPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrmPay.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmPay.BackgroundImage = global::VVPosS.Properties.Resources.save_button;
            this.btnFrmPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrmPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmPay.FlatAppearance.BorderSize = 0;
            this.btnFrmPay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFrmPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFrmPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFrmPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFrmPay.ForeColor = System.Drawing.Color.Black;
            this.btnFrmPay.Image = global::VVPosS.Properties.Resources.thanhtoan_icon;
            this.btnFrmPay.Location = new System.Drawing.Point(706, 11);
            this.btnFrmPay.Name = "btnFrmPay";
            this.btnFrmPay.Size = new System.Drawing.Size(105, 61);
            this.btnFrmPay.TabIndex = 26;
            this.btnFrmPay.Text = "Thanh toán";
            this.btnFrmPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFrmPay.UseVisualStyleBackColor = false;
            this.btnFrmPay.Click += new System.EventHandler(this.btnFrmPay_Click);
            // 
            // bntAll
            // 
            this.bntAll.BackColor = System.Drawing.Color.Transparent;
            this.bntAll.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.bntAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAll.FlatAppearance.BorderSize = 0;
            this.bntAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntAll.ForeColor = System.Drawing.Color.Black;
            this.bntAll.Image = global::VVPosS.Properties.Resources.all_icon;
            this.bntAll.Location = new System.Drawing.Point(6, 11);
            this.bntAll.Name = "bntAll";
            this.bntAll.Size = new System.Drawing.Size(83, 61);
            this.bntAll.TabIndex = 22;
            this.bntAll.Text = "All";
            this.bntAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntAll.UseVisualStyleBackColor = false;
            this.bntAll.Click += new System.EventHandler(this.bntAll_Click);
            // 
            // pLstsub
            // 
            this.pLstsub.AutoScroll = true;
            this.pLstsub.BackColor = System.Drawing.Color.White;
            this.pLstsub.Location = new System.Drawing.Point(136, 3);
            this.pLstsub.Name = "pLstsub";
            this.pLstsub.Size = new System.Drawing.Size(425, 77);
            this.pLstsub.TabIndex = 12;
            // 
            // btnGoNextMenu
            // 
            this.btnGoNextMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnGoNextMenu.BackgroundImage = global::VVPosS.Properties.Resources.next_button;
            this.btnGoNextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoNextMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoNextMenu.FlatAppearance.BorderSize = 0;
            this.btnGoNextMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGoNextMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoNextMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGoNextMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoNextMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoNextMenu.Image = global::VVPosS.Properties.Resources.next_icon;
            this.btnGoNextMenu.Location = new System.Drawing.Point(567, 24);
            this.btnGoNextMenu.Name = "btnGoNextMenu";
            this.btnGoNextMenu.Size = new System.Drawing.Size(35, 35);
            this.btnGoNextMenu.TabIndex = 11;
            this.btnGoNextMenu.UseVisualStyleBackColor = false;
            this.btnGoNextMenu.Click += new System.EventHandler(this.btnGoNextMenu_Click);
            // 
            // btnGoPreMenu
            // 
            this.btnGoPreMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnGoPreMenu.BackgroundImage = global::VVPosS.Properties.Resources.next_button;
            this.btnGoPreMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoPreMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoPreMenu.FlatAppearance.BorderSize = 0;
            this.btnGoPreMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGoPreMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoPreMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGoPreMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPreMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoPreMenu.Image = global::VVPosS.Properties.Resources.previous_icon;
            this.btnGoPreMenu.Location = new System.Drawing.Point(95, 24);
            this.btnGoPreMenu.Name = "btnGoPreMenu";
            this.btnGoPreMenu.Size = new System.Drawing.Size(35, 35);
            this.btnGoPreMenu.TabIndex = 3;
            this.btnGoPreMenu.UseVisualStyleBackColor = false;
            this.btnGoPreMenu.Click += new System.EventHandler(this.btnGoPreMenu_Click);
            // 
            // pMBottom
            // 
            this.pMBottom.BackColor = System.Drawing.Color.Transparent;
            this.pMBottom.Controls.Add(this.bntFrmMain);
            this.pMBottom.Controls.Add(this.linkNumber);
            this.pMBottom.Controls.Add(this.btnGoNextPro);
            this.pMBottom.Controls.Add(this.btnGoPrePro);
            this.pMBottom.Controls.Add(this.bntTamtinh);
            this.pMBottom.Controls.Add(this.bntShowTamTinh);
            this.pMBottom.Controls.Add(this.bntDesk);
            this.pMBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMBottom.Location = new System.Drawing.Point(0, 694);
            this.pMBottom.Name = "pMBottom";
            this.pMBottom.Size = new System.Drawing.Size(1022, 72);
            this.pMBottom.TabIndex = 1;
            // 
            // linkNumber
            // 
            this.linkNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.linkNumber.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.linkNumber.Location = new System.Drawing.Point(292, 18);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(66, 36);
            this.linkNumber.TabIndex = 47;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "1";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoNextPro
            // 
            this.btnGoNextPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoNextPro.BackColor = System.Drawing.Color.Transparent;
            this.btnGoNextPro.BackgroundImage = global::VVPosS.Properties.Resources.next_button;
            this.btnGoNextPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoNextPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoNextPro.FlatAppearance.BorderSize = 0;
            this.btnGoNextPro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGoNextPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoNextPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGoNextPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoNextPro.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoNextPro.Image = global::VVPosS.Properties.Resources.next_icon;
            this.btnGoNextPro.Location = new System.Drawing.Point(361, 16);
            this.btnGoNextPro.Name = "btnGoNextPro";
            this.btnGoNextPro.Size = new System.Drawing.Size(53, 40);
            this.btnGoNextPro.TabIndex = 46;
            this.btnGoNextPro.UseVisualStyleBackColor = false;
            this.btnGoNextPro.Click += new System.EventHandler(this.btnGoNextPro_Click);
            // 
            // btnGoPrePro
            // 
            this.btnGoPrePro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoPrePro.BackColor = System.Drawing.Color.Transparent;
            this.btnGoPrePro.BackgroundImage = global::VVPosS.Properties.Resources.next_button;
            this.btnGoPrePro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoPrePro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoPrePro.FlatAppearance.BorderSize = 0;
            this.btnGoPrePro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGoPrePro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoPrePro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGoPrePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPrePro.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoPrePro.Image = global::VVPosS.Properties.Resources.previous_icon;
            this.btnGoPrePro.Location = new System.Drawing.Point(235, 16);
            this.btnGoPrePro.Name = "btnGoPrePro";
            this.btnGoPrePro.Size = new System.Drawing.Size(53, 40);
            this.btnGoPrePro.TabIndex = 45;
            this.btnGoPrePro.UseVisualStyleBackColor = false;
            this.btnGoPrePro.Click += new System.EventHandler(this.btnGoPrePro_Click);
            // 
            // bntTamtinh
            // 
            this.bntTamtinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntTamtinh.BackColor = System.Drawing.Color.Transparent;
            this.bntTamtinh.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.bntTamtinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntTamtinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntTamtinh.FlatAppearance.BorderSize = 0;
            this.bntTamtinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntTamtinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntTamtinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntTamtinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntTamtinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTamtinh.ForeColor = System.Drawing.Color.Black;
            this.bntTamtinh.Image = global::VVPosS.Properties.Resources.tamtinh_icon;
            this.bntTamtinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntTamtinh.Location = new System.Drawing.Point(484, 6);
            this.bntTamtinh.Name = "bntTamtinh";
            this.bntTamtinh.Size = new System.Drawing.Size(205, 61);
            this.bntTamtinh.TabIndex = 44;
            this.bntTamtinh.Text = "Tam tinh";
            this.bntTamtinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTamtinh.UseVisualStyleBackColor = false;
            this.bntTamtinh.Visible = false;
            this.bntTamtinh.Click += new System.EventHandler(this.bntTamtinh_Click);
            // 
            // bntShowTamTinh
            // 
            this.bntShowTamTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntShowTamTinh.BackColor = System.Drawing.Color.Transparent;
            this.bntShowTamTinh.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.bntShowTamTinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntShowTamTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntShowTamTinh.FlatAppearance.BorderSize = 0;
            this.bntShowTamTinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntShowTamTinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntShowTamTinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntShowTamTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntShowTamTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntShowTamTinh.ForeColor = System.Drawing.Color.Black;
            this.bntShowTamTinh.Image = global::VVPosS.Properties.Resources.ds_tamtinh_icon;
            this.bntShowTamTinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntShowTamTinh.Location = new System.Drawing.Point(693, 6);
            this.bntShowTamTinh.Name = "bntShowTamTinh";
            this.bntShowTamTinh.Size = new System.Drawing.Size(205, 61);
            this.bntShowTamTinh.TabIndex = 42;
            this.bntShowTamTinh.Text = "DS tam tinh";
            this.bntShowTamTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntShowTamTinh.UseVisualStyleBackColor = false;
            this.bntShowTamTinh.Visible = false;
            this.bntShowTamTinh.Click += new System.EventHandler(this.bntShowTamTinh_Click);
            // 
            // bntDesk
            // 
            this.bntDesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDesk.BackColor = System.Drawing.Color.Transparent;
            this.bntDesk.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.bntDesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntDesk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntDesk.FlatAppearance.BorderSize = 0;
            this.bntDesk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDesk.ForeColor = System.Drawing.Color.Black;
            this.bntDesk.Image = global::VVPosS.Properties.Resources.ban_black_icon;
            this.bntDesk.Location = new System.Drawing.Point(6, 5);
            this.bntDesk.Name = "bntDesk";
            this.bntDesk.Size = new System.Drawing.Size(180, 61);
            this.bntDesk.TabIndex = 40;
            this.bntDesk.Text = "Desk";
            this.bntDesk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntDesk.UseVisualStyleBackColor = false;
            this.bntDesk.Visible = false;
            this.bntDesk.Click += new System.EventHandler(this.bntDesk_Click);
            // 
            // pMCenter
            // 
            this.pMCenter.BackColor = System.Drawing.Color.Transparent;
            this.pMCenter.Controls.Add(this.pTotal);
            this.pMCenter.Controls.Add(this.DataGridView1);
            this.pMCenter.Controls.Add(this.lstSp);
            this.pMCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMCenter.Location = new System.Drawing.Point(0, 82);
            this.pMCenter.Name = "pMCenter";
            this.pMCenter.Size = new System.Drawing.Size(1022, 612);
            this.pMCenter.TabIndex = 2;
            // 
            // pTotal
            // 
            this.pTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pTotal.BackColor = System.Drawing.Color.Transparent;
            this.pTotal.BackgroundImage = global::VVPosS.Properties.Resources.bg02;
            this.pTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTotal.Controls.Add(this.ckbIsPrint);
            this.pTotal.Controls.Add(this.txtDiscount);
            this.pTotal.Controls.Add(this.lbDiscount);
            this.pTotal.Controls.Add(this.lbtotal);
            this.pTotal.Controls.Add(this.lbTotalLang);
            this.pTotal.Location = new System.Drawing.Point(416, -1);
            this.pTotal.Margin = new System.Windows.Forms.Padding(0);
            this.pTotal.Name = "pTotal";
            this.pTotal.Size = new System.Drawing.Size(607, 117);
            this.pTotal.TabIndex = 32;
            // 
            // ckbIsPrint
            // 
            this.ckbIsPrint.BackColor = System.Drawing.Color.Transparent;
            this.ckbIsPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIsPrint.Location = new System.Drawing.Point(243, 76);
            this.ckbIsPrint.Name = "ckbIsPrint";
            this.ckbIsPrint.Size = new System.Drawing.Size(167, 36);
            this.ckbIsPrint.TabIndex = 4;
            this.ckbIsPrint.Text = "In ra bếp";
            this.ckbIsPrint.UseVisualStyleBackColor = false;
            this.ckbIsPrint.CheckedChanged += new System.EventHandler(this.ckbIsPrint_CheckedChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(243, 12);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(255, 26);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.Visible = false;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.MouseEnter += new System.EventHandler(this.txtDiscount_MouseEnter);
            this.txtDiscount.MouseLeave += new System.EventHandler(this.txtDiscount_MouseLeave);
            // 
            // lbDiscount
            // 
            this.lbDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDiscount.Location = new System.Drawing.Point(44, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(190, 41);
            this.lbDiscount.TabIndex = 2;
            this.lbDiscount.Text = "Discount";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDiscount.Visible = false;
            // 
            // lbtotal
            // 
            this.lbtotal.BackColor = System.Drawing.Color.White;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbtotal.ForeColor = System.Drawing.Color.Red;
            this.lbtotal.Location = new System.Drawing.Point(240, 41);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(258, 35);
            this.lbtotal.TabIndex = 1;
            this.lbtotal.Text = "0";
            this.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalLang
            // 
            this.lbTotalLang.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalLang.Location = new System.Drawing.Point(47, 34);
            this.lbTotalLang.Name = "lbTotalLang";
            this.lbTotalLang.Size = new System.Drawing.Size(190, 41);
            this.lbTotalLang.TabIndex = 0;
            this.lbTotalLang.Text = "Tổng cộng";
            this.lbTotalLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.stt,
            this.ProductName,
            this.ProductId,
            this.Qty,
            this.Price,
            this.AmountBeforeTax1,
            this.VAT,
            this.TotalAmount,
            this.colNotes,
            this.colDelete,
            this.colSub,
            this.colIsBuffet});
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(416, 115);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.Size = new System.Drawing.Size(606, 495);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "OrderId";
            this.OrderId.Name = "OrderId";
            this.OrderId.Visible = false;
            // 
            // stt
            // 
            this.stt.HeaderText = "NO";
            this.stt.Name = "stt";
            this.stt.Width = 40;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 120;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.Width = 42;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // AmountBeforeTax1
            // 
            this.AmountBeforeTax1.HeaderText = "AmountBeforeTax1";
            this.AmountBeforeTax1.Name = "AmountBeforeTax1";
            this.AmountBeforeTax1.Visible = false;
            this.AmountBeforeTax1.Width = 102;
            // 
            // VAT
            // 
            this.VAT.HeaderText = "VAT";
            this.VAT.Name = "VAT";
            this.VAT.Visible = false;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "ToltalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 102;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Width = 101;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Image = global::VVPosS.Properties.Resources.delete_icon;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.Width = 60;
            // 
            // colSub
            // 
            this.colSub.HeaderText = "Sub";
            this.colSub.Image = global::VVPosS.Properties.Resources.select_number;
            this.colSub.Name = "colSub";
            this.colSub.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSub.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSub.Width = 60;
            // 
            // colIsBuffet
            // 
            this.colIsBuffet.HeaderText = "IsBuffet";
            this.colIsBuffet.Name = "colIsBuffet";
            this.colIsBuffet.Visible = false;
            // 
            // lstSp
            // 
            this.lstSp.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstSp.AllowColumnReorder = true;
            this.lstSp.AllowDrop = true;
            this.lstSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSp.GridLines = true;
            this.lstSp.HoverSelection = true;
            this.lstSp.LabelEdit = true;
            this.lstSp.Location = new System.Drawing.Point(0, 0);
            this.lstSp.Margin = new System.Windows.Forms.Padding(0);
            this.lstSp.MultiSelect = false;
            this.lstSp.Name = "lstSp";
            this.lstSp.Size = new System.Drawing.Size(416, 610);
            this.lstSp.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstSp.TabIndex = 1;
            this.lstSp.UseCompatibleStateImageBehavior = false;
            this.lstSp.Click += new System.EventHandler(this.lstSp_Click);
            // 
            // bntFrmMain
            // 
            this.bntFrmMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFrmMain.BackColor = System.Drawing.Color.Transparent;
            this.bntFrmMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntFrmMain.BackgroundImage")));
            this.bntFrmMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntFrmMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntFrmMain.FlatAppearance.BorderSize = 0;
            this.bntFrmMain.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntFrmMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntFrmMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntFrmMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntFrmMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFrmMain.ForeColor = System.Drawing.Color.Black;
            this.bntFrmMain.Image = global::VVPosS.Properties.Resources.thoat_icon;
            this.bntFrmMain.Location = new System.Drawing.Point(915, 6);
            this.bntFrmMain.Name = "bntFrmMain";
            this.bntFrmMain.Size = new System.Drawing.Size(105, 61);
            this.bntFrmMain.TabIndex = 48;
            this.bntFrmMain.Text = "Main";
            this.bntFrmMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntFrmMain.UseVisualStyleBackColor = false;
            this.bntFrmMain.Click += new System.EventHandler(this.bntFrmMain_Click);
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
            this.bntFinish.Location = new System.Drawing.Point(817, 11);
            this.bntFinish.Name = "bntFinish";
            this.bntFinish.Size = new System.Drawing.Size(100, 61);
            this.bntFinish.TabIndex = 49;
            this.bntFinish.Text = "Tam tinh";
            this.bntFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntFinish.UseVisualStyleBackColor = false;
            this.bntFinish.Click += new System.EventHandler(this.bntTamtinh_Click);
            // 
            // frmServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::VVPosS.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(1022, 766);
            this.Controls.Add(this.pMCenter);
            this.Controls.Add(this.pMBottom);
            this.Controls.Add(this.pMTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.pMTop.ResumeLayout(false);
            this.pSubmenu.ResumeLayout(false);
            this.pMBottom.ResumeLayout(false);
            this.pMCenter.ResumeLayout(false);
            this.pTotal.ResumeLayout(false);
            this.pTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pMTop;
        private System.Windows.Forms.Panel pMBottom;
        private System.Windows.Forms.Panel pMCenter;
        private System.Windows.Forms.Panel pSubmenu;
        private System.Windows.Forms.Panel pLstsub;
        private System.Windows.Forms.Button btnGoNextMenu;
        private System.Windows.Forms.Button btnGoPreMenu;
        private System.Windows.Forms.Button bntAll;
        private System.Windows.Forms.Button btnFrmPay;
        private System.Windows.Forms.Button bntTamtinh;
        private System.Windows.Forms.Button bntShowTamTinh;
        private System.Windows.Forms.Button bntDesk;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button btnGoNextPro;
        private System.Windows.Forms.Button btnGoPrePro;
        private System.Windows.Forms.ListView lstSp;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Panel pTotal;
        private System.Windows.Forms.CheckBox ckbIsPrint;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label lbTotalLang;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountBeforeTax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewImageColumn colSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsBuffet;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button bntFinish;
        private System.Windows.Forms.Button bntFrmMain;
        //private VVPosS.Controls.NumericTextBox txtDiscount;
    }
}