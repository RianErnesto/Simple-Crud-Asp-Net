using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewEmployee()
        {
            return View();
        }

        public IActionResult EditEmployee()
        {
            return View();
        }

        public IActionResult DeleteEmployee()
        {
            return View("Index");
        }
    }
}
