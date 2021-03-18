using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetByColorId(int colorId);

        void Add(Color colorId);
        void Delete(Color colorId);
        void Update(Color colorId);

    }
}
