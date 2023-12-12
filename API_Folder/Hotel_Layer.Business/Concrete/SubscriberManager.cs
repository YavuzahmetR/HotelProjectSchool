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
    public class SubscriberManager : ISubscriberService
    {
        private readonly ISubscriberDal _subscriberDal;
        public SubscriberManager(ISubscriberDal subscriberDal)
        {
            _subscriberDal = subscriberDal;
        }
        public void TDelete(Subscriber t)
        {
            _subscriberDal.Delete(t);
        }

        public Subscriber TGetById(int id)
        {
            return _subscriberDal.GetById(id);
        }

        public List<Subscriber> TGetList()
        {
            return _subscriberDal.GetList();
        }

        public void TInsert(Subscriber t)
        {
            _subscriberDal.Insert(t);
        }

        public void TUpdate(Subscriber t)
        {
            _subscriberDal.Update(t);
        }
    }
}
