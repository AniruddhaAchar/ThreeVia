namespace ThreeVia.Data.Questions.Answers
{
    public class FreeFormAnswer : IAnswer
    {
        public AnswerType GetAnswerType()
        {
            return AnswerType.FreeForm;
        }

        public List<string> GetContent()
        {
            throw new NotImplementedException();
        }
    }
}
