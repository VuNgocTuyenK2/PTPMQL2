using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
     public class DemoController : Controller
    {
        //khai bao cac phuong thuc
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fName, string Email)
        {
            string strResult = "Hello " + fName + "-" + Email;
            ViewBag.thongBao = strResult;
            return View();
            
        }

    }
}