using System;

namespace Individual_Task.Model.Classes
{
    /// <summary>
    /// Содержит методы валидации.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Проверка действительной переменной на содержание положительного значения.
        /// </summary>
        /// <param name="value">Значение переменной для проверки.</param>
        /// <param name="nameProperty">Имя переменной для проверки.</param>
        /// <exception cref="ArgumentException">Сообщение, что переменная должна
        /// содержать только положительное значение.</exception>
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }

        /// <summary>
        /// Проверка действительной переменной на удовлетворение условию нахождения
        /// в определённом диапазоне.
        /// </summary>
        /// <param name="value">Значение переменной для проверки.</param>
        /// <param name="min">Минимальный порог.</param>
        /// <param name="max">Максимальный порог.</param>
        /// <param name="nameProperty">Имя переменной для проверки.</param>
        /// <exception cref="ArgumentException">Сообщение, что переменная должна
        /// содержать значение в определённом диапазоне.</exception>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }

        /// <summary>
        /// Проверка условия необходимый длины строки.
        /// </summary>
        /// <param name="value">Значение переменной строки.</param>
        /// <param name="lenght">Ограничение длины.</param>
        /// <param name="propertyName">Имя переменной строки.</param>
        /// <exception cref="ArgumentException">Сообщение, что переменная должна содержать
        /// только определённое количество символов.</exception>
        public static void AssertStringWithLimitedLenght(string value, int lenght, string propertyName)
        {
            if (value != null && value.Length > lenght)
            {
                throw new ArgumentException($"Переменная {propertyName} должна содержать " +
                    $"меньше {lenght} символов.");
            }
        }
    }
}
