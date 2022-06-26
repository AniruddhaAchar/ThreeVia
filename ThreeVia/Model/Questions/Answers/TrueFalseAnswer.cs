namespace ThreeVia.Data.Questions.Answers
{
    public class TrueFalseAnswer : IAnswer
    {
        public AnswerType GetAnswerType()
        {
            return AnswerType.TrueFalse;
        }

        public List<string> GetContent()
        {
            return new List<string> { "true", "false" };
        }
    }
}
