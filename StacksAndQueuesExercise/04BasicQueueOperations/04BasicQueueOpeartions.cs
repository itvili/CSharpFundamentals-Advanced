using System;
using System.Collections.Generic;
using System.Linq;

namespace _04BasicQueueOperations
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

            int numbersToEnqueue = command[0];
            int numbersToDequeue = command[1];
            int numberToSearch = command[2];

            var queue = new Queue<int>();
            int countFoundedNumbers = 0;
            int totalNumbersToEnqueue = numbersToEnqueue - numbersToDequeue;

            if (totalNumbersToEnqueue==0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (totalNumbersToEnqueue>0)
            {
                for (int i = numbersToDequeue; i < numbersToEnqueue; i++)
                {
                    queue.Enqueue(sequence[i]);
                    if (sequence[i]==numberToSearch)
                    {
                        Console.WriteLine("true");
                        countFoundedNumbers++;
                        break;
                    }
                }
            }

            if (countFoundedNumbers==0)
            {
                Console.WriteLine(queue.Min());
            }

        }
    }
}
