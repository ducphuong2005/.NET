using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_2
{
    internal class KhachHang
    {
        private string maKH;
        private string gioiTinh;
        private int soLuong;
        private double donGia;

        public KhachHang()
        {
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }

        public KhachHang(string maKH, string gioiTinh, int soLuong, double donGia)
        {
            this.maKH = maKH;
            this.gioiTinh = gioiTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public virtual void nhapTT()
        {
            Console.Write("Nhập mã khách hàng: ");
            MaKH = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhập số lượng: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            DonGia = double.Parse(Console.ReadLine());
        }
        public virtual double tinhtong()
        {
            double tong = SoLuong * DonGia;
            return tong;
        }
        public virtual void xuatTT()
        {
            Console.WriteLine("Ma khach hang: " + maKH);
            Console.WriteLine("Gioi tinh: " + gioiTinh);
            Console.WriteLine("So luong mua: " + soLuong);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Tong tien: " + tinhtong());
        }
    }
}
