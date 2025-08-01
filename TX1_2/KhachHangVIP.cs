using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1_2
{
    internal class KhachHangVIP : KhachHang
    {
        private DateTime ngayLamThe;

        public KhachHangVIP()
        {
        }
        public KhachHangVIP(DateTime ngayLamThe)
        {
            this.NgayLamThe = ngayLamThe;
        }
        public DateTime NgayLamThe { get => ngayLamThe; set => ngayLamThe = value; }

        public override double tinhtong()
        {
            double tong = base.tinhtong();
            if (tong <= 1000)
                tong = tong * 0.9;
            else
                tong = tong * 0.8;
            return tong;
        }
        public override void nhapTT()
        {
            base.nhapTT();
            Console.Write("Nhập ngày làm thẻ: ");
            NgayLamThe = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
        }

        public override void xuatTT()
        {
            base.xuatTT();
            Console.WriteLine("Ngày làm thẻ: " + ngayLamThe);
        }
    }
}
