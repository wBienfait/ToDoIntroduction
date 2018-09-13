using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CardsController : ApiController
    {
		private readonly IRepository<Card> _repository;

		public CardsController(IRepository<Card> cardRepository)
		{
			_repository = cardRepository;
		}

		[HttpGet]
		public IEnumerable<Card> GetAllCards()
		{
			return _repository.GetList();
		}

		[HttpGet]
		public IHttpActionResult GetCardById(int id)
		{
			var card = _repository.GetById(id);
			if (card == null)
			{
				return NotFound();
			}
			return Ok(card);
		}

	}
}
