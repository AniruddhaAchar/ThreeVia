using ThreeVia.Data.Questions;

namespace ThreeVia.Data.Game
{
    public class Stats
    {
        public List<PlayerStats> PlayerStats { get; set; }

        public Stats()
        {
            PlayerStats = new List<PlayerStats>();
        }

        public void AddPlayerStats(PlayerStats playerStats)
        {
            PlayerStats.Add(playerStats);
        }

        public Dictionary<Player, int> GetPlayerScores()
        {
            var scoreBoard = new Dictionary<Player, int>();
            foreach (var playerStats in PlayerStats)
            {
                int tempScore = 0;
                foreach (var correctAnswer in playerStats.Answers)
                {
                    if (correctAnswer.Value)
                    {
                        tempScore += correctAnswer.Key.GetPoints();
                    }
                }
                scoreBoard.Add(playerStats.Player, tempScore);
            }
            return scoreBoard;
        }

        public double GetPercentageCorrect(IQuestion question)
        {
            var correctAnswers = 0;
            var totalAnswers = 0;
            foreach (var playerStats in PlayerStats)
            {
                if (playerStats.Answers.ContainsKey(question) )
                {
                    if (playerStats.Answers[question])
                    {
                        correctAnswers++;
                    }
                    totalAnswers++;
                }
            }
            return (double)correctAnswers / totalAnswers;
        }
    }

    public class PlayerStats
    {
        public Player Player { get; set; }
        public Dictionary<IQuestion, bool> Answers { get; set; }

        public PlayerStats()
        {
            Answers = new Dictionary<IQuestion, bool>();
        }

        public void AddAnswer(IQuestion question, bool isCorrect)
        {
            Answers.Add(question, isCorrect);
        }
    }
}
