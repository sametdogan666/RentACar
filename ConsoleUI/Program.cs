using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager = new CarManager(new InMemoryCarDal());

           
           Car car1 = new Car{Id = 5, BrandId = 3, ColorId = 3, Description = "Ciya Baba", ModelYear = 2005, DailyPrice = 10000};
           carManager.Add(car1);
           foreach (var car in carManager.GetAll())
           {
               Console.WriteLine(car.Description);
           }
        }
    }
}
