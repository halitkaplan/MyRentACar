using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brandId)
        {
            _brandDal.Add(brandId);
        }

        public void Delete(Brand brandId)
        {
            _brandDal.Delete(brandId);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetByBrandId(int brandId)
        {
            return _brandDal.GetAll(b=>b.BrandId == brandId);
        }

        public void Update(Brand brandId)
        {
            _brandDal.Update(brandId);
        }
    }
}
