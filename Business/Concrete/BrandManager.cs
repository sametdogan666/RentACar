using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
               _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("The brand name must consist of at least 2 characters.");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
            }
            else
            {
                Console.WriteLine("The brand name must consist of at least 2 characters.");
            }
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.ID == id);
        }
    }
}
