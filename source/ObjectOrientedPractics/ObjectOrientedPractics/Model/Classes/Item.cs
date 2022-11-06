using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Classes
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
        /// Максимальная длинна названия.
        /// </summary>
        private const int NameMaxLenght = 200;

        /// <summary>
        /// Максимальная длинна описания.
        /// </summary>
        private const int InfoMaxLenght = 1000;

        /// <summary>
        /// Максимальная стоимость.
        /// </summary>
        private const double MaxCost = 100000.0;

        /// <summary>
        /// Минимальная стоимость.
        /// </summary>
        private const double MinCost = 0.0;

        /// <summary>
        /// Получает id товара.
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя товара. Не более 200 символов.
        /// </summary>
        public string Name
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
        public string Info
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
        public double Cost
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

        /// <summary>
        /// Gets and sets category of Item.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара. Предельная длина 200 символов.</param>
        /// <param name="info">Описание товара. Предельная длина 1000 символов.</param>
        /// <param name="cost">Цена товара. Допустимо значение от 0 до 100000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IDGenerator.GetNextID();
            Name = name;
            Info = info;
            Cost = cost;       
            Category = category;
        }
    }
}
