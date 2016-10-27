namespace VVPosS.Screen.POS
{
    partial class frmOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbUserText = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.ckbIsPrint = new System.Windows.Forms.CheckBox();
            this.pNote = new System.Windows.Forms.Panel();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.lbReceiptDetail = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.dataGridViewReceiptDetail = new System.Windows.Forms.DataGridView();
            this.lbSelectOrder = new System.Windows.Forms.Label();
            this.dataGridViewListOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeskOrder = new System.Windows.Forms.Button();
            this.btnALlOrders = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.bntFinish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmmountBeforeTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserText
            // 
            this.lbUserText.AutoSize = true;
            this.lbUserText.BackColor = System.Drawing.Color.Transparent;
            this.lbUserText.Enabled = false;
            this.lbUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserText.Location = new System.Drawing.Point(326, 21);
            this.lbUserText.Name = "lbUserText";
            this.lbUserText.Size = new System.Drawing.Size(93, 17);
            this.lbUserText.TabIndex = 84;
            this.lbUserText.Text = "Mã nhân viên";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(429, 20);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(123, 22);
            this.txtUser.TabIndex = 85;
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_MouseLeave);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbUser.Location = new System.Drawing.Point(379, 52);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(0, 16);
            this.lbUser.TabIndex = 89;
            // 
            // ckbIsPrint
            // 
            this.ckbIsPrint.BackColor = System.Drawing.Color.Transparent;
            this.ckbIsPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIsPrint.Location = new System.Drawing.Point(565, 22);
            this.ckbIsPrint.Name = "ckbIsPrint";
            this.ckbIsPrint.Size = new System.Drawing.Size(101, 21);
            this.ckbIsPrint.TabIndex = 93;
            this.ckbIsPrint.Text = "In ra bếp";
            this.ckbIsPrint.UseVisualStyleBackColor = false;
            this.ckbIsPrint.Visible = false;
            this.ckbIsPrint.CheckedChanged += new System.EventHandler(this.ckbIsPrint_CheckedChanged);
            // 
            // pNote
            // 
            this.pNote.BackColor = System.Drawing.Color.White;
            this.pNote.Controls.Add(this.btnAddDiscount);
            this.pNote.Controls.Add(this.lbReceiptDetail);
            this.pNote.Controls.Add(this.lbNotes);
            this.pNote.Controls.Add(this.rtxtNotes);
            this.pNote.Location = new System.Drawing.Point(376, 98);
            this.pNote.Name = "pNote";
            this.pNote.Size = new System.Drawing.Size(646, 172);
            this.pNote.TabIndex = 94;
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDiscount.BackgroundImage = global::VVPosS.Properties.Resources.saleoff_button;
            this.btnAddDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDiscount.FlatAppearance.BorderSize = 0;
            this.btnAddDiscount.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAddDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiscount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.Image = global::VVPosS.Properties.Resources.sale_icon;
            this.btnAddDiscount.Location = new System.Drawing.Point(452, 49);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(173, 48);
            this.btnAddDiscount.TabIndex = 102;
            this.btnAddDiscount.Text = "Chọn theo Bàn";
            this.btnAddDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDiscount.UseVisualStyleBackColor = false;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // lbReceiptDetail
            // 
            this.lbReceiptDetail.AutoSize = true;
            this.lbReceiptDetail.BackColor = System.Drawing.Color.Transparent;
            this.lbReceiptDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiptDetail.Location = new System.Drawing.Point(17, 132);
            this.lbReceiptDetail.Name = "lbReceiptDetail";
            this.lbReceiptDetail.Size = new System.Drawing.Size(142, 17);
            this.lbReceiptDetail.TabIndex = 99;
            this.lbReceiptDetail.Text = "Danh sách sản phẩm";
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.BackColor = System.Drawing.Color.Transparent;
            this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(17, 14);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(57, 17);
            this.lbNotes.TabIndex = 98;
            this.lbNotes.Text = "Ghi chú";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotes.Location = new System.Drawing.Point(17, 36);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtxtNotes.Size = new System.Drawing.Size(399, 75);
            this.rtxtNotes.TabIndex = 97;
            this.rtxtNotes.Text = "";
            // 
            // dataGridViewReceiptDetail
            // 
            this.dataGridViewReceiptDetail.AllowUserToAddRows = false;
            this.dataGridViewReceiptDetail.AllowUserToDeleteRows = false;
            this.dataGridViewReceiptDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReceiptDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceiptDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colOrderId,
            this.colProductId,
            this.colPromotionId,
            this.colProductName,
            this.colQty,
            this.colPrice,
            this.colAmmountBeforeTax,
            this.colTaxAmmount,
            this.colTotalAmmount,
            this.colDelete,
            this.colUpdate,
            this.colStatus,
            this.colNote});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceiptDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReceiptDetail.EnableHeadersVisualStyles = false;
            this.dataGridViewReceiptDetail.Location = new System.Drawing.Point(376, 254);
            this.dataGridViewReceiptDetail.Name = "dataGridViewReceiptDetail";
            this.dataGridViewReceiptDetail.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReceiptDetail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReceiptDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReceiptDetail.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewReceiptDetail.RowTemplate.DividerHeight = 1;
            this.dataGridViewReceiptDetail.RowTemplate.Height = 50;
            this.dataGridViewReceiptDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReceiptDetail.Size = new System.Drawing.Size(646, 510);
            this.dataGridViewReceiptDetail.TabIndex = 97;
            this.dataGridViewReceiptDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceiptDetail_CellClick);
            this.dataGridViewReceiptDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewReceiptDetail_CellValidating);
            this.dataGridViewReceiptDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceiptDetail_CellValueChanged);
            this.dataGridViewReceiptDetail.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewReceiptDetail_EditingControlShowing);
            // 
            // lbSelectOrder
            // 
            this.lbSelectOrder.AutoSize = true;
            this.lbSelectOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbSelectOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectOrder.Location = new System.Drawing.Point(22, 73);
            this.lbSelectOrder.Name = "lbSelectOrder";
            this.lbSelectOrder.Size = new System.Drawing.Size(142, 17);
            this.lbSelectOrder.TabIndex = 100;
            this.lbSelectOrder.Text = "Danh sách sản phẩm";
            // 
            // dataGridViewListOrder
            // 
            this.dataGridViewListOrder.AllowUserToAddRows = false;
            this.dataGridViewListOrder.AllowUserToDeleteRows = false;
            this.dataGridViewListOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column13,
            this.Column5,
            this.Column4,
            this.colPrint,
            this.colDel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewListOrder.EnableHeadersVisualStyles = false;
            this.dataGridViewListOrder.Location = new System.Drawing.Point(4, 98);
            this.dataGridViewListOrder.Name = "dataGridViewListOrder";
            this.dataGridViewListOrder.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListOrder.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewListOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListOrder.RowTemplate.Height = 50;
            this.dataGridViewListOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOrder.Size = new System.Drawing.Size(368, 666);
            this.dataGridViewListOrder.TabIndex = 101;
            this.dataGridViewListOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListOrder_CellClick);
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Order";
            this.Column2.MinimumWidth = 2;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã bàn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 80;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "TT Bàn ";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Ngày tạo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // colPrint
            // 
            this.colPrint.HeaderText = "Print";
            this.colPrint.Image = global::VVPosS.Properties.Resources.print_icon;
            this.colPrint.Name = "colPrint";
            this.colPrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrint.Width = 70;
            // 
            // colDel
            // 
            this.colDel.HeaderText = "Delete";
            this.colDel.Name = "colDel";
            this.colDel.Visible = false;
            // 
            // btnDeskOrder
            // 
            this.btnDeskOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnDeskOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeskOrder.BackgroundImage")));
            this.btnDeskOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeskOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeskOrder.FlatAppearance.BorderSize = 0;
            this.btnDeskOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDeskOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeskOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeskOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeskOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeskOrder.Image = global::VVPosS.Properties.Resources.ban_black_icon;
            this.btnDeskOrder.Location = new System.Drawing.Point(159, 4);
            this.btnDeskOrder.Name = "btnDeskOrder";
            this.btnDeskOrder.Size = new System.Drawing.Size(154, 59);
            this.btnDeskOrder.TabIndex = 99;
            this.btnDeskOrder.Text = "Chọn theo Bàn";
            this.btnDeskOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeskOrder.UseVisualStyleBackColor = false;
            this.btnDeskOrder.Visible = false;
            this.btnDeskOrder.Click += new System.EventHandler(this.btnDeskOrder_Click);
            // 
            // btnALlOrders
            // 
            this.btnALlOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnALlOrders.BackgroundImage = global::VVPosS.Properties.Resources.ds_all_button;
            this.btnALlOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnALlOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnALlOrders.FlatAppearance.BorderSize = 0;
            this.btnALlOrders.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnALlOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnALlOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnALlOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnALlOrders.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALlOrders.Image = global::VVPosS.Properties.Resources.all_icon;
            this.btnALlOrders.Location = new System.Drawing.Point(4, 4);
            this.btnALlOrders.Name = "btnALlOrders";
            this.btnALlOrders.Size = new System.Drawing.Size(153, 59);
            this.btnALlOrders.TabIndex = 98;
            this.btnALlOrders.Text = "Tất cả";
            this.btnALlOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnALlOrders.UseVisualStyleBackColor = false;
            this.btnALlOrders.Click += new System.EventHandler(this.btnALlOrders_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_02;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = global::VVPosS.Properties.Resources.reser_icon;
            this.btnReset.Location = new System.Drawing.Point(778, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 61);
            this.btnReset.TabIndex = 88;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // bntFinish
            // 
            this.bntFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFinish.BackColor = System.Drawing.Color.Transparent;
            this.bntFinish.BackgroundImage = global::VVPosS.Properties.Resources.save_button;
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
            this.bntFinish.Location = new System.Drawing.Point(672, 4);
            this.bntFinish.Name = "bntFinish";
            this.bntFinish.Size = new System.Drawing.Size(100, 61);
            this.bntFinish.TabIndex = 86;
            this.bntFinish.Text = "Hoàn tất";
            this.bntFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntFinish.UseVisualStyleBackColor = false;
            this.bntFinish.Click += new System.EventHandler(this.bntFinish_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::VVPosS.Properties.Resources.button_basic_01;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::VVPosS.Properties.Resources.thoat_icon;
            this.btnExit.Location = new System.Drawing.Point(884, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 61);
            this.btnExit.TabIndex = 87;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "STT";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNo.Width = 40;
            // 
            // colOrderId
            // 
            this.colOrderId.HeaderText = "Mã Order";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            this.colOrderId.Visible = false;
            // 
            // colProductId
            // 
            this.colProductId.HeaderText = "Mã SP";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // colPromotionId
            // 
            this.colPromotionId.HeaderText = "PromotionId";
            this.colPromotionId.Name = "colPromotionId";
            this.colPromotionId.ReadOnly = true;
            this.colPromotionId.Visible = false;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Sản phẩm";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 280;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "SL";
            this.colQty.MaxInputLength = 26;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 50;
            // 
            // colPrice
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrice.HeaderText = "DG";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 90;
            // 
            // colAmmountBeforeTax
            // 
            this.colAmmountBeforeTax.HeaderText = "TT";
            this.colAmmountBeforeTax.Name = "colAmmountBeforeTax";
            this.colAmmountBeforeTax.ReadOnly = true;
            this.colAmmountBeforeTax.Visible = false;
            this.colAmmountBeforeTax.Width = 90;
            // 
            // colTaxAmmount
            // 
            this.colTaxAmmount.HeaderText = "Thuế";
            this.colTaxAmmount.Name = "colTaxAmmount";
            this.colTaxAmmount.ReadOnly = true;
            this.colTaxAmmount.Visible = false;
            this.colTaxAmmount.Width = 90;
            // 
            // colTotalAmmount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.colTotalAmmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotalAmmount.HeaderText = "TT + Thuế";
            this.colTotalAmmount.Name = "colTotalAmmount";
            this.colTotalAmmount.ReadOnly = true;
            this.colTotalAmmount.Width = 90;
            // 
            // colDelete
            // 
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "Xóa";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = false;
            this.colDelete.Width = 47;
            // 
            // colUpdate
            // 
            this.colUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUpdate.HeaderText = "Sửa";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Visible = false;
            this.colUpdate.Width = 47;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = false;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Notes";
            this.colNote.Name = "colNote";
            this.colNote.Visible = false;
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewListOrder);
            this.Controls.Add(this.lbSelectOrder);
            this.Controls.Add(this.btnDeskOrder);
            this.Controls.Add(this.btnALlOrders);
            this.Controls.Add(this.dataGridViewReceiptDetail);
            this.Controls.Add(this.pNote);
            this.Controls.Add(this.ckbIsPrint);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bntFinish);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbUserText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            this.pNote.ResumeLayout(false);
            this.pNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserText;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button bntFinish;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.CheckBox ckbIsPrint;
        private System.Windows.Forms.Panel pNote;
        private System.Windows.Forms.Label lbReceiptDetail;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.DataGridView dataGridViewReceiptDetail;
        private System.Windows.Forms.Button btnDeskOrder;
        private System.Windows.Forms.Button btnALlOrders;
        private System.Windows.Forms.Label lbSelectOrder;
        private System.Windows.Forms.DataGridView dataGridViewListOrder;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn colPrint;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmmountBeforeTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}