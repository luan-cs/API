using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVPosM1.BusinessLayer;
using VVPosM1.Entities;
using VVPosM1.Common;
using System.Configuration;

namespace VVPosM1.Screen
{
    public partial class frmManageOject : Form
    {
        // bien  toan cuc trong form nay
        private Objects obj;
        private ObjectBLL objBLL;
        private Objects objSea;
        // 
        private int CurPage;
        private double totalPage;

        public frmManageOject()
        {
            InitializeComponent();
            SettingControl();
            obj = new Objects();
            objSea = new Objects();
            //SetUIChanges();
            //LoadStatus();
           // _sStatus = cboStatus.SelectedValue.ToString();
        }

       
        private void SettingControl()
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml(Common.Config.BACKGROUNDCOLOR);
            //this.BackgroundImage = Common.Config.BACKGROUNDIMAGE;
            //this.pInput.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "bg5.png");t

            //this.BackgroundImage = Common.Utility.GetImageFromService("ShopImg", "bg5.png");
        }

        /// <summary>
        /// Set text for control
        /// </summary>
        public void SetUIChanges()
        {
            bntExit.Text = Common.clsLanguages.GetResource("Exit");
            bntLuu.Text = Common.clsLanguages.GetResource("Save");
            bntSeach.Text = Common.clsLanguages.GetResource("Search");
            bntReset.Text = Common.clsLanguages.GetResource("Reset");
           
            lblObjectId.Text = Common.clsLanguages.GetResource("Name");
            lblObjectGroup.Text = Common.clsLanguages.GetResource("Location");
            lblStatus.Text = Common.clsLanguages.GetResource("Status");
            lblNote.Text = Common.clsLanguages.GetResource("Description");
            lblFullName.Text = Common.clsLanguages.GetResource("NoOfSeat");
            gShowDesk.Text = Common.clsLanguages.GetResource("DeskList");
            this.STT.HeaderText = Common.clsLanguages.GetResource("No");
            this.Status.HeaderText = Common.clsLanguages.GetResource("Status");           
            this.Description.HeaderText = Common.clsLanguages.GetResource("Description");
            this.DeskLocation.HeaderText = Common.clsLanguages.GetResource("Location");

            ///
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
   //         frmMain f = new frmMain();
 //           f.Visible = true;
        }


      

        private void bntSeach_Click_1(object sender, EventArgs e)
        {
            CurPage = 1;
            totalPage = 1;
           
            objSea = new Objects();
            objSea.ObjectId = txtObjectId.Text;
            if (!string.IsNullOrEmpty(cboObjectGroup.Text) && !string.IsNullOrWhiteSpace(cboObjectGroup.Text))
            {

                objSea.ObjectGroup = cboObjectGroup.SelectedValue.ToString();

            }
            objSea.ObjectType = cboOjectType.SelectedValue.ToString();
            objSea.FullName = txtFullName.Text;
            objSea.PID = txtPID.Text;
            if (chkPIDDate.Checked == true)
            {
                objSea.PIDState = dtpPIDDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                objSea.PIDState = "";
            }
            objSea.PIDIssue = txtPIDIssue.Text;
            if (chkDoB.Checked == true)
            {
                objSea.DoB = dtpDoB.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                objSea.DoB = "";
            }
            objSea.PoB = txtPoB.Text;
            objSea.PerAdd = txtPerAdd.Text;
            objSea.TemAdd = txtTemAdd.Text;
            objSea.Gender = cboGender.SelectedValue.ToString();
            objSea.ProvinceId = cboProvinceId.SelectedValue.ToString();
            objSea.Tel = txtTel.Text;
            objSea.Fax = txtFax.Text;
            objSea.Email = txtEmail.Text;
            objSea.Website = txtWebsite.Text;
            objSea.TaxCode = txtTaxCode.Text;
            objSea.Note = rtxtDescription.Text;
            objSea.Status = cboStatus.SelectedValue.ToString();
            SearchObjects(1);
            
        }

