using ThreeVia.Data.Questions;
using ThreeVia.Data.Questions.Answers;

namespace ThreeVia.Data.Game
{
    public class Round
    {
        public string Name { get; set; }
        public string Instructions { get; set; }

        public List<IQuestion> Questions { get; set; }

        public Dictionary<Player, IAnswer> SubmittedAnswers { get; set; }

        public bool IsVisible { get; set; }

        public bool CanSubmit { get; set; }

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
        public void AddQuestion(IQuestion question)
        {
            Questions.Add(question);
        }
    }
}
