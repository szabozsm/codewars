using System;
public class Kata
{
      
    public static bool isAValidMessage(string message)
        {
            int i = 0;
            while (i<message.Length)
            {
                if (!char.IsDigit(message[i]))
                    return false;

                string s0= message.Substring(i);

                string s1= System.Text.RegularExpressions.Regex.Match(s0, @"\d+").Value; 

                int n = int.Parse(s1);
                i += s1.Length;
                if ((i+n)> message.Length)
                    return false;
                string s = message.Substring(i, n);

                i += n;

                

            }
            return true;
        }

  
  
}
