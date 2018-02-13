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
    public void SameX_XEqualsQueenX_True()
    {
      Queen queen = new Queen(6, 4);
      Assert.AreEqual(true, queen.SameX(6));
      Assert.AreEqual(false, queen.SameX(3));
    }

    [TestMethod]
    public void SameY_YEqualsQueenY_True()
    {
      Queen queen = new Queen(6, 4);
      Assert.AreEqual(true, queen.SameY(4));
      Assert.AreEqual(false, queen.SameY(3));
    }

    [TestMethod]
    public void SameDiagonal_DiagonalEqualsQueenDiagonal_True()
    {
      Queen queen = new Queen(8, 4);
      Assert.AreEqual(true, queen.SameDiagonal(6, 6));
      Assert.AreEqual(false, queen.SameDiagonal(5, 3));
    }

    [TestMethod]
    public void CanAttack_QueenCanReachTarget_True()
    {
      Queen queen = new Queen(8, 4);
      Assert.AreEqual(true, queen.CanAttack(8, 1));
      Assert.AreEqual(true, queen.CanAttack(3, 4));
      Assert.AreEqual(true, queen.CanAttack(6, 6));
      Assert.AreEqual(false, queen.CanAttack(5, 3));
    }
  }
}
