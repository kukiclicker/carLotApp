using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface ICustomerBusiness
    {
        List<Customer> GetAllCustomers();
        int InsertCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        int DeleteCustomer(int JMBG);
    }
}
