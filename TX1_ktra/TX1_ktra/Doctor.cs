using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_ktra
{
    internal class Doctor
    {
        private string iD;
        private string fullName;
        private string gender;
        private string specialty;
        private int experience;
        private string mobile;

        public Doctor()
        {
        }

        public string ID { get => iD; set => iD = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Specialty { get => specialty; set => specialty = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Mobile { get => mobile; set => mobile = value; }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ID: "); ID = Console.ReadLine();
            Console.WriteLine("Nhap full name: "); FullName = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: "); Gender = Console.ReadLine();
            Console.WriteLine("Nhap chuyen khoa: "); Specialty = Console.ReadLine();
            Console.WriteLine("Nhap so nam kinh nghiem: "); Experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dien thoai: "); Mobile = Console.ReadLine();
        }
        public virtual void Output()
        {
            //Console.WriteLine("ID\tFull Name\tGioi tinh\tChuyen khoa\tSo nam kinh nghiem\tSo dien thoai");
            Console.Write(ID + "\t" + FullName + "\t" + Gender + "\t" + Specialty + "\t" +experience + "\t" +Mobile+ "\t");
        }
    }
}
