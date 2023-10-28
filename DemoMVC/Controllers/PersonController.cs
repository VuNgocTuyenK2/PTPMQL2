using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
public class PersonController  :   Controller
//Vu Ngoc Tuyen 2021050715
{
    public IActionResult Index()
    {
        return View();
    }
//Vu Ngoc Tuyen 2021050715
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Hello " + ps.PersonID + "-" + ps.FullName;
        ViewBag.thongBao = strResult;
        return View();
    }
}
// Vu Ngoc Tuyen 2021050715