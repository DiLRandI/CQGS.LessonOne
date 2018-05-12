using CQGS.LessonOne.PrintWorld;
using CQGS.LessonOne.ShapesWorld;
using System;

namespace CQGS.LessonOne
{
    public class Circul : CircularShapes
    {
        public Circul(IPrint print, string colour, double diameter) : base(print, colour, diameter)
        {
        }

        public override void DisplayInformation()
        {
            Print.Print($"Shape color {Colour} Shape area {GetArea()}");
        }

        public override double GetArea()
        {
            return Math.PI * Diameter;
        }
    }
}

