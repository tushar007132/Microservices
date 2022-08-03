using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVCEF.Models;

namespace MVCEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository emprepo;

        public HomeController(ILogger<HomeController> logger, IEmployeeRepository erep)
        {
            _logger = logger;
            emprepo = erep;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AllEmployee()
        {
            var model = emprepo.GetAllEmployees();
            return View(model);
        }

        public IActionResult AddEmp(Employee emp)
        {
            var model = emprepo.AddEmployee(emp);
            return View(model);
        }

        public IActionResult EditEmp(Employee emp)
        {
            var model = emprepo.UpdateEmployee(emp);
            return View(model);
        }
    }
}