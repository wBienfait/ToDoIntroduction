

namespace ConsoleApp2.Repository
{
	public class CardEntity
	{
		public int Id { get; private set; }
		public CardState State { get; private set; }
		public string Description { get; private set; }
		public void SetId(int id)
		{
			Id = id;
		}
		public void MoveTo(CardState state)
		{
			State = state;
		}
		public void Edit(string newDescription)
		{
			Description = newDescription;
		}
		public CardEntity(CardState state, string description)
		{
			State = state;
			Id = -1;
			Description = description;
		}

	}
}
