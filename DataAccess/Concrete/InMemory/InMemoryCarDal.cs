using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ID = 1, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 500, Description = "Manuel Vites"},
                new Car{ID = 2, BrandId = 1, ColorId = 1, ModelYear = 2012, DailyPrice = 300, Description = "Otomatik Vites"},
                new Car{ID = 3, BrandId = 2, ColorId = 1, ModelYear = 2017, DailyPrice = 600, Description = "Manuel Vites"},
                new Car{ID = 4, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 700, Description = "Otomatik Vites"}
            };
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.ID == id).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c =>c.ID == car.ID);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.ID == car.ID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
