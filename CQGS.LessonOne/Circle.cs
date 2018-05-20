using CQGS.LessonOne.PrintWorld;
using CQGS.LessonOne.ShapesWorld;
using System;

namespace CQGS.LessonOne
{
    public class Circle : CircularShapes
    {
        public Circle(IPrint print, string colour, double radius) : base(print, colour, radius)
        {
        }

        public override void DisplayInformation()
        {
            Print.Print($"Shape color {Colour} Shape area {GetArea()}");
        }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}

