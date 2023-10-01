using DataAccessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBusiness:ICustomerBusiness
    {
        public static ICustomerRepository customerRepository;
        public CustomerBusiness(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }
        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }
        public int DeleteCustomer(int customerID)
        {
            return customerRepository.DeleteCustomer(customerID);
        }
        public int InsertCustomer(Customer customer)
        {
            return customerRepository.InsertCustomer(customer);
        }
        public int UpdateCustomer(Customer customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }
    }
}
