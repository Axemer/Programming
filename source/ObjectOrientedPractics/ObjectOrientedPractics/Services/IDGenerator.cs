namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит метод генерации нового Id.
    /// </summary>
    internal class IDGenerator
    {
        /// <summary>
        /// Хранит последний выданный id.
        /// </summary>
        private static int _lastID = 0;

        /// <summary>
        /// Возвращает новый id, на 1 больше чем последний выданный.
        /// </summary>
        /// <returns>Возвращает новый id.</returns>
        public static int GetNextID()
        {
            _lastID++;
            return _lastID;
        }
    }
}
