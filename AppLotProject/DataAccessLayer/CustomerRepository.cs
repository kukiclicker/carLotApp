using Shared;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        public int DeleteCustomer(int JMBG)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM CUSTOMERS WHERE JMBG = @JMBG";
                    sqlCommand.Parameters.AddWithValue("@JMBG", JMBG);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM CUSTOMERS";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Customer customer = new Customer
                    {
                        JMBG = sqlDataReader.GetString(0),
                        FirstName = sqlDataReader.GetString(1),
                        LastName = sqlDataReader.GetString(2),
                        PhoneNumber = sqlDataReader.GetString(3)
                    };
                    customers.Add(customer);
                }
                return customers;
            }
        }

        public int InsertCustomer(Customer customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO CUSTOMERS VALUES (@JMBG,@FirstName,@LastName,@PhoneNumber);";
                    sqlCommand.Parameters.AddWithValue("@JMBG", customer.JMBG);
                    sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    
                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public int UpdateCustomer(Customer customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                string command = "UPDATE CUSTOMERS SET FirstName=@FirstName, LastName =@LastName, PhoneNumber=@PhoneNumber WHERE JMBG ="+customer.JMBG;

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
