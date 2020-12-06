using System;
using System.Collections.Generic;
using System.Text;
using Project4.Entities;

namespace Project4.DataAccess
{
    // class -- referance type
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
