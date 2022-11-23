using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang
{
    internal class SoTietKiem
    {
        protected string cmnd;
        protected string HoTen;
        protected double SoTienGui;
        protected DateTime NgayLapSo;
        protected double LaiSuat;

        public SoTietKiem()
        {
            cmnd = " ";
            HoTen = " ";
            SoTienGui = 0;
            NgayLapSo = new DateTime();
            LaiSuat = 0;
        }

        public SoTietKiem(string cmnd, string hoTen, double soTienGui, DateTime ngayLapSo, double laiSuat)
        {
            this.cmnd = cmnd;
            HoTen = hoTen;
            SoTienGui = soTienGui;
            NgayLapSo = ngayLapSo;
            LaiSuat = laiSuat;
        }

        public SoTietKiem(SoTietKiem stk)
        {
            cmnd = stk.cmnd;
            HoTen = stk.HoTen;
            SoTienGui = stk.SoTienGui;
            NgayLapSo = stk.NgayLapSo;
            LaiSuat = stk.LaiSuat;
        }
    }
}
