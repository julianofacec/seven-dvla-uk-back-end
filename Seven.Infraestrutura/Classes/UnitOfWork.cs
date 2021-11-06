using Seven.Dominio.Interfaces;
using System.Threading.Tasks;

namespace Seven.Infraestrutura.Classes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}