using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Персональный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Максимальная длинна полного имени.
        /// </summary>
        private const int NameMaxLength = 200;

        /// <summary>
        /// Получает ID покупателя.
        /// </summary>
        public int ID 
        {
            get
            {
                return _id; 
            } 
        }

        /// <summary>
        /// Принимает и возвращает полное имя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = Validator.AssertStringMaxLength(value, "Fullname", NameMaxLength);
            }
        }

        /// <summary>
        /// Возвращает корзину покупателя.
        /// </summary>
        public Cart Cart { get; }

        /// <summary>
        /// Возвращает список всех заказов покупателя.
        /// </summary>
        public List<Order> Orders { set; get; } = new List<Order>();

        /// <summary>
        /// Принимает и возвращает Адрес.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Отвечает за наличие приоритета
        /// </summary>
        public bool IsPriority { set; get; } = false;

        /// <summary>
        /// Хранит информацию о скидках
        /// </summary>
        public List<IDiscount> Discounts { get; } = new List<IDiscount>();

        /// <summary>
        /// Отображает правильные называния в списках.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Fullname;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullname, Address address)
        {
            _id = IDGenerator.GetNextID();
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = IDGenerator.GetNextID();
            string defaultName = "No Name";
            Fullname = defaultName;
            Address = new Address();
            Cart = new Cart();
        }
    }
}
