using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Длительность в минутах.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Пункт отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Пункт назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт длительность в минутах. Принимает только положительные значения.
        /// </summary>
        public int FlightTime
        {
            get 
            { 
                return _flightTime; 
            }

            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTime), value);
                _flightTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="from">Пункт отправления.</param>
        /// <param name="to">Пункт назначения.</param>
        /// <param name="flightTime">Длительность в минутах.
        /// Принимает только положительные значения.</param>
        public Flight(string from, string to, int flightTime)
        {
            Departure = from;
            Destination = to;
            FlightTime = flightTime;
        }
    }
}

