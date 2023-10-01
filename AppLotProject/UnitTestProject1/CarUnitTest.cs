using BusinessLayer;
using DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace CarUnitTest
{

    [TestClass]
    public class CarUnitTest
    {
      
        private readonly static Mock<ICarRepository> carRepositoryMock = new Mock<ICarRepository>();
        private readonly static CarBusiness carBusiness = new CarBusiness(carRepositoryMock.Object);
        private Car car = new Car
        {
            Model = "BMW",
            Type = "X3",
            CarBody = "SUV",
            Condition = "NEW",
            Price = 13000,
            Description = "",
            Engine = "1.9",
            Transmission = "Automatic",
            Color = "gray",
            Fuel = "Diesel",
            CarID = 1,
            Mileage = "10000",
            Status = "AVAILABLE",
            Year = 2016
        };
        private List<Car> carList = new List<Car>();
        public CarUnitTest()
        {
            carList.Add(car);
        }
        [TestMethod]
        public void GetAllCars_Successfull()
        {
            var result = carRepositoryMock.Setup(x => x.GetAllCars());
            Assert.AreNotEqual(result, null);
        }
        [TestMethod]
        public void IsCarInserted()
        {
            carRepositoryMock.Setup(x => x.InsertCar(car)).Returns(1);

            int result = carBusiness.InsertCar(car);

            Assert.IsTrue(result >= 0);
        }
        [TestMethod]
        public void IsCarDeleted()
        {
            carRepositoryMock.Setup(x => x.DeleteCar(car.CarID)).Returns(1);

            int result = carBusiness.DeleteCar(car.CarID);

            Assert.IsTrue(result >= 0);
        }
        [TestMethod]
        public void IsCarUpdated()
        {
            carRepositoryMock.Setup(x => x.UpdateCar(car)).Returns(1);

            int result = carBusiness.UpdateCar(car);

            Assert.IsTrue(result >= 0);
        }

    }
}
