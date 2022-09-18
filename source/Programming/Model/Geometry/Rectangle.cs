using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике и создаёт его экземпляр.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Счётчик количества прямоугольников. Используется для задания id.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длинна прямоугольника.
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина прямугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Возвращает и задаёт длинну прямоугольника. Всегда положительна.
        /// </summary>
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Length), value);
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Всегда положительна.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0.0)
                    Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }

        /// <summary>
        /// Цвет заливки прямоугольника.
        /// </summary>
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Rectangle {_allRectanglesCount}";
        }

        /// <summary>
        /// Точка на координатной сетке.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Уникальный индентификатор прямоугольника.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Создать экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина прямоугольника. Всегда положительна.</param>
        /// <param name="width">Ширина прямоугольника. Всегда положительна.</param>
        /// <param name="X"> х координата точки центра.</param>
        /// <param name="Y"> у координата точки центра.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        public Rectangle(int length, int width, string color, int X, int Y)
        {
            _allRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(X, Y);
            ID = _allRectanglesCount;
        }


    }
}
