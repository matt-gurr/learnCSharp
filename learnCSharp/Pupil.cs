using System;
using System.Collections.Generic;
using System.Text;

namespace learnCSharp
{
    class Pupil : Person
    {
        LinkedList testResults;

        public Pupil(String name) : base(name, Person.type.PUPIL)
        {
            // What other properties could the Pupil have?
            // I wonder if s/he could have an array of Test Scores?
            testResults = new LinkedList(0);

        }
        public void addTestResult(int data)
        {
            this.testResults.append(data);
        }
    }
}
