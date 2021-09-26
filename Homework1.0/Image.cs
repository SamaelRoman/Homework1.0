using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._0
{
    class Image : Rectangle
    {
        public List<Point> figure { get; set; }
        private Coordinates coordinates_C { get; set; }  //сделано для удобства хранения точек углов прямоугольника, помечено private что бы не было в наследниках
        private Coordinates coordinates_D { get; set; } //сделано для удобства хранения точек углов прямоугольника, помечено private что бы не было в наследниках
        public Image(decimal X, decimal Y, Coordinates Offset) : base(X,Y,Offset)
        {
            figure = new List<Point>();
            FigureBuild(Offset);
        }
        public override void Output()
        {
            Console.WriteLine("Hi I'm Image");
            Console.WriteLine("My location is");
            Console.WriteLine(coordinates_A.Output("A"));
            Console.WriteLine(coordinates_B.Output("B"));
            Console.WriteLine(coordinates_C.Output("C"));
            Console.WriteLine(coordinates_D.Output("D"));
            Console.WriteLine("I have this figure");
            Console.WriteLine(new string('~', 20));
            foreach (var F in figure)
            {
                F.Output();
            }
            Console.WriteLine(new string('~', 20));
        }
        public override void Move(decimal X, decimal Y)
        {
            Coordinates Offset = coordinates_C - coordinates_A;
            coordinates_A.X += X;
            coordinates_A.Y += Y;
            FigureBuild(Offset);
            foreach (var F in figure)
            {
                F.Move(X, Y);
            }
        }
        public override void Scale(decimal ScaleSize)
        {
            FigureBuild((coordinates_C - coordinates_A) * ScaleSize);
            foreach (var F in figure)
            {
                F.Scale(ScaleSize);
            }
        }
        private void FigureBuild(Coordinates Offset)
        {
            coordinates_C = new Coordinates(coordinates_A.X + Offset.X, coordinates_A.Y + Offset.Y);

            coordinates_B = new Coordinates(coordinates_A.X, coordinates_C.Y);

            coordinates_D = new Coordinates(coordinates_C.X, coordinates_A.Y);
        }
    }
}
