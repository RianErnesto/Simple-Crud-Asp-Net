using CRUD_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Repository
{
    public interface IEmployeeRepository
    {
        EmployeeModel Add(EmployeeModel employee);
        EmployeeModel Update(EmployeeModel employee);
        List<EmployeeModel> GetAll();
        EmployeeModel GetEmployee(int employeeId);
        EmployeeModel DeleteEmployee(int employeeId);
    }
}
