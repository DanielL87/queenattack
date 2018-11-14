using Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Game.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
   public void QueenCanAttack_XEqualsX()
   {
       Assert.AreEqual(true, QueenAttack.QueenCanAttack(2, 4, 2, 5));
   }
   [TestMethod]
   public void QueenCanAttack_YEqualsY()
   {
       Assert.AreEqual(true, QueenAttack.QueenCanAttack(2, 4, 3, 4));
  }
  [TestMethod]
   public void QueenCanAttack_XMinusXEqualsYMinusY()
   {
       Assert.AreEqual(true, QueenAttack.QueenCanAttack(3, 6, 6, 3));
  }

  [TestMethod]
   public void QueenCanNotAttack()
   {
       Assert.AreEqual(false, QueenAttack.QueenCanAttack(7, 0, 6, 7));
  }
}
}