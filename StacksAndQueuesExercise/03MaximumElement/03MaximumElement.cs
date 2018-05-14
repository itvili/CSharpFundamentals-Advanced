using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            var stackMaxNumber = new Stack<int>();
            int maxElement = int.MinValue;

            for (int i = 0; i < numberOfQueries; i++)
            {
                var queries = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (queries[0])
                {

                    case 1:

                        if (maxElement < queries[1])
                        {
                            maxElement = queries[1];
                            stackMaxNumber.Push(maxElement);
                        }
                        stack.Push(queries[1]);
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() == stackMaxNumber.Peek() && stackMaxNumber.Count > 0)
                            {
                                stackMaxNumber.Pop();

                                if (stackMaxNumber.Count > 0)
                                {
                                    maxElement = stackMaxNumber.Peek();
                                }
                                else
                                {
                                    maxElement = int.MinValue;
                                }
                            }
                            stack.Pop();
                        }
                        break;

                    case 3:
                        if (stackMaxNumber.Count > 0)
                        {
                            
                            Console.WriteLine(stackMaxNumber.Peek());
                        }
                        break;
                }

            }
        }
    }
}
