using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyStack<T>
    {
        LinkedList<T> stack;
        int count;

        public MyStack()
        {
            stack = new LinkedList<T>();
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public T Pop()
        {
            if (stack.Count == 0)
            {
                return default(T);
            } else
            {
                T poped = stack.First();
                stack.RemoveFirst();
                count--;
                return poped;
            }
        }

        public void Push(T item)
        {
            stack.AddFirst(item);
            count++;
        }
    }
}
