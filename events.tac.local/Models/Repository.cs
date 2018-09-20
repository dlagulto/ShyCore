using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
    //public abstract class EntityBase
    //{
    //    public Int64 Id { get; set; }
    //}

    public interface IRepository<T> 
    {
        T GetById(Int64 Id);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        IList<T> GetAll();
        



    }

    public interface IPostRepository : IRepository<int>
    {
        int GetCommentCount();
    }
    public class Repository<T> : IRepository<T> 
    {
        public void Create(T entity)
        {
            //%logic for add
        }

        public void Delete(T entity)
        {
            //%logic for delete
        }

        public IList<T> GetAll()
        {
            //%
            throw new NotImplementedException();
        }

        public T GetById(long Id)
        {
            //%retrieve
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            //%not a requirement
        }
    }
}