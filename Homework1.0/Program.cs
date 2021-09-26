using System;

namespace Homework1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(-5, 2, new Coordinates(6, 4));
            Triangle T = new Triangle(1, 4, new Coordinates(2, 6), new Coordinates(-6, 2));
            Circle C = new Circle(1, 12, 5);

            Image I = new Image(-20, -20, new Coordinates(22, 22));
            I.figure.Add(R);
            I.figure.Add(T);
            I.figure.Add(C);

            I.Output();
            I.Scale(2);
            I.Output();
            Console.ReadKey();
        }
    }
}
