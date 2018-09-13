using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
	public class Repository<T> : IRepository<T> where T : CardEntity
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

		public void Create(T entity)
		{
			if (!_context.EntityList().Contains(entity))
			{
				entity.SetId(GetNewId());
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
		}
	}
}
