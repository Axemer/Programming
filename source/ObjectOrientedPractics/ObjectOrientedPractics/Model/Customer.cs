using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Персональный индетификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Максимальная длинна полного имени.
        /// </summary>
        private const int NameMaxLength = 200;

        /// <summary>
        /// Максимальная длинна адреса
        /// </summary>
        private const int AddressMaxLength = 500;

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
        /// Принимае и возворащает полное имя.
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
        /// Принимае и возворащает Адрес.
        /// </summary>
        public string Address
        {
            get 
            {
                return _address; 
            }
            set 
            {
                _address = Validator.AssertStringMaxLength(value, "Address", AddressMaxLength);
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullname, string address)
        {
            _id = IDGenerator.GetNextID();
            Fullname = fullname;
            Address = address;
        }
    }
}
