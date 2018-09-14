using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication1.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
    }
}