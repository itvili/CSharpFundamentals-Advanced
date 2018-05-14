using System;
using System.Collections.Generic;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> queue = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                queue.Push(input[i]);
            }

            for (int i = 0; i <input.Length; i++)
            {
                Console.Write(queue.Pop());
            }

            
        }
    }
}
