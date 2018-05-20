using CQGS.LessonOne.PrintWorld;
using CQGS.LessonOne.ShapesWorld;

namespace CQGS.LessonOne
{
    public class Rectangle : OtherShapes
    {
        public double Height { get; }
        public Rectangle(IPrint print, string colour, double width, double height, int numberOfVertices) : base(print, colour, width, numberOfVertices)
        {
            Height = height;
        }

        public override void DisplayInformation()
        {
            Print.Print($"Shape color {Colour} Shape area {GetArea()}");
        }

        public override double GetArea() => Width * Height;
    }
}