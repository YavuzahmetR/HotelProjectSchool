using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.DataAccess.Concrete;
using Hotel_Layer.DataAccess.Repositories;
using Hotel_Layer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.DataAccess.EF
{
    public class EfWorkPlaceDal : GenericRepository<WorkPlace>, IWorkPlaceDal
    {
        public EfWorkPlaceDal(Context context) : base(context)
        {
        }
    }
}
