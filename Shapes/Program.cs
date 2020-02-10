using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static List<Shape> shapes = new List<Shape>();
        static IShapeFactory factory = new CircleFactory();

        static void Main(string[] args)
        {
            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Draw Circles", () => factory = new CircleFactory());
            menu.AddOption('2', "Draw Squares", () => factory = new SquareFactory());
            menu.AddOption('3', "Draw Lines", () => factory = new LineFactory());

            menu.AddOption('4', "Draw small shape", drawSmallShape);
            menu.AddOption('5', "Draw medium shape", drawMediumShape);
            menu.AddOption('6', "Draw large shape", drawLargeShape);

            menu.AddOption('7', "Print list of shapes", printShapes);
            menu.Start();
        }

        private static void printShapes()
        {
            shapes.ForEach((shape) =>
            {
                Console.WriteLine(shape);
            });
        }

        private static void drawSmallShape()
        {
            shapes.Add(factory.GetSmallShape());
            Console.WriteLine(shapes.Last());
        }

        private static void drawMediumShape()
        {
            shapes.Add(factory.GetMediumShape());
            Console.WriteLine(shapes.Last());
        }

        private static void drawLargeShape()
        {
            shapes.Add(factory.GetLargeShape());
            Console.WriteLine(shapes.Last());
        }
    }
}
