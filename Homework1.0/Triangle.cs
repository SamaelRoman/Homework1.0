using System;

namespace Homework1._0
{
    public class Triangle : Rectangle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="X">Координата основной точки треугольника по Х.</param>
        /// <param name="Y">Координата основной точки треугольника по Y.</param>
        /// <param name="Offset1">Смешение координат к второму углу, относительно основной точки.</param>
        /// <param name="Offset2"></param>
        public Triangle(decimal X,decimal Y,Coordinates Offset1, Coordinates Offset2):base(X,Y,Offset1)
        {
            FigureBuild(Offset1,Offset2);
            
        }
        public Coordinates coordinates_C { get; set; }
        public override void Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('~', 20));
            Console.WriteLine($"Hi i'm Triangle,i have coordinetes:");
            Console.WriteLine(coordinates_A.Output("A"));
            Console.WriteLine(coordinates_B.Output("B"));
            Console.WriteLine(coordinates_C.Output("C"));
            Console.WriteLine(new string('~', 20));
            Console.ResetColor();
        }
        private void FigureBuild(Coordinates Offset1, Coordinates Offset2)
        {
            coordinates_C = coordinates_A + Offset1;
            coordinates_B = coordinates_A + Offset2;
        }
        public override void Scale(decimal ScaleSize)
        {
            FigureBuild((coordinates_C - coordinates_A) * ScaleSize, (coordinates_B - coordinates_A) * ScaleSize);
        }
        public override void Move(decimal X, decimal Y)
        {
            Coordinates OffsetC = coordinates_C - coordinates_A;
            Coordinates OffsetB = coordinates_B - coordinates_A;
            coordinates_A.X += X;
            coordinates_A.Y += Y;
            FigureBuild(OffsetC, OffsetB);
        }
    }
}
