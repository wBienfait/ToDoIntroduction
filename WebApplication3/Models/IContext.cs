using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
	public interface IContext<T> where T : Card
	{
		List<T> EntityList();
	}
}
