using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

public class StudentController  :   Controller

{
    public IActionResult Index()
    {
        return View();
    }
//Vu Ngoc Tuyen 2021050715
    [HttpPost]
    public IActionResult Index(string StudentID, string FullName)
    {
        string strResult = "Hello " + StudentID + "-" + FullName;
        ViewBag.thongBao = strResult;
        return View();
    }
}
