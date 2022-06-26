namespace ThreeVia.Data.Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Guid TeamId { get; set; }

        public string ReEntryPasscode { get;}

        public Player(string name)
        {
            Name = name;
            Score = 0;
            TeamId = Guid.NewGuid();
            ReEntryPasscode = TeamId.ToString("n")[..4];
        }
    }
}
