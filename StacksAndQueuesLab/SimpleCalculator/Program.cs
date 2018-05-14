using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var reversedInput=input.Reverse();

            var stackNumberSequence = new Stack<string>(reversedInput);

            int countOfStack = stackNumberSequence.Count;
            
            while (stackNumberSequence.Count>=3)
            {
                int result = 0;
                var firstOperand = stackNumberSequence.Pop();
                var operators = stackNumberSequence.Pop();
                var secondOperand = stackNumberSequence.Pop();

                switch (operators)
                {
                    case"+":
                        result = int.Parse(firstOperand) + int.Parse(secondOperand);
                        break;
                    case "-":
                        result = int.Parse(firstOperand) - int.Parse(secondOperand);
                        break;

                }
                string resultToString = result.ToString();
                stackNumberSequence.Push(resultToString);
            }

            Console.WriteLine(stackNumberSequence.Pop());
        }
    }
}
