using System;

namespace learnCSharp {
    public class ListNode
    {
        public int data
        { /* want to be able to read it */
            get; /* want to be able to write */ /*set;*/
        }
        public ListNode next { get; set; }
        public ListNode previous { get; set; }

        public ListNode(int data, ListNode previous)
        {
            this.data = data;
            this.next = null;
            this.previous = previous;
        }
    }
}