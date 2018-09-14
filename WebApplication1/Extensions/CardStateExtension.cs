using System;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Extensions
{
    public static class CardStateExtension
    {
        public static CardStateDto ToViewModel(this CardState cardState)
        {
            switch (cardState)
            {
                case CardState.ToDo:
                    return CardStateDto.ToDo;
                case CardState.InProgress:
                    return CardStateDto.InProgress;
                case CardState.Done:
                    return CardStateDto.Done;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cardState), cardState, null);
            }
        }
    }
}