using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics24
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            Stack<int> stack1 = new Stack<int>();

            stack1.Push(1);
            stack1.Push(2);
            int value = stack1.Pop();
            Console.WriteLine(value);

            stack.Push("Tomo");
            stack.Push("Lucic");
            string value1 = stack.Pop();
            Console.WriteLine(value1);
        }
    }
    public class Stack<T>
    {
        public List<T> items = new List<T>();
        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }
    }
}
