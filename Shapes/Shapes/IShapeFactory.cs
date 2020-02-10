using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    interface IShapeFactory
    {
        Shape GetSmallShape();
        Shape GetMediumShape();
        Shape GetLargeShape();
    }
} 
