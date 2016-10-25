namespace VVPosM1.Screen.CRM.Employee
{
    partial class frmAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdEmployee = new System.Windows.Forms.RadioButton();
            this.rdManager = new System.Windows.Forms.RadioButton();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblconfirmpass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.chkBTablet = new System.Windows.Forms.CheckBox();
            this.gbInformationSearch = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdBFemal = new System.Windows.Forms.RadioButton();
            this.rdBMale = new System.Windows.Forms.RadioButton();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dteTBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbBCountry = new System.Windows.Forms.ComboBox();
            this.cbBEmployeeType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtHourlyWages = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.lblHourlyWages = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeNameId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBReception = new System.Windows.Forms.CheckBox();
            this.chkBManager = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.gbInformation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbInformationSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.gbInformation);
            this.panel1.Controls.Add(this.chkBTablet);
            this.panel1.Controls.Add(this.gbInformationSearch);
            this.panel1.Controls.Add(this.chkBReception);
            this.panel1.Controls.Add(this.chkBManager);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 623);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(98)))), ((int)(((byte)(114)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(364, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 66);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.panel2);
            this.gbInformation.Controls.Add(this.txtConfirm);
            this.gbInformation.Controls.Add(this.lblconfirmpass);
            this.gbInformation.Controls.Add(this.txtPassword);
            this.gbInformation.Controls.Add(this.txtUserName);
            this.gbInformation.Controls.Add(this.lblRole);
            this.gbInformation.Controls.Add(this.lblPassword);
            this.gbInformation.Controls.Add(this.lblUserName);
            this.gbInformation.Location = new System.Drawing.Point(12, 370);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(750, 173);
            this.gbInformation.TabIndex = 2;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Thông tin đăng nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdEmployee);
            this.panel2.Controls.Add(this.rdManager);
            this.panel2.Location = new System.Drawing.Point(161, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 36);
            this.panel2.TabIndex = 29;
            // 
            // rdEmployee
            // 
            this.rdEmployee.AutoSize = true;
            this.rdEmployee.Checked = true;
            this.rdEmployee.Location = new System.Drawing.Point(166, 5);
            this.rdEmployee.Name = "rdEmployee";
            this.rdEmployee.Size = new System.Drawing.Size(99, 25);
            this.rdEmployee.TabIndex = 1;
            this.rdEmployee.TabStop = true;
            this.rdEmployee.Text = "Nhân viên";
            this.rdEmployee.UseVisualStyleBackColor = true;
            // 
            // rdManager
            // 
            this.rdManager.AutoSize = true;
            this.rdManager.Location = new System.Drawing.Point(21, 5);
            this.rdManager.Name = "rdManager";
            this.rdManager.Size = new System.Drawing.Size(82, 25);
            this.rdManager.TabIndex = 0;
            this.rdManager.Text = "Quản lý";
            this.rdManager.UseVisualStyleBackColor = true;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Location = new System.Drawing.Point(161, 101);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(417, 29);
            this.txtConfirm.TabIndex = 27;
            this.txtConfirm.Tag = "2";
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblconfirmpass
            // 
            this.lblconfirmpass.AutoSize = true;
            this.lblconfirmpass.Location = new System.Drawing.Point(10, 105);
            this.lblconfirmpass.Name = "lblconfirmpass";
            this.lblconfirmpass.Size = new System.Drawing.Size(137, 21);
            this.lblconfirmpass.TabIndex = 28;
            this.lblconfirmpass.Text = "Nhập lại mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(161, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(417, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "2";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(161, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(417, 29);
            this.txtUserName.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(10, 139);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(86, 21);
            this.lblRole.TabIndex = 26;
            this.lblRole.Text = "Quyền hạn";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 21);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(10, 37);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 21);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // chkBTablet
            // 
            this.chkBTablet.AutoSize = true;
            this.chkBTablet.Location = new System.Drawing.Point(101, 550);
            this.chkBTablet.Name = "chkBTablet";
            this.chkBTablet.Size = new System.Drawing.Size(130, 25);
            this.chkBTablet.TabIndex = 5;
            this.chkBTablet.Text = "Sử dụng tablet";
            this.chkBTablet.UseVisualStyleBackColor = true;
            this.chkBTablet.Visible = false;
            // 
            // gbInformationSearch
            // 
            this.gbInformationSearch.Controls.Add(this.label3);
            this.gbInformationSearch.Controls.Add(this.rdBFemal);
            this.gbInformationSearch.Controls.Add(this.rdBMale);
            this.gbInformationSearch.Controls.Add(this.lblEmployeeId);
            this.gbInformationSearch.Controls.Add(this.btnChoseImage);
            this.gbInformationSearch.Controls.Add(this.picBoxImage);
            this.gbInformationSearch.Controls.Add(this.txtNote);
            this.gbInformationSearch.Controls.Add(this.txtAddress);
            this.gbInformationSearch.Controls.Add(this.dteTBirthday);
            this.gbInformationSearch.Controls.Add(this.cbBCountry);
            this.gbInformationSearch.Controls.Add(this.cbBEmployeeType);
            this.gbInformationSearch.Controls.Add(this.txtEmail);
            this.gbInformationSearch.Controls.Add(this.txtPhoneNumber);
            this.gbInformationSearch.Controls.Add(this.txtHourlyWages);
            this.gbInformationSearch.Controls.Add(this.txtEmployeeName);
            this.gbInformationSearch.Controls.Add(this.txtEmployeeCode);
            this.gbInformationSearch.Controls.Add(this.lblHourlyWages);
            this.gbInformationSearch.Controls.Add(this.lblNote);
            this.gbInformationSearch.Controls.Add(this.lblEmployeeType);
            this.gbInformationSearch.Controls.Add(this.lblBirthday);
            this.gbInformationSearch.Controls.Add(this.lblGender);
            this.gbInformationSearch.Controls.Add(this.lblCountry);
            this.gbInformationSearch.Controls.Add(this.lblPhoneNumber);
            this.gbInformationSearch.Controls.Add(this.lblEmail);
            this.gbInformationSearch.Controls.Add(this.lblAddress);
            this.gbInformationSearch.Controls.Add(this.lblEmployeeName);
            this.gbInformationSearch.Controls.Add(this.lblEmployeeNameId);
            this.gbInformationSearch.Controls.Add(this.label1);
            this.gbInformationSearch.Controls.Add(this.label2);
            this.gbInformationSearch.Controls.Add(this.label4);
            this.gbInformationSearch.Location = new System.Drawing.Point(12, 8);
            this.gbInformationSearch.Name = "gbInformationSearch";
            this.gbInformationSearch.Size = new System.Drawing.Size(750, 355);
            this.gbInformationSearch.TabIndex = 1;
            this.gbInformationSearch.TabStop = false;
            this.gbInformationSearch.Text = "Thông tin chung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(407, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 105;
            this.label3.Text = "*";
            // 
            // rdBFemal
            // 
            this.rdBFemal.AutoSize = true;
            this.rdBFemal.Checked = true;
            this.rdBFemal.Location = new System.Drawing.Point(160, 95);
            this.rdBFemal.Name = "rdBFemal";
            this.rdBFemal.Size = new System.Drawing.Size(49, 25);
            this.rdBFemal.TabIndex = 3;
            this.rdBFemal.TabStop = true;
            this.rdBFemal.Text = "Nữ";
            this.rdBFemal.UseVisualStyleBackColor = true;
            // 
            // rdBMale
            // 
            this.rdBMale.AutoSize = true;
            this.rdBMale.Location = new System.Drawing.Point(246, 95);
            this.rdBMale.Name = "rdBMale";
            this.rdBMale.Size = new System.Drawing.Size(62, 25);
            this.rdBMale.TabIndex = 4;
            this.rdBMale.Text = "Nam";
            this.rdBMale.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(317, 31);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(22, 21);
            this.lblEmployeeId.TabIndex = 104;
            this.lblEmployeeId.Text = "--";
            this.lblEmployeeId.Visible = false;
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnChoseImage.FlatAppearance.BorderSize = 0;
            this.btnChoseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoseImage.ForeColor = System.Drawing.Color.White;
            this.btnChoseImage.Location = new System.Drawing.Point(603, 208);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(120, 31);
            this.btnChoseImage.TabIndex = 12;
            this.btnChoseImage.Text = "Chọn ảnh...";
            this.btnChoseImage.UseVisualStyleBackColor = false;
            this.btnChoseImage.Click += new System.EventHandler(this.btnChoseImage_Click);
            // 
            // picBoxImage
            // 
            this.picBoxImage.Location = new System.Drawing.Point(590, 25);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(147, 176);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 103;
            this.picBoxImage.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(161, 298);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(415, 50);
            this.txtNote.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(161, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(416, 29);
            this.txtAddress.TabIndex = 8;
            // 
            // dteTBirthday
            // 
            this.dteTBirthday.CustomFormat = "yyyy-MM-dd";
            this.dteTBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteTBirthday.Location = new System.Drawing.Point(426, 93);
            this.dteTBirthday.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dteTBirthday.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dteTBirthday.Name = "dteTBirthday";
            this.dteTBirthday.Size = new System.Drawing.Size(151, 29);
            this.dteTBirthday.TabIndex = 4;
            this.dteTBirthday.Value = new System.DateTime(2013, 12, 19, 0, 0, 0, 0);
            // 
            // cbBCountry
            // 
            this.cbBCountry.BackColor = System.Drawing.Color.Silver;
            this.cbBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBCountry.FormattingEnabled = true;
            this.cbBCountry.Items.AddRange(new object[] {
            ""});
            this.cbBCountry.Location = new System.Drawing.Point(426, 160);
            this.cbBCountry.Name = "cbBCountry";
            this.cbBCountry.Size = new System.Drawing.Size(151, 29);
            this.cbBCountry.TabIndex = 7;
            // 
            // cbBEmployeeType
            // 
            this.cbBEmployeeType.BackColor = System.Drawing.Color.Silver;
            this.cbBEmployeeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBEmployeeType.FormattingEnabled = true;
            this.cbBEmployeeType.Location = new System.Drawing.Point(161, 229);
            this.cbBEmployeeType.Name = "cbBEmployeeType";
            this.cbBEmployeeType.Size = new System.Drawing.Size(416, 29);
            this.cbBEmployeeType.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(161, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(416, 29);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(161, 162);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 29);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // txtHourlyWages
            // 
            this.txtHourlyWages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtHourlyWages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHourlyWages.Location = new System.Drawing.Point(161, 265);
            this.txtHourlyWages.Name = "txtHourlyWages";
            this.txtHourlyWages.Size = new System.Drawing.Size(150, 29);
            this.txtHourlyWages.TabIndex = 10;
            this.txtHourlyWages.TextChanged += new System.EventHandler(this.txtHourlyWages_TextChanged);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Location = new System.Drawing.Point(160, 59);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(417, 29);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmployeeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeCode.Location = new System.Drawing.Point(160, 25);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(151, 29);
            this.txtEmployeeCode.TabIndex = 1;
            // 
            // lblHourlyWages
            // 
            this.lblHourlyWages.AutoSize = true;
            this.lblHourlyWages.Location = new System.Drawing.Point(10, 269);
            this.lblHourlyWages.Name = "lblHourlyWages";
            this.lblHourlyWages.Size = new System.Drawing.Size(117, 21);
            this.lblHourlyWages.TabIndex = 20;
            this.lblHourlyWages.Text = "Tiền lương/ giờ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(10, 313);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(63, 21);
            this.lblNote.TabIndex = 20;
            this.lblNote.Text = "Ghi chú";
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Location = new System.Drawing.Point(10, 233);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(67, 21);
            this.lblEmployeeType.TabIndex = 20;
            this.lblEmployeeType.Text = "Bộ phận";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(317, 97);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(80, 21);
            this.lblBirthday.TabIndex = 21;
            this.lblBirthday.Text = "Ngày sinh";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 97);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 21);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Giới tính";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(319, 164);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(76, 21);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Quốc tịch";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(10, 166);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(101, 21);
            this.lblPhoneNumber.TabIndex = 19;
            this.lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 199);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 21);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 63);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(76, 21);
            this.lblEmployeeName.TabIndex = 15;
            this.lblEmployeeName.Text = "Họ và tên";
            // 
            // lblEmployeeNameId
            // 
            this.lblEmployeeNameId.AutoSize = true;
            this.lblEmployeeNameId.Location = new System.Drawing.Point(10, 29);
            this.lblEmployeeNameId.Name = "lblEmployeeNameId";
            this.lblEmployeeNameId.Size = new System.Drawing.Size(104, 21);
            this.lblEmployeeNameId.TabIndex = 14;
            this.lblEmployeeNameId.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 105;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(138, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 21);
            this.label2.TabIndex = 105;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(138, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 105;
            this.label4.Text = "*";
            // 
            // chkBReception
            // 
            this.chkBReception.AutoSize = true;
            this.chkBReception.Location = new System.Drawing.Point(12, 581);
            this.chkBReception.Name = "chkBReception";
            this.chkBReception.Size = new System.Drawing.Size(71, 25);
            this.chkBReception.TabIndex = 4;
            this.chkBReception.Text = "Lễ tân";
            this.chkBReception.UseVisualStyleBackColor = true;
            this.chkBReception.Visible = false;
            // 
            // chkBManager
            // 
            this.chkBManager.AutoSize = true;
            this.chkBManager.Location = new System.Drawing.Point(12, 550);
            this.chkBManager.Name = "chkBManager";
            this.chkBManager.Size = new System.Drawing.Size(83, 25);
            this.chkBManager.TabIndex = 3;
            this.chkBManager.Text = "Quản lý";
            this.chkBManager.UseVisualStyleBackColor = true;
            this.chkBManager.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::VVPosM1.Properties.Resources.floppy13;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(268, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 66);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 623);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddAccount_FormClosed);
            this.Load += new System.EventHandler(this.frmAddAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbInformationSearch.ResumeLayout(false);
            this.gbInformationSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbInformationSearch;
        private System.Windows.Forms.DateTimePicker dteTBirthday;
        private System.Windows.Forms.ComboBox cbBEmployeeType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHourlyWages;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label lblEmployeeType;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeNameId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.CheckBox chkBTablet;
        private System.Windows.Forms.CheckBox chkBReception;
        private System.Windows.Forms.CheckBox chkBManager;
        private System.Windows.Forms.ComboBox cbBCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblHourlyWages;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.RadioButton rdBFemal;
        private System.Windows.Forms.RadioButton rdBMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblconfirmpass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdManager;
        private System.Windows.Forms.RadioButton rdEmployee;


    }
}