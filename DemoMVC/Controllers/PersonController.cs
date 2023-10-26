using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
public class PersonController  :   Controller

{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Hello " + ps.PersonID + "-" + ps.FullName;
        ViewBag.thongBao = strResult;
        return View();
    }
}