using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace learnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            schoolDirectory();
        }

        static void schoolDirectory()
        {
            Teacher teacher;
            Pupil[] pupil = new Pupil[1000];    // In release code, you'd definitely not
                                                // hardcode this, you'd use a List or similar!

            teacher = new Teacher("John Smith");

            Console.Out.WriteLine("Teacher's name is " + teacher.name);

            pupil[0] = new Pupil("James Earl Jones");

            Console.Out.WriteLine("Pupil 0's name is " + pupil[0].name);
        }

        static void doLinkedList()
        {
            LinkedList l;
            ListNode tmp;

            l = new LinkedList(1);

            l.append(5);
            l.append(10);


            /* l.printAll() */

            tmp = l.first;
            Console.Out.WriteLine(tmp.data);
            while ((tmp = tmp.next) != null)
                Console.Out.WriteLine(tmp.data);

            l = null;
        }

        static void bubbleSort()
        {
            int i, j;
            int[] unsortedList, sortedList;
            Random random;
            
            unsortedList = new int[10];
            sortedList = new int[10];
            random = new Random();

            for (i = 0; i < unsortedList.Length; i++)
                unsortedList[i] = random.Next(50);

            /* You can also do Python-style for loops */
            foreach (int num in unsortedList)
                Console.WriteLine(num);

            /* 
             * Copy unsortedList into sortedList
             */

            /* 
             * Iterate over the list, you'll need a couple of counting variables.
             * Above, i and j are declared for you.
             * You should know how to do a bubble sort by now, right? :)
             */
        }

    }
}
}
