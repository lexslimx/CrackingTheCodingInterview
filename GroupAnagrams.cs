using System;
using System.Collections.Generic;
using System.Linq;

public class GroupAnagrams
{
    public IList<IList<string>> Group(string[] strs)
    {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        //create the map's keys
        foreach(var item in strs){
            var arr = item.ToCharArray();
            Array.Sort(arr);
            var newstr = new string(arr);
            if(!map.ContainsKey(newstr)) {
                map.Add(newstr, new List<string>{item});
            }
            else{
                map[newstr].Add(item);
            }
        }
        foreach(var list in map.Values){
            result.Add(list);
        }
        return result;
    }
}