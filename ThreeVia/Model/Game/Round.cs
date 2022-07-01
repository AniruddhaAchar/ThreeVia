using ThreeVia.Model.Questions;
using ThreeVia.Model.Questions.Answers;

namespace ThreeVia.Model.Game
{
    public class Round
    {
        public string Name { get; set; }
        public string Instructions { get; set; }

        public List<Question> Questions { get; set; }

        public Dictionary<Player, IAnswer> SubmittedAnswers { get; set; }

        public bool IsVisible { get; set; }

        public bool CanSubmit { get; set; }

        public Round()
        {
            Questions = new List<Question>();
            SubmittedAnswers = new Dictionary<Player, IAnswer>();
        }

        //add new submissions
        public void AddSubmission(Player player, IAnswer answer)
        {
            if (SubmittedAnswers.ContainsKey(player))
            {
                SubmittedAnswers[player] = answer;
            }
            else
            {
                SubmittedAnswers.Add(player, answer);
            }
        }

        //set is visible
        public void SetVisible(bool isVisible)
        {
            IsVisible = isVisible;
        }

        //set can submit
        public void SetCanSubmit(bool canSubmit)
        {
            CanSubmit = canSubmit;
        }
        
        //add question
        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }
}
