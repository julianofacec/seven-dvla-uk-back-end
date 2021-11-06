using System.Threading.Tasks;

namespace Seven.Dominio.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}