namespace CQGS.LessonOne.ShapesWorld
{
    interface IShapes
    {
        string Colour { get; }

        void DisplayInformation();
        double GetArea();
    }
}