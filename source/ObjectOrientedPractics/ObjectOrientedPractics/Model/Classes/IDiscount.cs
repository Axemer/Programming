using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Classes
{
    interface IDiscount 
    {// здесь нет модификатора паблик так как интерфейс сам по себе публичный 

        /// <summary>
        /// Информация о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// 
        /// </summary>
        bool Active { get; set; }

        /// <summary>
        /// Рассчитать скидку для набора товаров.
        /// </summary>
        /// <param name="items">Набор товаров.</param>
        /// <returns>Сумма скидки.</returns>
        double Calculate(IEnumerable<Item> items);

        /// <summary>
        /// Применить скидку к набору товаров.
        /// </summary>
        /// <param name="items">Набор товаров.</param>
        /// <returns>Скидка.</returns>
        double Apply(IEnumerable<Item> items);

        /// <summary>
        /// Обновить скидку.
        /// </summary>
        /// <param name="items">Набор товаров.</param>
        void Update(IEnumerable<Item> items);
    }
}
