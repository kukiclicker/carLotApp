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
    public class CarRepository : ICarRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM CARS";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Car car = new Car
                    {
                        CarID = sqlDataReader.GetInt32(0),
                        Model = sqlDataReader.GetString(1),
                        Type = sqlDataReader.GetString(2),
                        Year = sqlDataReader.GetInt32(3),
                        CarBody = sqlDataReader.GetString(4),
                        Fuel = sqlDataReader.GetString(5),
                        Mileage = sqlDataReader.GetString(6),
                        Engine = sqlDataReader.GetString(7),
                        Transmission = sqlDataReader.GetString(8),
                        Color = sqlDataReader.GetString(9),
                        Description = sqlDataReader.GetString(10),
                        Price = sqlDataReader.GetFloat(11),
                        Condition = sqlDataReader.GetFloat(11),
                    };
                    employees.Add(employee);
                }
                return employees;
            }
        }
        public int DeleteCar(int carID)
        {
            throw new NotImplementedException();
        }
        public int InsertCar(Car car)
        {
            throw new NotImplementedException();
        }
        public int UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
