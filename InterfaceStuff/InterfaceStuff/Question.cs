using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceStuff
{
    public abstract class Question
    {
        public string CorrectAnswer { get; set; }
        public string Prompt { get; set; }

        public Question(string prompt, string answer)
        {
            CorrectAnswer = answer;
            Prompt = prompt;
        }

        // this is an instance method of this class
        public void PrintPrompt()
        {
            Console.WriteLine(Prompt);
        }
    }
}
