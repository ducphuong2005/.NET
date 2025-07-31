using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TX1_ktra
{
    internal class Surgeon : Doctor
    {
        private string surgeryType;
        private int numberOfSurgeries;

        public Surgeon()
        {
        }

        public string SurgeryType { get => surgeryType; set => surgeryType = value; }
        public int NumberOfSurgeries { get => numberOfSurgeries; set => numberOfSurgeries = value; }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap loai hinh phau thuat");
            SurgeryType = Console.ReadLine();
            Console.WriteLine("Nhap so luong ca phau thuat: ");
            NumberOfSurgeries=int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine(SurgeryType + "\t" + NumberOfSurgeries + "\t");
        }
    }
}
