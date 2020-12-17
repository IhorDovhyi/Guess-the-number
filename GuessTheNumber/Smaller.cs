using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    public class Smaller : ICommand
    {
        const string massage = "Try Something Smaller";
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(massage);
            Console.ResetColor();
        }
    }
}
