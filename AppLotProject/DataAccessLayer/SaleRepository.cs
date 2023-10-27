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
    public class SaleRepository : ISaleRepository
    {
        public int DeleteSale(int saleID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM SALES WHERE SaleID = @SaleID";
                    sqlCommand.Parameters.AddWithValue("@SaleID", saleID);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public List<Sale> GetAllSales()
        {
            List<Sale> sales = new List<Sale>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM SALES";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Sale sale = new Sale
                    {
                        SaleID = sqlDataReader.GetInt32(0),
                        SaleDate = sqlDataReader.GetDateTime(1),
                        Car = sqlDataReader.GetInt32(2),
                        Employee = sqlDataReader.GetInt32(3),
                        Customer = sqlDataReader.GetString(4)

                    };
                    sales.Add(sale);
                }
                return sales;
            }
        }

        public int InsertSale(Sale sale)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO Sales VALUES (@SaleDate,@Car,@Employee,@Customer)";
                    sqlCommand.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                    sqlCommand.Parameters.AddWithValue("@Car", sale.Car);
                    sqlCommand.Parameters.AddWithValue("@Employee", sale.Employee);
                    sqlCommand.Parameters.AddWithValue("@Customer", sale.Customer);
                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public int UpdateSale(Sale sale)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                string command = "UPDATE Sales SET SaleDate = @SaleDate, EmployeeID = @Employee, CarID = @Car, Customer = @Customer WHERE SaleID= "+sale.SaleID;

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                sqlCommand.Parameters.AddWithValue("@Employee", sale.Employee);
                sqlCommand.Parameters.AddWithValue("@Car", sale.Car);
                sqlCommand.Parameters.AddWithValue("@Customer", sale.Customer);
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
