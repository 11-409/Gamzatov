using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    internal class RealizationStack
    {
        private char[] Elements;
        private int LastIndex = -1;
        private int Size;
        RealizationStack(int size)
        {
            Size = size;
            Elements = new char[size];
        }
        public bool Fulled() { return LastIndex == Size - 1; }
        public bool Emptiness() { return LastIndex == -1; }

        public bool Push(char element)
        {
            if (Fulled()) return false;
            else
            {
                Elements[++LastIndex] = element;
                return true;
            }
        }
        public char Pop()
        {
            if (Emptiness()) return '-';
            else
            {
                return Elements[LastIndex--];
            }
        }
        public char Peek()
        {
            if (Emptiness()) return '0';
            else
            {
                return Elements[LastIndex];
            }
        }
    }
}
