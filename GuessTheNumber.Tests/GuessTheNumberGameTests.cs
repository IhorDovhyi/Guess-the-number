using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber;

namespace GuessTheNumber.Tests
{
    [TestClass]
    public class GuessTheNumberGameTests
    {
        [TestMethod]
        public void ProcessTest_AddUserNumber_ClassTypeEqualExpected()
        {
            // Arrange
            int guessNumber = 10, setNumber = 10;
            GuessTheNumberGame guessTheNumberGame = new GuessTheNumberGame(guessNumber);
            ICommand expected = new Equal();
            // Act
            ICommand actual = guessTheNumberGame.Process(setNumber);
            // Assert
            Assert.IsInstanceOfType(actual, expected.GetType());
        }
        [TestMethod]
        public void ProcessTest_AddUserNumber_ClassTypeMoreExpected()
        {
            // Arrange
            int guessNumber = 10, setNumber = 9;
            GuessTheNumberGame guessTheNumberGame = new GuessTheNumberGame(guessNumber);
            ICommand expected = new More();
            // Act
            ICommand actual = guessTheNumberGame.Process(setNumber);
            // Assert
            Assert.IsInstanceOfType(actual, expected.GetType());
        }
        [TestMethod]
        public void ProcessTest_AddUserNumber_ClassTypeSmallerExpected()
        {
            // Arrange
            int guessNumber = 10, setNumber = 11;
            GuessTheNumberGame guessTheNumberGame = new GuessTheNumberGame(guessNumber);
            ICommand expected = new Smaller();
            // Act
            ICommand actual = guessTheNumberGame.Process(setNumber);
            // Assert
            Assert.IsInstanceOfType(actual, expected.GetType());
        }
    }
}
