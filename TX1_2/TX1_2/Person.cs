using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_2
{
    internal abstract class Person
    {
        private string hoTen { get; set;}
        private string diaChi { get; set;}

        public string HoTen { 
            get { return hoTen; } 
            set { hoTen = value; }
        }
        public string DiaChi { 
            get { return diaChi; }
            set { diaChi = value; }
        }
        public abstract void nhap(string hoTen, string diaChi);
        public abstract double tinhLuong();

    }
}
