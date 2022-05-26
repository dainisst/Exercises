using System;

namespace Exercises.Level1;

/// <summary>
/// Medium warmup string/array loops
/// </summary>
public class Warmup2
{
    /// <summary>
    /// Given a string and a non-negative int n, return a larger string that is n copies of the original string.
    /// 
    /// stringTimes("Hi", 2) → "HiHi"
    /// stringTimes("Hi", 3) → "HiHiHi"
    /// stringTimes("Hi", 1) → "Hi"
    /// </summary>
    public string StringTimes(string str, int n)
    {
        string str2 = string.Empty;
        for (var i = 0; i < n; i++)
        {
            str2 = str2 + str;
        }
        return str2;
    }

    /// <summary>
    /// Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or whatever is there if the string is less than length 3. 
    /// Return n copies of the front;
    /// 
    /// frontTimes("Chocolate", 2) → "ChoCho"
    /// frontTimes("Chocolate", 3) → "ChoChoCho"
    /// frontTimes("Abc", 3) → "AbcAbcAbc"
    /// </summary>
    public string FrontTimes(string str, int n)
    {
        string strNew = string.Empty;
        for(var i = 0; i < n; i++)
        {
            if (str.Length > 2)
            {
                strNew = strNew + str.Substring(0, 3);
            }
            else
            {
                strNew = strNew + str;
            }
        }
        return strNew;
    }

    /// <summary>
    /// Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".
    /// 
    /// countXX("abcxx") → 1
    /// countXX("xxx") → 2
    /// countXX("xxxx") → 3
    /// </summary>
    public int CountXx(string str)
    {
        int count = 0;
        for (var i = 1; i < str.Length; i++)
        {
            if (str[i] == 'x' && str[i - 1] == 'x')
            {
                count++;
            }
        }
        return count;
    }

    /// <summary>
    /// Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
    ///
    /// doubleX("axxbb") → true
    /// doubleX("axaxax") → false
    /// doubleX("xxxxx") → true
    /// </summary>
    public bool DoubleX(string str)
    {
        int index = str.IndexOf("xx");
        int index2 = str.IndexOf('x');
        if (index >= 0 && index == index2)
        {
            return true;
        }
        return false;   
    }

    /// <summary>
    /// Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
    /// 
    /// stringBits("Hello") → "Hlo"
    /// stringBits("Hi") → "H"
    /// stringBits("Heeololeo") → "Hello"
    /// </summary>
    public string StringBits(string str)
    {
        string strNew = string.Empty;
        for (var i = 0; i < str.Length; i = i + 2)
        {
            strNew = strNew + str[i];
        }
        return strNew;
    }

    /// <summary>
    /// Given a non-empty string like "Code" return a string like "CCoCodCode".
    /// 
    /// stringSplosion("Code") → "CCoCodCode"
    /// stringSplosion("abc") → "aababc"
    /// stringSplosion("ab") → "aab"
    /// </summary>
    public string StringSplosion(string str)
    {
        string newStr = string.Empty;
        for (var i = 0; i < str.Length + 1; i++)
        {
            newStr = newStr + str.Substring(0, i);
        }
        return newStr;
    }

