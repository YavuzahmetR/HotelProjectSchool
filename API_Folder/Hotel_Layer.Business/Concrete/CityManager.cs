using Hotel_Layer.Business.Abstract;
using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public void TDelete(City t)
        {
            throw new NotImplementedException();
        }

        public City TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<City> TGetList()
        {
            return _cityDal.GetList();
        }

        public void TInsert(City t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(City t)
        {
            throw new NotImplementedException();
        }
    }
}
