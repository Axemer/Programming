using System;
using Programming.Model.Enums;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Создает прямоугольники с рандомными значениями и учетом отступа.
    /// </summary>
    internal class RectangleFactory
    {
        /// <summary>
        /// Минимальный отступ между элементами.
        /// </summary>
        private const int margin = 15;

        /// <summary>
        /// Создать экземпляр класса <see cref="Rectangle"/> с рандомными значениями.
        /// </summary>
        /// <param name="canvasWidth">Ширина холста.</param>
        /// <param name="canvasHeight">Высота холста.</param>
        /// <param name="name">Если имя не задаётся, то именем становится "Rectangle"+id.</param>
        /// <returns></returns>
        public static Rectangle Randomize(int canvasWidth, int canvasHeight, string name = null)
        {
            Random rnd = new Random();
            int randomHeight = rnd.Next(1, 100);
            int randomWidth = rnd.Next(1, 100);
            int randomX = rnd.Next(randomWidth+margin, canvasWidth - (margin+randomWidth));
            int randomY = rnd.Next(randomHeight+margin, canvasHeight - (margin +randomHeight));
            Array colors = Enum.GetValues(typeof(Color));
            Color randomColor = (Color)colors.GetValue(rnd.Next(colors.Length));
            Rectangle newRectangle = new Rectangle(randomHeight, randomWidth,
                                    randomColor.ToString(), randomX, randomY);
            return newRectangle;
        }
    }
}
