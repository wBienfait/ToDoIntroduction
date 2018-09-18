using System.Web.Http;
using AutoMapper;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;

namespace WebApplication1
{
    public static class MappingConfig
	{
        public static void Register(HttpConfiguration config)
        {
			//Mapper.Initialize(cfg => cfg.CreateMap<Card, CardViewModel>());
			//Mapper.Initialize(cfg => cfg.CreateMap<CardState, CardStateDto>());
		}
	}
}