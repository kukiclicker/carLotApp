using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusiness
    {
        public static EmployeeRepository employeeRepository = new EmployeeRepository();
        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }
        public int DeleteEmployee(int employeeID)
        {
            return employeeRepository.DeleteEmplyee(employeeID);
        }
        public int InsertEmployee(Employee employee)
        {
            return employeeRepository.InsertEmployee(employee);
        }
        public int UpdateEmployee(Employee employee) { 
            return employeeRepository.UpdateEmployee(employee); 
        }
        
    }
}
