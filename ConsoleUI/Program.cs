using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            //CustomerTest();
            //UserTest();
            //RentalTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }                            
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId = 1, CompanyName = "Microsoft"});
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.UserId + " " + customer.CompanyName);
            }
        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.Id + " " + user.FirstName + " " + user.LastName + " " + user.Email);
            }
        }
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { Id = 1, CustomerId = 1, CarId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Today });
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.Id + " " + rental.CustomerId + " " + rental.CarId + " " + rental.RentDate + " " + rental.ReturnDate);
            }
        }
    }
}
