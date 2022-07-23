using CRUD_MVC.Models;
using CRUD_MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            List<EmployeeModel> model = _employeeRepository.SearchEvery();

            return View(model);
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

        [HttpPost]
        public IActionResult AddNewEmployee(EmployeeModel employee)
        {
            _employeeRepository.Add(employee);

            return RedirectToAction("Index");
        }
    }
}
