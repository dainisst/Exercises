using System;

namespace Exercises.Level2;
public class Triangle
{
    /// <summary>
    /// Note: compleete half trangle first
    /// 
    /// The program:
    ///  You must create a triangle. 
    ///  n is the number of lines a triangle will have.
    ///  Triangle body has to be made out of "*",
    ///  so result should for 3 be like:
    ///  * 
    /// ***
    ///*****
    /// 
    /// Example of 5:
    /// 
    ///    *
    ///   ***
    ///  *****
    /// *******
    ///*********
    ///
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string[] GetTRiangle(int n)
    {
        var result = new string[n];
        for(var i = 0; i < n; i++)
        {
            var line = string.Empty;
            for (var j = 1; j < n - i; j++)
            {
                line += " ";
            }
            for (var j = 0; j <= 2 * i; j++)
            {
                line += "*";
            }
            result[i] = line;
        }

        return result;
    }
}
