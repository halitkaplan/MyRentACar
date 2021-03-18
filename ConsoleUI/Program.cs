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
