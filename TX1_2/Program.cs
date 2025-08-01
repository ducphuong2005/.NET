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
            Console.OutputEncoding = Encoding.UTF8;
            List<KhachHang> ds = new List<KhachHang>();
            while (true)
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1. Nhập thông tin");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Xóa khách hàng");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn: ");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine("1. Khách hàng");
                        Console.WriteLine("2. Khách hàng VIP");
                        Console.Write("Chọn: ");
                        int n = int.Parse(Console.ReadLine());

                        if (n == 1)
                        {
                            KhachHang kh = new KhachHang();
                            kh.nhapTT();
                            for (int i = 0; i < ds.Count; i++)
                            {
                                if (ds[i].MaKH == kh.MaKH)
                                {
                                    Console.WriteLine("Mã khách hàng dã tồn tại.");
                                    return;
                                }
                            }
                            ds.Add(kh);
                        }

                        if (n == 2)
                        {
                            KhachHangVIP khv = new KhachHangVIP();
                            khv.nhapTT();
                            for (int i = 0; i < ds.Count; i++)
                            {
                                if (ds[i].MaKH == khv.MaKH)
                                {
                                    Console.WriteLine("Mã khách hàng đã tồn tại.");
                                    return;
                                }
                            }
                            ds.Add(khv);
                        }
                        break;
                    case 2:
                        Console.WriteLine("---------------------------------");
                        foreach(var i in ds)
                        {
                            i.xuatTT();
                        }
                        break;
                    case 3:
                        Console.Write("Nhập mã khách hàng cần xóa: ");
                        string mkh = Console.ReadLine();
                        int d = 0;
                        for(int i = 0; i<ds.Count; i++)
                        {
                            if (mkh == ds[i].MaKH)
                            {
                                ds.Remove(ds[i]);
                                d++;
                                break;
                            }

                           
                        }
                        if(d==0) Console.WriteLine("Không thấy");
                        else Console.WriteLine("Xoa tc");
                        break;

                    case 4:
                        return;
                    //case 5:
                    //    Console.Write("Nhập mã khách hàng cần cập nhật: ");
                    //    string ma = Console.ReadLine();

                    //    KhachHang kh1 = ds.Find(o => o.MaKH == ma);
                    //    if (kh1 == null)
                    //    {
                    //        Console.WriteLine("Không tìm thấy khách hàng.");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Cập nhật thông tin khách hàng:");

                    //        Console.Write("Nhập giới tính mới: ");
                    //        kh1.GioiTinh = Console.ReadLine();

                    //        Console.Write("Nhập số lượng mới: ");
                    //        kh1.SoLuong = int.Parse(Console.ReadLine());

                    //        Console.Write("Nhập đơn giá mới: ");
                    //        kh1.DonGia = double.Parse(Console.ReadLine());

                    //        Console.WriteLine("Đã cập nhật thành công.");
                    //    }
                    //    break;
                }
            }
        }
    }
}
