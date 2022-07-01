using ThreeVia.Model.Questions.Answers;

namespace ThreeVia.Model.Questions
{
    public class Question
    {
        public List<IAnswer> Options { get; set; }
        public string Content { get; set; }
        public AnswerType AnswerType { get; set; }
        public List<IAnswer> CorrectAnswers { get; set; }
        public QuestionType QuestionType { get; set; }
        public int Points { get; set; }
    }

}
