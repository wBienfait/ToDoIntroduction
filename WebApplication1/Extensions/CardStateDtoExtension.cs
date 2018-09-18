using System;
using WebApplication1.Repositories.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Extensions
{
    public static class CardStateDtoExtension
	{
        public static CardState ToModel(this CardStateDto cardState)
        {
            switch (cardState)
            {
                case CardStateDto.ToDo:
                    return CardState.ToDo;
                case CardStateDto.InProgress:
                    return CardState.InProgress;
                case CardStateDto.Done:
                    return CardState.Done;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cardState), cardState, null);
            }
        }
    }
}