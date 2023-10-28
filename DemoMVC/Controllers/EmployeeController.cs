using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
//vungoctuyen2021050715
{

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //vungoctuyen2021050715
        }
        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            //vungoctuyen2021050715

            int TinhLuong = emp.LuongCB * emp.HeSoLuong + emp.PhuCap;
            string str1 = "FullName: " + " " + emp.FullName + " " + "Luong: " + TinhLuong + "VND";
            //vungoctuyen2021050715
            ViewBag.KetQuaTinhLuong = str1;
            return View();
            //vungoctuyen2021050715
        }
    }
}
