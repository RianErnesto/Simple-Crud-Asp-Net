using CRUD_MVC.Data;
using CRUD_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ContextDataBase _contextDataBase;

        public EmployeeRepository(ContextDataBase contextDataBase)
        {
            _contextDataBase = contextDataBase;
        }

        public EmployeeModel Add(EmployeeModel employee)
        {
            _contextDataBase.Employee.Add(employee);
            _contextDataBase.SaveChanges();

            return employee;
        }
        public EmployeeModel Update(EmployeeModel employee)
        {
            EmployeeModel employeeModel = GetEmployee(employee.EmployeeID);

            if(employeeModel == null)
            {
                throw new Exception("There were an error with the update.");
            }

            employeeModel.Address = employee.Address;
            employeeModel.BirthDate = employee.BirthDate;
            employeeModel.City = employee.City;
            employeeModel.Country = employee.Country;
            employeeModel.Extension = employee.Extension;
            employeeModel.FirstName = employee.FirstName;
            employeeModel.HireDate = employee.HireDate;
            employeeModel.HomePhone = employee.HomePhone;
            employeeModel.LastName = employee.LastName;
            employeeModel.Notes = employee.Notes;
            employeeModel.PostalCode = employee.PostalCode;
            employeeModel.Region = employee.Region;
            employeeModel.Title = employee.Title;
            employeeModel.TitleOfCourtesy = employee.TitleOfCourtesy;

            _contextDataBase.Employee.Update(employeeModel);
            _contextDataBase.SaveChanges();


            return employeeModel;
        }

        public EmployeeModel DeleteEmployee(int employeeId)
        {
            EmployeeModel employee = GetEmployee(employeeId);
            _contextDataBase.Employee.Remove(employee);
            _contextDataBase.SaveChanges();

            return employee;
        }

        public EmployeeModel GetEmployee(int employeeId)
        {
            return _contextDataBase.Employee.FirstOrDefault(t => t.EmployeeID == employeeId);
        }

        List<EmployeeModel> IEmployeeRepository.GetAll()
        {
            return _contextDataBase.Employee.ToList();
        }
    }
}
