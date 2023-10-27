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
    public class CarBusiness:ICarBusiness
    {
        public static ICarRepository _carRepository;
        public CarBusiness(ICarRepository carRepository)
        {
           _carRepository = carRepository; 
        }

        public List<Car> GetAvailableCars()
        {
            return _carRepository.GetAllCars().Where(x => x.CarStatus.ToUpper().Contains("AVAILABLE")).ToList();
        }
        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }
        public Car GetCar(int carID)
        {
            return _carRepository.GetAllCars().Where(x => x.CarID == carID).FirstOrDefault();
        }
        public int InsertCar(Car car)
        {
            return _carRepository.InsertCar(car);
        }
        public int DeleteCar(int carID)
        {
            return _carRepository.DeleteCar(carID);
        }
        public int SellCar(int carID)
        {
            return _carRepository.SellCar(carID);
        }
        public int LoanCar(int carID)
        {
            return _carRepository.LoanCar(carID);
        }
        public List<Car>FindCars(string query)
        {
            query.Replace(" ", "");
            query.Trim();
            return query != "" || query != null ? GetAvailableCars().FindAll(x => 
                                           x.Model.ToLower().Contains(query)  || 
                                           x.Year.ToString().Contains(query)  || 
                                           x.Type.ToLower().Contains(query)   || 
                                           x.Price.ToString().Contains(query) ||
                                           x.Fuel.ToString().Contains(query)  ||
                                           x.Color.ToString().Contains(query) ||
                                           x.CarCondition.ToString().Contains(query)
                                          )
                                           .ToList() : GetAllCars();
        }

        public int UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }
        public bool IsCarAvailable(int carID)
        {
            Car car = GetCar(carID);
            string status = car.CarStatus.ToUpper();
            return status.Equals("AVAILABLE");
        }
    }
}
