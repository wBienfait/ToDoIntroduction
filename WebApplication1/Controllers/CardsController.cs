using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication1.Extensions;
using WebApplication1.Repositories;
using WebApplication1.Repositories.Models;

namespace WebApplication1.Controllers
{
    public class CardsController : ApiController
    {
        private readonly IRepository<Card> _cardRepository;

        public CardsController(IRepository<Card> cardRepository)
        {
            _cardRepository = cardRepository;
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
                return Ok(results.ToViewModel());
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCardById(int id)
        {
            throw new NotImplementedException();
        }
    }
}