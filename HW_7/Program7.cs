/*Гра де у місце треба покласти фігуру підходящої форми. Адаптер робить так, щоб можна було перевірити,
чи можна покласти у круглу форму квадратну фігуру*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Adapter
{
    class RoundHole
    {
        double radius;
        public RoundHole(int radius)
        {
            this.radius = radius;
        }
        public bool itFits(IRoundShape shape)
        {
            return this.radius >= shape.getRadius();
        }
    }

    interface IRoundShape
    {
        double getRadius();
    }

    class RoundShape : IRoundShape
    {
        double radius;
        public RoundShape(int radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
    }

    class SquareShape
    {
        double width;
        public SquareShape(int width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return width;
        }
    }

    class SquareShapeAdapter : IRoundShape
    {
        private SquareShape shape;
        public SquareShapeAdapter(SquareShape shape)
        {
            this.shape = shape;
        }
        public double getRadius()
        {
            return shape.getWidth() * Math.Sqrt(2) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RoundHole hole = new RoundHole(5);
            RoundShape roundShape = new RoundShape(5);
            Console.WriteLine("Чи підходить кругла фігура: {0}", hole.itFits(roundShape));

            SquareShape squareShape = new SquareShape(10);
            SquareShapeAdapter adapter = new SquareShapeAdapter(squareShape);
            Console.WriteLine("Чи підходить квадратна фігура: {0}", hole.itFits(adapter));
        }
    }
}