using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BUOI01.Controllers
{
    public class DemoController : Controller
    {
        public string Chuoi()
        {
            return "Xin Chao";
        }

        public int So()
        {
            return new Random().Next(10,100);
        }

        public IActionResult Demo()
        {

            return View();
        }

        public IActionResult TuDien()
        {
            return View();
        }

        //host:port/demo/hcn?dai=11&&rong=9
        public IActionResult HCN(double dai, double rong)
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}