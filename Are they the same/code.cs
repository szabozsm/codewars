using System;
using System.Linq;
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
        {
    if (a==null) return false;
    if (b==null)  return false;
    
     
    if (  a.Length!=b.Length) return false;
    
            var c = b.ToList();

            foreach (var a0 in a)
            {
                var a2 = a0 * a0;
                if (c.Contains(a2))
                {
                    c.Remove(a2);
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

}