

namespace ConsoleApp2.Repository
{
	public enum CardState
	{
		Backlog = 0,
		ToDo,
		Doing,
		Done
	}
	class Environment
	{
		Environment _instance;
		public Repository<CardEntity> Repository;
		public Environment Instance
		{
			get
			{
				if(_instance == null)
				{
					_instance = new Environment();
				}
				return _instance;
			}
		}

		public void CreateNew(CardState state, string description)
		{
			CardEntity newCard = new CardEntity(state, description);
			Repository.Create(newCard);
		}
	}
}
