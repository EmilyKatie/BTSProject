using System;
namespace BinaryTS
{
    public class BinaryTree
    {
        public BinaryTree()

        {
            //root = null;
           
        }

        public bool IsEmpty(Node node)
        {

            return node == null;

        }

       

        public void AddData(int data, Node root)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (IsEmpty(root))
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            current = newNode;
                            break;
                        }

                    }
                    else if (data > current.Data)
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            current = newNode;
                            break;
                        }
                    }
                    
                }
            }
        }

        public static bool FindNode(int data, Node root)
        {
            Node tmp = root;
            while (tmp != null)
            {
                if (tmp.Data > data)
                    tmp = tmp.Right;

                else if (tmp.Data < data)
                    tmp = tmp.Left;
                else
                    return true;
            }
            return false;
        }

    }
}            
            
           
