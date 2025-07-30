using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> ds = new List<NhanVien>();
            while (true)
            {
                Console.WriteLine("Nhap lua chon: \n1. Them\n2. Hien thi\n3. Sap xep\n4. Thoat");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {

                    case 1:
                        Console.WriteLine("Nhap ho ten: ");
                        string hoTen= Console.ReadLine();
                        Console.WriteLine("Nhap dia chi: ");
                        string diaChi = Console.ReadLine();
                        NhanVien nv= new NhanVien();
                        nv.nhap(hoTen, diaChi);
                        ds.Add(nv);
                        Console.WriteLine("Them nhan vien thanh cong");
                        break;
                    case 2:
                        Console.WriteLine("Danh sach nhan vien: ");
                        foreach (var i in ds)
                        {
                            i.xuat();
                        }
                        break;
                     case 3:
                        var sapXep = ds.OrderBy(nvien => nvien.HoTen).ThenBy(nvien => nvien.HeSoLuong).ToList();
                        ds=sapXep;
                        Console.WriteLine("Sap xep thanh cong");
                        break;
                     case 4:
                        return;
                }
            }
        }
    }
}
