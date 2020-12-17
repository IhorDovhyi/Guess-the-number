using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    public class Equal : ICommand
    {
        const string massage = "Successfully!!!\nCongratulations You Won!!!";
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(massage);
            Console.ResetColor();
        }
    }
}
