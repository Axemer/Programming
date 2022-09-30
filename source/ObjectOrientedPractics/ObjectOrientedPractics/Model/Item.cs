using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

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
        /// 
        /// </summary>
        private const int NameMaxLenght = 200;

        /// <summary>
        /// 
        /// </summary>
        private const int InfoMaxLenght = 1000;

        /// <summary>
        /// 
        /// </summary>
        private const double MaxCost = 100000.0;

        /// <summary>
        /// 
        /// </summary>
        private const double MinCost = 0.0;

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
                _name = Validator.AssertStringMaxLength(value, "Name", NameMaxLenght);
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
                _info = Validator.AssertStringMaxLength(value, "Info", InfoMaxLenght);
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
                _cost = Validator.AssertValueInRange("Cost", value, MinCost, MaxCost);
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
