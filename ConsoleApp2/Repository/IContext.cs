using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
	public interface IContext<T> where T : CardEntity
	{
		List<T> EntityList();
		List<T> EntityList(CardState state);
	}
}