    /// <summary>
    /// Given a string, return the count of the number of times that a substring length 2 appears in the 
    /// string and also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
    /// 
    /// last2("hixxhi") → 1
    /// last2("xaxxaxaxx") → 1
    /// last2("axxxaaxx") → 2
    /// </summary>
    public int Last2(string str)
    {
        int counter = 0;
        if (str.Length > 1)
        {
            string strTofind = str.Substring(str.Length - 2);
            for (var i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == strTofind)
                {
                    counter++;
                }
            }
        }
        return counter;
    }

    /// <summary>
    /// Given an array of ints, return the number of 9's in the array.
    /// 
    /// arrayCount9([1, 2, 9]) → 1
    /// arrayCount9([1, 9, 9]) → 2
    /// arrayCount9([1, 9, 9, 3, 9]) → 3
    /// </summary>
    public int ArrayCount9(int[] nums)
    {
        int count = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 9)
            {
                count++;
            }
        }
        return count;
    }

    /// <summary>
    /// Given an array of ints, return true if one of the first 4 elements in the array is a 9. 
    /// The array length may be less than 4.
    /// 
    /// arrayFront9([1, 2, 9, 3, 4]) → true
    /// arrayFront9([1, 2, 3, 4, 9]) → false
    /// arrayFront9([1, 2, 3, 4, 5]) → false
    /// </summary>
    public bool ArrayFront9(int[] nums)
    {
        if (nums.Length < 5)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 9)
                {
                    return true;
                }
            }
        }
        else
        {
            for (var i = 0; i < 4; i++)
            {
                if (nums[i] == 9)
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if the sequence of numbers 1, 2, 3 appears in the array somewhere.
    /// 
    /// array123([1, 1, 2, 3, 1]) → true
    /// array123([1, 1, 2, 4, 1]) → false
    /// array123([1, 1, 2, 1, 2, 3]) → true
    /// </summary>
    public bool Array123(int[] nums)
    {
        var count = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count = 1;
            }
            else if (nums[i] == 2 && count == 1)
            {
                count = 2;
            }
            else if (nums[i] == 3 && count == 2)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Given 2 strings, a and b, return the number of the positions where they contain the same length 2 substring. 
    /// So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and "az" substrings appear in the same place in both strings.
    /// 
    /// stringMatch("xxcaazz", "xxbaaz") → 3
    /// stringMatch("abc", "abc") → 2
    /// stringMatch("abc", "axc") → 0
    /// </summary>
    public int StringMatch(string a, string b)
    {
        int longest = a.Length;
        if (b.Length < a.Length)
        {
            longest = b.Length;
        }
        int counter = 0;
        for (var i = 0; i < longest - 1; i++)
        {
            if (a.Substring(i, 2) == b.Substring(i, 2))
            {
                counter++;
            }
        }
        return counter;
    }

    /// <summary>
    /// Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end should not be removed.
    /// 
    /// stringX("xxHxix") → "xHix"
    /// stringX("abxxxcd") → "abcd"
    /// stringX("xabxxxcdx") → "xabcdx"
    /// </summary>
    public string StringX(string str)
    {
        string strNew = string.Empty;

        if (str.Length > 1)
        {
            strNew = str[0] + (str.Substring(1, str.Length - 2)).Replace("x", "") + str[str.Length - 1];
        }
        else
        {
            strNew = str;
        }

        return strNew;
    }

    /// <summary>
    /// Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
    ///
    /// altPairs("kitten") → "kien"
    /// altPairs("Chocolate") → "Chole"
    /// altPairs("CodingHorror") → "Congrr"
    /// </summary>
    public string AltPairs(string str)
    {
        //nesanak ar 8 simboliem
        string newStr = string.Empty ;
        for (var i = 0; i < str.Length; i = i + 4)
        {
            if (i < str.Length - 1)
            {
                newStr += str.Substring(i, 2);
            }
            else
            {
                newStr += str.Substring(i, 1);
            }
            
        }
        return newStr;
    }

    /// <summary>
    /// Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but the "a" can be any char.
    /// The "yak" strings will not overlap.
    /// 
    /// stringYak("yakpak") → "pak"
    /// stringYak("pakyak") → "pak"
    /// stringYak("yak123ya") → "123ya"
    /// </summary>
    public string StringYak(string str)
    {
        string str2 = string.Empty ;
        str2 = str.Replace("yak", "");

        return str2;
    }

    /// <summary>
    /// Given an array of ints, return the number of times that two 6's are next to each other in the array.
    /// Also count instances where the second "6" is actually a 7.
    /// 
    /// array667([6, 6, 2]) → 1
    /// array667([6, 6, 2, 6]) → 1
    /// array667([6, 7, 2, 6]) → 1
    /// </summary>
    public int Array667(int[] nums)
    {
        int counter = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == 6 && (nums[i + 1] == 6 || nums[i + 1] == 7))
            {
                counter++;
            }
        }

        return counter;
    }

    /// <summary>
    /// Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. Return true if the 
    /// array does not contain any triples.
    /// 
    /// noTriples([1, 1, 2, 2, 1]) → true
    /// noTriples([1, 1, 2, 2, 2, 1]) → false
    /// noTriples([1, 1, 1, 2, 2, 2, 1]) → false
    /// </summary>
    public bool NoTriples(int[] nums)
    {
        int counter = 0;
        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
            {
                counter++;
            }
        }
        if (counter > 0)
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// Given an array of ints, return true if it contains a 2, 7, 1 pattern: a value, followed by the value plus 5,
    /// followed by the value minus 1. Additionally the 271 counts even if the "1" differs by 2 or less from the correct value.
    /// 
    /// has271([1, 2, 7, 1]) → true
    /// has271([1, 2, 8, 1]) → false
    /// has271([2, 7, 1]) → true
    /// </summary>
    public bool Has271(int[] nums)
    {
        //nav

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i + 1] - nums[i] == 5 && (nums[i] - nums[i + 2] >= -1 && nums[i] - nums[i + 2] <= 3))
            {
                return true;
                
            }
        }

       return false;
    }
}

