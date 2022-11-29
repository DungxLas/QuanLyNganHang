using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System;

namespace QuanLyNganHang
{
    public partial class frmQuanLyNganHang : Form
    {
        public frmQuanLyNganHang()
        {
            InitializeComponent();
        }


        public static NganHang nganhang = new NganHang();
        public static string stt, HoTenKhachHang, cmnd, SoTienGui, NgayLapSo, KyHanLaiSuat, maSTK;
        public static bool check;

        private void Form1_Load(object sender, EventArgs e)
        {
            cBxKyHanGui.Items.Add("1 tháng / 5.65 %");
            cBxKyHanGui.Items.Add("3 tháng / 6 %");
            cBxKyHanGui.Items.Add("6 tháng / 7.6 %");
            cBxKyHanGui.Items.Add("12 tháng / 8.04 %");
            cBxKyHanGui.Items.Add("18 tháng / 8.4 %");

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
                //Bước 1: Xoá STK trong class NganHang
                string maSTK_Xoa = listViewDanhSachSo.SelectedItems[0].SubItems[6].Text;

                char kyTuDauCotKyHanLaiSuat = listViewDanhSachSo.SelectedItems[0].SubItems[5].Text[0];
                //Nếu ký tự đầu của ổ Kỳ hạn/Lãi  suất là số => đó là STK có kỳ hạn
                if (kyTuDauCotKyHanLaiSuat >= '0' && kyTuDauCotKyHanLaiSuat <= '9')
                {
                    nganhang.xoaSTKCoKyHan(maSTK_Xoa);
                }
                //Ngược lại là STK ko kỳ hạn
                else
                {
                    nganhang.xoaSTKKoKyHan(maSTK_Xoa);
                }

                //Bước 2: Xoá STK trong ListView
                int indexSelectItem = listViewDanhSachSo.Items.IndexOf(listViewDanhSachSo.SelectedItems[0]);

                listViewDanhSachSo.Items.RemoveAt(indexSelectItem);

                //Bước 3: Đặt lại số thứ tự
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
            //Bước 1: Cập nhập dữ liệu từ form quản lý ngân hàng sang form cập nhập
            frmCapNhap frm = new frmCapNhap();
            
            //frm.stt = listViewDanhSachSo.SelectedItems[0].SubItems[0].Text;
            frm.HoTenKhachHang = listViewDanhSachSo.SelectedItems[0].SubItems[1].Text;
            frm.cmnd = listViewDanhSachSo.SelectedItems[0].SubItems[2].Text;
            frm.SoTienGui = listViewDanhSachSo.SelectedItems[0].SubItems[3].Text;
            frm.NgayLapSo = listViewDanhSachSo.SelectedItems[0].SubItems[4].Text;
            frm.KyHanLaiSuat = listViewDanhSachSo.SelectedItems[0].SubItems[5].Text;
            frm. maSTK = listViewDanhSachSo.SelectedItems[0].SubItems[6].Text;

            frm.ShowDialog();

            //Bước 2: Nhận lại dữ liệu form cập nhập lại form quản lý ngân hàng ...... //Bước 3: Cập nhập dữ liệu vào list nganhang  
            if (check == true)
            {
                //Nhận lại dữ liệu form cập nhập lại form quản lý ngân hàng
                listViewDanhSachSo.SelectedItems[0].SubItems[1].Text = HoTenKhachHang;
                listViewDanhSachSo.SelectedItems[0].SubItems[2].Text = cmnd;
                listViewDanhSachSo.SelectedItems[0].SubItems[3].Text = SoTienGui;
                listViewDanhSachSo.SelectedItems[0].SubItems[4].Text = NgayLapSo;
                listViewDanhSachSo.SelectedItems[0].SubItems[5].Text = KyHanLaiSuat;

                //Cập nhập dữ liệu vào list nganhang bên form cập nhập
            }
        }

        public static string cmnd_TimKiem;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            frm.ShowDialog();

            //Duyệt qua danh sách listView đang có và tim ra các dòng có CMND trùng thì tô đỏ
            for (int i = 0; i < listViewDanhSachSo.Items.Count; i++)
            {
                if (listViewDanhSachSo.Items[i].SubItems[2].Text == cmnd_TimKiem)
                {
                    listViewDanhSachSo.Items[i].BackColor = Color.Red;
                    break;
                }    
            }
        }
    }
}
