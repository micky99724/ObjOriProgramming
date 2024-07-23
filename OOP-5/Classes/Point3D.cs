namespace OOP_5.Classes
{
    public class Point3D : IComparable, ICloneable
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Point3D()
        {

        }
        public Point3D(double x, double y, double z) : base()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public int CompareTo(object? obj)
        {
            Point3D? point3D = (Point3D)obj;
            return (this.X.CompareTo(point3D?.X) + this.Y.CompareTo(point3D?.Y));

        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (p1 != null && p2 != null)
            {
                return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
            }
            return false;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            if (p1 != null && p2 != null)
            {
                return p1.X != p2.X && p1.Y != p2.Y && p1.Z != p2.Z;
            }
            return false;
        }
    }
}
