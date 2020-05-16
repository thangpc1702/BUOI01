using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi02.Models
{
    public class HangHoa
    {
        public override string ToString()
        {
            return $"{MaHang} - {TenHangHoa}: {DonGia.ToString("#,###0")} đ";
        }
        public int MaHang { get; set; }
        public string TenHangHoa { get; set; }
        public double DonGia { get; set; }

        public double GiamGia { get; set; }
        public double GiaBan
        {
            get { return DonGia * (1 - GiamGia); }

        }
    }
}