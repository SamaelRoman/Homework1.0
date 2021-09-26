namespace Homework1._0
{
    public abstract class Point
    {
        public Point(decimal X, decimal Y)
        {
            this.coordinates_A = new Coordinates(X, Y);
        }
        public Coordinates coordinates_A { get; protected set; }

        /// <summary>
        /// Вывод информации об обьекте на экран
        /// </summary>
        abstract public void Output();
        /// <summary>
        /// Метод Маштабирования
        /// </summary>
        /// <param name="ScaleSize">коэффициент</param>
        abstract public void Scale(decimal ScaleSize);
        /// <summary>
        /// Метод перемещения точки в системе координат.перемещает на укзанное количество по Х и по Y
        /// </summary>
        /// <param name="X">Координаты по X</param>
        /// <param name="Y">Координаты по Y</param>
        public virtual void Move(decimal X, decimal Y)
        {
            coordinates_A.X += X;
            coordinates_A.Y += Y;
        }

    }
}
