using System;

namespace Individual_Task.Model.Classes
{
    public class Product
    {
        /// <summary>
        /// Ограничение на количество символов.
        /// </summary>
        private const int symbolLimit = 100;

        /// <summary>
        /// Название продукта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Произваодитель продукта.
        /// </summary>
        private string _manufacturer;

        /// <summary>
        /// Колличество продукта.
        /// </summary>
        private int _quantity;

        /// <summary>
        /// Категория продукта.
        /// </summary>
        public string Category;

        /// <summary>
        /// Возвращает и задаёт название. Не более 100 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringWithLimitedLenght(value, symbolLimit, Name);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт производителя. Не более 100 символов.
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                Validator.AssertStringWithLimitedLenght(value, symbolLimit, Manufacturer);
                _manufacturer = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт колличество. Всегда положительна.
        /// </summary>
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Quantity), value);
                _quantity = value;
            }
        }

        /// <summary>
        /// Создать экземпляр класса <see cref="Product"/>.
        /// </summary>
        /// <param name="name">Название продукта. Всегда положительна.</param>
        /// <param name="manufacturer">Производитель продукта. Всегда положительна.</param>
        /// <param name="quantity">Колличество продукта.</param>
        /// <param name="category">Категория продукта.</param>
        public Product(string name, string manufacturer, int quantity, string category)
        {
            Name = name;
            Manufacturer = manufacturer;
            Quantity = quantity;
            Category = category;
            
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Product"/>.
        /// </summary>
        public Product()
        {
            Name = "Без имени";
            Quantity = 0;
        }
    }
}
