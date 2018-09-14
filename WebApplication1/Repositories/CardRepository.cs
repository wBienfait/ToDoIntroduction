using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repositories.Models;

namespace WebApplication1.Repositories
{
    public class CardRepository : IRepository<Card>
    {
        public Task<IEnumerable<Card>> GetAllAsync()
        {
            var results = new List<Card>
            {
                Card.Create("test 1", CardState.ToDo),
                Card.Create("test 2", CardState.ToDo),
                Card.Create("test 3", CardState.ToDo),
                Card.Create("test 4", CardState.InProgress),
                Card.Create("test 5", CardState.Done)
            };

            return Task.FromResult(results.AsEnumerable());
        }

        public Task<Card> GetByIdAsync(int id)
        {
            var result = Card.Create("test 1", CardState.ToDo);

            return Task.FromResult(result);
        }
    }
}