using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.DataAccess.Concrete;
using Hotel_Layer.DataAccess.Repositories;
using Hotel_Layer.DTO.Dtos.AppUser;
using Hotel_Layer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.DataAccess.EF
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public List<AppUser> UserListWithWorkPlace()
        {
            using(var context = new Context())
            {
                return context.Users.Include(x => x.WorkPlace).ToList();
            }
        }

        public List<AppUser> UsersListWithWorkPlaces()
        {
           using(var context = new Context())
            {
                var values = context.Users.Include(x=>x.WorkPlace).Select(y => new AppUser
                {
                    Name = y.Name,
                    Surname = y.Surname,
                    Gender = y.Gender,
                    City = y.City,
                    Country = y.Country,
                    WorkPlaceID = y.WorkPlaceID,
                    WorkDepartment = y.WorkDepartment,
                    ImageUrl = y.ImageUrl
                }).ToList();
                return values;
            }
        }
    }
}
