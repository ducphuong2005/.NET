using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_1
{
    internal class KhachHang
    {
        private string maKH;
        public KhachHang()
        {
        }
        private string gioiTinh { get; set;}
        private int soLuong { get; set;}
        private double donGia { get; set;}
        public string MaKH { get => maKH; set => maKH = value; }

        public KhachHang(string maKH, string gioiTinh, int soLuong, double donGia)
        {
            this.maKH = maKH;
            this.gioiTinh = gioiTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public virtual void nhapTT()
        {
            Console.WriteLine("Nhap ma khach hang: ");
            maKH = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            gioiTinh= Console.ReadLine();
            Console.WriteLine("Nhap so luong mua: ");
            soLuong=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap don gia: ");
            donGia=double.Parse(Console.ReadLine());
        }
        public virtual double tinhTong()
        {
            double tong = soLuong * donGia;
            if (tong >= 1000)
                return tong * 0.8;
            else
                return tong;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma khach hang: "+ maKH);
            Console.WriteLine("Gioi tinh: "+ gioiTinh);
            Console.WriteLine("So luong mua: "+ soLuong);
            Console.WriteLine("Don gia: "+ donGia);
            Console.WriteLine("Tong tien: "+tinhTong());
        }
    }
}
