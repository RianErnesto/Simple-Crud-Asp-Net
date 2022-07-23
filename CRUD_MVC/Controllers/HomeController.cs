using CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeModel employeeModel = new EmployeeModel();

            employeeModel.FirstName = "Rian";
            employeeModel.LastName = "Ernesto";
            employeeModel.BirthDate = DateTime.Today;
            employeeModel.HomePhone = "992146734";

            return View(employeeModel);
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
    }
}
