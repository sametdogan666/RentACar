using Business.Concrete;
using System;
using System.Data.SqlTypes;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using DataAccess.Concrete.EntittyFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentalAdded();

            //CustomerAdded();

            //UserTest();

            //UserAdded();

            //CarTest();

            //BrandTest();

            //ColorTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void UserAdded()
        {
            UserManager user = new UserManager(new EfUserDal());
            var result = user.Add(new User
            {
                FirstName = "Samet",
                LastName = "DOGAN",
                Email = "sametdogan@gmail.com",
                Password = "123456789"
            });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager user = new UserManager(new EfUserDal());
            var result = user.GetAll();

            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Email);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAdded()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(
                new Customer
                {

                    UserId = 3,
                    CompanyName = "AnyCompany"

                });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAdded()
        {
            DateTime RentDate = new DateTime(2022, 7, 23);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(
                new Rental
                {

                    CarId = 3,
                    CustomerId = 2,
                    RentDate = RentDate

                });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
