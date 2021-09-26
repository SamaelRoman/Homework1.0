namespace Homework1._0
{
    /// <summary>
    /// Класс координат,создан для удобства хранения.
    /// </summary>
    public class Coordinates
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        /// <summary>
        /// Конструктор класса координат.
        /// </summary>
        /// <param name="X">Положение по X</param>
        /// <param name="Y">Положение по Y</param>
        public Coordinates(decimal X, decimal Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public static Coordinates operator *(Coordinates One, decimal Two)
        {
            return new Coordinates(One.X * 2, One.Y * 2);
        }
        public static Coordinates operator -(Coordinates One,Coordinates Two)
        {
            return new Coordinates(One.X - Two.X, One.Y - Two.Y);
        }
        public static Coordinates operator +(Coordinates One,Coordinates Two)
        {
            return new Coordinates(One.X + Two.X, One.Y + Two.Y);
        }
        /// <summary>
        /// Возвращает строку для удобного вывода информации о координатах на экран
        /// </summary>
        /// <param name="PointName">Название точки координт</param>
        /// <returns></returns>
        public string Output(string PointName)
        {
            return PointName + " [" + this.X + "," + this.Y + "]";
        }

    }
}
