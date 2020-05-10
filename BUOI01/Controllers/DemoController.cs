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
        public IActionResult Index()
        {
            return View();
        }
    }
}