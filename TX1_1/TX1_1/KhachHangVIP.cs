using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_1
{
    internal class KhachHangVIP : KhachHang
    {
        private DateTime ngayLamThe;
        public KhachHangVIP()
        {
        }

        public KhachHangVIP(string maKH, string gioiTinh, int soLuong, double donGia) : base(maKH, gioiTinh, soLuong, donGia)
        {
            this.NgayLamThe = NgayLamThe;
        }

        public DateTime NgayLamThe { get => ngayLamThe; set => ngayLamThe = value; }

        public override void nhapTT()
        {
            base.nhapTT();
            Console.WriteLine("Nhap ngay lam the: ");
            NgayLamThe = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }
        public override double tinhTong()
        {
            return base.tinhTong() * 0.9;

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ngay lam the: "+ NgayLamThe);
        }

    }
}
