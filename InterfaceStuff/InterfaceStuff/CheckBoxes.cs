using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceStuff
{
    public class CheckBoxes : Question, IGradeable
    {
        public CheckBoxes(string prompt, string answer) : base(prompt, answer) { }

        public bool GradeQuestion()
        {
            Console.WriteLine("This method doesn't actually grade anything, it is for learning purposes.");
            Console.WriteLine("But if we actually implemented it, it would need to test if all checked answers" +
                "are correct.");
            Console.WriteLine(CorrectAnswer);
            return true;
        }
    }
}
