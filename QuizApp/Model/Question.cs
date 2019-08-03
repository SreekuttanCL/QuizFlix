
namespace QuizApp
{
    public class Question
    {
        public string QuestionText { get; set; }
        public bool CorrectAnswer { get; set; }

        public Question()
        {
            QuestionText = "";
            CorrectAnswer = false;
        }

        public Question(string question, bool correctanswer)
        {
            QuestionText = question;
            CorrectAnswer = correctanswer;
        }

        public string getQuestion()
        {
            return QuestionText;
        }

        public bool getCorrectAnswer()
        {
            return CorrectAnswer;
        }

        public void setQuestion(string question)
        {
            QuestionText = question;
        }

        public void setCorrectAnswer(bool correctanswer)
        {
            CorrectAnswer = correctanswer;
        }
    }
}
