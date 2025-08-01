using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GranduateStudent : Student
    {
        public string major {  get; set; }
        public string thesisTitle { get; set; }
        public string advisor {  get; set; }

        public GranduateStudent()
        {
        }
        public GranduateStudent(string major, string thesisTitle, string advisor)
        {
            this.major = major;
            this.thesisTitle = thesisTitle;
            this.advisor = advisor;
        }

        public override void InputStudent()
        {
            base.InputStudent();
            Console.WriteLine("Nhap major: "); major = Console.ReadLine();
            Console.WriteLine("Nhap thesistitle: "); thesisTitle = Console.ReadLine();
            Console.WriteLine("Nhap advisor: "); advisor = Console.ReadLine();
        }

        public override string ToString()
        {
           return base.ToString()+ $", Major: {major}, Thesistitle: {thesisTitle}, Advisor: {advisor}";
        }
    }
}
