using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceStuff
{
    public interface IGradeable
    {
        // A class that implements this interface can be automatically graded by our program without the need
        // for a human to grade it.
        // In coding terms, a class the implements this interface must implement the gradeQuestion method
        // defined here
        // Syntactically, we don't include curly braces because our method signature shouldn't have a body.
        // The body is the actualy implementation, which will be different in each class that implements this
        // interface.
        public bool GradeQuestion();
    }
}
