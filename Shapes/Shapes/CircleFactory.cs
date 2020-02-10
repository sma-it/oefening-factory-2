using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class CircleFactory : IShapeFactory
    {
        string name = "circle";

        public Shape GetLargeShape()
        {
            var result = new Shape();
            result.ShapeName = name;
            result.Size = 1;
            return result;
        }

        public Shape GetMediumShape()
        {
            var result = new Shape();
            result.ShapeName = name;
            result.Size = 2;
            return result;
        }

        public Shape GetSmallShape()
        {
            var result = new Shape();
            result.ShapeName = name;
            result.Size = 3;
            return result;
        }
    }
}
