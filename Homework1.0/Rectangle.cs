using System;

namespace Homework1._0
{
    public class Rectangle : Point
    {
        public Coordinates coordinates_B { get; protected set; }
        private Coordinates coordinates_C { get; set; }  //сделано для удобства хранения точек углов прямоугольника, помечено private что бы не было в наследниках
        private Coordinates coordinates_D { get; set; } //сделано для удобства хранения точек углов прямоугольника, помечено private что бы не было в наследниках
        public Rectangle(decimal X, decimal Y,Coordinates Offset) : base(X,Y)
        {
            FigureBuild(Offset);
        }
        public override void Output()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('~', 20));
            Console.WriteLine($"Hi i'm Rectengle,i have coordinetes:");
            Console.WriteLine(coordinates_A.Output("A"));
            Console.WriteLine(coordinates_B.Output("B"));
            Console.WriteLine(coordinates_C.Output("C"));
            Console.WriteLine(coordinates_D.Output("D"));
            Console.WriteLine(new string('~', 20));
            Console.ResetColor();
        }

        public override void Scale(decimal ScaleSize)
        {
            FigureBuild((coordinates_C - coordinates_A) * ScaleSize);
        }
       /// <summary>
       /// Метод выявления координат углов прямоугольника на основе смешения от базовой известной точки
       /// </summary>
       /// <param name="Offset">смешение от безовой точки</param>
        private void FigureBuild(Coordinates Offset)
        {
            coordinates_C = new Coordinates(coordinates_A.X + Offset.X, coordinates_A.Y + Offset.Y);

            coordinates_B = new Coordinates(coordinates_A.X, coordinates_C.Y);

            coordinates_D = new Coordinates(coordinates_C.X, coordinates_A.Y);
        }
        public override void Move(decimal X, decimal Y)
        {
            Coordinates Offset = coordinates_C - coordinates_A;
            base.Move(X, Y);
            FigureBuild(Offset);
        }
    }
}
