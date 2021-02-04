using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    return words.Where(w => string.Join("", w.ToArray().OrderBy(c => c)) == string.Join("", word.ToArray().OrderBy(c => c))).ToList();

  }
}