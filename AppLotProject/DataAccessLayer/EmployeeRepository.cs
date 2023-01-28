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
    public class EmployeeRepository:IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM EMPLOYEES";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Employee employee = new Employee
                    {
                        EmployeeID = sqlDataReader.GetInt32(0),
                        Name = sqlDataReader.GetString(1),
                        LastName = sqlDataReader.GetString(2),
                        Password = sqlDataReader.GetString(3),
                        Address = sqlDataReader.GetString(4),
                        PhoneNumber = sqlDataReader.GetString(5),
                        Email = sqlDataReader.GetString(6),
                        UserName = sqlDataReader.GetString(7),
                        Role = sqlDataReader.GetString(8),
                    };
                    employees.Add(employee);
                }
                return employees;
            }

        }
        public int DeleteEmplyee(int emplyeeid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                    sqlCommand.Parameters.AddWithValue("@EmployeeID", emplyeeid);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public int InsertEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO Employees VALUES (@Name,@LastName,@Email,@PhoneNumber,@Address,@Username,@Password,@Role)";
                    sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
                    sqlCommand.Parameters.AddWithValue("@LastName", employee.Name);
                    sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
                    sqlCommand.Parameters.AddWithValue("@Username", employee.UserName);
                    sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
                    sqlCommand.Parameters.AddWithValue("@Role", employee.Role);
                    return sqlCommand.ExecuteNonQuery();
                } 
            }
        }
        public int UpdateEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                string command = "UPDATE Employees SET Name=@Name, LastName =@LastName  Email=@Email, PhoneNumber=@PhoneNumber, Address=@Address, username=@Username, Password=@Password, Role=@Role WHERE EmployeeID=@EmployeeID";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
                sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
                sqlCommand.Parameters.AddWithValue("@Username", employee.UserName);
                sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
                sqlCommand.Parameters.AddWithValue("@Role", employee.Role);
                sqlCommand.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
