using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    public class More : ICommand
    {
        const string massage = "Try Something More";
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(massage);
            Console.ResetColor();
        }
    }
}
