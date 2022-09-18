using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class CollisionManager
    {
        /// <summary>
        /// Проверка пересечения одного прямоугольника другим.
        /// </summary>
        /// <param name="rect1">Первый прямоугольник.</param>
        /// <param name="rect2">Второй прямоугольник.</param>
        /// <returns>Возвращает bool ответ происходит ли пересечение.</returns>
        public static bool IsCollision(Rectangle rect1, Rectangle rect2)
        {
            return rect1.Center.X < rect2.Center.X + rect2.Length && rect1.Center.X
                + rect1.Length > rect2.Center.X && rect1.Center.Y < rect2.Center.Y
                + rect2.Width && rect1.Width + rect1.Center.Y > rect2.Center.Y;
        }

        /// <summary>
        /// Проверка пересечения одного кольца другим.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает bool ответ происходит ли пересечение.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}
