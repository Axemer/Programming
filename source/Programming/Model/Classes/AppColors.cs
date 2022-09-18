namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит ключевые цвета приложения.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет заливки textbox в случае ошибки ввода данных.
        /// </summary>
        public static System.Drawing.Color _errorColor = System.Drawing.Color.LightPink;

        /// <summary>
        /// Цвет заливки textbox по умолчанию.
        /// </summary>
        public static System.Drawing.Color _defaultColor = System.Drawing.Color.White;

        /// <summary>
        /// Цвет заливки прямоугольников на холсте по умолчанию.
        /// </summary>
        public static System.Drawing.Color _rectangleDefaultColor =
            System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет заливки прямоугольников на холсте при ошибки.
        /// </summary>
        public static System.Drawing.Color _rectangleErrorColor =
            System.Drawing.Color.Coral;

    }
}