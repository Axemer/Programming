using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные всех товаров и покупателей.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список всех предметов.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает и задаёт покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get 
            { 
                return _customers;
            }
            set 
            {
                _customers = value; 
            }
        }

        /// <summary>
        /// Возвращает и задаёт предметы.
        /// </summary>
        public List<Item> Items
        {
            get 
            { 
                return _items; 
            }
            set 
            { 
                _items = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store">
        /// </summary>
        public Store() 
        {
            _customers = new List<Customer>();
            _items = new List<Item>();
        }

    }
}
