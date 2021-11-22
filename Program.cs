using System;
using CrackingTheCodingInterview.Heap;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
           LetterCombinationsProblem letterCombinationsProblem = new LetterCombinationsProblem();
           var ans = letterCombinationsProblem.LetterCombinations("234");
           foreach(var item in ans){
               Console.WriteLine(item);
           }
        }
    }
}
