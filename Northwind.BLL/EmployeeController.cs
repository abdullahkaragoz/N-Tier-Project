using Northwind.DAL;
using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.BLL
{
    public class EmployeeController
    {
        EmployeeManagement employeeManagement = new EmployeeManagement();

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = employeeManagement.GetEmployeesList();
            return employees;
        }

        public bool AddEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName)&employee.FirstName.Length>15)
            {
                return false;
            }
            bool isAdded = employeeManagement.AddEmployee(employee);
            return isAdded;

        }

        public bool DeleteEmployee(Employee employee)
        {
            bool isDeleted = employeeManagement.DeleteEmployee(employee);
            return isDeleted;
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool isUpdated = employeeManagement.UpdateEmployee(employee);
            return isUpdated;
        }
    }
}
