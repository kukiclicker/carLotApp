using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarBusiness
    {
        public static CarRepository carRepository = new CarRepository();

        public List<Car> GetAllCars()
        {
            return carRepository.GetAllCars();
        }
        public Car GetCar(int carID)
        {
            return (Car)carRepository.GetAllCars().Where(x => x.CarID == carID).Take(1);
        }
        public int InsertCar(Car car)
        {
            return carRepository.InsertCar(car);
        }
        public int DeleteCar(int carID)
        {
            return carRepository.DeleteCar(carID);
        }
    }
}
