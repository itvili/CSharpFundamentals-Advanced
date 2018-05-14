using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kidsInput = Console.ReadLine().Split(' ');

            int toss = int.Parse(Console.ReadLine());

            var kidsQueue = new Queue<string>(kidsInput);

            while (kidsQueue.Count!=1)
            {
                
                for (int i = 1; i < toss; i++)
                {
                    kidsQueue.Enqueue(kidsQueue.Dequeue());
                }

                Console.WriteLine($"Removed {kidsQueue.Dequeue()}");
            }

            Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
        }
    }
}
