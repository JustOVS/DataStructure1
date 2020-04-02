using System;
namespace DataStructure
{
    public class Node2d
    {
        public int Value { get; set; }
        public Node2d Next { get; set; }
        public Node2d Previous { get; set; }

        public Node2d()
        {
            Next = null;
            Previous = null;
        }

        public Node2d(int value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
