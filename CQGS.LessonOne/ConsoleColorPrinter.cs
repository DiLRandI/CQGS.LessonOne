using System;
using CQGS.LessonOne.PrintWorld;

namespace CQGS.LessonOne
{
    public class ConsoleColorPrinter : IPrint
    {
        private readonly ConsoleColor _consoleColor;

        public ConsoleColorPrinter(ConsoleColor consoleColor)
        {
            _consoleColor = consoleColor;
        }

        public void Print(string message)
        {
            var currentColour = Console.ForegroundColor;
            Console.ForegroundColor = _consoleColor;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColour;
        }
    }
}