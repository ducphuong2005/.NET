using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_2
{
    internal class NhanVien : Person
    {
        private string maNV { get; set; }
        public string MaNV
        {
            get { return maNV; }
            set{maNV=value;}
        }
        private string chucVu { get; set; }
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        private double heSoLuong { get; set; }

        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }
        public override void nhap(string hoTen, string diaChi)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            Console.WriteLine("Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu: ");
            chucVu = Console.ReadLine();
            Console.WriteLine("Nhap he so luong: ");
            heSoLuong = Double.Parse(Console.ReadLine());
        }
            /*
             * Chức vụ	                    Hệ số chức vụ
            Giám đốc	                    10
            Trưởng phòng hoặc phó giám đốc	6
            Phó phòng		                4
            Các chức vụ khác	            2
            */

        public int heSoChuCVu()
        {
            string cv=chucVu.ToLower();
            if (cv == "giam doc") return 10;
            else if (cv == "truong phong" || cv == "giam doc") return 6;
            else if (cv == "pho phong") return 4;
            else return 2;

        }
        //Tính lương  = (hệ số lương cơ bản + hệ số chức vụ) * 2.000.000 của nhân viên. 
        public override double tinhLuong()
        {
            return (HeSoLuong+heSoChuCVu())*2000000;
        }

        public void xuat()
        {
            Console.WriteLine("Ho ten: "+ HoTen);
            Console.WriteLine("Dia chi: "+ DiaChi);
            Console.WriteLine("Ma nhan vien: "+ MaNV);
            Console.WriteLine("Chuc vu: "+ ChucVu);
            Console.WriteLine("He so luong: "+ HeSoLuong);
            Console.WriteLine("Luong: "+ tinhLuong());
        }
    }
 }
