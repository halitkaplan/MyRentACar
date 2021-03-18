using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                var addedEntity = carContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                carContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                var deletedEntity = carContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                carContext.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return filter == null ? carContext.Set<Brand>().ToList() : carContext.Set<Brand>().Where(filter).ToList();
            }
        }

        public Brand GetById(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return carContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public Brand GetCarsByBrandId(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return carContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public Brand GetCarsByColorId(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return carContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public void Update(Brand entity)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                var updatedEntity = carContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                carContext.SaveChanges();
            }
        }
    }
}
