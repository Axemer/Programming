using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// ������ ������ � �������������� � ������ ��� ���������.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// ������� ���������� ���������������. ������������ ��� ������� id.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// ������ ��������������.
        /// </summary>
        private int _length;

        /// <summary>
        /// ������ �������������.
        /// </summary>
        private int _width;

        /// <summary>
        /// ���������� � ����� ������ ��������������. ������ ������������.
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
        /// ���������� � ����� ������ ��������������. ������ ������������.
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
        /// ���� ������� ��������������.
        /// </summary>
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Rectangle {_allRectanglesCount}";
        }

        /// <summary>
        /// ����� �� ������������ �����.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// ���������� �������������� ��������������.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// ������� ��������� ������ <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">����� ��������������. ������ ������������.</param>
        /// <param name="width">������ ��������������. ������ ������������.</param>
        /// <param name="X"> � ���������� ����� ������.</param>
        /// <param name="Y"> � ���������� ����� ������.</param>
        /// <param name="color">���� ��������������.</param>
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
