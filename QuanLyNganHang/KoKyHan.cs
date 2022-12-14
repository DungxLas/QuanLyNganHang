using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang
{
    internal class KoKyHan : SoTietKiem
    {
        public KoKyHan() : base()
        {
            
        }

        public KoKyHan(string cmnd, string hoTen, double soTienGui, DateTime ngayLapSo, double laiSuat)
            : base(cmnd, hoTen, soTienGui, ngayLapSo, laiSuat)
        {
            
        }
        public KoKyHan(KoKyHan stkKoKyHan) : base((SoTietKiem)stkKoKyHan)
        {
            
        }

        public List<string> xuatSTK()
        {
            List<string> stk = new List<string>();
            stk.Add(HoTen);
            stk.Add(Cmnd);
            stk.Add(SoTienGui.ToString());
            stk.Add(NgayLapSo.ToString("dd/MM/yyyy"));
            stk.Add(" Không kỳ hạn / " + LaiSuat.ToString() + " %");
            stk.Add(maSTK);

            return stk;
        }

        public void capNhapSTK(string hoTen, string cmnd, double soTienGui, DateTime ngayLapSo)
        {
            this.Cmnd = cmnd;
            HoTen = hoTen;
            SoTienGui = soTienGui;
            NgayLapSo = ngayLapSo;
        }
    }
}
