using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace QuizApp.Model
{
    public class QuestionBank: Question
    {
        //public Question question;

        List<Question> question = new List<Question>()
        {
            new Question { QuestionText = "How are you", CorrectAnswer = true},
            new Question { QuestionText = "kflshg", CorrectAnswer = false}
        };

       
    }
}
