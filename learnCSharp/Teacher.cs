using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace learnCSharp
{
    class Teacher : Person
    {
        public Teacher(String name) : base(name, Person.type.TEACHER)
        {
            /* What other properties could the Teacher have? */
        }
    }
}
