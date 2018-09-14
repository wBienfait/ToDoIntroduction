namespace WebApplication1.Repositories.Models
{
    public class Card
    {
        private Card(int id, string description, CardState state)
        {
            Id = id;
            Description = description;
            State = state;
        }

        public int Id { get; }
        public CardState State { get; private set; }
        public string Description { get; private set; }

        public void ChangeState(CardState state)
        {
            State = state;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
        }

        public static Card Create(int id, string description, CardState state)
        {
            return new Card(id, description, state);
        }

        public static Card Create(string description, CardState state)
        {
            return new Card(0, description, state);
        }
    }
}