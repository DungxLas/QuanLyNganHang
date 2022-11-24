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
            List<string> arr = new List<string>(); //Tạo 1 mảng để nạp dữ liệu vào mảng đó

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
                
                arr = stkCoKyHan.xuatSTK(); //nạp dữ liệu vào mảng
                arr.Insert(0, (listViewDanhSachSo.Items.Count + 1).ToString());
                ListViewItem item = new ListViewItem(arr.ToArray()); //Tạo 1 list item ứng với từng dữ liệu
                listViewDanhSachSo.Items.Add(item); //Nạp list item vào listView

                nganhang.listSoCoKyHan.Add(stkCoKyHan);

                MessageBox.Show("\nThêm thành công sổ tiết kiệm");
            }
            //Đamg chọn sổ không kỳ hạn
            else if (rBtnGuiKoKyHan.Checked == true)
            {
                double LaiSuatKoKyHan = double.Parse(txtBxLaiSuatKoKyHan.Text.Remove(txtBxLaiSuatKoKyHan.Text.IndexOf("%")));

                KoKyHan stkKoKyHan = new KoKyHan(txtBxCMND.Text, txtBxTenKhachHang.Text, double.Parse(txtBxSoTienGui.Text), dtpNgayLapSo.Value, LaiSuatKoKyHan);
                
                arr = stkKoKyHan.xuatSTK(); //nạp dữ liệu vào mảng
                arr.Insert(0, (listViewDanhSachSo.Items.Count + 1).ToString());
                ListViewItem item = new ListViewItem(arr.ToArray()); //Tạo 1 list item ứng với từng dữ liệu
                listViewDanhSachSo.Items.Add(item); //Nạp list item vào listView

                nganhang.listSoKoKyHan.Add(stkKoKyHan) ;

                MessageBox.Show("\nThêm thành công sổ tiết kiệm");
            }
            //Chưa chọn sổ
            else
            {
                MessageBox.Show("\nBạn chưa chọn sổ tiết kiệm!!!");
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xoá chứ ???", "Thông báo", MessageBoxButtons.YesNo);
            
            if (dlr == DialogResult.Yes)
            {
                int indexSelectItem = int.Parse(listViewDanhSachSo.SelectedItems[0].SubItems[0].Text) - 1;

                listViewDanhSachSo.Items.Remove(listViewDanhSachSo.SelectedItems[0]);

                for (int i = indexSelectItem; i < listViewDanhSachSo.Items.Count; i++)
                {
                    listViewDanhSachSo.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
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
