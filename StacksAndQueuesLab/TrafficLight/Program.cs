using System;
using System.Collections.Generic;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPassedCars = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            var queue = new Queue<string>();

            int countPassed = 0;

            while (command!="end")
            {
                if (command=="green")
                {
                    var endPass = Math.Min(queue.Count, numberPassedCars);
                    for (int i = 0; i < endPass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        countPassed++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{countPassed} cars passed the crossroads.");
        }
    }
}
