using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.DataAccess.Concrete;
using Hotel_Layer.DataAccess.Repositories;
using Hotel_Layer.Entities.Concrete;

namespace Hotel_Layer.DataAccess.EF
{
    public class EfAboutDal: GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(Context context) : base(context) { }
    }
}
