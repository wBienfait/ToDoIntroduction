using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication3.Models;
using System.Web;

namespace WebApplication3.Controllers
{
	public class Repository<T> : IRepository<T> where T : Card
	{
		IContext<T> _context;
		public T GetById(int id)
		{
			for (int i = 0; i < _context.EntityList().Count; i++)
			{
				if (_context.EntityList()[i].Id == id) return _context.EntityList()[i];
			}
			return null;
		}

		public List<T> GetList()
		{
			return _context.EntityList();
		}

		public void Create(T entity)
		{
			entity.SetId(GetNewId());
			if (!_context.EntityList().Contains(entity))
			{
				_context.EntityList().Add(entity);
			}
		}

		public void Delete(T entity)
		{
			if (_context.EntityList().Contains(entity))
			{
				_context.EntityList().Remove(entity);
			}
		}

		public void Update(T entity)
		{
			for (int i = 0; i < _context.EntityList().Count; i++)
			{
				if (_context.EntityList()[i].Id == entity.Id) _context.EntityList()[i] = entity;
			}
		}

		public int GetNewId()
		{
			int maxId = 0;
			for (int i = 0; i < _context.EntityList().Count; i++)
			{
				if (_context.EntityList()[i].Id > maxId) maxId = _context.EntityList()[i].Id;
			}
			return maxId + 1;
		}

		public Repository(IContext<T> context)
		{
			_context = context;
			//still not sure where to hardcode that part.
			Create(Card.Create("WebAPI", CardState.Doing) as T);
			Create(Card.Create("Angular", CardState.ToDo) as T);
			Create(Card.Create("DB", CardState.Backlog) as T);
		}
	}
}