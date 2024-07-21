using OOP_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Classes
{
    internal class AirPlain : Vichle, IMovable, IFlyable
    {
        void IMovable.Backward()
        {
            Console.WriteLine("The AirPlain moving Backword");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("The AirPlain Flying Backword");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("The AirPlain moving Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("The AirPlain Flying Forward");
        }

        void IMovable.Left()
        {
            Console.WriteLine("The AirPlain moving left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("The AirPlain Flying left");
        }

        void IMovable.Right()
        {
            Console.WriteLine("The AirPlain moving right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("The AirPlain flying right");
        }
    }
}
