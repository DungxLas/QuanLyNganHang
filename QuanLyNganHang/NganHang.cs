using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang
{
    public class NganHang
    {
        private List<CoKyHan> ListSoCoKyHan = new List<CoKyHan>();
        private List<KoKyHan> ListSoKoKyHan = new List<KoKyHan>();

        internal List<CoKyHan> listSoCoKyHan { get => ListSoCoKyHan; set => ListSoCoKyHan = value; }
        internal List<KoKyHan> listSoKoKyHan { get => ListSoKoKyHan; set => ListSoKoKyHan = value; }

        //Tìm STK Có kỳ Hạn với mã STK 
        public int timSTKCoKyHan(string maSTK)
        {
            int ListSoCoKyHan_count = ListSoCoKyHan.Count;
            for(int i = 0; i < ListSoCoKyHan_count; i++)
            {
                if (ListSoCoKyHan[i].maSTK_get() == maSTK)
                {
                    return i;
                }
            } 

            return -1; //Không tìm thấy sổ
        }

        //Xoá STK Có kỳ Hạn với mã STK 
        public void xoaSTKCoKyHan(string maSTK)
        {
            int stkMuonXoa_index = timSTKCoKyHan(maSTK);
            ListSoCoKyHan.RemoveAt(stkMuonXoa_index);
        }

        //Tìm STK Ko kỳ Hạn với mã STK 
        public int timSTKKoKyHan(string maSTK)
        {
            int ListSoKoKyHan_count = ListSoKoKyHan.Count;
            for (int i = 0; i < ListSoKoKyHan_count; i++)
            {
                if (ListSoKoKyHan[i].maSTK_get() == maSTK)
                {
                    return i;
                }
            }

            return -1; //Không tìm thấy sổ
        }

        //Xoá STK Ko kỳ Hạn với mã STK 
        public void xoaSTKKoKyHan(string maSTK)
        {
            int stkMuonXoa_index = timSTKKoKyHan(maSTK);
            ListSoKoKyHan.RemoveAt(stkMuonXoa_index);
        }
    }
}
