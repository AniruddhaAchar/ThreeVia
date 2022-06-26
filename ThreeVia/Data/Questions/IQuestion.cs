using ThreeVia.Data.Questions.Answers;

namespace ThreeVia.Data.Questions
{
    public interface IQuestion
    {
        public QuestionType GetQuestionType();
        public string GetContent();
        public List<IAnswer> GetCorrectAnswers();

        public List<IAnswer> GetAnswerOptions();
        public AnswerType GetAnswerType();

        public int GetPoints();

    }

    public enum QuestionType
    {
        Image,
        Text,
        Audio,
        Video
    }
}
