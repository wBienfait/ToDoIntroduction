using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication1.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}