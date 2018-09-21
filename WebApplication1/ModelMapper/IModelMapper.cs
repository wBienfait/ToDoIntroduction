using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace WebApplication1.ModelMapper
{
	public interface IModelMapper
	{
		IMapper Mapper();
	}
}
