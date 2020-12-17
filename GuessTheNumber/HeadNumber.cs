using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    class HeadNumber
    {
        private int guessedNumber;
        public int GuessedNumber()
        {
            Random random = new Random();
            return guessedNumber = random.Next(0, 100);
        }
    }
}
