using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
	public enum CardState
	{
		Backlog = 0,
		ToDo,
		Doing,
		Done
	}
	public class Card
	{
		public int Id { get; private set; }
		public CardState State { get; private set; }
		public string Description { get; private set; }

		public void ChangeState(CardState state)
		{
			State = state;
		}
		public void ChangeDescription(string newDescription)
		{
			Description = newDescription;
		}

		public void SetId(int id)
		{
			if(Id == -1)
			{
				Id = id;
			}
		}

		private Card(int id, string description, CardState state)
		{
			Id = id;
			Description = description;
			State = state;
		}

		public static Card Create(int id, string description, CardState state)
		{
			return new Card(id, description, state);
		}

		public static Card Create(string description, CardState state)
		{
			return new Card(-1, description, state);
		}
	}
}