using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication1.Repositories;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;
using WebApplication1.ModelMapper;
using AutoMapper;

namespace WebApplication1.Controllers
{
    public class CardsController : ApiController
    {
        private readonly IRepository<Card> _cardRepository;
		private readonly IMapper _mapper;

        public CardsController(IRepository<Card> cardRepository, IModelMapper mapper)
        {
            _cardRepository = cardRepository;
			_mapper = mapper.Mapper();
        }

		[Route("api/cards/create")]
		[HttpPost]
		public async Task<IHttpActionResult> CreateCard([FromBody]CardViewModel card)
		{
			_cardRepository.Create(_mapper.Map<Card>(card));
			var newCard = await _cardRepository.GetByIdAsync(card.Id);
			if(newCard != null) return Ok();
			return NotFound();
		}

		[Route("api/cards/update")]
		[HttpPut]
		public async Task<IHttpActionResult> UpdateCard([FromBody]CardViewModel card)
		{
			_cardRepository.Update(_mapper.Map<Card>(card));
			var newCard = await _cardRepository.GetByIdAsync(card.Id);
			if (newCard != null) return Ok(newCard);
			return NotFound();
		}

		[Route("api/cards/delete")]
		[HttpDelete]
		public async Task<IHttpActionResult> DeleteCard([FromBody]CardViewModel card)
		{
			_cardRepository.Create(_mapper.Map<Card>(card));
			var newCard = await _cardRepository.GetByIdAsync(card.Id);
			if (newCard == null) return Ok("Card deleted");
			else return Ok("Card not deleted");
		}

		[HttpGet]
        public async Task<IHttpActionResult> GetAllCards()
        {
            var results = await _cardRepository.GetAllAsync();
            if (results.Any())
            {
                //soit automapper (nuget + doc internet) (tres populaire)
                //soit mapping manuel (conversion manuelle avec class explicite mapper) => choix perso
                //soit méthode d'extension (.ToDTO()) => appliqué ici
                //return Ok(results.ToViewModel());
				return Ok(_mapper.Map<CardViewModel>(results));
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCardById(int id)
        {
			var result = await _cardRepository.GetByIdAsync(id);
			if(result != null)
			{
				return Ok(_mapper.Map<CardViewModel>(result));
			}
			return NotFound();
        }
    }
}