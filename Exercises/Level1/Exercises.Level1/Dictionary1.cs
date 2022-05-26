using System;
using System.Collections.Generic;

namespace Exercises.Level1;

public class Dictionary1
{

    /// Modify and return the given map as follows: if the key "a" has a value, 
    /// set the key "b" to have that value, and set the key "a" to have the value "". 
    /// Basically "b" is a bully, taking the value and replacing it with the empty string.
    /// 
    /// mapBully({ "a": "candy", "b": "dirt"}) → {"a": "", "b": "candy"}
    /// mapBully({ "a": "candy"}) → {"a": "", "b": "candy"}
    /// mapBully({ "a": "candy", "b": "carrot", "c": "meh"}) → {"a": "", "b": "candy", "c": "meh"}
    public Dictionary<string, string> DictionaryBully(Dictionary<string, string> map)
    {
        if (map.TryGetValue("a", out string mapValue))
        {
            map["b"] = map["a"];
            map["a"] = "";            
        }

        return map;
    }

    /// Modify and return the given map as follows: 
    /// if the key "a" has a value, set the key "b" to have that same value.
    /// In all cases remove the key "c", leaving the rest of the map unchanged.
    ///
    /// mapShare({ "a": "aaa", "b": "bbb", "c": "ccc"}) → {"a": "aaa", "b": "aaa"}
    /// mapShare({ "b": "xyz", "c": "ccc"}) → {"b": "xyz"}
    /// mapShare({ "a": "aaa", "c": "meh", "d": "hi"}) → {"a": "aaa", "b": "aaa", "d": "hi"}
    public Dictionary<string, string> DictionaryShare(Dictionary<string, string> map)
    {
        if (map.TryGetValue("a", out string mapValue))
        {
            map["b"] = map["a"];            
        }
        map.Remove("c");

        return map;
       
    }



    /// Modify and return the given map as follows: 
    /// for this problem the map may or may not contain the "a" and "b" keys.
    /// If both keys are present, append their 2 string values together and store the result under the key "ab".
    /// 
    /// mapAB({ "a": "Hi", "b": "There"}) → {"a": "Hi", "ab": "HiThere", "b": "There"}
    /// mapAB({ "a": "Hi"}) → {"a": "Hi"}
    /// mapAB({ "b": "There"}) → {"b": "There"}
    public Dictionary<string, string> DictionaryAB(Dictionary<string, string> map)
    {
        if (map.TryGetValue("a", out string mapValue) && map.TryGetValue("b", out string mapValue2))
        {
            map.Add("ab", map["a"] + map["b"]);
        }
        return map;
    }
}

