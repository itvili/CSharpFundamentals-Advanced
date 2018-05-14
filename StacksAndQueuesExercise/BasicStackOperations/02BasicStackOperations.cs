using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            var sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = command[0];
            int numbersToPop = command[1];
            int numberToSearch = command[2];


            int totalNumberToPush = numbersToPush - numbersToPop;

            if (totalNumberToPush<=0)
            {
                Console.WriteLine(0);
                return;
            }

            var stack = new Stack<int>();

            for (int i = 0; i < totalNumberToPush; i++)
            {
                stack.Push(sequence[i]);
            }

            int stackCount = stack.Count;

            var stackToArray = stack.ToArray();

            int countFoundedNumber = 0;

            for (int i = 0; i < stackCount; i++)
            {
                int foundedNumber = stack.Pop();

                if (foundedNumber==numberToSearch)
                {
                    Console.WriteLine("true");
                    countFoundedNumber++;
                    break;
                }
            }

            if (countFoundedNumber==0)
            {
                Console.WriteLine(stackToArray.Min());
            }
        }
    }
}
