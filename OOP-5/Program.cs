using OOP_5.Classes;

namespace OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project

            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());
            double x1, y1, z1, x2, y2, z2;

            do { Console.Write("Enter X coordinate for P1: "); }
            while (!double.TryParse(Console.ReadLine(), out x1));

            do { Console.Write("Enter Y coordinate for P1: "); }
            while (!double.TryParse(Console.ReadLine(), out y1));

            do { Console.Write("Enter Z coordinate for P1: "); }
            while (!double.TryParse(Console.ReadLine(), out z1));

            Point3D P1 = new Point3D(x1, y1, z1);

            do { Console.Write("Enter X coordinate for P2: "); }
            while (!double.TryParse(Console.ReadLine(), out x2));

            do { Console.Write("Enter Y coordinate for P2: "); }
            while (!double.TryParse(Console.ReadLine(), out y2));

            do { Console.Write("Enter Z coordinate for P2: "); }
            while (!double.TryParse(Console.ReadLine(), out z2));

            Point3D P2 = new Point3D(x2, y2, z2);
            if (P1 == P2)
                Console.WriteLine("P1 and P2 are equal.");
            else
                Console.WriteLine("P1 and P2 are not equal.");



            Point3D[] pointsArray = { P1, P2, new Point3D(53, 7, 32), new Point3D(52, 59, 51) };
            Array.Sort(pointsArray);
            foreach (var point in pointsArray)
            {
                Console.WriteLine(point.ToString());
            }

            Point3D copyP1 = (Point3D)P1.Clone();
            Console.WriteLine("Cloned P1: " + copyP1.ToString());

            #endregion


            #region Second Project

            Console.WriteLine(@$"Addition: {Maths.Add(12,12)} \nSubtraction: {Maths.Subtract(100, 20)} \n
                Multiplication: {Maths.Multiply(10, 5)} \nDivision: {Maths.Divide(12, 4)}");

            #endregion


            #region Third Project 

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1); 

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2); 

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3); 

            Duration D4 = new Duration(666);
            Console.WriteLine(D4); 

            // Example usage of operators
            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = ++D1;
            D3 = --D2;
            D1 = D1 - D2;

            if (D1 > D2)
            {
                Console.WriteLine($"{D1.ToString()} is greater than {D2.ToString()}");
            }

            if (D1 <= D2)
            {
                Console.WriteLine($"{D1.ToString()} is less than or equal {D2.ToString()}");
            }
            if (D1) 
             Console.WriteLine("True");
            else 
                Console.WriteLine("False");

            DateTime ConvertedObject = (DateTime)D1;
            Console.WriteLine(ConvertedObject);
        }

        #endregion

    }
    }
}
