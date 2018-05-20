using CQGS.LessonOne.PrintWorld;

namespace CQGS.LessonOne.ShapesWorld
{
    public abstract class CircularShapes : IShapes
    {
        public double Radius { get; }
        public string Colour { get; }
        protected readonly IPrint Print;

        protected CircularShapes(IPrint print, string colour, double radius)
        {
            Print = print;
            Colour = colour;
            Radius = radius;
        }

        public abstract void DisplayInformation();
        public abstract double GetArea();
    }
}