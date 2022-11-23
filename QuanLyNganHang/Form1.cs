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
            double LaiSuat = 5.65;
            

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

                CoKyHan stkCoKyHan = new CoKyHan(cmnd, HoTenKhachHang, SoTienGui, NgayLapSo, LaiSuat, KyHan);
            }
            else if (rBtnGuiKoKyHan.Checked == true)
            {

            }
        }
    }
}
