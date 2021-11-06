using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Seven.Dominio.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);

        Task<IQueryable<T>> GetAsync();
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);
    }
}