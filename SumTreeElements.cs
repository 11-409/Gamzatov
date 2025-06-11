using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    internal class SumTreeElements
    {
        public static int SumTreeIterative(Tree root)
        {
            if (root == null)
                return 0;

            Stack<Tree> stack = new Stack<Tree>();
            stack.Push(root);
            int sum = 0;

            while (stack.Count > 0)
            {
                Tree node = stack.Pop();
                sum += node.Baza;

                if (node.Right != null)
                    stack.Push(node.Right);

                if (node.Left != null)
                    stack.Push(node.Left);
            }

            return sum;
        }
    }
    class Tree
    {
        public int Baza;
        public Tree Left;
        public Tree Right;
        public Tree(int baza)
        {
            Baza = baza;
            Left = null;
            Right = null;
        }
    }
}
