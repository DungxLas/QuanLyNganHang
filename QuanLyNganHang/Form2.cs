using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganHang
{
    public partial class frmCapNhap : Form
    {
        public frmCapNhap()
        {
            InitializeComponent();
        }

        public string stt, HoTenKhachHang, cmnd, SoTienGui, NgayLapSo, KyHanLaiSuat, maSTK;

        private void Form2_Load(object sender, EventArgs e)
        {
            txtBxTenKhachHang.Text = HoTenKhachHang;
            txtBxCMND.Text = cmnd;
            txtBxSoTienGui.Text = SoTienGui;

            dtpNgayLapSo.Value = DateTime.ParseExact(NgayLapSo, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            cBxKyHanGui.Items.Add("1 tháng / 5.65 %");
            cBxKyHanGui.Items.Add("3 tháng / 6 %");
            cBxKyHanGui.Items.Add("6 tháng / 7.6 %");
            cBxKyHanGui.Items.Add("12 tháng / 8.04 %");
            cBxKyHanGui.Items.Add("18 tháng / 8.4 %");

            char kyTuDauCotKyHanLaiSuat = KyHanLaiSuat[0];
            //Nếu ký tự đầu của ổ Kỳ hạn/Lãi  suất là số => đó là STK có kỳ hạn
            if (kyTuDauCotKyHanLaiSuat >= '0' && kyTuDauCotKyHanLaiSuat <= '9')
            {
                rBtnGuiCoKyHan.Checked = true;
                lblKyHanGui.Visible = true;
                cBxKyHanGui.Visible = true;

                lblLaiSuat.Visible = false;
                txtBxLaiSuatKoKyHan.Visible = false;

                if (KyHanLaiSuat == "1 tháng / 5.65 %")
                {
                    cBxKyHanGui.SelectedIndex = 0;
                }
                else if (KyHanLaiSuat == "3 tháng / 6 %")
                {
                    cBxKyHanGui.SelectedIndex = 1;
                }
                else if (KyHanLaiSuat == "6 tháng / 7.6 %")
                {
                    cBxKyHanGui.SelectedIndex = 2;
                }
                else if (KyHanLaiSuat == "12 tháng / 8.04 %")
                {
                    cBxKyHanGui.SelectedIndex = 3;
                }
                else if (KyHanLaiSuat == "18 tháng / 8.4 %")
                {
                    cBxKyHanGui.SelectedIndex = 4;
                }
            }
            //Ngược lại là STK ko kỳ hạn
            else
            {
                rBtnGuiKoKyHan.Checked = true;
                lblKyHanGui.Visible = false;
                cBxKyHanGui.Visible = false;

                lblLaiSuat.Visible = true;
                txtBxLaiSuatKoKyHan.Visible = true;
            }
        }

        private void rBtnCoKyHan_Click(object sender, EventArgs e)
        {
            lblKyHanGui.Visible = true;
            cBxKyHanGui.Visible = true;

            lblLaiSuat.Visible = false;
            txtBxLaiSuatKoKyHan.Visible = false;
        }

        private void rBtnGuiKoKyHan_Click(object sender, EventArgs e)
        {
            lblKyHanGui.Visible = false;
            cBxKyHanGui.Visible = false;

            lblLaiSuat.Visible = true;
            txtBxLaiSuatKoKyHan.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin sổ tiết kiệm chứ ???", "Thông báo", MessageBoxButtons.YesNo);

            if (dlr == DialogResult.Yes)
            {
                frmQuanLyNganHang.HoTenKhachHang = txtBxTenKhachHang.Text;
                frmQuanLyNganHang.cmnd = txtBxCMND.Text;
                frmQuanLyNganHang.SoTienGui = txtBxSoTienGui.Text;
                frmQuanLyNganHang.NgayLapSo = dtpNgayLapSo.Value.ToString("dd/MM/yyyy");
                //Đang chọn sổ có kỳ hạn
                if (rBtnGuiCoKyHan.Checked == true)
                {
                    double LaiSuat = 0;
                    int KyHan = 0;

                    switch (cBxKyHanGui.SelectedIndex)
                    {
                        case 0:
                            {
                                LaiSuat = 5.65;
                                KyHan = 1;
                                break;
                            }
                        case 1:
                            {
                                LaiSuat = 6;
                                KyHan = 3;
                                break;
                            }
                        case 2:
                            {
                                LaiSuat = 7.6;
                                KyHan = 6;
                                break;
                            }
                        case 3:
                            {
                                LaiSuat = 8.04;
                                KyHan = 12;
                                break;
                            }
                        case 4:
                            {
                                LaiSuat = 8.4;
                                KyHan = 18;
                                break;
                            }
                    }

                    frmQuanLyNganHang.KyHanLaiSuat = KyHan.ToString() + " tháng / " + LaiSuat.ToString() + " %";  
                }
                //Đamg chọn sổ không kỳ hạn
                else if (rBtnGuiKoKyHan.Checked == true)
                {
                    frmQuanLyNganHang.KyHanLaiSuat = " Không kỳ hạn / " + txtBxLaiSuatKoKyHan.Text;
                }

                MessageBox.Show("\nThêm thành công sổ tiết kiệm");

                this.Close();
            }
            else if (dlr == DialogResult.No)
            {
                MessageBox.Show("Sau nhớ nghĩ kĩ rồi hay chọn", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
