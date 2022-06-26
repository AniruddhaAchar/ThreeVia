using ThreeVia.Data.Questions.Answers;

namespace ThreeVia.Data.Questions
{
    public class Question : IQuestion
    {
        private readonly List<IAnswer> options;
        private readonly string content;
        private readonly AnswerType answerType;
        private readonly List<IAnswer> correctAnswers;
        private readonly QuestionType questionType;
        private readonly int points;

        public Question(List<IAnswer> options,
                             string imageUrl,
                             AnswerType answerType,
                             List<IAnswer> correctAnswers,
                             QuestionType questionType,
                             int points)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
            content = imageUrl ?? throw new ArgumentNullException(nameof(imageUrl));
            this.answerType = answerType;
            this.correctAnswers = correctAnswers ?? throw new ArgumentNullException(nameof(correctAnswers));
            this.questionType = questionType;
            this.points = points;
        }

        public List<IAnswer> GetAnswerOptions()
        {
            return options;
        }

        public AnswerType GetAnswerType()
        {
            return answerType;
        }

        public string GetContent()
        {
            return content;
        }

        public List<IAnswer> GetCorrectAnswers()
        {
            return correctAnswers;
        }

        public QuestionType GetQuestionType()
        {
            return questionType;
        }

        public int GetPoints()
        {
            return points;
        }
    }

}
