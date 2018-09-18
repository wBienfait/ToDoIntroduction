using System.Collections.Generic;
using System.Linq;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Extensions
{
    public static class CardViewModelExtension
	{
        public static Card ToModel(this CardViewModel card)
        {
			return Card.Create(card.Id, card.Description, card.State.ToModel());
        }

		public static IEnumerable<Card> ToModel(this IEnumerable<CardViewModel> cards)
        {
            return cards.Select(ToModel);
        }
    }
}