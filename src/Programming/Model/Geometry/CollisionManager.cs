﻿using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Реализует статическую обработку данных двух прямоугольников/окружностей.
    /// И проверяет, пересекаются или нет.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если все условия пересечения выполнены.
        /// И false, если нет.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                   rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                   rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height &&
                   rectangle1.Height + rectangle1.Center.Y > rectangle2.Center.Y;
        }

        /// <summary>
        /// Проверяет, пересекаются ли две окружности.
        /// </summary>
        /// <param name="ring1">Первая окружность.</param>
        /// <param name="ring2">Вторая окружность.</param>
        /// <returns>Возвращает true, если условие пересечения выполнено.
        /// И false, если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX*dX + dY*dY);

            return (c < (ring1.OuterRadius + ring2.OuterRadius));
        }
    }
}
