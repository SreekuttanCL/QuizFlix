using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace QuizApp.Model
{
    public class QuestionBank : Question
    {
        //public Question question;

        public QuestionBank (){}

      public  List<Question> question = new List<Question>()
        {
            new Question { QuestionText = "Question no 1", CorrectAnswer = true},
            new Question { QuestionText = "Question no 2", CorrectAnswer = false},
            new Question { QuestionText = "Question no 3", CorrectAnswer = false},
            new Question { QuestionText = "Question no 4", CorrectAnswer = false},
            new Question { QuestionText = "Question no 5", CorrectAnswer = false},
            new Question { QuestionText = "Question no 6", CorrectAnswer = false},
            new Question { QuestionText = "Question no 7", CorrectAnswer = false},
            new Question { QuestionText = "Question no 8", CorrectAnswer = false},
            new Question { QuestionText = "Question no 9", CorrectAnswer = false},
            new Question { QuestionText = "Question no 10", CorrectAnswer = false},
        };

       
    }
}
