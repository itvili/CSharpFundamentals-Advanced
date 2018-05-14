using System;
using System.Linq;

namespace _06TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            var pumpsInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int fuel = pumpsInfo[0];
            int distance = pumpsInfo[1];
        }
    }
}
