using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang
{
    internal class NganHang
    {
        private List<CoKyHan> ListSoCoKyHan = new List<CoKyHan>();
        private List<KoKyHan> ListSoKoKyHan = new List<KoKyHan>();

        internal List<CoKyHan> listSoCoKyHan { get => ListSoCoKyHan; set => ListSoCoKyHan = value; }
        internal List<KoKyHan> listSoKoKyHan { get => ListSoKoKyHan; set => ListSoKoKyHan = value; }

    }
}
