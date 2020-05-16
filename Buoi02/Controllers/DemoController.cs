using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Buoi02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi02.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LayMot()
        {
            // đọc csdl / file
            var hh = new HangHoa
            {
                MaHang = 1,
                TenHangHoa = "Suzuki",
                DonGia = 584939,
            };

            // đổ sang View để hiển thị
            return View(hh);
        }

        public IActionResult DanhSach()
        {
            List<HangHoa> danhsach = new List<HangHoa>();
            HangHoa tmp;
            var rd = new Random();
            // sinh số phần tử ngẫu nhiên từ 3 -> 10
            var soPhanTu = rd.Next(5, 10);

            for (int i = 0; i < soPhanTu; i++)
            {
                tmp = new HangHoa
                {
                    MaHang = i + 100,
                    TenHangHoa = $"Suzuki {rd.Next()}",
                    DonGia = rd.NextDouble() * 100000,
                    GiamGia = rd.NextDouble()
                };
                danhsach.Add(tmp);

            }
            return View(danhsach);
        }
        public IActionResult DemoHinhHoc()
        {
            return View();
        }


    }
}