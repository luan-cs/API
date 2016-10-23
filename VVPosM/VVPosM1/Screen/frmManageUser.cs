using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using VVPosM1.Entities;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;
using System.Configuration;
using VVPosM1.Controls;
using VVPosM1.Common;

namespace VVPosM1.Screen
{
    public partial class frmManageUser : Form
    {
         // bien  toan cuc trong form nay
        private Users user;
        private UsersBLL userBLL;
        private Users userSea;
        // 
        private Boolean _bAllowInsert = false;
        private int CurPage;
        private double totalPage;

        public frmManageUser()
        {
            InitializeComponent();
            userBLL = new UsersBLL();
            LoadStatus();
            LoadRoleId();
            LoadObject();
            user = new Users();
            userSea = new Users();
            //SetUIChanges();
            //LoadStatus();
           // _sStatus = cboStatus.SelectedValue.ToString();
        }

        private void LoadObject()
        {
            this.txtObject.Text = string.Empty;

            // Add some sample auto complete entry items...
            List<Objects> lst = userBLL.ReadListFromAutoComplete(this.txtObject.Text);
            if (lst != null)
            {
                foreach (Objects ob in lst)
                {
                    string str = ob.ObjectId + "," + ob.FullName;
                    this.txtObject.Items.Add(new AutoCompleteEntry(str, ob.FullName, ob.ObjectId, ob.FullName, ob.ObjectGroup, ob.ObjectType, ob.PID, ob.PIDState,
                        ob.PIDIssue, ob.DoB, ob.PoB, ob.PerAdd, ob.TemAdd, ob.ProvinceId, ob.Tel, ob.Fax, ob.Email, ob.Website, ob.TaxCode, ob.Note, ob.Status, ob.CreatedBy,
                        ob.CreatedDate, ob.ModifiedBy, ob.ModifiedDate));
                }
            }
            this.Validate();
        }



        private void Reset()
        {
            foreach (Control c in this.pInput.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = String.Empty;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                lblMaDT.Text = "";
                txtObject.Text = "";
                lblTB.Text = "...";
                dgv.Rows.Clear();

            }
        }

        private void frmMagageUser_Load(object sender, EventArgs e)
        {
            

        }

        private void LoadStatus() {
            //load cboTrangThai
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Status_null"));
            test.Add("1", VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_0"));
            test.Add("0", VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_1"));
            test.Add("2", VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_2"));
            cboStatus.DataSource = new BindingSource(test, null);
            cboStatus.DisplayMember = "Value";
            cboStatus.ValueMember = "Key";
        }
       
        private void LoadRoleId()
        {

            //load cboRoleId
            DataTable dt = userBLL.GetRoleByRoleId();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["RoleId"].ToString(), dr["RoleName"].ToString());
            }
            cboRoleId.DataSource = new BindingSource(test, null);
            cboRoleId.DisplayMember = "Value";
            cboRoleId.ValueMember = "Key";
     
       
        
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntReset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void bntSeach_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
            userSea = new Users();
            userSea.UserId = txtUserId.Text;
            userSea.Pwd = txtPwd.Text;
            if (!string.IsNullOrEmpty(lblMaDT.Text))
            {
                userSea.ObjectId = lblMaDT.Text;
            }
            // userSea.Status = cboStatus.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(cboStatus.Text) && !string.IsNullOrWhiteSpace(cboStatus.Text))
            {

                userSea.Status = cboStatus.SelectedValue.ToString();

            }

            //userSea.RoleId = cboRoleId.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(cboStatus.Text) && !string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                userSea.RoleId = cboRoleId.SelectedValue.ToString();
            }
            
            SearchUsers(1);
        }

