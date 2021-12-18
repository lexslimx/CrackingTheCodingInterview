using System.Collections.Generic;

public class FirstUniqueCharacter
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> counter = new Dictionary<char, int>();
        foreach (var character in s)
        {
            if (counter.ContainsKey(character))
            {
                counter[character]++;
            }
            else
            {
                counter.Add(character, 1);
            }
        }

        //go over the string again and check each item's count in the map
        var arr = s.ToCharArray();
        for (var i = 0; i < arr.Length; i++)
        {
            if (counter[arr[i]] == 0) return i;
        }

        return -1;
    }
}