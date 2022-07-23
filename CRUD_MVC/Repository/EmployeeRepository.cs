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

        List<EmployeeModel> IEmployeeRepository.SearchEvery()
        {
            return _contextDataBase.Employee.ToList();
        }
    }
}
