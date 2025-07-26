using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<KhachHang> ds = new List<KhachHang>();
            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Xoa khach hang");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon: ");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine("Nhap loai khach hang: 1. Thuong/2.VIP ");
                        int loai=int.Parse(Console.ReadLine());
                        if(loai == 1)
                        {
                            KhachHang kh=new KhachHang();
                            kh.nhapTT();
                            ds.Add(kh);
                        }
                        else
                        {
                            KhachHangVIP khv = new KhachHangVIP();
                            khv.nhapTT();
                            ds.Add(khv);
                        }
                            break;
                    case 2:
                            foreach(KhachHang kh in ds)
                            { kh.xuat(); }
                        break;
                    case 3:
                        Console.WriteLine("Nhap ma khach hang muon xoa: ");
                        string ma= Console.ReadLine();
                        KhachHang khXoa = ds.Find(kh => kh.MaKH == ma);
                        if(khXoa != null)
                        {
                            ds.Remove(khXoa);
                            Console.WriteLine("Xoa thanh cong");
                        }
                        else
                            Console.WriteLine("Khong tim thay khach hang nao co ma khach hang nhu tren");
                            break;
                    case 4:
                        return;
                }
            }
        }
    }
}
