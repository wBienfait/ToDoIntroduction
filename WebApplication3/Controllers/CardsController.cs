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
		Repository<Card> _repository;

		/// <summary>
		/// Placeholder to initialize hardcoded data
		/// </summary>
		private void InitializeCards()
		{
			_repository.Create(Card.Create(_repository.GetNewId(), "WebAPI", CardState.Doing));
			_repository.Create(Card.Create(_repository.GetNewId(), "Angular", CardState.ToDo));
			_repository.Create(Card.Create(_repository.GetNewId(), "DB", CardState.Backlog));
		}
		public IEnumerable<Card> GetAllCards()
		{
			if (_repository.GetList().Count == 0) InitializeCards();
			return _repository.GetList();
		}

		public IHttpActionResult GetCard(int id)
		{
			if (_repository.GetList().Count == 0) InitializeCards();
			var card = _repository.GetById(id);
			//var card = _cards.FirstOrDefault((p) => p.Id == id);
			if (card == null)
			{
				return NotFound();
			}
			return Ok(card);
		}
	}
}
