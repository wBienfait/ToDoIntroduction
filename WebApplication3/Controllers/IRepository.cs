using System.Collections.Generic;
namespace WebApplication3.Controllers
{
	interface IRepository <T>
	{
		T GetById(int id);
		List<T> GetList();
		void Create(T entity);
		void Delete(T entity);
		void Update(T entity);
		int GetNewId();
	}
}
