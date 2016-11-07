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
    public partial class frmManageEmployee : Form
    {
        // bien  toan cuc trong form nay
        private Employees employee;
        private EmployBLL employBLL;
        private Employees employSea;
       
        // bien page
        private Boolean _bAllowInsert = false;
        private int CurPage;
        private double totalPage;

        public frmManageEmployee()
        {
            InitializeComponent();
            // load tat ca cac bien tham so lua chon...
            employBLL = new EmployBLL();
            employSea = new Employees();

            LoadStatus();
            LoadPositionId();
            LoadObject();
        }

        private void frmManageEmploy_Load(object sender, EventArgs e)
        {
            

        }
        private void LoadPositionId()
        {
            DataTable dt = employBLL.GetEmployPositionId();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["CommonId"].ToString(), dr["StrValue1"].ToString());
            }
            cboPositionId.DataSource = new BindingSource(test, null);
            cboPositionId.DisplayMember = "Value";
            cboPositionId.ValueMember = "Key";
        }


        

        private void LoadStatus()
        {
            //load cboTrangThai
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Status_null"));          
            test.Add("0", VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_0"));
            test.Add("1", VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_1"));
            test.Add("2", VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_2"));
            cboStatus.DataSource = new BindingSource(test, null);
            cboStatus.DisplayMember = "Value";
            cboStatus.ValueMember = "Key";
        }

        private void bntSeach_Click(object sender, EventArgs e)
        {
            lblTB1.Text = "...";
            CurPage = 1;
            totalPage = 1;
            employSea = new Employees();
            employSea.EmployeeId = txtEmployeeId.Text;
            employSea.EmployeeCode = txtEmployeeCode.Text;
            if (!string.IsNullOrEmpty(lblMaDT.Text))
            {
                employSea.ObjectId = lblMaDT.Text;
            }
            employSea.Note = rtxtDescription.Text;
            if (!string.IsNullOrEmpty(cboStatus.Text) && !string.IsNullOrWhiteSpace(cboStatus.Text))
            {

                employSea.Status = cboStatus.SelectedValue.ToString();

            }
            if (!string.IsNullOrEmpty(cboStatus.Text) && !string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                employSea.PositionId = cboPositionId.SelectedValue.ToString();
            }
           
            SearchEmployees(1);
        }

        private void SearchEmployees(int page)
        {
            CurPage = page;
            
            int total = 0;
            DataTable dt = employBLL.SearchEmployees(employSea, page, out total);

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
                    string str;
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[0].Value = (stt + 1).ToString();
                    dgv.Rows[i].Cells[1].Value = dr["EmployeeId"].ToString();
                    dgv.Rows[i].Cells[2].Value = dr["EmployeeCode"].ToString();
                    str = "";
                    DataTable dtP = employBLL.GetObjectTheoID(dr["ObjectId"].ToString());
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
                        dgv.Rows[i].Cells[3].Value = str;

                    }
                    else
                    {
                        dgv.Rows[i].Cells[3].Value = "";
                    }
                    
                    str = "";
                    if (dr["Status"].ToString() == "0")
                        str = str  + VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_0") + "\n";
                    if (dr["Status"].ToString() == "1")
                        str = str+ VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_1") + "\n";
                    if (dr["Status"].ToString() == "2")
                        str = str + VVPosM1.Common.clsLanguages.GetResource("StatusNhanVien_2") + "\n";
                    dgv.Rows[i].Cells[4].Value = str;
                    str = "";
                    DataTable dtP1 = employBLL.GetPositionTheoID(dr["PositionId"].ToString());
                    if (dtP1 != null && dtP1.Rows.Count > 0)
                    {

                        str = dtP1.Rows[0]["StrValue1"].ToString();
                        dgv.Rows[i].Cells[5].Value = str;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[5].Value = "";
                    }
                //    dgv.Rows[i].Cells[5].Value = dr["PositionId"].ToString();
                    dgv.Rows[i].Cells[6].Value = dr["Notes"].ToString();

                    str = "";
                    str = str + "Tạo bởi : " + dr["CreatedBy"].ToString() + "\n";
                    str = str + "Ngày tạo : " + dr["CreatedDate"].ToString() + "\n";
                    str = str + "Chỉnh sửa bởi : " + dr["ModifiedBy"].ToString() + "\n";
                    str = str + "Ngày chỉnh sửa : " + dr["ModifiedDate"].ToString();
                    dgv.Rows[i].Cells[7].Value = str;

                    

                    i++;
                    stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = "Tìm thấy " + total.ToString() + " mẫu tin !";                
            
        }
            

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //// chon anh
        //private void button7_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    //ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        string filePath = ofd.FileName;
        //        string safeFilePath = ofd.SafeFileName;
        //        txtImage.Text = filePath;
        //    }
        //}

        //private void SaveImage(string empID)
        //{
        //    try
        //    {
        //        string strImage = txtImage.Text;
        //        Image img = System.Drawing.Image.FromFile(strImage);
        //        int i = employBLL.SaveImageEmpIntoWeb(img, empID);
        //        if (i == 1)
        //        {
        //            txtImage.Text = "";
        //            pbImageEmploy.Image = null;
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //}

        private void LoadObject()
        {
            this.txtObject.Text = string.Empty;

            // Add some sample auto complete entry items...
            List<Objects> lst = employBLL.ReadListFromAutoComplete(this.txtObject.Text);
            if (lst != null)
            {
                foreach (Objects ob in lst)
                {
                    string str = ob.ObjectId + "," + ob.FullName;
                    this.txtObject.Items.Add(new AutoCompleteEntry(str, ob.FullName, ob.ObjectId, ob.FullName,ob.ObjectGroup,ob.ObjectType,ob.PID,ob.PIDState,
                        ob.PIDIssue,ob.DoB,ob.PoB,ob.PerAdd,ob.TemAdd,ob.ProvinceId,ob.Tel,ob.Fax,ob.Email,ob.Website,ob.TaxCode,ob.Note,ob.Status,ob.CreatedBy,
                        ob.CreatedDate,ob.ModifiedBy,ob.ModifiedDate));
                }
            }            
            this.Validate();
        }

        private void txtObject_Validated(object sender, EventArgs e)
        {
            string str =txtObject.Text;
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
            }
            else
                lblMaDT.Text = "Thông tin đối tượng chưa đúng";
        }

        private void txtObject_Validated1()
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
                List<Objects> lst = employBLL.ReadListFromAutoComplete(str.Substring(0, i));
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
                //MessageBox.Show("Nhập lại thông tin đối tượng1!");
                CustomMessageBox.MessageBox.ShowCustomMessageBox("Nhập lại thông tin đối tượng !",
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtObject.Focus();               
                _bAllowInsert = false;
                return;
            }
        }

       

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset() {
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

        private void txtObject_Validating(object sender, CancelEventArgs e)
        {
            //LoadObject();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string employID = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Employees employ = employBLL.GetEmployeeWithID(employID);
                if (employ != null)
                {
                    txtEmployeeId.Text = employ.EmployeeId;
                    txtEmployeeCode.Text = employ.EmployeeCode;
                    txtObject.Text = employ.ObjectId;
                    lblMaDT.Text = employ.ObjectId;
                    //if (!string.IsNullOrEmpty(employ.Status))
                    //{
                        cboStatus.SelectedValue = employ.Status;
                    //}
                    //if (!string.IsNullOrEmpty(employ.PositionId))
                    //{
                        //check trong cbo                        
                        cboPositionId.SelectedIndex = 0;
                        foreach (var item in cboPositionId.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == employ.PositionId)
                            {
                                cboPositionId.SelectedValue = employ.PositionId;
                                break;
                            }
                        }
                        //cboPosition.SelectedIndex = 0;
                    //}
                    rtxtDescription.Text = employ.Notes;
                    

                    // load hinh tu web
                    //pbImageEmploy.SizeMode = PictureBoxSizeMode.Zoom;
                    //pbImageEmploy.Image = VVPosM1.Common.Utility.GetImageFromService("Users", employ.Image);

                }

                //// Xóa
                if (e.ColumnIndex == 8)
                {
                    
                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaNv"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {

                        int Xoa = employBLL.DeleteNV(employID);
                         // xóa thành côg
                       
                        if (Xoa == 1)
                        {
                            CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaTCong"),
                                            Common.clsLanguages.GetResource("Information"),
                                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                            //Reset();
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
                           // SearchEmployees(1);
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            XuatExcel();
        }
        private void XuatExcel()
        {
            DataTable Final = new DataTable();
            int total = 0;
            Final = employBLL.SearchEmployees(employSea, 1, out total);
            double RecordPerPage = 20;
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = employBLL.SearchEmployees(employSea, i, out total);
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

            epex.ExportFileFromDataTable_Dung(Final, "Employees_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Employees_" + DateTime.Now.ToString("ddMMyy_HHmmss"), null);
        }
        private bool Kiemtra()
        {
            if (txtEmployeeCode.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtEmployeeCode.Focus();
                return false;
            }
            if (txtObject.Text == "")
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("NameNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                txtObject.Focus();
                return false;
            }
            if (cboPositionId.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("PositionIdEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboPositionId.Focus();
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

            employSea.EmployeeId = txtEmployeeId.Text;
            employSea.EmployeeCode = txtEmployeeCode.Text;
            if (!string.IsNullOrEmpty(lblMaDT.Text))
            {
                employSea.ObjectId = lblMaDT.Text;
            }
            employSea.Note = rtxtDescription.Text;
            if (!string.IsNullOrEmpty(cboStatus.Text) && !string.IsNullOrWhiteSpace(cboStatus.Text))
            {

                employSea.Status = cboStatus.SelectedValue.ToString();

            }
            if (!string.IsNullOrEmpty(cboStatus.Text) && !string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                employSea.PositionId = cboPositionId.SelectedValue.ToString();
            }
            int total = 0;
            employBLL.SearchEmployees(employSea, 1, out total);

        }
        private void SaveData()
        {
            // check xem có trong db chưa?
            string employeeID = txtEmployeeId.Text.Trim();
            Employees employ = new Employees();
            employ = employBLL.GetEmployeeWithID(employeeID);

             employSea = new Employees();

            employSea.EmployeeCode = txtEmployeeCode.Text;
            if (!string.IsNullOrEmpty(lblMaDT.Text))
            {
                employSea.ObjectId = lblMaDT.Text;
            }
            else
            {
                employSea.ObjectId = "";
            }
            employSea.Notes = rtxtDescription.Text;
            employSea.Status = cboStatus.SelectedValue.ToString();
            employSea.PositionId = cboPositionId.SelectedValue.ToString();


            if (employ != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    
                    employSea.EmployeeId = employeeID;
                    int i = employBLL.Update(employSea);
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
                    employ = employBLL.GetEmployeeCode(txtEmployeeCode.Text);
                    if (employ != null)
                    {
                        CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("EmploCode1"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                        txtEmployeeCode.Focus();
                        return;
                    }
                    employeeID = employBLL.Tao_EmployeeID();
                    employSea.EmployeeId = employeeID;

                    int i = employBLL.Insert(employSea);
                    if (i == 1)
                    {
                        lblTB1.Text = "Thêm mới thành công !!!";
                        txtEmployeeId.Text = employeeID;
                    }
                    else
                    {
                        lblTB1.Text = "Thêm mới thất bại !!!";
                    }

                }
            }
            // hinh
            //if (!string.IsNullOrEmpty(txtImage.Text))
            //{
            //    SaveImage(employeeID);
            //}


            SearchEmployees(1);
   

        }

        private void bntPre_Click(object sender, EventArgs e)
        {

            if (CurPage > 1)
            {
                SearchEmployees(CurPage - 1);
            }
        }

        private void bntNext_Click(object sender, EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchEmployees(CurPage + 1);
            }
        }

        private void txtObject_Validated()
        {

        }

        #region TextBox Events

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtEmployeeCode, 16);
        }

        #endregion


    }
}
