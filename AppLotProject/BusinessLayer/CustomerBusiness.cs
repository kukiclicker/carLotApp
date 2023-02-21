using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBusiness
    {
        public static CustomerRepository customerRepository = new CustomerRepository();
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
