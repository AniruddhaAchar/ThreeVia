using ThreeVia.Model.Questions;

namespace ThreeVia.Model.Game
{
    public class Tournament
    {
        public Guid Id { get;}
        public string PassCode { get;}
        public List<Round> Rounds { get; set; }

        public List<Player> Players { get; set; }

        public Tournament()
        {
            Id = Guid.NewGuid();
            PassCode = Id.ToString("n")[..4];
            Rounds = new List<Round>();
            Players = new List<Player>();
        }

    }
}
