using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_ktra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Surgeon> ds = new List<Surgeon>();
            while (true)
            {
                Console.WriteLine("Nhap lua chon: \n1. Them\n2. Hien thi\n3. Sap xep\n4. Thoat");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Surgeon sg=new Surgeon();
                        sg.Input();
                        if(ds.Any(x => x.ID == sg.ID))
                        {
                            Console.WriteLine("Ma bac si da ton tai");
                            return;
                        }
                        ds.Add(sg);
                        Console.WriteLine("Them thanh cong");
                        break;
                    case 2:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("DANH SACH BAC SI PHAU THUAT");
                        foreach (var i in ds)
                        {
                            i.Output();
                        }
                        break;
                    case 3:
                        //ds= ds.OrderBy(sx => sx.NumberOfSurgeries).ToList();
                        ds.Sort((a,b) => a.NumberOfSurgeries.CompareTo(b.NumberOfSurgeries)); //sap xep tang dan
                        Console.WriteLine("Sap xep thanh cong");
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
