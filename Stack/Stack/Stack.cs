using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abcd
{
    public class Stack
    {
        private string []Buffer;
        private int Top;
        public Stack (int size)
        {
            Buffer = new string[size];
            Top = -1;
        }
        //buffer 1000 items
        public Stack()
        {
            Buffer = new string[1000];
            Top = -1;
        }
        public void Push(string v)
        {
            Buffer[Top+1] = v;
            Top++;
        }
        public string Pop()
        {
            string v = Buffer[Top];
            Top = Top - 1;
            return v;
        }
        public string Peek()
        {
            return Buffer[Top];
        }
        public int Count()
        {
            return Top + 1;
        }
        public void Clear()
        {
            Top = -1;
        }
    }
}
