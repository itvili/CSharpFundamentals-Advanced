using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var openingBracketIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openingBracketIndex.Push(i);
                }
                if (input[i] == ')')
                {
                    var currentIndex = openingBracketIndex.Pop();
                    var lengthSubstring = i - currentIndex;
                    var bracketSubstring = input.Substring(currentIndex, lengthSubstring+1);
                    Console.WriteLine(bracketSubstring);
                }
            }
            
               
            
        }
    }
}
