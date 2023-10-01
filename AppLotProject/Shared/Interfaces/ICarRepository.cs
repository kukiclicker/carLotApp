using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface ICarRepository
    {
        List<Car>GetAllCars();
        int InsertCar(Car car);
        int UpdateCar(Car car);
        int DeleteCar(int carID);
        int SellCar(int carID);
        int LoanCar(int carID);

    }
}
