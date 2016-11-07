namespace VVPosM1.Screen
{
    partial class frmManageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pInput = new System.Windows.Forms.Panel();
            this.cboRoleId = new System.Windows.Forms.ComboBox();
            this.lblMaDT = new System.Windows.Forms.Label();
            this.txtObject = new VVPosM1.Controls.CoolTextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblTB1 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.bntReset = new System.Windows.Forms.Button();
            this.linkNumber = new System.Windows.Forms.LinkLabel();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntPre = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntSeach = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblRoleId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblObjectId = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pInput.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Size = new System.Drawing.Size(1200, 284);
            this.dgv.TabIndex = 24;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã người dùng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Thông tin người dùng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thời gian đăng nhập gần nhất";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quyền của người dùng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TT Khởi tạo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Delete";
            this.Column8.Image = global::VVPosM1.Properties.Resources._1404478970_f_cross;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 309);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người sử dụng";
            // 
            // pInput
            // 
            this.pInput.Controls.Add(this.cboRoleId);
            this.pInput.Controls.Add(this.lblMaDT);
            this.pInput.Controls.Add(this.txtObject);
            this.pInput.Controls.Add(this.cboStatus);
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
            this.pInput.Controls.Add(this.txtPwd);
            this.pInput.Controls.Add(this.txtUserId);
            this.pInput.Controls.Add(this.lblRoleId);
            this.pInput.Controls.Add(this.lblStatus);
            this.pInput.Controls.Add(this.lblObjectId);
            this.pInput.Controls.Add(this.lblPwd);
            this.pInput.Controls.Add(this.lblUserId);
            this.pInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInput.Location = new System.Drawing.Point(0, 0);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(1206, 342);
            this.pInput.TabIndex = 96;
            // 
            // cboRoleId
            // 
            this.cboRoleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoleId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoleId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoleId.FormattingEnabled = true;
            this.cboRoleId.Location = new System.Drawing.Point(723, 76);
            this.cboRoleId.Name = "cboRoleId";
            this.cboRoleId.Size = new System.Drawing.Size(361, 26);
            this.cboRoleId.TabIndex = 99;
            // 
            // lblMaDT
            // 
            this.lblMaDT.AutoSize = true;
            this.lblMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDT.Location = new System.Drawing.Point(161, 115);
            this.lblMaDT.Name = "lblMaDT";
            this.lblMaDT.Size = new System.Drawing.Size(0, 16);
            this.lblMaDT.TabIndex = 115;
            // 
            // txtObject
            // 
            this.txtObject.AutoScroll = true;
            this.txtObject.BackColor = System.Drawing.SystemColors.Window;
            this.txtObject.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtObject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObject.Location = new System.Drawing.Point(163, 92);
            this.txtObject.Name = "txtObject";
            this.txtObject.Padding = new System.Windows.Forms.Padding(4);
            this.txtObject.PopupWidth = 300;
            this.txtObject.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.txtObject.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtObject.Size = new System.Drawing.Size(335, 27);
            this.txtObject.TabIndex = 97;
            this.txtObject.Validated += new System.EventHandler(this.txtObject_Validated);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Được sử dụng",
            "Đang sửa"});
            this.cboStatus.Location = new System.Drawing.Point(723, 24);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(361, 26);
            this.cboStatus.TabIndex = 98;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcel.Image = global::VVPosM1.Properties.Resources._1409729156_excel;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(633, 180);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 51);
            this.btnExcel.TabIndex = 104;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblTB1
            // 
            this.lblTB1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB1.Location = new System.Drawing.Point(351, 248);
            this.lblTB1.Name = "lblTB1";
            this.lblTB1.Size = new System.Drawing.Size(468, 21);
            this.lblTB1.TabIndex = 114;
            this.lblTB1.Text = "...";
            this.lblTB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTB
            // 
            this.lblTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTB.Location = new System.Drawing.Point(351, 285);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(468, 21);
            this.lblTB.TabIndex = 113;
            this.lblTB.Text = "...";
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntReset
            // 
            this.bntReset.BackColor = System.Drawing.Color.ForestGreen;
            this.bntReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntReset.Image = global::VVPosM1.Properties.Resources._1404382393_icon_ios7_undo;
            this.bntReset.Location = new System.Drawing.Point(540, 180);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(91, 51);
            this.bntReset.TabIndex = 102;
            this.bntReset.Text = "Reset";
            this.bntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntReset.UseVisualStyleBackColor = false;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click_1);
            // 
            // linkNumber
            // 
            this.linkNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNumber.Location = new System.Drawing.Point(1057, 299);
            this.linkNumber.Name = "linkNumber";
            this.linkNumber.Size = new System.Drawing.Size(46, 20);
            this.linkNumber.TabIndex = 111;
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
            this.bntNext.Location = new System.Drawing.Point(1112, 286);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(75, 33);
            this.bntNext.TabIndex = 112;
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
            this.bntPre.Location = new System.Drawing.Point(979, 287);
            this.bntPre.Name = "bntPre";
            this.bntPre.Size = new System.Drawing.Size(75, 32);
            this.bntPre.TabIndex = 110;
            this.bntPre.Text = "<";
            this.bntPre.UseVisualStyleBackColor = false;
            this.bntPre.Click += new System.EventHandler(this.bntPre_Click);
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.DarkRed;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntExit.Image = global::VVPosM1.Properties.Resources._1404382724_common_logout_signout_exit;
            this.bntExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExit.Location = new System.Drawing.Point(727, 180);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(91, 51);
            this.bntExit.TabIndex = 103;
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
            this.bntLuu.Location = new System.Drawing.Point(447, 180);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(91, 51);
            this.bntLuu.TabIndex = 101;
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
            this.bntSeach.Location = new System.Drawing.Point(354, 180);
            this.bntSeach.Name = "bntSeach";
            this.bntSeach.Size = new System.Drawing.Size(91, 51);
            this.bntSeach.TabIndex = 100;
            this.bntSeach.Text = "Tìm kiếm";
            this.bntSeach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSeach.UseVisualStyleBackColor = false;
            this.bntSeach.Click += new System.EventHandler(this.bntSeach_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(163, 58);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(334, 29);
            this.txtPwd.TabIndex = 96;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(162, 24);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(335, 29);
            this.txtUserId.TabIndex = 95;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // lblRoleId
            // 
            this.lblRoleId.AutoSize = true;
            this.lblRoleId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleId.Location = new System.Drawing.Point(561, 81);
            this.lblRoleId.Name = "lblRoleId";
            this.lblRoleId.Size = new System.Drawing.Size(142, 16);
            this.lblRoleId.TabIndex = 109;
            this.lblRoleId.Text = "Quyền của người dùng";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(638, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 16);
            this.lblStatus.TabIndex = 108;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lblObjectId
            // 
            this.lblObjectId.AutoSize = true;
            this.lblObjectId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectId.Location = new System.Drawing.Point(19, 96);
            this.lblObjectId.Name = "lblObjectId";
            this.lblObjectId.Size = new System.Drawing.Size(131, 16);
            this.lblObjectId.TabIndex = 107;
            this.lblObjectId.Text = "Thông tin đối tượng *";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(78, 64);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(71, 16);
            this.lblPwd.TabIndex = 106;
            this.lblPwd.Text = "Mật khẩu *";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(43, 25);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(106, 16);
            this.lblUserId.TabIndex = 105;
            this.lblUserId.Text = "Mã người dùng *";
            // 
            // frmManageUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.ControlBox = false;
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.ComboBox cboRoleId;
        private System.Windows.Forms.Label lblMaDT;
        private Controls.CoolTextBox txtObject;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblTB1;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.LinkLabel linkNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntPre;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntSeach;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblObjectId;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}