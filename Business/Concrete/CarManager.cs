using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Enter the daily price of the car at a greater value than zero.");
            }
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice <= min && c.DailyPrice >= max);
        }
    }
}
