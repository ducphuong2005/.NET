using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student
    {
        public int iD { get; set; }
        public string name { get; set; }
        public string mark { get; set; }

        public Student()
        {
        }
        public Student(int iD, string name, string mark)
        {
            this.iD = iD;
            this.name = name;
            this.mark = mark;
        }

        public virtual string ToString()
        {
            return $"ID: {iD}, Name: {name}, Mark: {mark}";
        }
        public virtual void InputStudent()
        {
            Console.WriteLine("Nhap ID: "); iD= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap name: "); name=Console.ReadLine();
            Console.WriteLine("Nhap mark: "); mark= Console.ReadLine();
        }
    }
}
