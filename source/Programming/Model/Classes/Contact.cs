using System;
namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит контактные данные.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер контакта.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя контакта. Содержит только буквы.</param>
        /// <param name="surname">Фамилия контакта. Содержит только буквы.</param>
        /// <param name="number">Телефонный номер. Целочисленное 11-ти значное число.</param>
        public Contact(string name,
            string surname,
            string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Содержит только буквы.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Name), value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Содержит только буквы.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт телефонный номер. Целочисленное 11-ти значное число.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (!long.TryParse(value, out long num))
                {
                    throw new ArgumentException(
                        "the value of the Number field must consist of digits only");
                }

                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        "the value of the Number field must consist of 11 digits");
                }

                _number = value;
            }
        }
    }
}
