using System;
using System.Linq;

public class WeightSort {
  
    public static string orderWeight(string strng)
        {
             return strng==string.Empty? string.Empty : string.Join(" ", strng.Split(' ').Where(p=>p.Trim()!=string.Empty) .Select(p => Int64.Parse(p)).OrderBy(p => p.ToString(), new Comparer<string>()));
 
    }

        private class Comparer<T> : System.Collections.Generic.IComparer<string>
        {
            int System.Collections.Generic.IComparer<string>.Compare(string x, string y)
            {
                var xv = x.ToString().ToArray().Select(o => (int)Char.GetNumericValue(o)).Sum();
                var yv = y.ToString().ToArray().Select(o => (int)Char.GetNumericValue(o)).Sum();

                if (xv.CompareTo(yv) == 0)
                {
                    return x.CompareTo(y);
                }
                else
                    return xv.CompareTo(yv);


            }
        }
}