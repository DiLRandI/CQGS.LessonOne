using CQGS.LessonOne.ShapesWorld;
using System;
using System.Collections.Generic;

namespace CQGS.LessonOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            var redPrinte = new ConsoleColorPrinter(ConsoleColor.Red);
            var greenPrinter = new ConsoleColorPrinter(ConsoleColor.Green);
            var yellowPrinter = new ConsoleColorPrinter(ConsoleColor.Yellow);
            var defaultPrinter = new ConsolePrinter();

            var defaultSquare = new Square(defaultPrinter, "White", 6, 4);
            var redCircle = new Circle(redPrinte, "Red", 10);
            var greenSquare = new Square(greenPrinter, "Green", 5, 4);
            var yellowRectangle = new Rectangle(yellowPrinter, "Yellow", 5, 2, 4);

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

