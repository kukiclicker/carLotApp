
using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class EmployeeBusiness:IEmployeeBusiness
    {
        public static IEmployeeRepository employeeRepository;
        
        public EmployeeBusiness(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }
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
        public Employee GetEmployee(int employeeID) {
            return employeeRepository.GetEmployee(employeeID);
        }
    }
}
