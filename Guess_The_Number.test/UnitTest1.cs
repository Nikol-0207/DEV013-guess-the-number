namespace Guess_The_Number.test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GameTests
{
    private Game game = new Game("Test Player");
    private Player AIPlayer = new AIPlayer("Test AI");
    private Player Player = new HumanPlayer("Test Person");
    [TestMethod]
    public void CheckGuess_True()
    {
        int guess = game.secretNumber;
        bool result = game.CheckGuess(guess, guess);
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void CheckGuess_False(){
        bool result = game.CheckGuess(40,50);
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void AIGetLast_List(){
       AIPlayer.AddListAiGuess(34);
       AIPlayer.AddListAiGuess(20);
       int result= AIPlayer.GetLastAIGuess();
       Assert.AreEqual(20,result);
    }
     [TestMethod]
    public void GetLast_List(){
       Player.AddListGuess(50);
       Player.AddListGuess(100);
       int result=Player.GetLastGuess();
       Assert.AreEqual(100,result);
    }
    
}        