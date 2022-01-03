using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class MyQueue
    {
        //Queue == first in first out
        //Stack = first in last out

        Stack<int> front;
        Stack<int> back;

        public MyQueue()
        {
            front = new Stack<int>();
            back = new Stack<int>();
        }

        public void Push(int x)
        {
            while (back.Count > 0)
            {
                front.Push(back.Pop());
            }

            front.Push(x);
        }

        public int Pop()
        {
            //move all elements from front to back then pop back
            while(front.Count > 0)
            {
                back.Push(front.Pop());
            }

            var result = back.Pop();
            return result;
        }

        public int Peek()
        {
            if(back.Count > 0)
            {
                return back.Peek();
            }

            while (front.Count > 0)
            {
                back.Push(front.Pop());
            }
            return back.Peek();
        }

        public bool Empty()
        {
            return front.Count == 0 && back.Count == 0;
        }
    }

}