        private void SearchUsers(int page)
        {
            CurPage = page;
            
            int total = 0;
            DataTable dt = userBLL.SearchUsers(userSea, page, out total);
            double RecordPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            int RecPerPage = int.Parse(ConfigurationManager.AppSettings["MaxRecordDesk"]);
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            dgv.Rows.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                int i = 0;
                int stt = (page - 1) * RecPerPage;
                foreach (DataRow dr in dt.Rows)
                {
                    string str = "";
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[0].Value = (stt + 1).ToString();
                    dgv.Rows[i].Cells[1].Value = dr["UserId"].ToString();
                   
                    /*thông tin đối tượng*/
                    str = "";
                    DataTable dtP = userBLL.GetObjectTheoID(dr["ObjectId"].ToString());
                    if (dtP != null && dtP.Rows.Count > 0)
                    {
                        str = str + "Tên ĐT : " + dtP.Rows[0]["FullName"].ToString() + "\n";
                        str = str + "Mã ĐT : " + dtP.Rows[0]["ObjectId"].ToString() + "\n";
                        str = str + "Mã nhóm : " + dtP.Rows[0]["ObjectGroup"].ToString() + "\n";
                        str = str + "Loại nhóm : " + dtP.Rows[0]["ObjectType"].ToString() + "\n";
                        str = str + "Số CMND : " + dtP.Rows[0]["PID"].ToString() + "\n";
                        str = str + "  Ngày cấp : " + dtP.Rows[0]["PIDDate"].ToString() + "\n";
                        str = str + "  Nơi cấp : " + dtP.Rows[0]["PIDIssue"].ToString() + "\n";
                        //str = str + "Mã nhóm : " + dtP.Rows[0]["ObjectGroup"].ToString();
                        //str = str + "Mã nhóm : " + dtP.Rows[0]["ObjectGroup"].ToString();
                        //str = str + "Mã nhóm : " + dtP.Rows[0]["ObjectGroup"].ToString();
                        //str = str + "Mã nhóm : " + dtP.Rows[0]["ObjectGroup"].ToString();
                        //str = str + "Mã nhóm : " + dtP.Rows[0]["ObjectGroup"].ToString();
                        //str = str + "Mã nhóm : " + dtP.Rows[0]["ObjectGroup"].ToString();
                        dgv.Rows[i].Cells[2].Value = str;

                    }
                    else
                    {
                        dgv.Rows[i].Cells[2].Value = "";
                    }

                    dgv.Rows[i].Cells[3].Value = dr["LastLogin"].ToString();

                    //Trạng thái
                    str = "";
                    if (dr["Status"].ToString() == "0")
                        str = VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_1");
                    if (dr["Status"].ToString() == "1")
                        str = VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_0");
                    if (dr["Status"].ToString() == "2")
                        str = VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_2");
                    dgv.Rows[i].Cells[4].Value = str;

                    //Quyền của người dùng
                    str = "";
                    DataTable dtP1 = userBLL.GetRoleByRoleId(dr["RoleId"].ToString());
                    if (dtP1 != null && dtP1.Rows.Count > 0)
                    {
                       
                        str =dtP1.Rows[0]["RoleName"].ToString();
                    }
                    dgv.Rows[i].Cells[5].Value = str;

                    //Thông tin khởi tạo
                    str = "";
                    str = str + "Tạo bởi : " + dr["CreatedBy"].ToString() + "\n";
                    str = str + "Ngày tạo : " + dr["CreatedDate"].ToString() + "\n";
                    str = str + "Chỉnh sửa bởi : " + dr["ModifiedBy"].ToString() + "\n";
                    str = str + "Ngày chỉnh sửa : " + dr["ModifiedDate"].ToString();
                    dgv.Rows[i].Cells[6].Value = str;

                    i++;
                    stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = "Tìm thấy " + total.ToString() + " mẫu tin !";
        }

        private void bntPre_Click(object sender, EventArgs e)
        {
            if (CurPage > 1)
            {
                SearchUsers(CurPage - 1);
            }
        }

        private void bntNext_Click(object sender, EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchUsers(CurPage + 1);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string userID = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Users user = userBLL.GetUserWithID(userID);
                if (user != null)
                {
                    txtUserId.Text = user.UserId;
                    txtPwd.Text = user.Pwd;
                    txtObject.Text = user.ObjectId;
                    lblMaDT.Text = user.ObjectId;
                    if (!string.IsNullOrEmpty(user.Status))
                    {

                        cboStatus.SelectedValue = user.Status;
                    }





                    if (!string.IsNullOrEmpty(user.RoleId))
                    {



                        //check trong cbo                        
                        //cboRoleId.SelectedIndex = 0;
                        foreach (var item in cboRoleId.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == user.RoleId)
                            {
                                cboRoleId.SelectedValue = user.RoleId.ToString();
                                break;
                            }
                        }
                        //cboPosition.SelectedIndex = 0;
                    }


                }

                //// Xóa
                if (e.ColumnIndex == 8)
                {
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaNv"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = userBLL.DeleteNV(userID);
                        if (Xoa == 1) // xóa thành côg
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaTCong"),
                                              Common.clsLanguages.GetResource("Information"),
                                              Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                              Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            dgv.Rows.RemoveAt(e.RowIndex);
                            foreach (Control c in this.pInput.Controls)
                            {
                                if (c is TextBox)
                                {
                                    ((TextBox)c).Text = String.Empty;
                                }
                                if (c is RichTextBox)
                                {
                                    ((RichTextBox)c).Text = String.Empty;
                                }
                                if (c is ComboBox)
                                {
                                    ((ComboBox)c).SelectedIndex = 0;
                                }
                                if (c is CheckBox)
                                {
                                    ((CheckBox)c).Checked = false;
                                }
                                lblMaDT.Text = "";
                                txtObject.Text = "";
                                lblTB.Text = "...";
                            }
                            DanhLaiSTT();
                        }
                    }
                }
            }
        }
        private void DanhLaiSTT()
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private bool Kiemtra()
        {
            if (txtUserId.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("UserIdEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtUserId.Focus();
                return false;
            }
            if (txtPwd.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PwdEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtPwd.Focus();
                return false;
            }
            if (txtObject.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("TTDTEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtObject.Focus();
                return false;
            }
            if (cboRoleId.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("RoleEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboRoleId.Focus();
                return false;
            }
            if (cboStatus.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("StatusEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboStatus.Focus();
                return false;
            }
            return true;
            
        }
        private void bntLuu_Click(object sender, EventArgs e)
        {
            
            if (!Kiemtra()) return;
            txtObject_Validated1();
            if (!_bAllowInsert)
            {
                txtObject.Focus();
                return;
            }
            SaveData();
        }
        private void txtObject_Validated1()
        {
            string str = txtObject.Text;
            if (string.IsNullOrEmpty(str))
                return;
            if (!string.IsNullOrEmpty(str) && str.Length >= 14)
            {
                int i = str.IndexOf(",");
                if (i < 0)
                {
                    i = 14;
                }
                lblMaDT.Text = str.Substring(0, i);
                List<Objects> lst = userBLL.ReadListFromAutoComplete(str.Substring(0, i));
                if (lst == null)
                {
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Nhập lại thông tin đối tượng!",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    txtObject.Focus();
                    _bAllowInsert = false;
                    return;
                }
                else
                    _bAllowInsert = true;
            }
            else
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Nhập lại thông tin đối tượng!",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtObject.Focus();
                _bAllowInsert = false;
                return;
            }
        }
        private void SaveData() {
            // check xem có trong db chưa?
            string userID = txtUserId.Text.Trim();
            Users user = new Users();
            user = userBLL.GetUserWithID(userID);

            userSea = new Users();

            userSea.Pwd = Program.ConvertStringToMD5(txtPwd.Text.Trim());
            if (!string.IsNullOrEmpty(lblMaDT.Text))
            {
                userSea.ObjectId = lblMaDT.Text;
            }
            else
            {
                userSea.ObjectId = "";
            }

            userSea.Status = cboStatus.SelectedValue.ToString();
            userSea.RoleId = cboRoleId.SelectedValue.ToString();



            if (user != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    userSea.UserId = userID;
                    int i = userBLL.Update(userSea);
                    if (i == 1)
                    {
                        lblTB1.Text = "Cập nhật thành công !!!";
                    }
                    else
                    {
                        lblTB1.Text = "Cập nhật thất bại !!!";
                    }
                }
            }
            else
            {// Thêm mới
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeCreate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    userSea.UserId = txtUserId.Text;

                    int i = userBLL.Insert(userSea);
                    if (i == 1)
                    {
                        lblTB1.Text = "Thêm mới thành công !!!";
                        txtUserId.Text = userID;
                    }
                    else
                    {
                        lblTB1.Text = "Thêm mới thất bại !!!";
                    }

                }
            }
            SearchUsers(1);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            XuatExcel();
        }
        private void XuatExcel()
        {
            DataTable Final = new DataTable();
            int total = 0;
            Final = userBLL.SearchUsers(userSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt =userBLL.SearchUsers(userSea, i, out total);
                int j = Final.Rows.Count;
                foreach (DataRow dr in dt.Rows)
                {
                    Final.Rows.Add();
                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        Final.Rows[j][k] = dr[k];
                    }
                    j++;
                }
            }

            ExportExcelAlgorithms epex = new ExportExcelAlgorithms();

            epex.ExportFileFromDataTable_Dung(Final, "Users_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Users_" + DateTime.Now.ToString("ddMMyy_HHmmss"), null);
        }

        private void txtObject_Validated(object sender, EventArgs e)
        {
            string str = txtObject.Text;
            if (!string.IsNullOrEmpty(str) && str.Length >= 14)
            {
                int i = str.IndexOf(",");
                if (i < 0)
                {
                    i = 14;
                }
                lblMaDT.Text = str.Substring(0, i);
            }
            else
                lblMaDT.Text = "Thông tin đối tượng chưa đúng";
        }

        #region TextBox Events

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtUserId, 100);
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtPwd, 50);
        }

        #endregion

    }
}
