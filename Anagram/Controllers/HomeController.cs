using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Anagrams.Models;
using System.Text.RegularExpressions;

namespace Anagrams.Controllers
{
  public class HomeController : Controller
  {

     [HttpGet("/")]
     public ActionResult Index()
    {
      List<string> Agram = new List<string>{};
      return View();
    }


    [HttpPost("/")]
    public ActionResult Results()
   {
     List<string> Model = new List<string>{};
     // Dictionary<string, object> model = new Dictionary<string, object>();
     // model.Add("msg", "");
     // return View("Index", model);
    Anagram myWord = new Anagram("");
    myWord.SetMyWord(Request.Form["our-word"]);
    myWord.BreakKeyWord();
    char[] forSorting = myWord.SortMyChars(myWord.GetMyChars());
    // forSorting is our char list in order
    string theirWord = Request.Form["their-list"]; // NEW

    string[] theirWords = theirWord.Split(' ');

    foreach (string line in theirWords)
    {
        Console.WriteLine(line);
        Anagram newAnagram = new Anagram(line);
        newAnagram.Save();
    }
    Console.WriteLine("********************************");

    List<Anagram> myList = Anagram.GetAll();
    for (var i = 1; i < myList.Count; i++)
    {
      Console.WriteLine(myList[i].GetYourWord() + "\n");
      string weee = myList[i].GetYourWord();
      myList[i].BreakToChar(weee);
      char [] x = myList[i].SortMyChars(myList[i].GetTheirWord());

      if (forSorting.Length == x.Length)
      {
        int winner = 0;
        for(var j = 0; j < forSorting.Length; j++)
        {
          if (forSorting[j] == x[j])
          {
              winner++;
          }
        }
        if (winner == forSorting.Length)
        {
          Model.Add(myList[i].GetYourWord());
        }
      }

      // if (forSorting.SequenceEqual(x))
      // {
      //   Model.Add(myList[i].GetYourWord());
      // }
    }
    Console.WriteLine("**** NOW WRITING WINNERS ****");

    for (var i = 0; i < Model.Count; i++)
    {
      Console.WriteLine(i + " : " + Model[i]);
    }





    // string value = "cat\r\ndog\r\nanimal\r\nperson";
    //         // Split the string on line breaks.
    //         // ... The return value from Split is a string array.
    //         string[] lines = Regex.Split(value, "\r\n");
    //
    //         foreach (string line in lines)
    //         {
    //             Console.WriteLine(line);
    //         }
    // Regex.Replace("This is a test string, with lots of: punctuations; in it?!.", @"[^\w\s]", "");
    // // Regex rgx = new Regex("[^/\w/\-]*");
    // theirWord = rgx.Replace(theirWord, "");
    // Console.WriteLine(theirWord[1]);

    // myWord.BreakKeyWord();
    // char[] forSorting = myWord.SortMyChars(myWord.GetMyChars());

    // foreach (char character in forSorting)
    // {
    //   // Console.WriteLine(character + "\n");
    //   model.Add(character+"\n");
    // }
    //  model.Add(Request.Form["our-word"]);
    return View("Index", Model);
    //  return View("Index", model);
   }
  }
}
