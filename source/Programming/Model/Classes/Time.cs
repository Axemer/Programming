using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит инфомарцию о времени с точностью до секунд.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задаёт количество часов. Принимает значения от 0 до 23.
        /// </summary>
        public int Hours
        {
            get 
            { 
                return _hours;
            }

            set
            {
                Validator.AssertValueInRange(nameof(Hours), value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество минут. Принимает значения от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get
            { 
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Minutes), value, 0, 60);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество секунд. Принимает значения от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get 
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Seconds), value, 0, 60);
                _seconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>
        /// </summary>
        /// <param name="hours">Количество часов. Принимает значения от 0 до 23.</param>
        /// <param name="minutes">Количество минут. Принимает значения от 0 до 59.</param>
        /// <param name="seconds">Количество секунд. Принимает значения от 0 до 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Создает Создаёт экземпляр класса <see cref="Time"/>
        /// </summary>
        public Time() { }
    }
}

