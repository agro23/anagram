using System.Collections.Generic;
using System;

namespace Anagrams.Models
{
  public class Anagram
  {
    private string _word;
    private char[] _myChars;
    private string[] _theirWords;
    private char[] _theirWord;
    private string _yourWord;
    private static List<Anagram> _instances = new List<Anagram> {};

    public Anagram(string yourWord)
    {
      _yourWord = yourWord;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static List<Anagram> GetAll()
    {
      return _instances;
    }

    public string GetMyWord()
    {
      return _word;
    }

    public void SetMyWord(string myWord)
    {
      _word = myWord;
    }

    public string GetYourWord()
    {
      return _yourWord;
    }

    public void SetYourWord(string yourWord)
    {
      _yourWord = yourWord;
    }

    public char[] GetMyChars()
    {
      return _myChars;
    }

    public void SetMyChars (char[] myChars)
    {
      _myChars = myChars;
    }

    public string[] GetTheirWords()
    {
      return _theirWords;
    }

    public void SetTheirWords(string[] theirWords)
    {
      _theirWords = theirWords;
    }

    public char[] GetTheirWord()
    {
      return _theirWord;
    }

    public void SetTheirWord (char[] myChars)
    {
      _theirWord = myChars;
    }

    // * Break Key word into an Array of Chars
    //   1. String Key = "test";
    //   2. var ourChars = Key.ToCharArray();

    public void BreakKeyWord()
    {
      SetMyChars(GetMyWord().ToCharArray()); // make an array of Char from my Key word
    }

    public void BreakToChar(string aWord)
    {
      SetTheirWord(aWord.ToCharArray());
    }

    // * Sort ourChars
    //   - EXPECTED INPUT: ["B", "E", "A", "R", "D"];
    //   - EXPECTED OUTPUT: (each Char on a separate line, "A", "B", "D", "E", "R")

    public char[] SortMyChars(char[] myChars)
    {
      Array.Sort(myChars);
      return myChars;
    }
  }
}
