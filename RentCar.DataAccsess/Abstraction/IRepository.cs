using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataAccsess
{
    public interface IRepository<T>
    {
        int Delete(int id);
        T Find(Expression<Func<T, bool>> where);
        int Insert(T obj);
        T Update(int id,T obj);
        List<T> List();
        List<T> List(Expression<Func<T, bool>> where);
        int Save();

    }
}
