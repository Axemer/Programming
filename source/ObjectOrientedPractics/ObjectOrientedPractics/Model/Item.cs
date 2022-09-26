using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре и создает его экземпляр.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задаёт имя товара. Не более 200 символов.
        /// </summary>
        private string Name
        {
            get
            {
                return _name;
            }
            set
            {

            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара. Не более 1000 символов.
        /// </summary>
        private string Info
        {
            get
            {
                return _info;
            }
            set
            {

            }
        }

        /// <summary>
        /// Возвращает и задаёт цену товара. От 0 до 100 000.
        /// </summary>
        private double Cost
        {
            get 
            {
                return _cost;
            }
            set 
            { 
                _cost = value; 
            }
        }

        public Item(string name, string info, double cost)
        {
            _id++;
            Name = name;
            Info = info;
            Cost = cost;
            
        }
    }
}
