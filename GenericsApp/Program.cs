using System;
using StackLib;

namespace GenericsApp
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(2);
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}