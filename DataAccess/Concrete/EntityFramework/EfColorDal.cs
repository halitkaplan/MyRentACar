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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                var addedEntity = carContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                carContext.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                var deletedEntity = carContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                carContext.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return filter == null ? carContext.Set<Color>().ToList() : carContext.Set<Color>().Where(filter).ToList();
            }
            
        }

        public Color GetById(Expression<Func<Color, bool>> filter)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return carContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public Color GetCarsByBrandId(Expression<Func<Color, bool>> filter)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return carContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public Color GetCarsByColorId(Expression<Func<Color, bool>> filter)
        {
            using (RentACarContext carContext = new RentACarContext())
            {
                return carContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public void Update(Color entity)
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
