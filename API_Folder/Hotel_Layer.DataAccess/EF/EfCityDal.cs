﻿using Hotel_Layer.DataAccess.Abstract;
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
    public class EfCityDal : GenericRepository<City>, ICityDal
    {
        public EfCityDal(Context context) : base(context)
        {
        }  
    }
}
