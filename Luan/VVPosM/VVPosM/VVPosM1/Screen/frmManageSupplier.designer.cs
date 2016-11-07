namespace VVPosM1.Screen
{
    partial class frmManageSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSupplier));
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblTB1 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.bntReset = new System.Windows.Forms.Button();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntPre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntSeach = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblWWebsite = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.pInput = new System.Windows.Forms.Panel();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcel.Image = global::VVPosM1.Properties.Resources._1409729156_excel;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(429, 147);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 51);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblTB1
            // 
            this.lblTB1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB1.Location = new System.Drawing.Point(469, 209);
            this.lblTB1.Name = "lblTB1";
            this.lblTB1.Size = new System.Drawing.Size(274, 37);
            this.lblTB1.TabIndex = 62;
            this.lblTB1.Text = "...";
            // 
            // lblTB
            // 
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(468, 246);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(440, 21);
            this.lblTB.TabIndex = 61;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bntReset
            // 
            this.bntReset.BackColor = System.Drawing.Color.ForestGreen;
            this.bntReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntReset.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.bntReset.Location = new System.Drawing.Point(336, 147);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(91, 51);
            this.bntReset.TabIndex = 9;
            this.bntReset.Text = "Reset";
            this.bntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntReset.UseVisualStyleBackColor = false;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // linkNumber
            // 
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(995, 248);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(72, 20);
            this.linkNumber.TabIndex = 59;
            this.linkNumber.TabStop = true;
            this.linkNumber.Text = "1";
            this.linkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntNext
            // 
            this.bntNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNext.BackColor = System.Drawing.Color.OrangeRed;
            this.bntNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntNext.ForeColor = System.Drawing.Color.Transparent;
            this.bntNext.Location = new System.Drawing.Point(1073, 234);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(75, 33);
            this.bntNext.TabIndex = 60;
            this.bntNext.Text = ">";
            this.bntNext.UseVisualStyleBackColor = false;
            this.bntNext.Click += new System.EventHandler(this.bntNext_Click);
            // 
            // bntPre
            // 
            this.bntPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPre.BackColor = System.Drawing.Color.OrangeRed;
            this.bntPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntPre.ForeColor = System.Drawing.Color.Transparent;
            this.bntPre.Location = new System.Drawing.Point(914, 235);
            this.bntPre.Name = "bntPre";
            this.bntPre.Size = new System.Drawing.Size(75, 32);
            this.bntPre.TabIndex = 58;
            this.bntPre.Text = "<";
            this.bntPre.UseVisualStyleBackColor = false;
            this.bntPre.Click += new System.EventHandler(this.bntPre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1202, 369);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách NCC";
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SupplierId,
            this.SupplierName,
            this.Address,
            this.Phone,
            this.Email,
            this.Website,
            this.Delete});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Size = new System.Drawing.Size(1196, 344);
            this.dgv.TabIndex = 24;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Mã NCC";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            this.SupplierId.Width = 150;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Tên ";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 180;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 120;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Website
            // 
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            this.Website.Width = 200;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.DarkRed;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntExit.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.bntExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExit.Location = new System.Drawing.Point(523, 147);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(91, 51);
            this.bntExit.TabIndex = 10;
            this.bntExit.Text = "Thoát";
            this.bntExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.Color.Red;
            this.bntLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntLuu.Image = global::VVPosM1.Properties.Resources._1404381785_save;
            this.bntLuu.Location = new System.Drawing.Point(243, 147);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(91, 51);
            this.bntLuu.TabIndex = 8;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntSeach
            // 
            this.bntSeach.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bntSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntSeach.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntSeach.Image = global::VVPosM1.Properties.Resources._1404382137_meanicons_32;
            this.bntSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSeach.Location = new System.Drawing.Point(150, 147);
            this.bntSeach.Name = "bntSeach";
            this.bntSeach.Size = new System.Drawing.Size(91, 51);
            this.bntSeach.TabIndex = 7;
            this.bntSeach.Text = "Tìm kiếm";
            this.bntSeach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSeach.UseVisualStyleBackColor = false;
            this.bntSeach.Click += new System.EventHandler(this.bntSeach_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(617, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 29);
            this.txtEmail.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(150, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierId.Location = new System.Drawing.Point(149, 13);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.ReadOnly = true;
            this.txtSupplierId.Size = new System.Drawing.Size(335, 29);
            this.txtSupplierId.TabIndex = 0;
            // 
            // lblWWebsite
            // 
            this.lblWWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWWebsite.Location = new System.Drawing.Point(508, 86);
            this.lblWWebsite.Name = "lblWWebsite";
            this.lblWWebsite.Size = new System.Drawing.Size(96, 16);
            this.lblWWebsite.TabIndex = 17;
            this.lblWWebsite.Text = "Website";
            this.lblWWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(511, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(57, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 16);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Địa chỉ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Tên NCC *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierId.Location = new System.Drawing.Point(13, 16);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(122, 16);
            this.lblSupplierId.TabIndex = 12;
            this.lblSupplierId.Text = "Mã NCC";
            this.lblSupplierId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pInput
            // 
            this.pInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pInput.BackColor = System.Drawing.Color.Transparent;
            this.pInput.Controls.Add(this.txtSite);
            this.pInput.Controls.Add(this.txtPhone);
            this.pInput.Controls.Add(this.lbPhone);
            this.pInput.Controls.Add(this.txtAddress);
            this.pInput.Controls.Add(this.btnExcel);
            this.pInput.Controls.Add(this.lblTB1);
            this.pInput.Controls.Add(this.lblTB);
            this.pInput.Controls.Add(this.bntReset);
            this.pInput.Controls.Add(this.linkNumber);
            this.pInput.Controls.Add(this.bntNext);
            this.pInput.Controls.Add(this.bntPre);
            this.pInput.Controls.Add(this.bntExit);
            this.pInput.Controls.Add(this.bntLuu);
            this.pInput.Controls.Add(this.bntSeach);
            this.pInput.Controls.Add(this.txtEmail);
            this.pInput.Controls.Add(this.txtName);
            this.pInput.Controls.Add(this.txtSupplierId);
            this.pInput.Controls.Add(this.lblWWebsite);
            this.pInput.Controls.Add(this.lblEmail);
            this.pInput.Controls.Add(this.lblAddress);
            this.pInput.Controls.Add(this.lblName);
            this.pInput.Controls.Add(this.lblSupplierId);
            this.pInput.Location = new System.Drawing.Point(-1, 1);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(1205, 281);
            this.pInput.TabIndex = 26;
            // 
            // txtSite
            // 
            this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(617, 78);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(335, 29);
            this.txtSite.TabIndex = 67;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(617, 12);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 29);
            this.txtPhone.TabIndex = 66;
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(511, 15);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(93, 16);
            this.lbPhone.TabIndex = 65;
            this.lbPhone.Text = "Phone";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(149, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(335, 29);
            this.txtAddress.TabIndex = 2;
            // 
            // frmManageSupplier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1198, 653);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmManageSupplier";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblTB1;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntSeach;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblWWebsite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox txtSite;
    }
}