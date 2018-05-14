using System;
using System.Collections.Generic;

namespace DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            var stackBinary = new Stack<int>();

            if (decimalNumber==0)
            {
                Console.WriteLine(0);
                
            }
            while (decimalNumber>0)
            {
                int remainder = decimalNumber % 2;
                stackBinary.Push(remainder);

                decimalNumber /= 2;
            }

            while (stackBinary.Count>0)
            {
                Console.Write(stackBinary.Pop());
            }


        }
    }
}
