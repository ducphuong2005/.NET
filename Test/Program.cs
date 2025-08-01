using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<GranduateStudent> ds= new List<GranduateStudent>();
            while (true)
            {
                Console.WriteLine("Nhap lua chon: ");
                Console.WriteLine("1. Thêm một sinh viên cao học mới\r\n2. Hiển thị danh sách các sinh viên cao học\r\n3. Tìm kiếm sinh viên cao học\r\n4. Xóa một sinh viên cao học\r\n5. Sửa thông tin sinh viên cao học\r\n6. Sắp xếp danh sách sinh viên cao học\r\n7. Kết thúc chương trình");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GranduateStudent student = new GranduateStudent();
                        student.InputStudent();
                        for(int i = 0; i < ds.Count; i++)
                        {
                            if (ds[i].iD==student.iD)
                            {
                                Console.WriteLine("Ma sinh vien da ton tai");
                                Console.ReadKey();
                                return;
                            }
                        }
                        ds.Add(student);
                        break;
                    case 2:
                        Console.WriteLine("------------DANH SACH SINH VIEN---------------");
                        foreach (var i in ds)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhap id sinh vien de tim: ");
                        int ma=int.Parse(Console.ReadLine());
                        for(int i=0; i<ds.Count; i++)
                        {
                            if (ds[i].iD==ma)
                            {
                                Console.WriteLine(ds[i].ToString());
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap id sinh vien de xoa: ");
                        int masv=int.Parse(Console.ReadLine());
                        int d = 0;
                        for(int i=0; i<ds.Count; i++)
                        {
                            if (ds[i].iD==masv)
                            {
                                ds.Remove(ds[i]);
                                d++;
                            }
                        }
                        if (d == 0) Console.WriteLine("Khong tim thay");
                        break;

                     case 5:
                        Console.WriteLine("Nhap id sinh vien de sua: ");
                        int maSV=int.Parse(Console.ReadLine());
                        for(int i=0; i<ds.Count; i++)
                        {
                            if (ds[i].iD==maSV)
                            {
                                ds[i].InputStudent();
                                Console.WriteLine("Sua thanh cong");
                            }
                            else Console.WriteLine("Khong tim thay de sua");
                        }
                        break;
                       case 6:
                        ds = ds.OrderBy(x => x.major).ThenByDescending(x => x.mark).ToList();
                        Console.WriteLine("Sap xep thanh cong");
                        break;
                      case 7:
                             return;
                }
            }
        }
    }
}
