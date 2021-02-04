using System;
using System.Linq;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    // complete the function
   var s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (var item in s.ToArray())
            {
            str=    str.Replace(item.ToString(), " " + item.ToString());
            }
            return str;
  }
}