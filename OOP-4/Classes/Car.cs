using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Classes
{
    internal class Car : Vichle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("The car moving Backword");
        }

        public void Forward()
        {
            Console.WriteLine("The car moving Forward");
        }

        public void Left()
        {
            Console.WriteLine("The car moving left");
        }

        public void Right()
        {
            Console.WriteLine("The car moving right");
        }
    }
}
