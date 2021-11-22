/*
Given a string containing digits from 2-9 inclusive, 
return all possible letter combinations that the number could represent. 
Return the answer in any order.
A mapping of digit to letters (just like on the telephone buttons) is given below. 
Note that 1 does not map to any letters.
*/
using System.Collections.Generic;
using System.Linq;

public class LetterCombinationsProblem
{
    public IList<string> LetterCombinations(string digits)
    {
        List<string> result = new List<string>();
        if(string.IsNullOrEmpty(digits)) return result;
        Dictionary<int, List<char>> mappings = new Dictionary<int, List<char>>();
        CreateMap(mappings);
        CombineLetters(result, digits, "", 0, mappings);
        
        return  result;
    }
    public void CombineLetters(List<string> result, string digits, string current, int index, Dictionary<int,List<char>> mapping){
        if(index == digits.Length){ 
            result.Add(current);
            return;
        }
        string c = digits.ElementAt(index).ToString();
        int digit = int.Parse(c);
        List<char> letters = mapping[digit];
        for(int i = 0 ; i < letters.Count; i ++){
            CombineLetters(result, digits, current + letters[i], index+1, mapping);
        }



    }
    void CreateMap(Dictionary<int, List<char>> map)
    {
        map.Add(0, new List<char> { });
        map.Add(1, new List<char> { });
        map.Add(2, new List<char> { 'a', 'b', 'c' });
        map.Add(3, new List<char> { 'd', 'e', 'f' });
        map.Add(4, new List<char> { 'g', 'h', 'i' });
        map.Add(5, new List<char> { 'j', 'k', 'l' });
        map.Add(6, new List<char> { 'm', 'n', 'o' });
        map.Add(7, new List<char> { 'p', 'q', 'r', 's' });
        map.Add(8, new List<char> { 't', 'u', 'v' });
        map.Add(9, new List<char> { 'w', 'x', 'y', 'z' });
    }
}
