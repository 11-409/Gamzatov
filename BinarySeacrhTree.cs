using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    internal class BinarySeacrhTree
    {

    }
    public class Node
    {
        public int Value;
        public Node Right;
        public Node Left;
        public Node(int value)
        {
            Value = value;
            Right = null;
            Left = null;
        }
    }
    public class BinSearchTree
    {
        public Node Root { get; private set; }

        public BinSearchtree(Node root = null)
        {
            Root = root;
        }
        public bool Search(int value, Node node)
        {
            if (node == null) return false;
            else if (node.Value == value) return true;
            else
            {
                if (node.Value > value)
                    return Search(value, node.Left);
                else
                    return Search(value, node.Right);
            }
        }
        Node Add(int value, Node node)
        {
            if (node == null) return new Node(value);

            if (value < node.Value)
                node.Left = Add(value, node.Left);

            else if (value > node.Value)
                node.Right = Add(value, node.Right);

            return node;
        }
    }
}
