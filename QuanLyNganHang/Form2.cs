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
    }
}
