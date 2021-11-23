/*
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            BackTrack(result,"",0,0,n);
            return result;
        }

        private void BackTrack(List<string> result,string currentString,int open, int close, int max)
        {
            //base case where we addd a string onto the list
            if (currentString.Length == max * 2 )
            {
                result.Add(currentString);
                return;
            }
            //make all possible decisions

            //as long as opening is not at the max number of opening we can have (max) we add one more
            if (open < max) BackTrack(result, currentString + "(", open + 1, close, max);
            //as long as closings are less than opening we can add oen more close
            //we cannot have closing before opening parenthesis
            if (close < open) BackTrack(result, currentString + ")", open, close + 1, max);
        }
    }
}
