

public class Kata
{
 
    public static string CreatePhoneNumber(int[] numbers)
        {
            return string.Format("({0}) {1}-{2}", CreateChunk(numbers, 0,3), CreateChunk(numbers,3, 3), CreateChunk(numbers,6, 4));
        }

        private static string CreateChunk(int[] numbers, int j, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += numbers[i+j].ToString();
            }
            return result;
        }
  
}