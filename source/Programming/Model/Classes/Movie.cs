using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Номер фильма
        /// </summary>
        private static int _count;

        /// <summary>
        /// Длительность в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Год выхода в показ.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт длительность в минутах. Принимает только положительные значения.
        /// </summary>
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }

            set
            {
                Validator.AssertOnPositiveValue(nameof(_durationMinutes),value);
                _durationMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выход в показ. Принимает только значения от 1900 до текущего.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }

            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        public string Genre { get; set; }


        /// <summary>
        /// Возвращает и задаёт рейтинг. Принимает действительные значения от 0 до 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0d, 10d);
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="duration">Длительность в минутах.
        /// Принимает только положительные значения.</param>
        /// <param name="year">Год выход в показ.
        /// Принимает только значения от 1900 до текущего.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг. Принимает действительные значения от 0 до 10.</param>
        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Title = title;
            DurationMinutes = duration;
            ReleaseYear = year;
            Genre = genre;
            Rating = rating;
            _count++;
        }

        /// <summary>
        /// Считает фильмы.
        /// </summary>
        public Movie()
        {
            _count++;
        }

        /// <summary>
        /// Выдает номер фильма.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Movie {_count}";
        }
    }
}
