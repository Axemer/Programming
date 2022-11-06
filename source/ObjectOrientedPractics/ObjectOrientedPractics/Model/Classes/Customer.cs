using ObjectOrientedPractics.Services;

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
        /// Адрес покупателя.
        /// </summary>
        //private string _address;

        /// <summary>
        /// Максимальная длинна полного имени.
        /// </summary>
        private const int NameMaxLength = 200;

        /// <summary>
        /// Максимальная длинна адреса
        /// </summary>
        //private const int AddressMaxLength = 500;

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

        
        //public string _Address
        //{
        //    get 
        //    {
        //        return _address; 
        //    }
        //    set 
        //    {
        //        _address = Validator.AssertStringMaxLength(value, "Address", AddressMaxLength);
        //    }
        //}

        /// <summary>
        /// Принимает и возвращает Адрес.
        /// </summary>
        public Address Address { get; set; }

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
        }
    }
}