        private void SearchObjects(int page)
        {
           
            ///...

            CurPage = page;
            int total =0;
            DataTable dt = objBLL.SearchObjects(objSea, page, out total);
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
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[0].Value = (stt + 1).ToString();
                    dgv.Rows[i].Cells[1].Value = dr["ObjectId"].ToString();

                    //Thông tin đối tượng
                    string str = "";
                    str = str + "Tên ĐT: " + dr["FullName"].ToString() + "\n";

                    DataTable dtOG = objBLL.GetObjectTypeId(dr["ObjectType"].ToString());
                    if (dtOG != null && dtOG.Rows.Count>0)
                    {
                        str = str + "Mã Loại ĐT : " + dtOG.Rows[0]["CommonId"].ToString() + "\n";
                        str = str + "Tên Loại ĐT  : " + dtOG.Rows[0]["StrValue1"].ToString() + "\n";
                    }

                    DataTable dtOG1 = objBLL.GetObjectGroupId(dr["ObjectGroup"].ToString());
                    if (dtOG1 != null && dtOG1.Rows.Count > 0)
                    {
                        str = str + "Mã Nhóm ĐT : " + dtOG1.Rows[0]["CommonId"].ToString() + "\n";
                        str = str + "Tên Nhóm ĐT  : " + dtOG1.Rows[0]["StrValue1"].ToString() + "\n";
                    }    


                    //str = str + "Mã Nhóm ĐT: " + dr["ObjectGroup"].ToString() + "\n";
                    //str = str + "Mã Loại ĐT: " + dr["ObjectType"].ToString() + "\n";
                    dgv.Rows[i].Cells[2].Value = str;

                    //Thông tin CMND- passport - GPKD...
                    str = "";
                    str = str + "Số CMND /Passport : " + dr["PID"].ToString() + "\n";
                    str = str + "Ngày cấp : " + dr["PIDDate"].ToString() + "\n";
                    str = str + "Nơi cấp" + dr["PIDIssue"].ToString() + "\n";
                    dgv.Rows[i].Cells[3].Value = str;

                    //Thông tin cá nhân
                    str = "";
                    str = str + "Ngày sinh : " + dr["DoB"].ToString() + "\n";
                    str = str + "Nơi sinh : " + dr["PoB"].ToString() + "\n";
                    if(dr["Gender"].ToString()=="0")
                    str=str+ "Giới tính: "+ VVPosM1.Common.clsLanguages.GetResource("Gender_0")+"\n";
                    if(dr["Gender"].ToString()=="1")
                    str = str + "Giới tính: " + VVPosM1.Common.clsLanguages.GetResource("Gender_1") + "\n";
                    str = str + "MST : " + dr["TaxCode"].ToString() ;
                    dgv.Rows[i].Cells[4].Value = str;

                    //Thông tin liên lạc
                    str = "";
                    str = str + "ĐC thường trú : " + dr["PerAdd"].ToString() + "\n";
                    str = str + "Địa chỉ tạm trú : " + dr["TemAdd"].ToString() + "\n";
                    str = str + "Số điện thoại : " + dr["Tel"].ToString() + "\n";
                    str = str + "Fax : " + dr["Fax"].ToString() + "\n";
                    str = str + "Email : " + dr["Email"].ToString() + "\n";
                    str = str + "Website : " + dr["Website"].ToString() ;
                    dgv.Rows[i].Cells[5].Value = str;

                    //Mã tỉnh
                    str = "";
                    DataTable dtP = objBLL.GetProvinceTheoID(dr["ProvinceId"].ToString());
                    if (dtP != null && dtP.Rows.Count>0)
                    {
                        str = str + "Mã tỉnh : " + dtP.Rows[0]["commonid"].ToString()+"\n";
                        str = str + "Tên tỉnh : " + dtP.Rows[0]["StrValue1"].ToString();
                    }                    
                    //str = str + dr["ProvinceId"].ToString() + "\n";
                    dgv.Rows[i].Cells[6].Value = str;
                    
                    //Trạng thái
                    if (dr["Status"].ToString() == "")
                        str = "";
                    if(dr["Status"].ToString()=="0")
                        str=VVPosM1.Common.clsLanguages.GetResource("Status_0");
                    if (dr["Status"].ToString() == "1")
                        str = VVPosM1.Common.clsLanguages.GetResource("Status_1");
                    if (dr["Status"].ToString() == "2")
                        str = VVPosM1.Common.clsLanguages.GetResource("Status_2");
                     dgv.Rows[i].Cells[7].Value = str;

                    //Ghi chú
                    str = "";
                    str = str + dr["Note"].ToString();
                    dgv.Rows[i].Cells[8].Value = str;

                    //Thông tin khởi tạo
                    str = "";
                    str = str + "Tạo bởi : " + dr["CreatedBy"].ToString() + "\n";
                    str = str + "Ngày tạo : " + dr["CreatedDate"].ToString() + "\n";
                    str = str + "Chỉnh sửa bởi : " + dr["ModifiedBy"].ToString() + "\n";
                    str = str + "Ngày chỉnh sửa : " + dr["ModifiedDate"].ToString() ;
                    dgv.Rows[i].Cells[9].Value = str;
                    
                    i++;
                    stt++;
                }
            }
            linkNumber.Text = CurPage.ToString() + "/" + totalPage.ToString();
            lblTB.Text = "Tìm thấy " + total.ToString() + " mẫu tin !";
        }

        private void frmManageOject_Load(object sender, EventArgs e)
        {
            // khởi tạo các đối tượng 
            objBLL = new ObjectBLL();

            // load tat ca cac bien tham so lua chon...
            LoadStatus();
            LoadGender();
            LoadProvince();
            LoadObjectGroup();
            LoadOBjectType();
        }
        private void LoadOBjectType() {
            DataTable dt = objBLL.GetObjectType();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["CommonId"].ToString(), dr["StrValue1"].ToString());
            }
            cboOjectType.DataSource = new BindingSource(test, null);
            cboOjectType.DisplayMember = "Value";
            cboOjectType.ValueMember = "Key";
        }

        private void LoadObjectGroup()
        {
            DataTable dt = objBLL.GetObjectGroup();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["CommonId"].ToString(), dr["StrValue1"].ToString());
            }
            cboObjectGroup.DataSource = new BindingSource(test, null);
            cboObjectGroup.DisplayMember = "Value";
            cboObjectGroup.ValueMember = "Key";
        }

        private void LoadStatus()
        {
            //load cboTrangThai
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Status_null"));
            test.Add("0", VVPosM1.Common.clsLanguages.GetResource("Status_0"));
            test.Add("1", VVPosM1.Common.clsLanguages.GetResource("Status_1"));
            test.Add("2", VVPosM1.Common.clsLanguages.GetResource("Status_2"));
            cboStatus.DataSource = new BindingSource(test, null);
            cboStatus.DisplayMember = "Value";
            cboStatus.ValueMember = "Key";
        }

        private void LoadGender()
        {
            //load cboTrangThai
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            test.Add("0", VVPosM1.Common.clsLanguages.GetResource("Gender_0"));
            test.Add("1", VVPosM1.Common.clsLanguages.GetResource("Gender_1"));            
            cboGender.DataSource = new BindingSource(test, null);
            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Key";
        }

        private void LoadProvince()
        {
            DataTable dt = objBLL.GetProvince();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("", VVPosM1.Common.clsLanguages.GetResource("Gender_null"));
            foreach (DataRow dr in dt.Rows)
            {
                test.Add(dr["CommonId"].ToString(), dr["StrValue1"].ToString());
            }    
            cboProvinceId.DataSource = new BindingSource(test, null);
            cboProvinceId.DisplayMember = "Value";
            cboProvinceId.ValueMember = "Key";
        }

        private void chkPIDDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPIDDate.Checked == true)
            {
                dtpPIDDate.Enabled = true;
            }
            else
            {
                dtpPIDDate.Enabled = false;
            }
        }

        private void chkDoB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoB.Checked == true)
            {
                dtpDoB.Enabled = true;
            }
            else
            {
                dtpDoB.Enabled = false;
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            foreach (Control c in this.pInput.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                if(c is RichTextBox )
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
                lblTB.Text = "...";
                lblTB1.Text = "...";
                dgv.Rows.Clear();

                


            }
            //cboStatus.SelectedIndex = 0;
            //cboObjectGroup.SelectedIndex = 0;
            //cboOjectType.SelectedIndex = 0;
            //cboGender.SelectedIndex = 0;
            //cboProvinceId.SelectedIndex = 0;
            //chkPIDDate.Checked = false;
            //chkDoB.Checked = false;

        }

        private void bntPre_Click(object sender, EventArgs e)
        {
            if (CurPage > 1)
            {
                SearchObjects(CurPage - 1);
            }
        }

        private void bntNext_Click(object sender, EventArgs e)
        {
            if (CurPage < totalPage)
            {
                SearchObjects(CurPage + 1);
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string objID = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Objects ob = objBLL.GetObjectWithID(objID);
                if (ob != null)
                {
                    txtObjectId.Text = ob.ObjectId;
                    if (!string.IsNullOrEmpty(ob.ObjectGroup))
                    {
                        //check trong cbo  
                        //cboObjectGroup.SelectedIndex = 0;
                        foreach (var item in cboObjectGroup.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == ob.ObjectGroup)
                            {
                                cboObjectGroup.SelectedValue = ob.ObjectGroup;
                                break;
                            }                           
                        }
                                           
                    }
                    if (!string.IsNullOrEmpty(ob.ObjectType))
                    {
                        //check trong cbo                        
                       // cboOjectType.SelectedIndex = 0;
                        foreach (var item in cboOjectType.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == ob.ObjectType)
                            {
                                cboOjectType.SelectedValue = ob.ObjectType;
                                break;
                            }
                        }                        
                    }
                    if (!string.IsNullOrEmpty(ob.PIDState))
                    {
                        dtpPIDDate.Value = DateTime.Parse(ob.PIDState);
                    }
                    txtPIDIssue.Text = ob.PIDIssue;
                    if (!string.IsNullOrEmpty(ob.DoB))
                    {
                        dtpDoB.Value = DateTime.Parse(ob.DoB);
                    }
                    txtPoB.Text = ob.PoB;
                    txtPerAdd.Text = ob.PerAdd;
                    txtTemAdd.Text = ob.TemAdd;
                    txtFullName.Text = ob.FullName;
                    if (!string.IsNullOrEmpty(ob.Gender))
                    {
                        cboGender.SelectedValue = ob.Gender;
                    }
                    if (!string.IsNullOrEmpty(ob.ProvinceId))
                    {
                        //check trong cbo                        
                        //cboProvinceId.SelectedIndex = 0;
                        foreach (var item in cboProvinceId.Items)
                        {
                            KeyValuePair<string, string> itm = (KeyValuePair<string, string>)item;
                            if (itm.Key == ob.ProvinceId)
                            {
                                cboProvinceId.SelectedValue = ob.ProvinceId;
                                break;
                            }
                        }   
                        //cboProvinceId.SelectedIndex = 0;
                    }
                    txtTel.Text = ob.Tel;
                    txtFax.Text = ob.Fax;
                    txtEmail.Text = ob.Email;
                    txtWebsite.Text = ob.Website;
                    txtPID.Text=ob.PID;
                    txtTaxCode.Text = ob.TaxCode;
                    //if (!string.IsNullOrEmpty(ob.Status))
                    //{
                        cboStatus.SelectedValue = ob.Status;
                    //}
                    rtxtDescription.Text = ob.Note;

                    // load hinh tu web
                    pbImgObject.SizeMode = PictureBoxSizeMode.Zoom;
                    pbImgObject.Image = VVPosM1.Common.Utility.GetImageFromService("Users", ob.Image);

                }

                //// Xóa
                if (e.ColumnIndex == 10)
                {

                    if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("KhoaNv"),
                                    Common.clsLanguages.GetResource("Information"),
                                    Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                    Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                    {
                        int Xoa = objBLL.Delete(objID);
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
                                lblTB.Text = "...";
                                lblTB1.Text = "...";
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


        // kiểm tra trường nào trống
        private bool Kiemtra()
        {
            if (cboObjectGroup.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ObjectGroupNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboObjectGroup.Focus();
                return false;
            }
            if (cboOjectType.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ObjectTypeNotEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboOjectType.Focus();
                return false;
            }
            if (cboStatus.SelectedIndex == 0)
            {
                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("StatusEmpty"),
                                     Common.clsLanguages.GetResource("Information"),
                                     Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                     Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                cboOjectType.Focus();
                return false;
            }
            return true;
        }


        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            SaveData();

        }

        private void SaveData()
        {
            // check xem có trong db chưa?
            string objID = txtObjectId.Text.Trim();
            Objects obj = new Objects();
            obj = objBLL.GetObjectWithID(objID);

            objSea = new Objects();
            
            objSea.ObjectGroup = cboObjectGroup.SelectedValue.ToString();
            objSea.ObjectType = cboOjectType.SelectedValue.ToString();
            objSea.FullName = txtFullName.Text;
            objSea.PID = txtPID.Text;
            if (chkPIDDate.Checked == true)
            {
                objSea.PIDState = dtpPIDDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                objSea.PIDState = "";
            }
            objSea.PIDIssue = txtPIDIssue.Text;
            if (chkDoB.Checked == true)
            {
                objSea.DoB = dtpDoB.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                objSea.DoB = "";
            }
            objSea.PoB = txtPoB.Text;
            objSea.PerAdd = txtPerAdd.Text;
            objSea.TemAdd = txtTemAdd.Text;
            objSea.Gender = cboGender.SelectedValue.ToString();
            objSea.ProvinceId = cboProvinceId.SelectedValue.ToString();
            objSea.Tel = txtTel.Text;
            objSea.Fax = txtFax.Text;
            objSea.Email = txtEmail.Text;
            objSea.Website = txtWebsite.Text;
            objSea.TaxCode = txtTaxCode.Text;
            objSea.Note = rtxtDescription.Text;
            objSea.Status = cboStatus.SelectedValue.ToString();

            if(!string.IsNullOrEmpty(objSea.Email)){
                if (!Common.Utility.IsValidEmail(objSea.Email)){
                    CustomMessageBox.MessageBox.ShowCustomMessageBox("Email không hợp lệ, vui lòng kiểm tra lại",
                                       Common.clsLanguages.GetResource("Information"),
                                       Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                       Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
                    txtEmail.Focus();
                    return;
                }
            }
            if (obj != null)
            {// Cập nhật
                if (CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CommonCodeUpdate"),
                                   Common.clsLanguages.GetResource("Information"),
                                   Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                                   Common.Config.CUSTOM_MESSAGEBOX_BUTTON.YESNO) == DialogResult.Yes)
                {
                    objSea.ObjectId = obj.ObjectId;
                    int i = objBLL.Update(objSea);
                    if (i == 1)
                    {
                        lblTB1.Text = "Cập nhật thành công !!!";

                        objSea.Image = obj.Image;

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
                    objID = objBLL.Tao_ObjectID(cboObjectGroup.SelectedValue.ToString(), cboOjectType.SelectedValue.ToString());
                    objSea.ObjectId = objID;

                    int i = objBLL.Insert(objSea);
                    if (i == 1)
                    {
                        lblTB1.Text = "Thêm mới thành công !!!";
                        txtObjectId.Text = objID;
                        objSea.Image = null;
                    }
                    else
                    {
                        lblTB1.Text = "Thêm mới thất bại !!!";
                    }
                }
            }
            // hinh
            if (!string.IsNullOrEmpty(txtImage.Text))
            {
                SaveImage(objID, objSea.Image);
            }


            SearchObjects(1);
            
        }

        private void SaveImage(string objID, string Image)
        {
            try
            {
                string strImage = txtImage.Text;
                //string[] sExtends = strImage.Split('.');
                //string sExtend = sExtends[sExtends.Length - 1].ToString();
                Image img = System.Drawing.Image.FromFile(strImage);
                int i = objBLL.SaveImageIntoWeb(img, objID, Image);
                if (i == 1)
                {
                    txtImage.Text = "";
                    pbImgObject.Image = null;
                }
            }
            catch (Exception e)
            {

            }
        }


        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string safeFilePath = ofd.SafeFileName;
                txtImage.Text = filePath;
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
            Final = objBLL.SearchObjects(objSea, 1, out total);
            double RecordPerPage = 20;            
            double tem = (total / RecordPerPage);
            totalPage = Math.Ceiling(tem);

            for (int i = 2; i <= totalPage; i++) // duyet tat ca cac trang
            {
                DataTable dt = objBLL.SearchObjects(objSea, i, out total);
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

            epex.ExportFileFromDataTable_Dung(Final, "Objects_" + DateTime.Now.ToString("ddMMyy_HHmmss"),
                "List of " + "Objects_" + DateTime.Now.ToString("ddMMyy_HHmmss"), null);
        }

        private void cboProvinceId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region TextBox Events

        private void txtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDecimal1(e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Utility.MaskDecimal1(e);
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtPID, 40);
        }

        private void txtPIDIssue_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtPIDIssue, 150);
        }

        private void txtPoB_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtPoB, 250);
        }

        private void txtPerAdd_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtPerAdd, 250);
        }

        private void txtTemAdd_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtTemAdd, 250);
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtFullName, 200);
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtTel, 150);
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtFax, 150);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtEmail, 250);
        }

        private void txtWebsite_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtWebsite, 250);
        }

        private void txtTaxCode_TextChanged(object sender, EventArgs e)
        {
            Common.Utility.TextLengthValid(txtTaxCode, 250);
        }

        #endregion

    }
}
