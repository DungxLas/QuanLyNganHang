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

        }

        private void rBtnGuiKoKyHan_Click(object sender, EventArgs e)
        {
            lblKyHanGui.Visible = false;
            cBxKyHanGui.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string HoTenKhachHang = txtBxTenKhachHang.Text;
            string cmnd = txtBxCMND.Text;
            double SoTienGui = double.Parse(txtBxSoTienGui.Text);
            DateTime NgayLapSo = dtpNgayLapSo.Value;
            double LaiSuat = 1;

            string[] arr = new string[5]; //Tạo 1 mảng và nạp dữ liệu vào mảng đó
            arr[0] = HoTenKhachHang;
            arr[1] = cmnd;
            arr[2] = SoTienGui.ToString();
            arr[3] = NgayLapSo.ToString("dd/MM/yyyy");

            if (rBtnGuiCoKyHan.Checked == true)
            {
                int KyHan = 1;

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

                //CoKyHan stkCoKyHan = new CoKyHan(cmnd, HoTenKhachHang, SoTienGui, NgayLapSo, LaiSuat, KyHan);

                arr[4] = KyHan.ToString() + " tháng / " + LaiSuat.ToString() + "%";
            }
            else if (rBtnGuiKoKyHan.Checked == true)
            {
                //KoKyHan stkKoKyHan = new KoKyHan(cmnd, HoTenKhachHang, SoTienGui, NgayLapSo, LaiSuat);

                arr[4] = "Không kỳ hạn / " + LaiSuat.ToString() + "%";
            }

            ListViewItem item = new ListViewItem(arr); //Tạo 1 list item ứng với từng dữ liệu

            listViewDanhSachSo.Items.Add(item); //Nạp list item vào listView
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xoá chứ ???", "Thông báo", MessageBoxButtons.YesNo);
            
            if (dlr == DialogResult.Yes)
            {
                for (int i = 0; i < listViewDanhSachSo.Items.Count; i++)
                {
                    if (listViewDanhSachSo.Items[i].Selected)
                    {
                        listViewDanhSachSo.Items[i].Remove();
                        break;
                    }
                }
            }
            else if (dlr == DialogResult.No)
            {
                MessageBox.Show("Sau nhớ nghĩ kĩ rồi hay chọn", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
