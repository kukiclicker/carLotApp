using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IEmployeeBusiness
    {
        List<Employee> GetAllEmployees();
        int InsertEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int emplyeeid);
        Employee GetEmployee(int employeeID);
    }
}
