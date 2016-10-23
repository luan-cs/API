namespace VVPosM1.Screen.CRM.Types
{
    partial class frmCustommerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustommerType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.dgvCustomerType = new System.Windows.Forms.DataGridView();
            this.MemberTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberTypeName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberTypeName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInformationSearh = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMemberTypeName3 = new System.Windows.Forms.TextBox();
            this.txtMemberTypeName2 = new System.Windows.Forms.TextBox();
            this.txtMemberTypeName = new System.Windows.Forms.TextBox();
            this.lblMemberTypeName3 = new System.Windows.Forms.Label();
            this.lblMemberTypeName2 = new System.Windows.Forms.Label();
            this.lblMemberTypeName = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerType)).BeginInit();
            this.gbInformationSearh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gbInformationSearh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 470);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.gbInformation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 470);
            this.panel3.TabIndex = 8;
            // 
            // gbInformation
            // 
            this.gbInformation.BackColor = System.Drawing.Color.Transparent;
            this.gbInformation.Controls.Add(this.dgvCustomerType);
            this.gbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformation.Location = new System.Drawing.Point(0, 0);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(613, 470);
            this.gbInformation.TabIndex = 3;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Danh sách loại thành viên";
            // 
            // dgvCustomerType
            // 
            this.dgvCustomerType.AllowUserToAddRows = false;
            this.dgvCustomerType.AllowUserToDeleteRows = false;
            this.dgvCustomerType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvCustomerType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberTypeID,
            this.MemberTypeCode,
            this.MemberTypeName,
            this.MemberTypeName2,
            this.MemberTypeName3});
            this.dgvCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerType.Location = new System.Drawing.Point(3, 25);
            this.dgvCustomerType.Name = "dgvCustomerType";
            this.dgvCustomerType.ReadOnly = true;
            this.dgvCustomerType.RowHeadersVisible = false;
            this.dgvCustomerType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerType.Size = new System.Drawing.Size(607, 442);
            this.dgvCustomerType.TabIndex = 9;
            this.dgvCustomerType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerType_CellClick);
            // 
            // MemberTypeID
            // 
            this.MemberTypeID.DataPropertyName = "MemberTypeID";
            this.MemberTypeID.FillWeight = 215.736F;
            this.MemberTypeID.HeaderText = "Mã số";
            this.MemberTypeID.Name = "MemberTypeID";
            this.MemberTypeID.ReadOnly = true;
            this.MemberTypeID.Visible = false;
            this.MemberTypeID.Width = 95;
            // 
            // MemberTypeCode
            // 
            this.MemberTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberTypeCode.DataPropertyName = "MemberTypeCode";
            this.MemberTypeCode.FillWeight = 71.06599F;
            this.MemberTypeCode.HeaderText = "Mã loại thành viên";
            this.MemberTypeCode.Name = "MemberTypeCode";
            this.MemberTypeCode.ReadOnly = true;
            this.MemberTypeCode.Visible = false;
            // 
            // MemberTypeName
            // 
            this.MemberTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberTypeName.DataPropertyName = "MemberTypeName";
            this.MemberTypeName.FillWeight = 1F;
            this.MemberTypeName.HeaderText = "Tên tiếng Việt";
            this.MemberTypeName.Name = "MemberTypeName";
            this.MemberTypeName.ReadOnly = true;
            // 
            // MemberTypeName2
            // 
            this.MemberTypeName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberTypeName2.DataPropertyName = "MemberTypeName2";
            this.MemberTypeName2.FillWeight = 1F;
            this.MemberTypeName2.HeaderText = "Tiêng tiếng Nhật";
            this.MemberTypeName2.Name = "MemberTypeName2";
            this.MemberTypeName2.ReadOnly = true;
            // 
            // MemberTypeName3
            // 
            this.MemberTypeName3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberTypeName3.DataPropertyName = "MemberTypeName3";
            this.MemberTypeName3.FillWeight = 1F;
            this.MemberTypeName3.HeaderText = "Tên tiếng Anh";
            this.MemberTypeName3.Name = "MemberTypeName3";
            this.MemberTypeName3.ReadOnly = true;
            // 
            // gbInformationSearh
            // 
            this.gbInformationSearh.Controls.Add(this.btnDelete);
            this.gbInformationSearh.Controls.Add(this.btnAddNew);
            this.gbInformationSearh.Controls.Add(this.btnSave);
            this.gbInformationSearh.Controls.Add(this.txtMemberTypeName3);
            this.gbInformationSearh.Controls.Add(this.txtMemberTypeName2);
            this.gbInformationSearh.Controls.Add(this.txtMemberTypeName);
            this.gbInformationSearh.Controls.Add(this.lblMemberTypeName3);
            this.gbInformationSearh.Controls.Add(this.lblMemberTypeName2);
            this.gbInformationSearh.Controls.Add(this.lblMemberTypeName);
            this.gbInformationSearh.Controls.Add(this.listBox3);
            this.gbInformationSearh.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbInformationSearh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationSearh.Location = new System.Drawing.Point(613, 0);
            this.gbInformationSearh.Name = "gbInformationSearh";
            this.gbInformationSearh.Size = new System.Drawing.Size(371, 470);
            this.gbInformationSearh.TabIndex = 16;
            this.gbInformationSearh.TabStop = false;
            this.gbInformationSearh.Text = "Thông tin chi tiết";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(98)))), ((int)(((byte)(114)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::VVPosM1.Properties.Resources.cancel103;
            this.btnDelete.Location = new System.Drawing.Point(226, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = global::VVPosM1.Properties.Resources.reload8;
            this.btnAddNew.Location = new System.Drawing.Point(89, 210);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(130, 44);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Làm mới";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::VVPosM1.Properties.Resources.floppy13;
            this.btnSave.Location = new System.Drawing.Point(227, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMemberTypeName3
            // 
            this.txtMemberTypeName3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberTypeName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMemberTypeName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberTypeName3.Location = new System.Drawing.Point(177, 165);
            this.txtMemberTypeName3.Name = "txtMemberTypeName3";
            this.txtMemberTypeName3.Size = new System.Drawing.Size(180, 29);
            this.txtMemberTypeName3.TabIndex = 4;
            // 
            // txtMemberTypeName2
            // 
            this.txtMemberTypeName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberTypeName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMemberTypeName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberTypeName2.Location = new System.Drawing.Point(177, 123);
            this.txtMemberTypeName2.Name = "txtMemberTypeName2";
            this.txtMemberTypeName2.Size = new System.Drawing.Size(180, 29);
            this.txtMemberTypeName2.TabIndex = 3;
            // 
            // txtMemberTypeName
            // 
            this.txtMemberTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMemberTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberTypeName.Location = new System.Drawing.Point(177, 84);
            this.txtMemberTypeName.Name = "txtMemberTypeName";
            this.txtMemberTypeName.Size = new System.Drawing.Size(180, 29);
            this.txtMemberTypeName.TabIndex = 2;
            // 
            // lblMemberTypeName3
            // 
            this.lblMemberTypeName3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberTypeName3.AutoSize = true;
            this.lblMemberTypeName3.Location = new System.Drawing.Point(19, 169);
            this.lblMemberTypeName3.Name = "lblMemberTypeName3";
            this.lblMemberTypeName3.Size = new System.Drawing.Size(106, 21);
            this.lblMemberTypeName3.TabIndex = 13;
            this.lblMemberTypeName3.Text = "Tên tiếng Anh";
            // 
            // lblMemberTypeName2
            // 
            this.lblMemberTypeName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberTypeName2.AutoSize = true;
            this.lblMemberTypeName2.Location = new System.Drawing.Point(19, 127);
            this.lblMemberTypeName2.Name = "lblMemberTypeName2";
            this.lblMemberTypeName2.Size = new System.Drawing.Size(112, 21);
            this.lblMemberTypeName2.TabIndex = 13;
            this.lblMemberTypeName2.Text = "Tên tiếng Nhật";
            // 
            // lblMemberTypeName
            // 
            this.lblMemberTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberTypeName.AutoSize = true;
            this.lblMemberTypeName.Location = new System.Drawing.Point(19, 88);
            this.lblMemberTypeName.Name = "lblMemberTypeName";
            this.lblMemberTypeName.Size = new System.Drawing.Size(105, 21);
            this.lblMemberTypeName.TabIndex = 13;
            this.lblMemberTypeName.Text = "Tên tiếng Việt";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(1142, 32);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(291, 67);
            this.listBox3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 41);
            this.panel2.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblTitle.Location = new System.Drawing.Point(304, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 32);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Quản lý loại thành viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberTypeID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 215.736F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 277;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MemberTypeCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã loại thành viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MemberTypeName";
            this.dataGridViewTextBoxColumn3.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên loại thành viên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MemberTypeName2";
            this.dataGridViewTextBoxColumn4.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tiêng tiếng Nhật";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MemberTypeName3";
            this.dataGridViewTextBoxColumn5.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên tiếng Anh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frmCustommerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustommerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCustommerType_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerType)).EndInit();
            this.gbInformationSearh.ResumeLayout(false);
            this.gbInformationSearh.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.DataGridView dgvCustomerType;
        private System.Windows.Forms.GroupBox gbInformationSearh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMemberTypeName;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtMemberTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtMemberTypeName3;
        private System.Windows.Forms.TextBox txtMemberTypeName2;
        private System.Windows.Forms.Label lblMemberTypeName3;
        private System.Windows.Forms.Label lblMemberTypeName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberTypeName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberTypeName3;
    }
}