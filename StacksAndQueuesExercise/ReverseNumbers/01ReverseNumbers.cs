using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var stack = new Stack<int>(numbers);
                     
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(stack.Pop()+" ");
            }


        }
    }
}
