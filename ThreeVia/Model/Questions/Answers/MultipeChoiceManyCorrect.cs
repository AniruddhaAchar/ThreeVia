namespace ThreeVia.Data.Questions.Answers
{
    public class MultipeChoiceManyCorrect : MultipleChoiceOneCorrect
    {
        public MultipeChoiceManyCorrect(List<string> optionsText) : base(optionsText)
        {
        }

        public override AnswerType GetAnswerType()
        {
            return AnswerType.MultipleCorrect;
        }
    }
}
