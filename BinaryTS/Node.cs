using System;
namespace BinaryTS
{

    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;


        public void DisplayNode()
        {
            Console.WriteLine(Data + " ");
        }

        public Node()
        {
            Left = null;
            Right = null;
        }
        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}






    
    














