using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            string strResult = "Hello " + emp.EmployeeID + " - " + emp.FullName;
            ViewBag.noti = strResult;
            return View();
        }
    }
