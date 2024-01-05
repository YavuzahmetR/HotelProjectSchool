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
    public class WorkPlaceManager : IWorkPlaceService
    {
        private readonly IWorkPlaceDal _workPlaceDal;
        public WorkPlaceManager(IWorkPlaceDal workPlaceDal)
        {
            _workPlaceDal = workPlaceDal;
        }
        public void TDelete(WorkPlace t)
        {
            _workPlaceDal.Delete(t);
        }

        public WorkPlace TGetById(int id)
        {
            return _workPlaceDal.GetById(id);
        }

        public List<WorkPlace> TGetList()
        {
            return _workPlaceDal.GetList();
        }

        public void TInsert(WorkPlace t)
        {
            _workPlaceDal.Insert(t);
        }

        public void TUpdate(WorkPlace t)
        {
           _workPlaceDal.Update(t);
        }
    }
}
