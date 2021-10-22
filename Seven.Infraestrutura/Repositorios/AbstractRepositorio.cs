using Microsoft.EntityFrameworkCore;
using Seven.Dominio.Interfaces;
using Seven.Infraestrutura.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Seven.Infraestrutura.Repositorios
{
    public abstract class AbstractRepositorio<T> : IRepositorio<T> where T : class
    {
        private readonly DataContext _context;

        protected DbSet<T> Entity => _context.Set<T>();

        protected AbstractRepositorio(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(_context));
        }

        public async Task AddAsync(T entity) => await Entity.AddAsync(entity ?? throw new ArgumentNullException(nameof(entity)));
        public void Update(T entity) => Entity.Update(entity ?? throw new ArgumentNullException(nameof(entity)));
        public void Remove(T entity) => Entity.Remove(entity ?? throw new ArgumentNullException(nameof(entity)));
        public Task<IQueryable<T>> GetAsync() => throw new NotImplementedException();
        public Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate) => throw new NotImplementedException();
    }
}