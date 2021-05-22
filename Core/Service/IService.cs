using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IService<T> where T:class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        //Find(x=>x.id =23)
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        //category.SingleOrDefault(x=>x.name="kalem")
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entity);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        T Update(T entity);
    }
}
