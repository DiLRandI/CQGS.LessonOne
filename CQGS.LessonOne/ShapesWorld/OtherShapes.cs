using CQGS.LessonOne.PrintWorld;

namespace CQGS.LessonOne.ShapesWorld
{
    public abstract class OtherShapes : IShapes
    {
        public int NumberOfVertices { get; }
        public double Width { get; }
        public string Colour { get; }

        protected readonly IPrint Print;

        protected OtherShapes(IPrint print, string colour, double width, int numberOfVertices)
        {
            Print = print;
            Colour = colour;
            Width = width;
            NumberOfVertices = numberOfVertices;
        }


        public abstract void DisplayInformation();
        public abstract double GetArea();
    }
}