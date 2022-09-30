namespace Programming.Model.Geometry
{
    /// <summary>
    /// Точка состоящая из координат x и y. Представляет расположение объектов в двумерной плоскости.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// X координата на двумерной плоскости.
        /// </summary>
        private int _x;

        /// <summary>
        /// Y координата на двумерной плоскости.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x"> X координата. Должна быть положительной.</param>
        /// <param name="y"> Y координата. Должна быть положительной.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задаёт x координату на двумерной плоскости. Число должно быть положительным
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                Validator.AssertOnPositiveValue(nameof(_x), value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт y координату на двумерной плоскости. Число должно быть положительным.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                Validator.AssertOnPositiveValue(nameof(_y), value);
                _y = value;
            }
        }
    }
}
