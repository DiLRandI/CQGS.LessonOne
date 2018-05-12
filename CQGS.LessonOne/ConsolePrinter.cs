using CQGS.LessonOne.PrintWorld;
using System;

namespace CQGS.LessonOne
{
    public class ConsolePrinter : IPrint
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}