﻿using Hotel_Layer.Business.Abstract;
using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetById(int id)
        {
           return _contactDal.GetById(id);
        }

        public int TGetContactNumber()
        {
            return _contactDal.GetContactNumber();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
