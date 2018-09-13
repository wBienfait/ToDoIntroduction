using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
	interface IRepository <T> where T : CardEntity
	{
		T GetById(int id);
		void Create(T entity);
		void Delete(T entity);
		void Update(T entity);
		int GetNewId();
	}
}
