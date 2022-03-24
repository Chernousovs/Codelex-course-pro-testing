using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordleGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfGuessIsCorrect()
        {
            //Arrange
            var wordToGuess = new Word();
            char[] expectedWord = { 'v','a','l','i','d' };

            //Act
            var actual = wordToGuess.word;
            char[] actualCharArray = actual.ToCharArray();

            //Assert
            CollectionAssert.AreEqual(expectedWord, actualCharArray);

        }

        [TestMethod]
        public void TestWordChecker()
        {
            //Arrange
            
        }

    }
}
