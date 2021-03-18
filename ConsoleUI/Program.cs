using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            carManager.Add(new Car
            {
               
                BrandId = 3,
                ColorId = 5,
                DailyPrice = 240000,
                ModelYear = "2004",
                Description = "Honda S200"


            });

            carManager.Update(new Car
            {
                Id=5,
                BrandId = 3,
                ColorId = 5,
                DailyPrice = 240000,
                ModelYear = "2018",
                Description = "Nissan GT-R35"


            });



            // carManager.Delete(new Car { Id=1002 });






            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç Adı :" + car.Description);
            }

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Marka :" + brand.BrandName);
            }

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Renk :"+ color.ColorName);
            }


            Console.WriteLine("-----------------");
            
        }

    
    }
}
