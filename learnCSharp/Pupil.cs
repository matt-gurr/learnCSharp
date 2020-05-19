using System;
using System.Collections.Generic;
using System.Text;

namespace learnCSharp
{
    class Pupil : Person
    {
        public Pupil(String name) : base(name, Person.type.PUPIL)
        {
            // What other properties could the Pupil have?
            // I wonder if s/he could have an array of Test Scores?
        }
    }
}
