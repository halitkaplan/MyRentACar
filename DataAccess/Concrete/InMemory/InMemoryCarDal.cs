using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
           {
               new Car{ Id=1, BrandId=1, ColorId=1, DailyPrice=180000, Description="Renault Captur", ModelYear="2015"},
               new Car{ Id=2, BrandId=1, ColorId=2, DailyPrice=250000, Description="Renault Koleos", ModelYear="2016"},
               new Car{ Id=3, BrandId=1, ColorId=3, DailyPrice=340000, Description="Renault Talisman ", ModelYear="2018"},
               new Car{ Id=4, BrandId=1, ColorId=4, DailyPrice=520000, Description="Renault Zoe", ModelYear="2020"},
               new Car{ Id=5, BrandId=2, ColorId=5, DailyPrice=173500, Description="Honda Civic", ModelYear="2012"},
               new Car{ Id=6, BrandId=3, ColorId=6, DailyPrice=863000, Description="Nissan GTR-R35", ModelYear="2017"},
               new Car{ Id=7, BrandId=4, ColorId=4, DailyPrice=258900, Description="Wolksvagen Caddy", ModelYear="2021"},
           };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;

            carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate;

            carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
