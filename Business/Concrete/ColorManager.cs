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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color colorId)
        {
            _colorDal.Add(colorId);
        }

        public void Delete(Color colorId)
        {
            _colorDal.Delete(colorId);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetByColorId(int colorId)
        {
            return _colorDal.GetAll(c=>c.ColorId == colorId);
        }

        public void Update(Color colorId)
        {
            _colorDal.Delete(colorId);
        }
    }
}
