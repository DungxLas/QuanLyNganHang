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
        private string maSTK;

        protected string MaSTK { get => maSTK; set => maSTK = value; }

        public string taoMaSTK()
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            int length = chars.Count();

            string str = "";
            Random rd = new Random();

            for (int i = 0; i < length; i++)
            {
                str += chars[rd.Next(0, length)];
            }

            return str;
        }

        public SoTietKiem()
        {
            cmnd = " ";
            HoTen = " ";
            SoTienGui = 0;
            NgayLapSo = new DateTime();
            LaiSuat = 0;
            maSTK = " ";
        }

        public SoTietKiem(string cmnd, string hoTen, double soTienGui, DateTime ngayLapSo, double laiSuat)
        {
            this.cmnd = cmnd;
            HoTen = hoTen;
            SoTienGui = soTienGui;
            NgayLapSo = ngayLapSo;
            LaiSuat = laiSuat;
            maSTK = taoMaSTK();
        }

        public SoTietKiem(SoTietKiem stk)
        {
            cmnd = stk.cmnd;
            HoTen = stk.HoTen;
            SoTienGui = stk.SoTienGui;
            NgayLapSo = stk.NgayLapSo;
            LaiSuat = stk.LaiSuat;
            maSTK = taoMaSTK();
        }
    }
}
