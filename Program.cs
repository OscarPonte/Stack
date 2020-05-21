using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(DateTime.Now);
           // stack.Push(null);
            stack.Push(8);
            stack.Push("Test");

            //stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
           // Console.WriteLine(stack.Pop());
        }
    }
}
