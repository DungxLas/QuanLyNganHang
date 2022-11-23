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
            //string HoTenKhachHang = txtBxTenKhachHang.Text;
            //string cmnd = txtBxCMND.Text;
            //double SoTienGui = double.Parse(txtBxSoTienGui.Text);
            //int ngay = int.Parse(txtBxNgay.Text);
            //int thang = int.Parse(txtBxThang.Text);
            //int nam = int.Parse(txtBxNam.Text);
            //ThoiGian NgayLapSo = new ThoiGian(ngay, thang, nam);
            //double LaiSuat = 1.2;

            //SoTietKiem stk = new SoTietKiem(cmnd, HoTenKhachHang, SoTienGui, NgayLapSo, LaiSuat);

            //if(rBtnGuiCoKyHan.Checked == true)
            //{
            //    int KyHan = int.Parse(txtBxKyHan.Text);
            //    CoKyHan STKCoKyHan = new CoKyHan();
                
            //}
            //else if(rBtnGuiKoKyHan.Checked == true)
            //{

            //}
        }
    }
}