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
        public List<Car> GetAvailableCars()
        {
            return carRepository.GetAllCars().Where(x=>x.Status.Contains("available")).ToList();
        }
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
        public List<Car>FindCars(string query)
        {
            query.Trim();
            return query != "" || query != null ? GetAllCars().FindAll(x => 
                                           x.Model.ToLower().Contains(query)  || 
                                           x.Year.ToString().Contains(query)  || 
                                           x.Type.ToLower().Contains(query)   || 
                                           x.Price.ToString().Contains(query) ||
                                           x.Fuel.ToString().Contains(query)  ||
                                           x.Color.ToString().Contains(query) ||
                                           x.Condition.ToString().Contains(query)
                                           )
                                           .ToList() : GetAllCars();
        }
    }
}
