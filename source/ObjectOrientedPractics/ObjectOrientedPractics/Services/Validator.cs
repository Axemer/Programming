using System;

namespace ObjectOrientedPractics.Model
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
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }

        /// <summary>
        /// Проверка действительной переменной на содержание положительного значения.
        /// </summary>
        /// <param name="value">Значение переменной для проверки.</param>
        /// <param name="nameProperty">Имя переменной для проверки.</param>
        /// <exception cref="ArgumentException">Сообщение, что переменная должна
        /// содержать только положительное значение.</exception>
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value <= 0)
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
        public static int AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
            return value;
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
        public static double AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
            return value;
        }

        /// <summary>
        /// Проверка строки на содержание только английских букв.
        /// </summary>
        /// <param name="value">Значение переменной строки..</param>
        /// <param name="nameProperty">Имя переменной строки.</param>
        /// <exception cref="ArgumentException">Сообщение, что переменная должна
        /// содержать только символы английского алфавита.</exception>
        public static string AssertStringContainsOnlyLetters(string value, string nameProperty)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException(
                        $"the value of the {nameProperty} field should consist only of English letters.");
                }
            }

            return value;
        }


        /// <summary>
        /// Провека строки на удовлетворение условию заданной длинны.
        /// </summary>
        /// <param name="value">Значение переменной строки.</param>
        /// <param name="nameProperty">Имя переменной строки.</param>
        /// <param name="MaxLength">Максимальный порог динны.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string AssertStringMaxLength(string value, string nameProperty, int MaxLength)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (i >= MaxLength)
                {
                    throw new ArgumentException(
                        $"the length of the {nameProperty} field should be shorter than {MaxLength} characters.");
                }
            }

            return value;
        }
    }
}
