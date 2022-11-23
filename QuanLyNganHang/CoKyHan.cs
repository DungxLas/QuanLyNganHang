using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang
{
    internal class CoKyHan : SoTietKiem
    {
        private int KyHan;

        public CoKyHan() : base()
        {
            this.KyHan = 0;
        }

        public CoKyHan(string cmnd, string hoTen, double soTienGui, DateTime ngayLapSo, double laiSuat, int kyHan)
            : base(cmnd, hoTen, soTienGui, ngayLapSo, laiSuat)
        {
            this.KyHan = kyHan;
        }
        public CoKyHan(CoKyHan stkCoKyHan) : base((SoTietKiem)stkCoKyHan)
        {
            this.KyHan = stkCoKyHan.KyHan;
        }

        public double TinhTienLoi()
        {
            return SoTienGui * LaiSuat * KyHan;
        }
    }
}
