using DemoMVC.Controllers;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
//Vu Ngoc Tuyen 2021050715
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]//Vu Ngoc Tuyen 2021050715
    public IActionResult Index(Person ps)
    {
        string strResult = ps.PersonID + "-" + ps.FullName;
        ViewBag.thongBao = strResult;    
        return View();
    }
}
//Vu Ngoc Tuyen 2021050715