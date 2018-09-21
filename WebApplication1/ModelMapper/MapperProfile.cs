using AutoMapper;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;
using System.Collections.Generic;

namespace WebApplication1.ModelMapper
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<Card, CardViewModel>();
			CreateMap<CardState, CardStateDto>();
		}
	}
}