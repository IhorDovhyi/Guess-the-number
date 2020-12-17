using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    public class GuessThtNumberProceses
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the game \"Guess The Number\"");
            Console.ResetColor();
            Menu();
        }
        protected void GameProcess()
        {
            HeadNumber headNumber = new HeadNumber();
            GuessTheNumberGame guessTheNumberGame = new GuessTheNumberGame(headNumber.GuessedNumber());
            int userNamber = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Guess the guessed number");
            Console.ResetColor();
            while (!(guessTheNumberGame.Process(userNamber) is Equal))
            {
                CorrectInputCheck(out userNamber);
                guessTheNumberGame.Process(userNamber).Execute();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Do you want to play again?");
            Console.ResetColor();
            Menu();
        }
        protected void CorrectInputCheck(out int value)
        {
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered an invalid number\nTry again");
                    Console.ResetColor();
                }
                if (value < -1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Number must be greater than 0\nTry again");
                    Console.ResetColor();
                    continue;
                }
                else
                    break;
            }
        }
        public int MenuCorrectInputCheck()
        {
            int value, menuValue;
            while (true)
            {
                CorrectInputCheck(out value);
                menuValue = value;
                if (menuValue < 1 || menuValue > 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered an invalid number\nTry again");
                    Console.ResetColor();
                    WriteMenuChoice();
                }
                else
                    return menuValue;
            }
        }
        protected void Menu()
        {
            int menu = -1;
            do
            {
                WriteMenuChoice();
                switch (MenuCorrectInputCheck())
                {
                    case 1:
                        GameProcess();
                        break;
                    case 2:
                        menu = -1;
                        break;
                    default:
                        break;
                }
            } while (menu != -1);
        }
        protected void WriteMenuChoice()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1 - Start game");
            Console.WriteLine("2 - Exit game\n");
            Console.WriteLine("Your choice: ");
            Console.ResetColor();
        }
    }
}
