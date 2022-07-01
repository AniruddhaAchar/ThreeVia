namespace ThreeVia.Model.Questions.Answers
{
    public class MultipleChoiceOneCorrect : IAnswer
    {
        public List<string> OptionsText { get; }

        public MultipleChoiceOneCorrect(List<string> optionsText)
        {
            OptionsText = optionsText;
        }

        public virtual AnswerType GetAnswerType()
        {
            return AnswerType.OneCorrect;
        }

        public List<string> GetContent()
        {
            return OptionsText;
        }
    }

}
