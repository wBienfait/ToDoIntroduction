using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace WebApplication1.ModelMapper
{
	public class ModelMapper : IModelMapper
	{
		private IMapper _mapper;
		public ModelMapper()
		{
			var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
			_mapper = config.CreateMapper();
		}

		public IMapper Mapper()
		{
			return _mapper;
		}
	}
}