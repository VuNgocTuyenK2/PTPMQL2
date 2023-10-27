using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class PhuongTrinhBacNhatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Vu Ngoc Tuyen 2021050715
        //Giai phuong trinh bac nhat
        [HttpPost]
        public IActionResult Index(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    ViewBag.ThongBao = "Phuong trinh co vo so nghiem";
                }
                else
                {
                    ViewBag.ThongBao = "Phuong trinh vo nghiem";
                }
                //Vu Ngoc Tuyen 2021050715
            }
            else
            {
                double nghiem = -b / a;
                ViewBag.ThongBao = $"Nghiem cua phuong trinh la x = {nghiem}";
            }

            //Vu Ngoc Tuyen 2021050715
            return View();
        }
    }
}