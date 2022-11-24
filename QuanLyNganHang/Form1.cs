namespace QuanLyNganHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBxKyHanGui.Items.Add("01 tháng / 5.65%");
            cBxKyHanGui.Items.Add("03 tháng / 6.00%");
            cBxKyHanGui.Items.Add("06 tháng / 7.60%");
            cBxKyHanGui.Items.Add("12 tháng / 8.04%");
            cBxKyHanGui.Items.Add("18 tháng / 8.40%");

            cBxKyHanGui.SelectedIndex = 0;

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            NganHang nganhang = new NganHang();

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

                CoKyHan stkCoKyHan = new CoKyHan(txtBxCMND.Text, txtBxTenKhachHang.Text, double.Parse(txtBxSoTienGui.Text), dtpNgayLapSo.Value, LaiSuat, KyHan);
                nganhang.listSoCoKyHan.Add(stkCoKyHan);
            }
            //Đamg chọn sổ không kỳ hạn
            else if (rBtnGuiKoKyHan.Checked == true)
            {
                double LaiSuatKoKyHan = double.Parse(txtBxLaiSuatKoKyHan.Text.Remove(txtBxLaiSuatKoKyHan.Text.IndexOf("%")));

                KoKyHan stkKoKyHan = new KoKyHan(txtBxCMND.Text, txtBxTenKhachHang.Text, double.Parse(txtBxSoTienGui.Text), dtpNgayLapSo.Value, LaiSuatKoKyHan);
                nganhang.listSoKoKyHan.Add(stkKoKyHan) ;
            }
            //Chưa chọn sổ
            else
            {
                MessageBox.Show("\nBạn chưa chọn sổ tiết kiệm!!!");
            }
            MessageBox.Show("\nThêm thành công sổ tiết kiệm");

            string[] arr = new string[5]; //Tạo 1 mảng và nạp dữ liệu vào mảng đó
            ListViewItem item = new ListViewItem(arr); //Tạo 1 list item ứng với từng dữ liệu

            listViewDanhSachSo.Items.Add(item); //Nạp list item vào listView
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xoá chứ ???", "Thông báo", MessageBoxButtons.YesNo);
            
            if (dlr == DialogResult.Yes)
            {
                listViewDanhSachSo.Items.Remove(listViewDanhSachSo.SelectedItems[0]);
            }
            else if (dlr == DialogResult.No)
            {
                MessageBox.Show("Sau nhớ nghĩ kĩ rồi hay chọn", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string HoTenKhachHang = listViewDanhSachSo.SelectedItems[0].SubItems[0].Text;
            string cmnd = listViewDanhSachSo.SelectedItems[0].SubItems[1].Text;
            double SoTienGui = double.Parse(listViewDanhSachSo.SelectedItems[0].SubItems[2].Text);
            string NgayLapSo = listViewDanhSachSo.SelectedItems[0].SubItems[3].Text;
            string LaiSuat = listViewDanhSachSo.SelectedItems[0].SubItems[4].Text; ;

            //CoKyHan stkCoKyHan = new CoKyHan(cmnd, HoTenKhachHang, SoTienGui, NgayLapSo, LaiSuat, KyHan);

            Form2 frm2 = new Form2();
            
        }
    }
}
