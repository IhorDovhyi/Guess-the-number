using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace GuessTheNumber
{
    public class GuessTheNumberGame
    {
        int guessedNumber;
        public GuessTheNumberGame(int guessedNumber)
        {
          this.guessedNumber = guessedNumber;
        }
        public ICommand Process(int userNamber)
        {
            ICommand toReturn;
            if (userNamber < guessedNumber)
            {
               toReturn = new More();
            }
            else if (userNamber > guessedNumber)
            {
               toReturn = new Smaller();
            }
            else
            {
               toReturn = new Equal();
            }
            return toReturn;
        }
    }
}
