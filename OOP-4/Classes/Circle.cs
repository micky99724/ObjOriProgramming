using OOP_4.Interfaces;

namespace OOP_4.Classes
{
    public class Circle : ICircle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area { get { return Math.PI * Radius * Radius; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius {Radius}, Area: {Area}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with length {Length} and width {Width}, Area: {Area}");
        }
    }

}
