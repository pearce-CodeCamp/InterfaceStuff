using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceStuff
{
    public class TrueFalse : Question, IGradeable
    {
        public TrueFalse(string prompt, string answer) : base(prompt, answer) { }

        public bool GradeQuestion()
        {
            Console.WriteLine("This method doesn't actually grade anything, it is for learning purposes.");
            Console.WriteLine("But for fun, we will have it always return true so every answer is correct.");
            Console.WriteLine(CorrectAnswer);
            return true;
        }
    }
}
