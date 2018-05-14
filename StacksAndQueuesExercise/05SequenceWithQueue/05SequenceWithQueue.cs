using System;
using System.Collections.Generic;

namespace _05SequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            long currentElement = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();

            Console.Write("{0} ",currentElement);
            queue.Enqueue(currentElement);
            int count = 1;
            while(count<50)
            {
                currentElement = queue.Dequeue();
                Console.Write("{0} ", currentElement+1);
                
                queue.Enqueue(currentElement + 1);
                count++;

                if (count < 50)
                {
                    Console.Write("{0} ", 2 * currentElement + 1);
                    queue.Enqueue(2 * currentElement + 1);
                    count++;
                }
                else
                {
                    break;
                }
                if (count < 50)
                {
                    Console.Write("{0} ", currentElement + 2);
                    queue.Enqueue(currentElement + 2);
                    count++;
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}
