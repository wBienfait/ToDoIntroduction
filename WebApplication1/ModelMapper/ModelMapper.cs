using AutoMapper;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;
using System.Collections.Generic;

namespace WebApplication1.ModelMapper
{
	public static class ModelMapper
	{
		public static Card ToCard(CardViewModel cardVM)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<Card, CardViewModel>());
			return Mapper.Map<Card>(cardVM);
		}

		public static CardState ToCardState(CardStateDto stateDto)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<CardState, CardStateDto>());
			return Mapper.Map<CardState>(stateDto);
		}

		public static CardViewModel ToCardVM(Card card)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<Card, CardViewModel>());
			return AutoMapper.Mapper.Map<CardViewModel>(card);
		}

		public static CardStateDto ToCardStateDto(CardState state)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<CardState, CardStateDto>());
			return Mapper.Map<CardStateDto>(state);
		}
	}
}