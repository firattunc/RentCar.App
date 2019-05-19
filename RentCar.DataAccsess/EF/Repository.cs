using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RentCar.DataAccsess.EF
{
    public class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        public Repository()
        {
            _objectSet = context.Set<T>();
        }
        public int Delete(int id)
        {
            _objectSet.Remove(_objectSet.Find(id));
            return Save();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).FirstOrDefault();
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public List<T> List()
        {

            return _objectSet.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public T Update(int id,T obj)
        {

            context.Entry(obj).State = System.Data.Entity.EntityState.Modified;

            
            Save();
            return obj;
        }
    }
}
