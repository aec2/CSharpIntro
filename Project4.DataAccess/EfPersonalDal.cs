﻿using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project4.DataAccess
{
    public class EfPersonalDal : IPersonelDal
    {
        public void Add(Personel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Personel entity)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Personels.ToList();
            }
        }

        public Personel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel entity)
        {
            throw new NotImplementedException();
        }
    }
}
