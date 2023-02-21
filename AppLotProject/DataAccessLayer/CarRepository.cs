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
                        Price = sqlDataReader.GetDouble(11),
                        Condition = sqlDataReader.GetString(12),
                        Status = sqlDataReader.GetString(13)
                    };
                    cars.Add(car);
                }
                return cars;
            }
        }
        public int DeleteCar(int carID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM CARS WHERE CarID = @CarID";
                    sqlCommand.Parameters.AddWithValue("@CarID", carID);

                    return sqlCommand.ExecuteNonQuery();
                }

            }
        }
        public int InsertCar(Car car)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO CARS VALUES (@Model,@Type,@Year,@CarBody,@Fuel,@Mileage,@Engine,@Transmission,@Color,@Description,@Price,@Condition,@status)";
                    sqlCommand.Parameters.AddWithValue("@Model", car.Model);
                    sqlCommand.Parameters.AddWithValue("@Type", car.Type);
                    sqlCommand.Parameters.AddWithValue("@Year", car.Year);
                    sqlCommand.Parameters.AddWithValue("@CarBody", car.CarBody);
                    sqlCommand.Parameters.AddWithValue("@Fuel", car.Fuel);
                    sqlCommand.Parameters.AddWithValue("@Mileage", car.Mileage);
                    sqlCommand.Parameters.AddWithValue("@Engine", car.Engine);
                    sqlCommand.Parameters.AddWithValue("@Transmission", car.Transmission);
                    sqlCommand.Parameters.AddWithValue("@Color", car.Color);
                    sqlCommand.Parameters.AddWithValue("@Description", car.Description);
                    sqlCommand.Parameters.AddWithValue("@Price", car.Price);
                    sqlCommand.Parameters.AddWithValue("@Condition", car.Condition);
                    sqlCommand.Parameters.AddWithValue("@status", car.Status);
                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public int UpdateCar(Car car)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                string command = "UPDATE CARS SET CarID=@CarID, Model =@Model , " +
                    "Type=@Type, Year=@Year, CarBody=@CarBody, Fuel=@Fuel, Mileage=@Mileage, " +
                    "Engine=@Engine,Transmission=@Transmission,Color=@Color,Description=@Description" +
                    ",Price=@Price, Condition=@Condition  WHERE CarID=@CarID";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CarID", car.CarID);
                sqlCommand.Parameters.AddWithValue("@Model", car.Model);
                sqlCommand.Parameters.AddWithValue("@Type", car.Type);
                sqlCommand.Parameters.AddWithValue("@Year", car.Year);
                sqlCommand.Parameters.AddWithValue("@CarBody", car.CarBody);
                sqlCommand.Parameters.AddWithValue("@Fuel", car.Fuel);
                sqlCommand.Parameters.AddWithValue("@Mileage", car.Mileage);
                sqlCommand.Parameters.AddWithValue("@Engine", car.Engine);
                sqlCommand.Parameters.AddWithValue("@Transmission", car.Transmission);
                sqlCommand.Parameters.AddWithValue("@Color", car.Color);
                sqlCommand.Parameters.AddWithValue("@Description", car.Description);
                sqlCommand.Parameters.AddWithValue("@Price", car.Price);
                sqlCommand.Parameters.AddWithValue("@Condition", car.Condition);

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int SellCar(int carID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "UPDATE CARS SET status = 'SOLD' WHERE CarID = "+carID;
                    return sqlCommand.ExecuteNonQuery();
                }
               
            }
        }
        public int LoanCar(int carID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "UPDATE CARS SET status = 'LOANED' WHERE CarID = " + carID;
                    return sqlCommand.ExecuteNonQuery();
                }

            }
        }
    }
}
