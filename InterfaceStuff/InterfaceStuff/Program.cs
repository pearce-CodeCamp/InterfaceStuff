using System;
using System.Collections.Generic;

namespace InterfaceStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShortAnswer question1 = new ShortAnswer("Explain what the heck an interface is!!!!", "I don't know.");
            TrueFalse question2 = new TrueFalse("Are interfaces useful?", "True");
            CheckBoxes question3 = new CheckBoxes("Check all concepts that apply to interfaces", "some list of answers");

            // PrintPrompt is a method that is implemented in the Question class,
            // so any child class of the Question class can use it
            question1.PrintPrompt();
            question2.PrintPrompt();
            // GradeQuestion is a method that exists in the IGradeable interface, but just as a signature
            // Each class that implements the IGradeable interface needs to implement this GradeQuestion method
            // And if you check the individual classes, they have their own implementations of GradeQuestion
            question2.GradeQuestion();
            question3.PrintPrompt();
            question3.GradeQuestion();

            // example of using an interface as a TYPE like using a class as a type
            /*List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);

            foreach(Question question in questions)
            {
                question.PrintPrompt();
            }

            Console.WriteLine();

            List<IGradeable> gradeableQuestions = new List<IGradeable>();
            gradeableQuestions.Add(question2);
            gradeableQuestions.Add(question3);

            foreach(IGradeable question in gradeableQuestions)
            {
                question.GradeQuestion();
            }*/
        }
    }
}
