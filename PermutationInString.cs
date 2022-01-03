using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length) return false;

            for (var i = 0; i < (s2.Length - s1.Length) + 1 ; i++)
            {
                int start = i;
                int end = i + s1.Length - 1;

                //check if start-end is a permutation of 
                if (IsPermutation(start, end, s2, s1))
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            return false;
        }

        private bool IsPermutation(int start, int end, string s1, string s2)
        {
            //Use Dictionary
            Dictionary<char, int> counter = new Dictionary<char, int>();
            for (int i = start; i <= end; i++)
            {
                if (counter.ContainsKey(s1[i]))
                {
                    counter[s1[i]]++;
                }
                else
                {
                    counter.Add(s1[i], 1);
                }
            }

            //check if s2 is a match
            foreach (char character in s2)
            {
                if (!counter.ContainsKey(character))
                {
                    return false;
                }
                else
                {
                    counter[character]--;
                }
            }

            foreach (var pair in counter)
            {
                if (pair.Value != 0) return false;
            }

            return true;
        }
    }
}
