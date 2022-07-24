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
            List<EmployeeModel> model = _employeeRepository.GetAll();

            return View(model);
        }

        public IActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewEmployee(EmployeeModel employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeRepository.Add(employee);
                    TempData["Success"] = $"Employee {employee.FirstName} {employee.LastName} successfully added.";
                    return RedirectToAction("Index");
                }

                return View(employee);
            }
            catch(System.Exception e)
            {
                TempData["Error"] = $"Ops, something went wrong: {e.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult EditEmployeeView(int id)
        {
            EmployeeModel employee = _employeeRepository.GetEmployee(id);

            return View(employee);
        }

        public IActionResult EditEmployee(EmployeeModel employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeRepository.Update(employee);
                    TempData["Success"] = $"Employee {employee.FirstName} {employee.LastName} successfully edited.";
                    return RedirectToAction("Index");
                }

                return View("EditEmployeeView", employee);
            }
            catch(System.Exception e)
            {
                TempData["Error"] = $"Ops, something went wrong: {e.Message}";
                return View("EditEmployeeView", employee);
            }
        }

        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                EmployeeModel deletedEmployee = _employeeRepository.DeleteEmployee(id);
                TempData["Success"] = $"Employee {deletedEmployee.FirstName} {deletedEmployee.LastName} successfully deleted.";
                return RedirectToAction("Index");
            }
            catch(System.Exception e)
            {
                TempData["Error"] = $"Ops, something went wrong: {e.Message}";
                return RedirectToAction("Index");
            }
        }

        
    }
}
