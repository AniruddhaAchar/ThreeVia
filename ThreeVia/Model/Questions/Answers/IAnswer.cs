namespace ThreeVia.Model.Questions.Answers
{
    public interface IAnswer
    {
        AnswerType GetAnswerType();

        List<string> GetContent();
    }

    public enum AnswerType
    {
        FreeForm,
        OneCorrect,
        MultipleCorrect,
        TrueFalse,
    }
}
