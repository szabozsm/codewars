using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
 	    var x = arr.Where(a => a != 0);
            var y = Enumerable.Repeat(0, arr.Count(a => a == 0));

            return x.Concat(y).ToArray();
  }
}