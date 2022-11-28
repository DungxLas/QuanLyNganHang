using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang
{
    internal class CoKyHan : SoTietKiem
    {
        private int kyHan;

        public int KyHan { get => kyHan; set => kyHan = value; }

        public CoKyHan() : base()
        {
            this.kyHan = 0;
        }

        public CoKyHan(string cmnd, string hoTen, double soTienGui, DateTime ngayLapSo, double laiSuat, int kyHan)
            : base(cmnd, hoTen, soTienGui, ngayLapSo, laiSuat)
        {
            this.kyHan = kyHan;
        }
        public CoKyHan(CoKyHan stkCoKyHan) : base((SoTietKiem)stkCoKyHan)
        {
            this.kyHan = stkCoKyHan.kyHan;
        }

        public List<string> xuatSTK()
        {
            List<string> stk = new List<string>();
            stk.Add(HoTen);
            stk.Add(Cmnd);
            stk.Add(SoTienGui.ToString());
            stk.Add(NgayLapSo.ToString("dd/MM/yyyy"));
            stk.Add(kyHan.ToString() + " tháng / " + LaiSuat.ToString() + " %");
            stk.Add(maSTK);

            return stk;
        }

        public void capNhapSTK(string hoTen, string cmnd, double soTienGui, DateTime ngayLapSo, double laiSuat, int kyHan)
        {
            this.Cmnd = cmnd;
            HoTen = hoTen;
            SoTienGui = soTienGui;
            NgayLapSo = ngayLapSo;
            LaiSuat = laiSuat;
            KyHan = kyHan;
        }

        public double TinhTienLoi()
        {
            return SoTienGui * LaiSuat * KyHan;
        }
    }
}
