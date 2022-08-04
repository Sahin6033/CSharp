using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFigure
{
    internal class Program
    {

        interface IFigure
        {
            void CalculateArea();
            void CalculatePerimeter();
        }
        class Rectangle : IFigure
        {
            double x;
            double y;
            public Rectangle(double X, double Y)
            {
                this.x = X;
                this.y = Y;
            }
            public void CalculateArea()
            {

                Console.WriteLine($"Area of Rectangle (a * b) {x} * {y} = {x * y}");
            }

            public void CalculatePerimeter()
            {
                Console.WriteLine($"Perimeter of Rectangle ((a + b) * 2) ({x} + {y})*2 = {(x + y) * 2}");
            }
        }

        class Circle : IFigure
        {
            double radius;
            public Circle(double rd)
            {
                this.radius = rd;
            }
            public void CalculateArea()
            {
                Console.WriteLine($"Area of Circle (pi * r ^ 2) {radius} * {radius} * {3.142872} = {radius * radius * 3.142872}");
            }

            public void CalculatePerimeter()
            {
                Console.WriteLine($"Perimeter of Circle (2 * pi * r) {2} * {radius}*{3.142872} = {2 * radius * 3.142872}");
            }
        }

        class Triangle : IFigure
        {
            double a;
            double b;
            double c;
            public Triangle(double A, double B, double C)
            {
                this.a = A;
                this.b = B;
                this.c = C;
            }
            public void CalculateArea()
            {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Area of Triangle ( p = (a + b + c) / 2 | area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)) ) =   {area}");
            }

            public void CalculatePerimeter()
            {
                Console.WriteLine($"Perimeter of Triangle ( a + b + c)  {a} + {b} + {c} = {a + b + c}");
            }
        }

        class Square : IFigure
        {
            double a;
            public Square(double A)
            {
                this.a = A;
            }
            public void CalculateArea()
            {
                Console.WriteLine($" Area o Square (a * a)  {a} * {a} = {a*a}");
            }

            public void CalculatePerimeter()
            {
                Console.WriteLine($"Perimeter of Square (a * 4) {a} * 4 = {a * 4} ");
            }
        }

        static void Main(string[] args)
        {
            /*Rectangle rectangle = new Rectangle(5,10);
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();*/

            /* Circle circle = new Circle(7);
             circle.CalculateArea();
             circle.CalculatePerimeter();*/

            /*  Triangle triangle = new Triangle(3,4,5);
              triangle.CalculateArea();
              triangle.CalculatePerimeter();*/

            Square square = new Square(5);
            square.CalculateArea();
            square.CalculatePerimeter();
        }
    }
}
