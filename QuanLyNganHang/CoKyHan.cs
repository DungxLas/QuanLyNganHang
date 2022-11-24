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

        public List<string> xuatSTK()
        {
            List<string> stk = new List<string>();
            stk.Add(HoTen);
            stk.Add(cmnd);
            stk.Add(SoTienGui.ToString());
            stk.Add(NgayLapSo.ToString("dd/MM/yyyy"));
            stk.Add(KyHan.ToString() + " tháng / " + LaiSuat.ToString() + " %");

            return stk;
        }

        public double TinhTienLoi()
        {
            return SoTienGui * LaiSuat * KyHan;
        }
    }
}
