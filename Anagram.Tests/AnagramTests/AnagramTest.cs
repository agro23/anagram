using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;
using Anagrams.Models;
using System.Collections.Generic;

namespace Anagrams.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void BreakMyKeyword()
    {
      Anagram tester = new Anagram();
      tester.SetMyWord("Test");
      tester.BreakKeyWord();
      Assert.AreEqual(true, tester.GetMyChars());
      Assert.AreEqual(false, tester.GetMyChars());
    }
    //
    // [TestMethod]
    // public void SameY_YEqualsQueenY_True()
    // {
    //   Queen queen = new Queen(6, 4);
    //   Assert.AreEqual(true, queen.SameY(4));
    //   Assert.AreEqual(false, queen.SameY(3));
    // }
    //
    // [TestMethod]
    // public void SameDiagonal_DiagonalEqualsQueenDiagonal_True()
    // {
    //   Queen queen = new Queen(8, 4);
    //   Assert.AreEqual(true, queen.SameDiagonal(6, 6));
    //   Assert.AreEqual(false, queen.SameDiagonal(5, 3));
    // }
    //
    // [TestMethod]
    // public void CanAttack_QueenCanReachTarget_True()
    // {
    //   Queen queen = new Queen(8, 4);
    //   Assert.AreEqual(true, queen.CanAttack(8, 1));
    //   Assert.AreEqual(true, queen.CanAttack(3, 4));
    //   Assert.AreEqual(true, queen.CanAttack(6, 6));
    //   Assert.AreEqual(false, queen.CanAttack(5, 3));
    // }
  }
}
