using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang
{
    internal class SoTietKiem
    {
        private string cmnd;
        private string hoTen;
        private double soTienGui;
        private DateTime ngayLapSo;
        private double laiSuat;
        protected string maSTK;

        protected string Cmnd { get => cmnd; set => cmnd = value; }
        protected string HoTen { get => hoTen; set => hoTen = value; }
        protected double SoTienGui { get => soTienGui; set => soTienGui = value; }
        protected DateTime NgayLapSo { get => ngayLapSo; set => ngayLapSo = value; }
        protected double LaiSuat { get => laiSuat; set => laiSuat = value; }

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
            LaiSuat = 1;
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

        public string maSTK_get()
        {
            return maSTK;
        }
    }
}
