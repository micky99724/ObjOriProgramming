using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interfaces
{
    public interface IRectangle : IShape
    {
        double Length { get; }
        double Width { get; }
    }

}
