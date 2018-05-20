using CQGS.LessonOne.PrintWorld;
using CQGS.LessonOne.ShapesWorld;

namespace CQGS.LessonOne
{
    public class Square : OtherShapes
    {
        public Square(IPrint print, string colour, double width, int numberOfVertices) : base(print, colour, width, numberOfVertices)
        {
        }

        public override void DisplayInformation()
        {
            Print.Print($"Shape {nameof(Square)} color {Colour} Shape area {GetArea()}");
        }

        public override double GetArea() => Width * Width;
    }
}