using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class Shape
    {
        public int Size { get; set; }
        public string ShapeName { get; set; }

        public override string ToString()
        {
            string result = "This is a ";
            if (Size <= 1) result += "small ";
            else if (Size == 2) result += "medium ";
            else result += "large ";
            result += ShapeName;
            result += ".";
            return result;
        }
    }
}
