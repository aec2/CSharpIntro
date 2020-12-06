﻿using Project4.Entities;
using Project4.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}
