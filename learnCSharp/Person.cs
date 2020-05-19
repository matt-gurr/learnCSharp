using System;
using System.Collections.Generic;
using System.Text;

namespace learnCSharp
{
    class Person
    {
        public enum type
        {
            TEACHER, PUPIL
        };
        protected type pType;
        public String name { get; }
        public Person(String name, type pType)
        {
            this.name = name;
            this.pType = pType;
        }
    }
}