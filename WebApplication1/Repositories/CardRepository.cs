using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repositories.Models;

namespace WebApplication1.Repositories
{
    public class CardRepository : IRepository<Card>
    {
		List<Card> _cards;
        public Task<IEnumerable<Card>> GetAllAsync()
        {
            return Task.FromResult(_cards.AsEnumerable());
        }

        public Task<Card> GetByIdAsync(int id)
        {
			Card result = null;
			for (int i = 0; i < _cards.Count; i++)
			{
				if (_cards[i].Id == id) result = _cards[i];
			}
			return Task.FromResult(result);
        }

		public void Create(Card entity)
		{
			if(!_cards.Contains(entity))
			{
				_cards.Add(entity);
			}
		}

		public void Update(Card entity)
		{
			for (int i = 0; i < _cards.Count; i++)
			{
				if (_cards[i].Id == entity.Id) _cards[i] = entity;
			}
		}

		public void Delete(Card entity)
		{
			if (_cards.Contains(entity))
			{
				_cards.Remove(entity);
			}
		}

		private int GetNewId()
		{
			int maxId = 0;
			for (int i = 0; i < _cards.Count; i++)
			{
				if (_cards[i].Id > maxId) maxId = _cards[i].Id;
			}
			return maxId + 1;
		}

		public CardRepository()
		{
			_cards = new List<Card>();
			_cards.Add(Card.Create(GetNewId(), "test 1", CardState.ToDo));
			_cards.Add(Card.Create(GetNewId(), "test 2", CardState.Done));
			_cards.Add(Card.Create(GetNewId(), "test 3", CardState.ToDo));
			_cards.Add(Card.Create(GetNewId(), "test 4", CardState.InProgress));
			_cards.Add(Card.Create(GetNewId(), "test 5", CardState.Done));
		}
    }
}