using FirstMVCproject1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCproject1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "This is sample message from controller";
            List<string> colors = new List<string>()
            {
                "Red","Green","Blue","Yellow","Black","White","Pink"
            };
            ViewData["colors"] = colors;

            List<Employee> Employees = new List<Employee>()
                {
                new Employee{Id=1,Name="emp1",Salary=25000},
                new Employee{Id=2,Name="emp2",Salary=26000},
                new Employee{Id=3,Name="emp3",Salary=27000},
                new Employee{Id=4,Name="emp4",Salary=28000}
            };
            ViewData["Emplist"] = Employees;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }


        public IActionResult ContactUs()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}