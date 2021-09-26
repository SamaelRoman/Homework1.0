using System;

namespace Homework1._0
{
    public class Circle : Point
    {
        public decimal Radius { get; set; }
        public Circle(decimal X, decimal Y, decimal Radius) : base (X,Y)
        {
            this.Radius = Radius;
        }
        public override void Output()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('~', 20));
            Console.WriteLine($"Hi i'm circle, my radius - {Radius}. I am at coordinates X:{coordinates_A.X}, Y:{coordinates_A.Y}.");
            Console.WriteLine(new string('~', 20));
            Console.ResetColor();
        }

        public override void Scale(decimal ScaleSize)
        {
            Radius *= ScaleSize;
        }
    }
}
