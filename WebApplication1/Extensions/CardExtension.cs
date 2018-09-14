using System.Collections.Generic;
using System.Linq;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Extensions
{
    public static class CardExtension
    {
        public static CardViewModel ToViewModel(this Card card)
        {
            return new CardViewModel
            {
                Id = card.Id,
                Description = card.Description,
                State = card.State.ToViewModel()
            };
        }

		public static IEnumerable<CardViewModel> ToViewModel(this IEnumerable<Card> cards)
        {
            return cards.Select(ToViewModel);
        }
    }
}