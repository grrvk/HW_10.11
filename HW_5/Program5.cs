using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrototypeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IFigure figure = new Rectangle(10, 20);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Triangle(3, 4, 5);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Romb(4);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            Console.Read();
        }
    }
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
        }
    }
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }

    class Triangle : IFigure
    {
        int firstSide;
        int secondSide;
        int thirdSide;
        public Triangle(int f, int s, int t)
        {
            firstSide = f;
            secondSide = s;
            thirdSide = t;
        }
        public IFigure Clone()
        {
            return new Triangle(this.firstSide, this.secondSide, this.thirdSide);
        }
        public void GetInfo()
        {
            Console.WriteLine("Трикутник зі сторонами {0}, {1} та {2}", firstSide, secondSide, thirdSide);
        }
    }

    class Romb : IFigure
    {
        int side;
        public Romb(int s)
        {
            side = s;
        }
        public IFigure Clone()
        {
            return new Romb(this.side);
        }
        public void GetInfo()
        {
            Console.WriteLine("Ромб зі стороною {0}", side);
        }
    }
}