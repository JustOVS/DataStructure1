using System;
namespace DataStructure
{
    public class L2Node
    {
        public int Value { get; set; }
        public L2Node Next { get; set; }
        public L2Node Previous { get; set; }

        public L2Node()
        {
            Next = null;
            Previous = null;
        }

        public L2Node(int value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
