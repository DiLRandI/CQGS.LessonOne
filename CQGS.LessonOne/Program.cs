using CQGS.LessonOne.ShapesWorld;
using System;
using System.Collections.Generic;

namespace CQGS.LessonOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            var redConsole = new ConsoleColorPrinter(ConsoleColor.Red);
            var greenConsole = new ConsoleColorPrinter(ConsoleColor.Green);
            var yellowConsole = new ConsoleColorPrinter(ConsoleColor.Yellow);
            var defaultConsole = new ConsolePrinter();

            var defaultSquare = new Square(defaultConsole, "White", 6, 4);
            var redCircle = new Circle(redConsole, "Red", 10);
            var greenSquare = new Square(greenConsole, "Green", 5, 4);
            var yellowRectangle = new Rectangle(yellowConsole, "Yellow", 5, 2, 4);

            var shapeList = new List<IShapes>
            {
                defaultSquare,
                redCircle,
                greenSquare,
                yellowRectangle
            };

            foreach (var shapese in shapeList)
            {
                shapese.DisplayInformation();
            }

            Console.ReadKey();
        }
    }
}

