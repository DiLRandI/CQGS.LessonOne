using CQGS.LessonOne.PrintWorld;

namespace CQGS.LessonOne.ShapesWorld
{
    public abstract class CircularShapes : IShapes
    {
        public double Diameter { get; private set; }
        public string Colour { get; private set; }
        protected readonly IPrint Print;

        protected CircularShapes(IPrint print, string colour, double diameter)
        {
            Print = print;
            Colour = colour;
            Diameter = diameter;
        }

        public abstract void DisplayInformation();
        public abstract double GetArea();
    }
}