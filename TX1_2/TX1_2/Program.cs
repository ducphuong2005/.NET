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
                Console.WriteLine("Nhap lua chon: \n1. Them\n2. Hien thi\n3. Sap xep\n4. Thoat\n5. Xoa nhan vien");
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
                        //var sapXep = ds.OrderBy(nvien => nvien.HoTen).ThenBy(nvien => nvien.HeSoLuong).ToList()
                        //ds=sapXep;
                        //OrderBy: tang dan     OrderByDescending: giam dan
                        //ds= ds.OrderByDescending(nvien => nvien.tinhLuong()).ToList();
                        ds.Sort((a,b) => a.tinhLuong().CompareTo(b.tinhLuong()));  //sap xep tang dan
                        Console.WriteLine("Sap xep thanh cong");
                        break;
                     case 4:
                        return;
                    case 5:
                        Console.WriteLine("Nhap ma nhan vien de xoa");
                        string ma= Console.ReadLine();
                        /*NhanVien nhanVien = ds.Find(nV => nV.MaNV == ma);
                        if (nhanVien != null)
                        {
                            ds.Remove(nhanVien);
                            Console.WriteLine("Xoa thanh cong");
                        }
                        else
                        { Console.WriteLine("Khong tim thay nhan vien"); } */
                        int d = 0;
                        for(int i=0; i<ds.Count; i++)
                        {
                            if (ds[i].MaNV == ma)
                            {
                                ds.Remove(ds[i]);
                                d++;
                            }
                        }
                        if(d==0) Console.WriteLine("Khong tim thay nhan vien");
                            break;
                }
            }
        }
    }
}
